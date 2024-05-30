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

        [HttpPost]
        [Route("ObterTodos")]
        public IEnumerable<Residuo> ObterTodos() => ResiduoPersistencia.ObterTodos().OfType<Residuo>();

        [HttpPost]
        [Route("ObterPorId")]
        public Residuo ObterPorId(int id) => ResiduoPersistencia.ObterPorId(id) as Residuo;

        [HttpPost]
        [Route("Adicionar")]
        public int Adicionar(Residuo residuo) => ResiduoPersistencia.Adicionar(residuo);

        [HttpPost]
        [Route("Atualizar")]
        public bool Atualizar(Residuo residuo) => ResiduoPersistencia.Atualizar(residuo);

        [HttpPost]
        [Route("Excluir")]
        public bool Excluir(int id) => ResiduoPersistencia.Excluir(id);
    }
}
