using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Blazor_DI_Interface_Service.Server.Controllers
{
    [AllowAnonymous]
    [Route("api/[controller]")]
    [ApiController]
    public class DadosController : ControllerBase
    {
        private readonly IBaseService _baseService;
        public DadosController(IBaseService baseService)
        {
            _baseService = baseService;
        }

        [AllowAnonymous]
        [HttpGet("totalbasedados")]
        public async Task<ActionResult<int>> GetTotalBaseDados()
        {
            return await _baseService.DevolveNumTotalRegsBaseDados();
        }

    }
}
