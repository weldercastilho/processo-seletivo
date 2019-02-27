<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label12" runat="server" Text="Cadastro geral"></asp:Label></br></br></br>
            
            <asp:Label ID="Label13" runat="server" Visible="false" Text="Cadastro de responsavel"></asp:Label></br></br></br>

            <asp:Label ID="Label11" runat="server" Text="Nome"></asp:Label>
            <asp:TextBox ID="loj_nome" runat="server" ></asp:TextBox>
            <asp:Label ID="Label8" runat="server" Text="CNPJ"></asp:Label>
            <asp:TextBox ID="loj_cnpj" runat="server" ></asp:TextBox>
            <asp:Label ID="Label9" runat="server" Text="Razão Social"></asp:Label>
            <asp:TextBox ID="loj_razsocial" runat="server" ></asp:TextBox>
            <asp:Label ID="Label10" runat="server" Text="Cidade"></asp:Label>
            <asp:TextBox ID="end_cidade" runat="server" ></asp:TextBox>
            <asp:DropDownList ID="end_estado" runat="server">
                <asp:ListItem>Estado</asp:ListItem>
                <asp:ListItem>AC</asp:ListItem>
                <asp:ListItem>AL</asp:ListItem>
                <asp:ListItem>AP</asp:ListItem>
                <asp:ListItem>AM</asp:ListItem>
                <asp:ListItem>BA</asp:ListItem>
                <asp:ListItem>CE</asp:ListItem>
                <asp:ListItem>DF</asp:ListItem>
                <asp:ListItem>ES</asp:ListItem>
                <asp:ListItem>GO</asp:ListItem>
                <asp:ListItem>MA</asp:ListItem>
                <asp:ListItem>MT</asp:ListItem>
                <asp:ListItem>MS</asp:ListItem>
                <asp:ListItem>MG</asp:ListItem>
                <asp:ListItem>PA</asp:ListItem>
                <asp:ListItem>PR</asp:ListItem>
                <asp:ListItem>PB</asp:ListItem>
                <asp:ListItem>PI</asp:ListItem>
                <asp:ListItem>PE</asp:ListItem>
                <asp:ListItem>RJ</asp:ListItem>
                <asp:ListItem>RN</asp:ListItem>
                <asp:ListItem>RS</asp:ListItem>
                <asp:ListItem>RO</asp:ListItem>
                <asp:ListItem>RR</asp:ListItem>
                <asp:ListItem>SC</asp:ListItem>
                <asp:ListItem>SP</asp:ListItem>
                <asp:ListItem>SE</asp:ListItem>
                <asp:ListItem>TO</asp:ListItem>
            </asp:DropDownList>
            <asp:Label ID="Label1" runat="server" Text="Bairro"></asp:Label>
            <asp:TextBox ID="end_bairro" runat="server" ></asp:TextBox>
            <asp:Label ID="Label2" runat="server" Text="Rua"></asp:Label>
            <asp:TextBox ID="end_rua" runat="server" ></asp:TextBox>
            <asp:Label ID="Label3" runat="server" Text="Numero"></asp:Label>
            <asp:TextBox ID="end_numero" runat="server" ></asp:TextBox>
            <asp:Label ID="Label4" runat="server" Text="Complemento"></asp:Label>
            <asp:TextBox ID="end_complemento" runat="server" ></asp:TextBox>
            
            <asp:DropDownList ID="ddl_lojas2" AutoPostBack="true" OnSelectedIndexChanged="ddl_lojas2_SelectedIndexChanged" Visible="false" runat="server"></asp:DropDownList>
            <asp:DropDownList ID="ddl_responsavel" AutoPostBack="true" Visible="false" OnSelectedIndexChanged="ddl_responsavel_SelectedIndexChanged" runat="server"></asp:DropDownList>
            <asp:Label ID="Label5" runat="server" Text="Telefone"></asp:Label>
            <asp:TextBox ID="rsp_telefone" runat="server" ></asp:TextBox>
            <asp:Label ID="Label6" runat="server" Text="Responsavel"></asp:Label>
            <asp:TextBox ID="rsp_nome" runat="server" ></asp:TextBox>
            <asp:Label ID="Label7" runat="server" Text="Cargo"></asp:Label>
            <asp:TextBox ID="rsp_cargo" runat="server" ></asp:TextBox>
            <asp:Button ID="btn_salvar" runat="server" Text="Salvar" OnClick="btn_salvar_Click"/>
            
            <asp:Button ID="btn_rsp" runat="server" Text="Cadastro de responsavel" OnClick="btn_rsp_Click"/>
            
            <asp:Button ID="btn_loj" runat="server" Visible="false" Text="Cadastro de geral" OnClick="btn_loj_Click"/>
            
            <asp:Button ID="salvarNovo" runat="server" Visible="false" Text="salver novo responsavel" OnClick="salvarNovo_Click"/>

            <asp:Button ID="rsp_update" runat="server" Visible="false" Text="atualizar responsavel" OnClick="rsp_update_Click"/>

            </br></br></br></br></br>

        </div>

        <div>
            
            <asp:Label ID="Label14" runat="server" Text="Cadastro de produto"></asp:Label>
            </br></br>
            <asp:DropDownList ID="ddl_lojas" runat="server"></asp:DropDownList>
            <asp:Label ID="Produto" runat="server" Text="Produto"></asp:Label>
            <asp:TextBox ID="pdt_nome" runat="server"></asp:TextBox>
            <asp:Label ID="Preço" runat="server" Text="Preço"></asp:Label>
            <asp:TextBox ID="pdt_preco" runat="server"></asp:TextBox>
            <asp:Label ID="Descrição" runat="server" Text="Descrição"></asp:Label>
            <asp:TextBox ID="pdt_descricao" runat="server"></asp:TextBox>

            <asp:Button ID="Button1" runat="server" Text="Cadastro de produto" OnClick="Button1_Click"/>
        </div>

    </form>
</body>
</html>
