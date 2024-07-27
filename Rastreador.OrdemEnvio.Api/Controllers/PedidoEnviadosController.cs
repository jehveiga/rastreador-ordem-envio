using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rastreador.OrdemEnvio.Application.Dtos.InputModels;
using Rastreador.OrdemEnvio.Application.Services;

namespace Rastreador.OrdemEnvio.Api.Controllers
{
    [ApiController]
    [Route("api/pedidos-envio")]
    public class PedidoEnviadosController : ControllerBase
    {
        private readonly IPedidoEnvioService _service;

        public PedidoEnviadosController(IPedidoEnvioService service)
        {
            _service = service;
        }

        [HttpGet("{code}")]
        public async Task<IActionResult> GetByCode(string code)
        {
            var pedidoEnvio = await _service.GetByCode(code);

            if(pedidoEnvio == null)
                return NotFound();

            return Ok(pedidoEnvio);
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPedidoEnvioInputModel model)
        {
            var code = await _service.Add(model);

            return CreatedAtAction(
                nameof(GetByCode),
                new { code },
                model
);
        }
    }
}
