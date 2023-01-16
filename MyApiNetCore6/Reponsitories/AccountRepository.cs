﻿using Data.SqlServer.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using MyApiNetCore6.Models;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace MyApiNetCore6.Reponsitories
{
    public class AccountRepository : IAccountRepository
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IConfiguration _configuration;

        public AccountRepository(UserManager<ApplicationUser> userManager, 
            SignInManager<ApplicationUser> signInManager, IConfiguration configuration)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _configuration = configuration;
        }
        public async Task<string> SignInAsync(SignInModel model)
        {
            var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, false, false);
            if (!result.Succeeded)
            {
                //Trả về chuỗi rỗng
                return string.Empty;
            }
            //Tạo ra các quyền ; Tọa ra các danh sách Claim
            var authClaims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, model.Email),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(ClaimTypes.Email, model.Email),
            };
            //Lấy keySecret AuthKey
            var authenKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:Secret"]));
            //Tạo mới 1 token
            var token = new JwtSecurityToken(
                issuer: _configuration["JWT:ValidIssuer"],      //lấy ra các default từ Appsetting.json
                audience: _configuration["JWT:ValidAudience"],  //lấy ra các default từ Appsetting.json
                expires: DateTime.Now.AddMinutes(20),           //Set thời gian hết hạn của token
                claims: authClaims,                             //Danh sách các CLaim
                //Cuối cùng quan trọng là kí lên token
                signingCredentials: new SigningCredentials(authenKey, SecurityAlgorithms.HmacSha512Signature)
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        public async Task<IdentityResult> SignUpAsync(SignUpModel model)
        {
            var user = new ApplicationUser
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.Email,
                UserName = model.Email
            };
            return await _userManager.CreateAsync(user,model.Password);
        }
        private string GenerateToken(SignInModel model)
        {

            return null;
        }
    }
}
