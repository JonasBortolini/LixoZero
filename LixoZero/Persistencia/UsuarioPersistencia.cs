using LixoZero.Model;

namespace LixoZero.Persistencia
{
    public class UsuarioPersistencia
    {
        public bool CriarLogin(Usuario usuario)
        {
            //aqui sera feito o tratamento para salvar no banco 

            usuario.Id = VaiSerExcluidoQuandoOBancoEstiverFuncionando.Usuarios.OrderBy(r => r.Id).LastOrDefault().Id + 1;
            var usuarios = VaiSerExcluidoQuandoOBancoEstiverFuncionando.Usuarios.ToList();
            usuarios.Add(usuario);

            VaiSerExcluidoQuandoOBancoEstiverFuncionando.Usuarios = usuarios;

            return true;
        }

        public bool Logar(string login_Email, string senha)
        {
            var usuario = VaiSerExcluidoQuandoOBancoEstiverFuncionando.Usuarios.FirstOrDefault(x => (x.Login.Equals(login_Email) || x.Email.Equals(login_Email)) && x.Senha.Equals(senha));

            if (usuario is null)
                return false;

            return true;
        }
    }
}
