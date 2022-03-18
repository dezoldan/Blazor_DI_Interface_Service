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
        [HttpGet("TotalBaseDeDados")]
        public async Task<ActionResult<int>> GetTotalBase()
        {
            return await _baseService.DevolveNumTotalRegsBase();
        }

    }
}
