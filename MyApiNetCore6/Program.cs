using Data.SqlServer.Data;
using Data.SqlServer.Context;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using MyApiNetCore6.Reponsitories;
using System.Text;
using NetCore.Domain.Interfaces;

var builder = WebApplication.CreateBuilder(args);
#region          Thêm LOGIN header Api Swagger
builder.Services.AddSwaggerGen(options =>
{
    options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Scheme = "Bearer",
        BearerFormat = "JWT",
        In = ParameterLocation.Header,
        Name = "Authorization",
        Description = "Bearer Authentication with JWT Token",
        Type = SecuritySchemeType.Http
    });
    options.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Id = "Bearer",
                    Type = ReferenceType.SecurityScheme
                }
            },
            new List<string>()
        }
    });
});
#endregion
// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
#region    Cấu hình DataContext
//Api cho nhiều trình duyệt, ứng dụng khác sử dụng được bằng các cấu hình
builder.Services.AddCors(options =>
    options.AddDefaultPolicy(policy =>
    policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod()));
//Kết nối sever database context cùng với Auth + Identity + Token
builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
    .AddEntityFrameworkStores<DataContext>().AddDefaultTokenProviders();
//Kết nối sever database context
builder.Services.AddDbContext<DataContext>(options => {
    options.UseSqlServer(builder.Configuration.GetConnectionString("ProductStore"));
});
#endregion
#region config AUTO Map Map giữa ModelEntities và DataSql Database
builder.Services.AddAutoMapper(typeof(Program));
#endregion
#region  Đăng ký để sử dụng Repository
//Life cycle DI: AddSignleton(), AddTransient(), AddScoped()
builder.Services.AddScoped<IBookRepository, BookRepository>();
builder.Services.AddScoped<IHocVienRepository, HocVienRepository>();
builder.Services.AddScoped<IAccountRepository, AccountRepository>();
#endregion
#region  KHai báo lớp đăng nhập hệ thống Auth
builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;     //Mức default Auth
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;        //Mức độ thử thách
    options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;                 //Mức độ 3
}).AddJwtBearer(options => {                                                        //Cấu hình thêm 1 số thứ như thời gian sống, lấy ở đâu     
    options.SaveToken = true;                                                       //Token có save không 
    options.RequireHttpsMetadata = false;               
    options.TokenValidationParameters = new TokenValidationParameters               
    {
        ValidateIssuer = true,                                      //Cấp phép
        ValidateAudience = true,                                    //
        ValidateIssuerSigningKey = true,                            //
        ValidAudience = builder.Configuration["JWT:ValidAudience"], //Lấy bên Appsetting.json
        ValidIssuer = builder.Configuration["JWT:ValidIssuer"],     //Lấy bên Appsetting.json
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["JWT:Secret"]))
    };
});
#endregion

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    //Thêm LOGIN header Api Swagger
    app.UseSwaggerUI(c => { c.SwaggerEndpoint("../swagger/v1/swagger.json", "My API V1"); });
}

app.UseHttpsRedirection();
app.UseAuthorization();
//thêm quyền đăng nhập
app.UseAuthentication();

app.MapControllers();

app.Run();
