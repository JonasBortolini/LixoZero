using LixoZero.Model;
using LixoZero.Persistencia;
using Microsoft.AspNetCore.Mvc;

namespace LixoZero.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PublicacaoController : ControllerBase
    {
        private readonly ILogger<PublicacaoController> _logger;
        private PublicacaoPersistencia PublicacaoPersistencia { get; set; } = new PublicacaoPersistencia();

        public PublicacaoController(ILogger<PublicacaoController> logger)
        {
            _logger = logger;
        }

        [HttpGet("ObterTodos")]
        public IEnumerable<Publicacao> ObterTodos() => PublicacaoPersistencia.ObterTodos().OfType<Publicacao>();

        [HttpGet("{id}")]
        public Publicacao ObterPorId(int id) => PublicacaoPersistencia.ObterPorId(id) as Publicacao;

        [HttpPost("{id}")]
        public int Adicionar(Publicacao publicacao) => PublicacaoPersistencia.Adicionar(publicacao);

        [HttpPut]
        public bool Atualizar(Publicacao publicacao) => PublicacaoPersistencia.Atualizar(publicacao);

        [HttpDelete("{id}")]
        public bool Excluir(int id) => PublicacaoPersistencia.Excluir(id);
    }
}
