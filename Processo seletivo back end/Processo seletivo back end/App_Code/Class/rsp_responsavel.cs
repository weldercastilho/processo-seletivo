using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for rsp_responsavel
/// </summary>
public class rsp_responsavel
{
    private int rsp_id;
    private string rsp_telefone;
    private string rsp_nome;
    private string rsp_cargo;
    private loj_lojas loj_id;

    public int Rsp_id { get => rsp_id; set => rsp_id = value; }
    public string Rsp_telefone { get => rsp_telefone; set => rsp_telefone = value; }
    public string Rsp_nome { get => rsp_nome; set => rsp_nome = value; }
    public string Rsp_cargo { get => rsp_cargo; set => rsp_cargo = value; }
    public global::loj_lojas Loj_id { get => loj_id; set => loj_id = value; }
}