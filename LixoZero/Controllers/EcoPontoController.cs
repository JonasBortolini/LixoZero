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

        [HttpGet("ObterTodos")]
        public IEnumerable<EcoPonto> ObterTodos() => EcoPontoPersistencia.ObterTodos();

        [HttpGet("{id}")]
        public EcoPonto ObterPorId(int id) => EcoPontoPersistencia.ObterPorId(id);

        [HttpPost("{id}")]
        public int Adicionar(EcoPonto ecoPonto) => EcoPontoPersistencia.Adicionar(ecoPonto);

        [HttpPut]
        public bool Atualizar(EcoPonto ecoPonto) => EcoPontoPersistencia.Atualizar(ecoPonto);

        [HttpDelete("{id}")]
        public bool Excluir(int id) => EcoPontoPersistencia.Excluir(id);
    }
}
