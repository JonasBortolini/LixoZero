using LixoZero.Model;
using MySql.Data.MySqlClient;

namespace LixoZero.Persistencia
{
    public class PublicacaoPersistencia
    {
        private DatabaseConnection dbConnection;
        private ResiduoPersistencia residuoPersistencia;

        public PublicacaoPersistencia()
        {
            dbConnection = new DatabaseConnection();
            residuoPersistencia = new ResiduoPersistencia();
        }

        public IEnumerable<Publicacao> ObterTodos()
        {
            List<Publicacao> publicacoes = new List<Publicacao>();

            using (MySqlConnection connection = dbConnection.GetConnection())
            {
                string query = "SELECT * FROM Publicacao";
                MySqlCommand command = new MySqlCommand(query, connection);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Publicacao publicacao = new Publicacao
                        {
                            Id = reader.GetInt32("Id"),
                            Titulo = reader.GetString("Titulo"),
                            Conteudo = reader.GetString("Conteudo"),
                            Imagem = reader.GetString("Imagem"),
                            Data = reader.GetString("Data"),
                            Residuos = ObterResiduosPorPublicacaoId(reader.GetInt32("Id"))
                        };

                        publicacoes.Add(publicacao);
                    }
                }
            }

            return publicacoes;
        }

        private IEnumerable<Residuo> ObterResiduosPorPublicacaoId(int publicacaoId)
        {
            List<Residuo> residuos = new List<Residuo>();

            using (MySqlConnection connection = dbConnection.GetConnection())
            {
                string query = "SELECT ResiduoId FROM Publicacao_Residuo WHERE PublicacaoId = @PublicacaoId";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@PublicacaoId", publicacaoId);

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

        public Publicacao ObterPorId(int id)
        {
            Publicacao publicacao = null;

            using (MySqlConnection connection = dbConnection.GetConnection())
            {
                string query = "SELECT * FROM Publicacao WHERE Id = @Id";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        publicacao = new Publicacao
                        {
                            Id = reader.GetInt32("Id"),
                            Titulo = reader.GetString("Titulo"),
                            Conteudo = reader.GetString("Conteudo"),
                            Imagem = reader.GetString("Imagem"),
                            Data = reader.GetString("Data"),
                            Residuos = ObterResiduosPorPublicacaoId(id)
                        };
                    }
                }
            }

            return publicacao;
        }

        public int Adicionar(Publicacao publicacao)
        {
            int id = 0;

            using (MySqlConnection connection = dbConnection.GetConnection())
            {
                string query = "INSERT INTO Publicacao (Titulo, Conteudo, Imagem, Data) VALUES (@Titulo, @Conteudo, @Imagem, @Data)";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Titulo", publicacao.Titulo);
                command.Parameters.AddWithValue("@Conteudo", publicacao.Conteudo);
                command.Parameters.AddWithValue("@Imagem", publicacao.Imagem);
                command.Parameters.AddWithValue("@Data", publicacao.Data);

                command.ExecuteNonQuery();

                id = (int)command.LastInsertedId;

                foreach (var residuo in publicacao.Residuos)
                {
                    query = "INSERT INTO Publicacao_Residuo (PublicacaoId, ResiduoId) VALUES (@PublicacaoId, @ResiduoId)";
                    command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@PublicacaoId", id);
                    command.Parameters.AddWithValue("@ResiduoId", residuo.Id);

                    command.ExecuteNonQuery();
                }
            }

            return id;
        }

        public bool Atualizar(Publicacao publicacao)
        {
            using (MySqlConnection connection = dbConnection.GetConnection())
            {
                string query = "UPDATE Publicacao SET Titulo = @Titulo, Conteudo = @Conteudo, Imagem = @Imagem, Data = @Data WHERE Id = @Id";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", publicacao.Id);
                command.Parameters.AddWithValue("@Titulo", publicacao.Titulo);
                command.Parameters.AddWithValue("@Conteudo", publicacao.Conteudo);
                command.Parameters.AddWithValue("@Imagem", publicacao.Imagem);
                command.Parameters.AddWithValue("@Data", publicacao.Data);

                int result = command.ExecuteNonQuery();

                if (result > 0)
                {
                    query = "DELETE FROM Publicacao_Residuo WHERE PublicacaoId = @PublicacaoId";
                    command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@PublicacaoId", publicacao.Id);

                    command.ExecuteNonQuery();

                    foreach (var residuo in publicacao.Residuos)
                    {
                        query = "INSERT INTO Publicacao_Residuo (PublicacaoId, ResiduoId) VALUES (@PublicacaoId, @ResiduoId)";
                        command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@PublicacaoId", publicacao.Id);
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
                string query = "DELETE FROM Publicacao WHERE Id = @Id";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);

                int result = command.ExecuteNonQuery();

                return result > 0;
            }
        }
    }
}
