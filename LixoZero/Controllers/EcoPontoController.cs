using LixoZero.Model;
using LixoZero.Persistencia;
using Microsoft.AspNetCore.Mvc;

namespace LixoZero.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EcoPontoController : ControllerBase
    {
        private readonly ILogger<EcoPontoController> _logger;
        private EcoPontoPersistencia EcoPontoPersistencia { get; set; } = new EcoPontoPersistencia();

        public EcoPontoController(ILogger<EcoPontoController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        [Route("ObterTodos")]
        public IEnumerable<EcoPonto> ObterTodos() => EcoPontoPersistencia.ObterTodos();
        [HttpPost]
        [Route("ObterPorId")]
        public EcoPonto ObterPorId(int id) => EcoPontoPersistencia.ObterPorId(id);

        [HttpPost]
        [Route("Adicionar")]
        public int Adicionar(EcoPonto ecoPonto) => EcoPontoPersistencia.Adicionar(ecoPonto);

        [HttpPost]
        [Route("Atualizar")]
        public bool Atualizar(EcoPonto ecoPonto) => EcoPontoPersistencia.Atualizar(ecoPonto);

        [HttpPost]
        [Route("Excluir")]
        public bool Excluir(int id) => EcoPontoPersistencia.Excluir(id);
    }
}
