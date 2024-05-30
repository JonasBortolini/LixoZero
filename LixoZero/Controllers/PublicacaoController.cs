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

        [HttpPost]
        [Route("ObterTodos")]
        public IEnumerable<Publicacao> ObterTodos() => PublicacaoPersistencia.ObterTodos().OfType<Publicacao>();

        [HttpPost]
        [Route("ObterPorId")]
        public Publicacao ObterPorId(int id) => PublicacaoPersistencia.ObterPorId(id) as Publicacao;

        [HttpPost]
        [Route("Adicionar")]
        public int Adicionar(Publicacao publicacao) => PublicacaoPersistencia.Adicionar(publicacao);

        [HttpPost]
        [Route("Atualizar")]
        public bool Atualizar(Publicacao publicacao) => PublicacaoPersistencia.Atualizar(publicacao);

        [HttpPost]
        [Route("Excluir")]
        public bool Excluir(int id) => PublicacaoPersistencia.Excluir(id);
    }
}
