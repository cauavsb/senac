using System;
using System.Collections.Generic;

public class Produto
{
    public int id { get; set; }
    public string produto { get; set; }
    public string tamanho { get; set; }
    public string sexo { get; set; }
    public int quantidade_estoque { get; set; }
    public int quantidade_venda { get; set; }
    public Double valor_unitario { get; set; }
    public Double valor_venda { get; set; }
}