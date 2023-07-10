using System;
using MySqlConnector;
using System.Collections.Generic;

public class UsuarioRepository
{
    private const string DadosConexao = "Database = projeto; Data Source = localhost; User Id = root;";

    public void testeConexao() {

        MySqlConnection Conexao = new MySqlConnection(DadosConexao);

        Conexao.Open();

        Console.WriteLine("Deu certo!");

        Conexao.Close();
    }

    public void inserir(Usuario u) {

        MySqlConnection Conexao = new MySqlConnection(DadosConexao);

        Conexao.Open();

        string query = "INSERT INTO usuario (id, nome, login, senha, data_nascimento) VALUES (@id, @nome, @login, @senha, @data_nascimento)";

        MySqlCommand Comando = new MySqlCommand(query, Conexao);
        Comando.Parameters.AddWithValue("@id", u.id);
        Comando.Parameters.AddWithValue("@nome", u.nome);
        Comando.Parameters.AddWithValue("@login", u.login);
        Comando.Parameters.AddWithValue("@senha", u.senha);
        Comando.Parameters.AddWithValue("@data_nascimento", u.data_nascimento.ToString("yyyy-MM-dd"));
        Comando.ExecuteNonQuery();

        Conexao.Close();
    }

    public List<Usuario> listar() {

        MySqlConnection Conexao = new MySqlConnection(DadosConexao);

        Conexao.Open();

        string query = "SELECT * FROM usuario";

        MySqlCommand Comando = new MySqlCommand(query, Conexao);

        MySqlDataReader reader = Comando.ExecuteReader();
        
        List<Usuario> listaUsuario = new List<Usuario>();

        while(reader.Read()) {
            Usuario u = new Usuario();

            u.id = reader.GetInt32("id");

            if(!reader.IsDBNull(reader.GetOrdinal("nome")))
            u.nome = reader.GetString("nome");

            if(!reader.IsDBNull(reader.GetOrdinal("login")))
            u.login = reader.GetString("login");

            if(!reader.IsDBNull(reader.GetOrdinal("senha")))
            u.senha = reader.GetString("senha");

            if(!reader.IsDBNull(reader.GetOrdinal("data_nascimento")))
            u.data_nascimento = reader.GetDateTime("data_nascimento");

            listaUsuario.Add(u);
        }

        Conexao.Close();

        return listaUsuario; 
    }

    public void editar(Usuario u) {

        MySqlConnection Conexao = new MySqlConnection(DadosConexao);

        Conexao.Open();

        string query = "UPDATE usuario SET id=@id, nome=@nome, login=@login, senha=@senha, data_nascimento=@data_nascimento";

        MySqlCommand Comando = new MySqlCommand(query, Conexao);
        Comando.Parameters.AddWithValue("@id", u.id);
        Comando.Parameters.AddWithValue("@nome", u.nome);
        Comando.Parameters.AddWithValue("@login", u.login);
        Comando.Parameters.AddWithValue("@senha", u.senha);
        Comando.Parameters.AddWithValue("@data_nascimento", u.data_nascimento.ToString("yyyy-MM-dd"));
        Comando.ExecuteNonQuery();

        Conexao.Close();
    }

    public Usuario buscarPorId(int id) {

        MySqlConnection Conexao = new MySqlConnection(DadosConexao);

        Conexao.Open();

        string query = "SELECT * from usuario WHERE id = @id";

        MySqlCommand Comando = new MySqlCommand(query, Conexao);

        Comando.Parameters.AddWithValue("id", id);

        MySqlDataReader reader = Comando.ExecuteReader();

        Usuario u = new Usuario();

        if(reader.Read()) {
            u.id = reader.GetInt32("id");

            if(!reader.IsDBNull(reader.GetOrdinal("nome")))
            u.nome = reader.GetString("nome");

            if(!reader.IsDBNull(reader.GetOrdinal("login")))
            u.login = reader.GetString("login");

            if(!reader.IsDBNull(reader.GetOrdinal("senha")))
            u.senha = reader.GetString("senha");

            if(!reader.IsDBNull(reader.GetOrdinal("data_nascimento")))
            u.data_nascimento = reader.GetDateTime("data_nascimento");
        }

        Conexao.Close();

        return u;
    }

    public Usuario verificaLogin(Usuario user) {

        MySqlConnection Conexao = new MySqlConnection(DadosConexao);

        Conexao.Open();

        string query = "SELECT * from usuario WHERE login=@login AND senha=@senha";

        MySqlCommand Comando = new MySqlCommand(query, Conexao);

        Comando.Parameters.AddWithValue("@login", user.login);
        Comando.Parameters.AddWithValue("@senha", user.senha);

        MySqlDataReader reader = Comando.ExecuteReader();

        Usuario u = new Usuario();

        if(reader.Read()) {
            u.id = reader.GetInt32("id");

            if(!reader.IsDBNull(reader.GetOrdinal("nome"))) 
            u.nome = reader.GetString("nome");

            if(!reader.IsDBNull(reader.GetOrdinal("login")))
            u.login = reader.GetString("login");

            if(!reader.IsDBNull(reader.GetOrdinal("senha")))
            u.senha = reader.GetString("senha");

            if(!reader.IsDBNull(reader.GetOrdinal("data_nascimento")))
            u.data_nascimento = reader.GetDateTime("data_nascimento");
        }

        Conexao.Close();

        return u;
    }

    public void deletar(int id) {

        MySqlConnection Conexao = new MySqlConnection(DadosConexao);

        Conexao.Open();

        string query = "DELETE from usuario WHERE id = @id";

        MySqlCommand Comando = new MySqlCommand(query, Conexao);

        Comando.Parameters.AddWithValue("@id", id);

        Comando.ExecuteNonQuery();

        Conexao.Close();
    }
}