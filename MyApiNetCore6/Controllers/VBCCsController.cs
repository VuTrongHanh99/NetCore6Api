using Microsoft.AspNetCore.Mvc;
using NetCore.Domain.Entities;
using NetCore.Domain.Interfaces;

namespace MyApiNetCore6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VBCCsController : Controller
    {
        private readonly IVBCCRepository _vBCCRepository;

        public VBCCsController(IVBCCRepository vBCCRepository)
        {
            _vBCCRepository = vBCCRepository;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllHocViens()
        {
            try
            {
                return Ok(await _vBCCRepository.GetAllVBCCsAsync());
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetVBCCById(int id)
        {
            var result = await _vBCCRepository.GetVBCCAsync(id);
            return result == null ? NotFound() : Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> AddNewVBCC(VBCCModelEntity model)
        {
            try
            {
                var newHocVienId = await _vBCCRepository.AddVBCCAsync(model);
                var result = await _vBCCRepository.GetVBCCAsync(newHocVienId);
                return result == null ? NotFound() : Ok(result);
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
