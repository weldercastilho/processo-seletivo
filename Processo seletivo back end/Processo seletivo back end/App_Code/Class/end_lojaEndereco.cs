using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for end_lojaEndereco
/// </summary>
public class end_lojaEndereco
{
    private int end_id;
    private string end_cidade;
    private string end_estado;
    private string end_bairro;
    private string end_rua;
    private int end_numero;
    private string end_complemento;
    private loj_lojas loj_id;

    public int End_id { get => end_id; set => end_id = value; }
    public string End_cidade { get => end_cidade; set => end_cidade = value; }
    public string End_estado { get => end_estado; set => end_estado = value; }
    public string End_bairro { get => end_bairro; set => end_bairro = value; }
    public string End_rua { get => end_rua; set => end_rua = value; }
    public int End_numero { get => end_numero; set => end_numero = value; }
    public string End_complemento { get => end_complemento; set => end_complemento = value; }
    public global::loj_lojas Loj_id { get => loj_id; set => loj_id = value; }
}