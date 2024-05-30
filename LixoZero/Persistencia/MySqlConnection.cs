using MySql.Data.MySqlClient;

public class DatabaseConnection
{
    private string server = "localhost";
    private string database = "lixo";
    private string port = "3306";
    private string username = "root";
    private string password = "";

    public MySqlConnection GetConnection()
    {
        string connectionString = $"Server={server};Port={port};Database={database};Uid={username};Pwd={password};";

        MySqlConnection connection = null;

        try
        {
            connection = new MySqlConnection(connectionString);
            connection.Open();
        }
        catch (MySqlException ex)
        {
            Console.WriteLine("Erro de conexão: " + ex.Message);
        }

        return connection;
    }
}
