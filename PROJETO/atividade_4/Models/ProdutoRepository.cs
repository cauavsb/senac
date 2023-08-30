using System;
using MySqlConnector;
using System.Collections.Generic;

public class ProdutoRepository
{
    private const string DadosConexao = "Database = projeto; Data Source = localhost; User Id = root;";

    public void testeConexao() {

        MySqlConnection Conexao = new MySqlConnection(DadosConexao);

        Conexao.Open();

        Console.WriteLine("Deu certo!");

        Conexao.Close();
    }

    public void inserir(Produto p) {

        MySqlConnection Conexao = new MySqlConnection(DadosConexao);

        Conexao.Open();

        string query = "INSERT INTO produto (id, produto, tamanho, sexo, quantidade_estoque, quantidade_venda, valor_unitario, valor_venda) VALUES (@id, @produto, @tamanho, @sexo, @quantidade_estoque, @quantidade_venda, @valor_unitario, @valor_venda)";

        MySqlCommand Comando = new MySqlCommand(query, Conexao);
        Comando.Parameters.AddWithValue("@id", p.id);
        Comando.Parameters.AddWithValue("@produto", p.produto);
        Comando.Parameters.AddWithValue("@tamanho", p.tamanho);
        Comando.Parameters.AddWithValue("@sexo", p.sexo);
        Comando.Parameters.AddWithValue("@quantidade_estoque", p.quantidade_estoque);
        Comando.Parameters.AddWithValue("@quantidade_venda", p.quantidade_venda);
        Comando.Parameters.AddWithValue("@valor_unitario", p.valor_unitario);
        Comando.Parameters.AddWithValue("@valor_venda", p.valor_venda);
        Comando.ExecuteNonQuery();

        Conexao.Close();
    }

    public List<Produto> listar() {

        MySqlConnection Conexao = new MySqlConnection(DadosConexao);

        Conexao.Open();

        string query = "SELECT * FROM produto";

        MySqlCommand Comando = new MySqlCommand(query, Conexao);

        MySqlDataReader reader = Comando.ExecuteReader();
        
        List<Produto> listaProdutos = new List<Produto>();

        while(reader.Read()) {
            Produto p = new Produto();

            p.id = reader.GetInt32("id");

            if(!reader.IsDBNull(reader.GetOrdinal("produto")))
            p.produto = reader.GetString("produto");

            if(!reader.IsDBNull(reader.GetOrdinal("tamanho")))
            p.tamanho = reader.GetString("tamanho");

            if(!reader.IsDBNull(reader.GetOrdinal("sexo")))
            p.sexo = reader.GetString("sexo");

            if(!reader.IsDBNull(reader.GetOrdinal("quantidade_estoque")))
            p.quantidade_estoque = reader.GetInt32("quantidade_estoque");

            if(!reader.IsDBNull(reader.GetOrdinal("quantidade_venda")))
            p.quantidade_venda = reader.GetInt32("quantidade_venda");

            if(!reader.IsDBNull(reader.GetOrdinal("valor_unitario")))
            p.valor_unitario = reader.GetDouble("valor_unitario");

            if(!reader.IsDBNull(reader.GetOrdinal("valor_venda")))
            p.valor_venda = reader.GetDouble("valor_venda");

            listaProdutos.Add(p);
        }

        Conexao.Close();

        return listaProdutos; 
    }

    public void editar(Produto p) {

        MySqlConnection Conexao = new MySqlConnection(DadosConexao);

        Conexao.Open();

        string query = "UPDATE produto SET produto=@produto, tamanho=@tamanho, sexo=@sexo, quantidade_estoque=@quantidade_estoque, quantidade_venda=@quantidade_venda, valor_unitario=@valor_unitario, valor_venda=@valor_venda WHERE id = @id";

        MySqlCommand Comando = new MySqlCommand(query, Conexao);
        Comando.Parameters.AddWithValue("@id", p.id);
        Comando.Parameters.AddWithValue("@produto", p.produto);
        Comando.Parameters.AddWithValue("@tamanho", p.tamanho);
        Comando.Parameters.AddWithValue("@sexo", p.sexo);
        Comando.Parameters.AddWithValue("@quantidade_estoque", p.quantidade_estoque);
        Comando.Parameters.AddWithValue("@quantidade_venda", p.quantidade_venda);
        Comando.Parameters.AddWithValue("@valor_unitario", p.valor_unitario);
        Comando.Parameters.AddWithValue("@valor_venda", p.valor_venda);
        Comando.ExecuteNonQuery();

        Conexao.Close();
    }

    public Produto buscarPorId(int id) {

        MySqlConnection Conexao = new MySqlConnection(DadosConexao);

        Conexao.Open();

        string query = "SELECT * from produto WHERE id = @id";

        MySqlCommand Comando = new MySqlCommand(query, Conexao);

        Comando.Parameters.AddWithValue("id", id);

        MySqlDataReader reader = Comando.ExecuteReader();

        Produto p = new Produto();

        if(reader.Read()) {
            p.id = reader.GetInt32("id");

            if(!reader.IsDBNull(reader.GetOrdinal("produto")))
            p.produto = reader.GetString("produto");

            if(!reader.IsDBNull(reader.GetOrdinal("tamanho")))
            p.tamanho = reader.GetString("tamanho");

            if(!reader.IsDBNull(reader.GetOrdinal("sexo")))
            p.sexo = reader.GetString("sexo");

            if(!reader.IsDBNull(reader.GetOrdinal("quantidade_estoque")))
            p.quantidade_estoque = reader.GetInt32("quantidade_estoque");

            if(!reader.IsDBNull(reader.GetOrdinal("quantidade_venda")))
            p.quantidade_venda = reader.GetInt32("quantidade_venda");

            if(!reader.IsDBNull(reader.GetOrdinal("valor_unitario")))
            p.valor_unitario = reader.GetDouble("valor_unitario");

            if(!reader.IsDBNull(reader.GetOrdinal("valor_venda")))
            p.valor_venda = reader.GetDouble("valor_venda");
        }

        Conexao.Close();

        return p;
    }

    public void deletar(int id) {

        MySqlConnection Conexao = new MySqlConnection(DadosConexao);

        Conexao.Open();

        string query = "DELETE from produto WHERE id = @id";

        MySqlCommand Comando = new MySqlCommand(query, Conexao);

        Comando.Parameters.AddWithValue("@id", id);

        Comando.ExecuteNonQuery();

        Conexao.Close();
    }
}