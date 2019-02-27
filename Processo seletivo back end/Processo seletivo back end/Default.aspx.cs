using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            try
            {
                //Carregar um DropDownList com o Banco de Dados
                DataSet ds = loj_lojasDB.SelectLoja();
                ddl_lojas.DataSource = ds;
                ddl_lojas.DataTextField = "loj_nome"; // Nome da coluna do Banco de dados
                ddl_lojas.DataValueField = "loj_id"; // ID da coluna do Banco
                ddl_lojas.DataBind();
                ddl_lojas.Items.Insert(0, "Lojas");

                //Carregar um DropDownList com o Banco de Dados
                ddl_lojas2.DataSource = ds;
                ddl_lojas2.DataTextField = "loj_nome"; // Nome da coluna do Banco de dados
                ddl_lojas2.DataValueField = "loj_id"; // ID da coluna do Banco
                ddl_lojas2.DataBind();
                ddl_lojas2.Items.Insert(0, "Lojas");

               
            }
            catch
            {


            }
        }
    }

    protected void btn_salvar_Click(object sender, EventArgs e)
    {
        end_lojaEndereco end = new end_lojaEndereco();
        end.End_bairro = end_bairro.Text;
        end.End_cidade = end_cidade.Text;
        end.End_complemento = end_complemento.Text;
        end.End_estado = end_estado.SelectedItem.Text;
        end.End_numero = Convert.ToInt32(end_numero.Text);
        end.End_rua = end_rua.Text;

        rsp_responsavel rsp = new rsp_responsavel();
        rsp.Rsp_cargo = rsp_cargo.Text;
        rsp.Rsp_nome = rsp_nome.Text;
        rsp.Rsp_telefone = rsp_telefone.Text;

        loj_lojas loj = new loj_lojas();
        loj.Loj_cnpj = loj_cnpj.Text;
        loj.Loj_nome = loj_nome.Text;
        loj.Loj_razsocial = loj_razsocial.Text;
        loj.Rsp_id = rsp;
        loj.End_id = end;

        switch (end_lojaEnderecoDB.Insert(loj))
        {
            case 0:
                ClientScript.RegisterClientScriptBlock(this.GetType(), "MensagemDeAlert", "alert('Sucesso');", true);
                break;
            case -2:
                ClientScript.RegisterClientScriptBlock(this.GetType(), "MensagemDeAlert", "alert('Falhou');", true);
                break;
        }

        end_bairro.Text = "";
        end_cidade.Text = "";
        end_complemento.Text = "";
        end_estado.SelectedIndex = 0;
        end_numero.Text = "";
        end_rua.Text = "";
        rsp_cargo.Text = "";
        rsp_nome.Text = "";
        rsp_telefone.Text = "";
        loj_cnpj.Text = "";
        loj_nome.Text = "";
        loj_razsocial.Text = "";
    }
    protected void btn_rsp_Click(object sender, EventArgs e)
    {


        end_bairro.Visible = false;
        end_cidade.Visible = false;
        end_complemento.Visible = false;
        end_estado.Visible = false;
        end_numero.Visible = false;
        end_rua.Visible = false;
        loj_cnpj.Visible = false;
        loj_nome.Visible = false;
        loj_razsocial.Visible = false;
        Label1.Visible = false;
        Label2.Visible = false;
        Label3.Visible = false;
        Label4.Visible = false;
        Label8.Visible = false;
        Label9.Visible = false;
        Label10.Visible = false;
        Label11.Visible = false;
        Label12.Visible = false;
        Label13.Visible = true;
        btn_rsp.Visible = false;
        btn_loj.Visible = true;
        ddl_lojas2.Visible = true;
        salvarNovo.Visible = true;
        btn_salvar.Visible = false;
        ddl_responsavel.Visible = true;
    }

    protected void btn_loj_Click(object sender, EventArgs e)
    {

        end_bairro.Visible = true;
        end_cidade.Visible = true;
        end_complemento.Visible = true;
        end_estado.Visible = true;
        end_numero.Visible = true;
        end_rua.Visible = true;
        loj_cnpj.Visible = true;
        loj_nome.Visible = true;
        loj_razsocial.Visible = true;
        Label1.Visible = true;
        Label2.Visible = true;
        Label3.Visible = true;
        Label4.Visible = true;
        Label8.Visible = true;
        Label9.Visible = true;
        Label10.Visible = true;
        Label11.Visible = true;
        Label12.Visible = true;
        Label13.Visible = false;
        btn_rsp.Visible = true;
        btn_loj.Visible = false;
        ddl_lojas2.Visible = false;
        salvarNovo.Visible = false;
        btn_salvar.Visible = true;
        ddl_responsavel.Visible = false;
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        pdt_produto pdt = new pdt_produto();
        pdt.Pdt_descricao = pdt_descricao.Text;
        pdt.Pdt_nome = pdt_nome.Text;
        pdt.Pdt_preco = Convert.ToDouble(pdt_preco.Text);

        loj_lojas loj = new loj_lojas();
        loj.Loj_id = Convert.ToInt32(ddl_lojas.SelectedIndex);
        pdt.Loj_id = loj;

        switch (pdt_produtoDB.Insert(pdt))
        {
            case 0:
                ClientScript.RegisterClientScriptBlock(this.GetType(), "MensagemDeAlert", "alert('Sucesso');", true);
                break;
            case -2:
                ClientScript.RegisterClientScriptBlock(this.GetType(), "MensagemDeAlert", "alert('Falhou');", true);
                break;
        }


    }

    protected void salvarNovo_Click(object sender, EventArgs e)
    {
        loj_lojas loj = new loj_lojas();
        loj.Loj_id = ddl_lojas2.SelectedIndex;

        rsp_responsavel rsp = new rsp_responsavel();
        rsp.Rsp_cargo = rsp_cargo.Text;
        rsp.Rsp_nome = rsp_nome.Text;
        rsp.Rsp_telefone = rsp_telefone.Text;
        rsp.Loj_id = loj;

        switch (rsp_responsavelDB.Insert(rsp))
        {
            case 0:
                ClientScript.RegisterClientScriptBlock(this.GetType(), "MensagemDeAlert", "alert('Sucesso');", true);
                rsp_cargo.Text = "";
                rsp_nome.Text = "";
                rsp_telefone.Text = "";
                break;
            case -2:
                ClientScript.RegisterClientScriptBlock(this.GetType(), "MensagemDeAlert", "alert('Falhou');", true);
                break;
        }
    }

    protected void ddl_responsavel_SelectedIndexChanged(object sender, EventArgs e)
    {
        DataSet rsp = rsp_responsavelDB.SelectRspId(Convert.ToInt32(ddl_responsavel.SelectedItem.Value));
        rsp_telefone.Text = rsp.Tables[0].Rows[0]["rsp_telefone"].ToString();
        rsp_nome.Text = rsp.Tables[0].Rows[0]["rsp_nome"].ToString();
        rsp_cargo.Text = rsp.Tables[0].Rows[0]["rsp_cargo"].ToString();
        rsp_update.Visible = true;
    }

    protected void rsp_update_Click(object sender, EventArgs e)
    {
        rsp_responsavel rsp = new rsp_responsavel();
        rsp.Rsp_id = Convert.ToInt32(ddl_responsavel.SelectedIndex);
        rsp.Rsp_telefone = rsp_telefone.Text;
        rsp.Rsp_nome = rsp_nome.Text;
        rsp.Rsp_cargo = rsp_cargo.Text;
        rsp_update.Visible = false;

        switch (rsp_responsavelDB.UpDate(rsp))
        {
            case 0:
                ClientScript.RegisterClientScriptBlock(this.GetType(), "MensagemDeAlert", "alert('Sucesso');", true);
                rsp_cargo.Text = "";
                rsp_nome.Text = "";
                rsp_telefone.Text = "";
                //Response.Redirect("Default.aspx");
                break;
            case -2:
                ClientScript.RegisterClientScriptBlock(this.GetType(), "MensagemDeAlert", "alert('Falhou');", true);
                break;
        }


    }

    protected void ddl_lojas2_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {

            DataSet rsp = rsp_responsavelDB.SelectRsp(Convert.ToInt32(ddl_lojas2.SelectedItem.Value));
            //Carregar um DropDownList com o Banco de Dados
            ddl_responsavel.DataSource = rsp;
            ddl_responsavel.DataTextField = "rsp_nome"; // Nome da coluna do Banco de dados
            ddl_responsavel.DataValueField = "rsp_id"; // ID da coluna do Banco
            ddl_responsavel.DataBind();
            ddl_responsavel.Items.Insert(0, "Responsavel");
        }
        catch { }
    }
}
