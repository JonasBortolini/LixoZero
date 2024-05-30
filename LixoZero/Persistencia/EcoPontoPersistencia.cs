using LixoZero.Model;
using MySql.Data.MySqlClient;

namespace LixoZero.Persistencia
{
    public class EcoPontoPersistencia
    {
        private DatabaseConnection dbConnection;
        private ResiduoPersistencia residuoPersistencia;

        public EcoPontoPersistencia()
        {
            dbConnection = new DatabaseConnection();
            residuoPersistencia = new ResiduoPersistencia();
        }

        public IEnumerable<EcoPonto> ObterTodos()
        {
            List<EcoPonto> ecoPontos = new List<EcoPonto>();

            using (MySqlConnection connection = dbConnection.GetConnection())
            {
                string query = "SELECT * FROM EcoPonto";
                MySqlCommand command = new MySqlCommand(query, connection);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        EcoPonto ecoPonto = new EcoPonto
                        {
                            Id = reader.GetInt32("Id"),
                            Nome = reader.GetString("Nome"),
                            Endereco = reader.GetString("Endereco"),
                            HorarioFuncionamento = reader.GetString("HorarioFuncionamento"),
                            Latitude = reader.GetDouble("Latitude"),
                            Longitude = reader.GetDouble("Longitude"),
                            Residuos = ObterResiduosPorEcoPontoId(reader.GetInt32("Id"))
                        };

                        ecoPontos.Add(ecoPonto);
                    }
                }
            }

            return ecoPontos;
        }

        private IEnumerable<Residuo> ObterResiduosPorEcoPontoId(int ecoPontoId)
        {
            List<Residuo> residuos = new List<Residuo>();

            using (MySqlConnection connection = dbConnection.GetConnection())
            {
                string query = "SELECT ResiduoId FROM EcoPonto_Residuo WHERE EcoPontoId = @EcoPontoId";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@EcoPontoId", ecoPontoId);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int residuoId = reader.GetInt32("ResiduoId");
                        Residuo residuo = residuoPersistencia.ObterPorId(residuoId);
                        if (residuo != null)
                        {
                            residuos.Add(residuo);
                        }
                    }
                }
            }

            return residuos;
        }

        public EcoPonto ObterPorId(int id)
        {
            EcoPonto ecoPonto = null;

            using (MySqlConnection connection = dbConnection.GetConnection())
            {
                string query = "SELECT * FROM EcoPonto WHERE Id = @Id";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        ecoPonto = new EcoPonto
                        {
                            Id = reader.GetInt32("Id"),
                            Nome = reader.GetString("Nome"),
                            Endereco = reader.GetString("Endereco"),
                            HorarioFuncionamento = reader.GetString("HorarioFuncionamento"),
                            Latitude = reader.GetDouble("Latitude"),
                            Longitude = reader.GetDouble("Longitude"),
                            Residuos = ObterResiduosPorEcoPontoId(id)
                        };
                    }
                }
            }

            return ecoPonto;
        }

        public int Adicionar(EcoPonto ecoPonto)
        {
            int id = 0;

            using (MySqlConnection connection = dbConnection.GetConnection())
            {
                string query = "INSERT INTO EcoPonto (Nome, Endereco, HorarioFuncionamento, Latitude, Longitude) VALUES (@Nome, @Endereco, @HorarioFuncionamento, @Latitude, @Longitude)";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nome", ecoPonto.Nome);
                command.Parameters.AddWithValue("@Endereco", ecoPonto.Endereco);
                command.Parameters.AddWithValue("@HorarioFuncionamento", ecoPonto.HorarioFuncionamento);
                command.Parameters.AddWithValue("@Latitude", ecoPonto.Latitude);
                command.Parameters.AddWithValue("@Longitude", ecoPonto.Longitude);

                command.ExecuteNonQuery();

                id = (int)command.LastInsertedId;

                foreach (var residuo in ecoPonto.Residuos)
                {
                    query = "INSERT INTO EcoPonto_Residuo (EcoPontoId, ResiduoId) VALUES (@EcoPontoId, @ResiduoId)";
                    command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@EcoPontoId", id);
                    command.Parameters.AddWithValue("@ResiduoId", residuo.Id);

                    command.ExecuteNonQuery();
                }
            }

            return id;
        }

        public bool Atualizar(EcoPonto ecoPonto)
        {
            using (MySqlConnection connection = dbConnection.GetConnection())
            {
                string query = "UPDATE EcoPonto SET Nome = @Nome, Endereco = @Endereco, HorarioFuncionamento = @HorarioFuncionamento, Latitude = @Latitude, Longitude = @Longitude WHERE Id = @Id";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", ecoPonto.Id);
                command.Parameters.AddWithValue("@Nome", ecoPonto.Nome);
                command.Parameters.AddWithValue("@Endereco", ecoPonto.Endereco);
                command.Parameters.AddWithValue("@HorarioFuncionamento", ecoPonto.HorarioFuncionamento);
                command.Parameters.AddWithValue("@Latitude", ecoPonto.Latitude);
                command.Parameters.AddWithValue("@Longitude", ecoPonto.Longitude);

                int result = command.ExecuteNonQuery();

                if (result > 0)
                {
                    query = "DELETE FROM EcoPonto_Residuo WHERE EcoPontoId = @EcoPontoId";
                    command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@EcoPontoId", ecoPonto.Id);

                    command.ExecuteNonQuery();

                    foreach (var residuo in ecoPonto.Residuos)
                    {
                        query = "INSERT INTO EcoPonto_Residuo (EcoPontoId, ResiduoId) VALUES (@EcoPontoId, @ResiduoId)";
                        command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@EcoPontoId", ecoPonto.Id);
                        command.Parameters.AddWithValue("@ResiduoId", residuo.Id);

                        command.ExecuteNonQuery();
                    }
                }

                return result > 0;
            }
        }

        public bool Excluir(int id)
        {
            using (MySqlConnection connection = dbConnection.GetConnection())
            {
                string query = "DELETE FROM EcoPonto WHERE Id = @Id";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);

                int result = command.ExecuteNonQuery();

                return result > 0;
            }
        }
    }
}
