using Microsoft.AspNetCore.Mvc;
using NetCore.Domain.Entities;
using NetCore.Domain.Interfaces;

namespace MyApiNetCore6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HocViensController : Controller
    {
        private readonly IHocVienRepository _hocVienRepository;

        public HocViensController(IHocVienRepository hocVienRepository)
        {
            _hocVienRepository = hocVienRepository;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllHocViens()
        {
            try
            {
                return Ok(await _hocVienRepository.GetAllHocViensAsync());
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetHocVienById(int id)
        {
            var result = await _hocVienRepository.GetHocVienAsync(id);
            return result == null ? NotFound() : Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> AddNewHocVien(HocVienModelEntity model)
        {
            try
            {
                var newHocVienId = await _hocVienRepository.AddHocVienAsync(model);
                var result = await _hocVienRepository.GetHocVienAsync(newHocVienId);
                return result == null ? NotFound() : Ok(result);
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateHocVien(int id, [FromBody] HocVienModelEntity model)
        {
            if (id != model.Id)
            {
                return NotFound();
            }
            await _hocVienRepository.UpdateHocVienAsync(id, model);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHocVien([FromRoute] int id)
        {
            await _hocVienRepository.DeleteHocVienAsync(id);
            return Ok();
        }
    }
}
