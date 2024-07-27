using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rastreador.OrdemEnvio.Application.Services;

namespace Rastreador.OrdemEnvio.Api.Controllers
{
    [ApiController]
    [Route("api/envio-services")]
    public class EnvioServicesController : ControllerBase
    {
        private readonly IEnvioServiceService _service;

        public EnvioServicesController(IEnvioServiceService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var envioServices = await _service.GetAll();

            return Ok(envioServices);
        }
    }
}
