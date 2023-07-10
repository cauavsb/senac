using System;
using System.Collections.Generic;
public class Cadastrar
{
    private List<Produto> listaProdutos;

    public Cadastrar() {
        listaProdutos = new List<Produto>();
    }

    public void incluir(Produto p) {
        listaProdutos.Add(p);
    }

    public List<Produto> listarProdutos() {
        return listaProdutos;
    }
}