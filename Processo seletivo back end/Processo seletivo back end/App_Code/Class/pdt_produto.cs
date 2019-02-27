using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for pdt_produto
/// </summary>
public class pdt_produto
{
    private int pdt_id;
    private string pdt_nome;
    private double pdt_preco;
    private string pdt_descricao;
    private loj_lojas loj_id;

    public int Pdt_id { get => pdt_id; set => pdt_id = value; }
    public string Pdt_nome { get => pdt_nome; set => pdt_nome = value; }
    public double Pdt_preco { get => pdt_preco; set => pdt_preco = value; }
    public string Pdt_descricao { get => pdt_descricao; set => pdt_descricao = value; }
    public global::loj_lojas Loj_id { get => loj_id; set => loj_id = value; }
}