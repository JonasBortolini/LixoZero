using LixoZero.Model.Interface;

namespace LixoZero.Model
{
    public class EcoPonto : IObjeto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string HorarioFuncionamento { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public IEnumerable<Residuo> Residuos { get; set; }
    }
}
