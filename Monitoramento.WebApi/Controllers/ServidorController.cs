using Microsoft.AspNetCore.Mvc;
using Monitoramento.Domain.Interfaces.Services;

namespace Monitoramento.WebApi.Controllers
{
    [ApiController]
    [Route("api")]
    public class ServidorController : Controller
    {

        private readonly ILogger<ServidorController> _logger;
        private readonly IServidorService _servidorService;

        public ServidorController(ILogger<ServidorController> logger, IServidorService servidorService)
        {
            _logger = logger;
            _servidorService = servidorService;
        }

        [Route("servers")]
        [HttpGet()]
        public async Task<IActionResult> Index()
        {
            return Ok(await _servidorService.Recuperar());
        }
    }
}
