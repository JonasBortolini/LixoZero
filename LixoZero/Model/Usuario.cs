using LixoZero.Model.Interface;

namespace LixoZero.Model
{
    public class Usuario : IObjeto
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
    }
}
