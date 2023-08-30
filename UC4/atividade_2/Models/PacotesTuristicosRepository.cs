using System;
using MySqlConnector;
using System.Collections.Generic;

public class PacotesTuristicosRepository
{
    private const string DadosConexao = "Database = senac; Data Source = localhost; User Id = root;";

    public void testeConexao() {

        MySqlConnection Conexao = new MySqlConnection(DadosConexao);

        Conexao.Open();

        Console.WriteLine("Deu certo!");

        Conexao.Close();
    }

    public void inserir(PacotesTuristicos pc) {

        MySqlConnection Conexao = new MySqlConnection(DadosConexao);

        Conexao.Open();

        string query = "INSERT INTO Pacote (id, nome, origem, destino, atrativos, saida, retorno, usuario) VALUES (@id, @nome, @origem, @destino, @atrativos, @saida, @retorno, @usuario)";

        MySqlCommand Comando = new MySqlCommand(query, Conexao);
        Comando.Parameters.AddWithValue("@id", pc.id);
        Comando.Parameters.AddWithValue("@nome", pc.nome);
        Comando.Parameters.AddWithValue("@origem", pc.origem);
        Comando.Parameters.AddWithValue("@destino", pc.destino);
        Comando.Parameters.AddWithValue("@atrativos", pc.atrativos);
        Comando.Parameters.AddWithValue("@saida", pc.saida.ToString("yyyy-MM-dd"));
        Comando.Parameters.AddWithValue("@retorno", pc.retorno.ToString("yyyy-MM-dd"));
        Comando.Parameters.AddWithValue("@usuario", pc.usuario);
        Comando.ExecuteNonQuery();

        Conexao.Close();
    }

    public List<PacotesTuristicos> listar() {

        MySqlConnection Conexao = new MySqlConnection(DadosConexao);

        Conexao.Open();

        string query = "SELECT * FROM pacote";

        MySqlCommand Comando = new MySqlCommand(query, Conexao);

        MySqlDataReader reader = Comando.ExecuteReader();
        
        List<PacotesTuristicos> listaPacotes = new List<PacotesTuristicos>();

        while(reader.Read()) {
            PacotesTuristicos pc = new PacotesTuristicos();

            pc.id = reader.GetInt32("id");

            if(!reader.IsDBNull(reader.GetOrdinal("nome")))
            pc.nome = reader.GetString("nome");

            if(!reader.IsDBNull(reader.GetOrdinal("origem")))
            pc.origem = reader.GetString("origem");

            if(!reader.IsDBNull(reader.GetOrdinal("destino")))
            pc.destino = reader.GetString("destino");

            if(!reader.IsDBNull(reader.GetOrdinal("atrativos")))
            pc.atrativos = reader.GetString("atrativos");

            if(!reader.IsDBNull(reader.GetOrdinal("saida")))
            pc.saida = reader.GetDateTime("saida");

            if(!reader.IsDBNull(reader.GetOrdinal("retorno")))
            pc.retorno = reader.GetDateTime("retorno");

            if(!reader.IsDBNull(reader.GetOrdinal("usuario")))
            pc.usuario = reader.GetInt32("usuario");

            listaPacotes.Add(pc);
        }

        Conexao.Close();

        return listaPacotes; 
    }

    public void editar(PacotesTuristicos pc) {

        MySqlConnection Conexao = new MySqlConnection(DadosConexao);

        Conexao.Open();

        string query = "UPDATE pacote SET id=@id, nome=@nome, origem=@origem, destino=@destino, atrativos=@atrativos, saida=@saida, retorno=@retorno, usuario=@usuario";

        MySqlCommand Comando = new MySqlCommand(query, Conexao);
        Comando.Parameters.AddWithValue("@id", pc.id);
        Comando.Parameters.AddWithValue("@nome", pc.nome);
        Comando.Parameters.AddWithValue("@origem", pc.origem);
        Comando.Parameters.AddWithValue("@destino", pc.destino);
        Comando.Parameters.AddWithValue("@atrativos", pc.atrativos);
        Comando.Parameters.AddWithValue("@saida", pc.saida.ToString("yyyy-MM-dd"));
        Comando.Parameters.AddWithValue("@retorno", pc.retorno.ToString("yyyy-MM-dd"));
        Comando.Parameters.AddWithValue("@usuario", pc.usuario);
        Comando.ExecuteNonQuery();

        Conexao.Close();
    }

    public PacotesTuristicos buscarPorId(int id) {

        MySqlConnection Conexao = new MySqlConnection(DadosConexao);

        Conexao.Open();

        string query = "SELECT * from pacote WHERE id = @id";

        MySqlCommand Comando = new MySqlCommand(query, Conexao);

        Comando.Parameters.AddWithValue("id", id);

        MySqlDataReader reader = Comando.ExecuteReader();

        PacotesTuristicos pc = new PacotesTuristicos();

        if(reader.Read()) {
            pc.id = reader.GetInt32("id");

            if(!reader.IsDBNull(reader.GetOrdinal("nome"))) {
                pc.nome = reader.GetString("nome");
            }
            
            if(!reader.IsDBNull(reader.GetOrdinal("origem"))) {
                pc.origem = reader.GetString("origem");
            }
            
            if(!reader.IsDBNull(reader.GetOrdinal("destino"))) {
                pc.destino = reader.GetString("destino");
            }

            if(!reader.IsDBNull(reader.GetOrdinal("atrativos"))) {
                pc.atrativos = reader.GetString("atrativos");
            }
            
            if(!reader.IsDBNull(reader.GetOrdinal("saida"))) {
                pc.saida = reader.GetDateTime("saida");
            }
            
            if(!reader.IsDBNull(reader.GetOrdinal("retorno"))) {
                pc.retorno = reader.GetDateTime("retorno");
            }
            
            if(!reader.IsDBNull(reader.GetOrdinal("usuario"))) {
                pc.usuario = reader.GetInt32("usuario");
            }
        }

        Conexao.Close();

        return pc;
    }

    public void deletar(int id) {

        MySqlConnection Conexao = new MySqlConnection(DadosConexao);

        Conexao.Open();

        string query = "DELETE from pacote WHERE id = @id";

        MySqlCommand Comando = new MySqlCommand(query, Conexao);

        Comando.Parameters.AddWithValue("@id", id);

        Comando.ExecuteNonQuery();

        Conexao.Close();
    }
}