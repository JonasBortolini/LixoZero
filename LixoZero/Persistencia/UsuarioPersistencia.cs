using LixoZero.Model;
using MySql.Data.MySqlClient;

namespace LixoZero.Persistencia
{
    public class UsuarioPersistencia
    {
        private DatabaseConnection dbConnection;

        public UsuarioPersistencia()
        {
            dbConnection = new DatabaseConnection();
        }

        public bool CriarLogin(Usuario usuario)
        {
            using (MySqlConnection connection = dbConnection.GetConnection())
            {
                string query = "INSERT INTO Usuario (Login, Email, Senha) VALUES (@Login, @Email, @Senha)";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Login", usuario.Login);
                command.Parameters.AddWithValue("@Email", usuario.Email);
                command.Parameters.AddWithValue("@Senha", usuario.Senha);

                int result = command.ExecuteNonQuery();

                return result > 0;
            }
        }

        public bool Logar(string login_Email, string senha)
        {
            using (MySqlConnection connection = dbConnection.GetConnection())
            {
                string query = "SELECT * FROM Usuario WHERE (Login = @LoginEmail OR Email = @LoginEmail) AND Senha = @Senha";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@LoginEmail", login_Email);
                command.Parameters.AddWithValue("@Senha", senha);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    return reader.HasRows;
                }
            }
        }
    }
}
