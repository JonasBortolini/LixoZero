using LixoZero.Model.Interface;

namespace LixoZero.Model
{
    public class Publicacao : IObjeto
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Conteudo { get; set; }
        public string Imagem { get; set; }
        public string Data { get; set; }
        public IEnumerable<Residuo> Residuos { get; set; }
    }
}
