using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for loj_lojas
/// </summary>
public class loj_lojas
{
    private int loj_id;
    private string loj_nome;
    private string loj_cnpj;
    private string loj_razsocial;
    private end_lojaEndereco end_id;
    private rsp_responsavel rsp_id;

    public int Loj_id { get => loj_id; set => loj_id = value; }
    public string Loj_nome { get => loj_nome; set => loj_nome = value; }
    public string Loj_cnpj { get => loj_cnpj; set => loj_cnpj = value; }
    public string Loj_razsocial { get => loj_razsocial; set => loj_razsocial = value; }
    public global::end_lojaEndereco End_id { get => end_id; set => end_id = value; }
    public global::rsp_responsavel Rsp_id { get => rsp_id; set => rsp_id = value; }
}