using LixoZero.Model;
using MySql.Data.MySqlClient;

namespace LixoZero.Persistencia
{
    public class ResiduoPersistencia
    {
        private DatabaseConnection dbConnection;

        public ResiduoPersistencia()
        {
            dbConnection = new DatabaseConnection();
        }

        public IEnumerable<Residuo> ObterTodos()
        {
            List<Residuo> residuos = new List<Residuo>();

            using (MySqlConnection connection = dbConnection.GetConnection())
            {
                string query = "SELECT * FROM Residuo";
                MySqlCommand command = new MySqlCommand(query, connection);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Residuo residuo = new Residuo
                        {
                            Id = reader.GetInt32("Id"),
                            Tipo = reader.GetString("Tipo")
                        };

                        residuos.Add(residuo);
                    }
                }
            }

            return residuos;
        }

        public Residuo ObterPorId(int id)
        {
            Residuo residuo = null;

            using (MySqlConnection connection = dbConnection.GetConnection())
            {
                string query = "SELECT * FROM Residuo WHERE Id = @Id";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        residuo = new Residuo
                        {
                            Id = reader.GetInt32("Id"),
                            Tipo = reader.GetString("Tipo")
                        };
                    }
                }
            }

            return residuo;
        }

        public int Adicionar(Residuo residuo)
        {
            int id = 0;

            using (MySqlConnection connection = dbConnection.GetConnection())
            {
                string query = "INSERT INTO Residuo (Tipo) VALUES (@Tipo)";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Tipo", residuo.Tipo);

                int result = command.ExecuteNonQuery();

                if (result > 0)
                {
                    id = (int)command.LastInsertedId;
                }
            }

            return id;
        }


        public bool Atualizar(Residuo residuo)
        {
            using (MySqlConnection connection = dbConnection.GetConnection())
            {
                string query = "UPDATE Residuo SET Tipo = @Tipo WHERE Id = @Id";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", residuo.Id);
                command.Parameters.AddWithValue("@Tipo", residuo.Tipo);

                int result = command.ExecuteNonQuery();

                return result > 0;
            }
        }

        public bool Excluir(int id)
        {
            using (MySqlConnection connection = dbConnection.GetConnection())
            {
                string query = "DELETE FROM Residuo WHERE Id = @Id";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);

                int result = command.ExecuteNonQuery();

                return result > 0;
            }
        }
    }
}
