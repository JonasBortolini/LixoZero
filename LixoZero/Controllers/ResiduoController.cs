using LixoZero.Model;
using LixoZero.Persistencia;
using Microsoft.AspNetCore.Mvc;

namespace LixoZero.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ResiduoController : ControllerBase
    {
        private readonly ILogger<ResiduoController> _logger;
        private ResiduoPersistencia ResiduoPersistencia { get; set; } = new ResiduoPersistencia();

        public ResiduoController(ILogger<ResiduoController> logger)
        {
            _logger = logger;
        }

        [HttpGet("ObterTodos")]
        public IEnumerable<Residuo> ObterTodos() => ResiduoPersistencia.ObterTodos().OfType<Residuo>();

        [HttpGet("{id}")]
        public Residuo ObterPorId(int id) => ResiduoPersistencia.ObterPorId(id) as Residuo;

        [HttpPost("{id}")]
        public int Adicionar(Residuo residuo) => ResiduoPersistencia.Adicionar(residuo);

        [HttpPut]
        public bool Atualizar(Residuo residuo) => ResiduoPersistencia.Atualizar(residuo);

        [HttpDelete("{id}")]
        public bool Excluir(int id) => ResiduoPersistencia.Excluir(id);
    }
}
