using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for end_lojaEnderecoDB
/// </summary>
public class end_lojaEnderecoDB
{
    public static int Insert(loj_lojas loja)
    {
        int retorno = 0;

        try
        {
            IDbConnection objConexao;  // Abre a conexao 
            IDbCommand objCommand;  // Cria o comando 
            string sql = "call cad_cadastro (?vloj_nome, ?vloj_cnpj, ?vloj_razsocial, ?vend_cidade, ?vend_estado, ?vend_bairro, ?vend_rua, ?vend_numero, ?vend_complemento, ?vloj_id, ?vrsp_telefone, ?vrsp_nome, ?vrsp_cargo)";

            objConexao = Mapeamento.Connection();
            objCommand = Mapeamento.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapeamento.Parameter("?vloj_nome", loja.Loj_nome));
            objCommand.Parameters.Add(Mapeamento.Parameter("?vloj_cnpj", loja.Loj_cnpj));
            objCommand.Parameters.Add(Mapeamento.Parameter("?vloj_razsocial", loja.Loj_razsocial));
            objCommand.Parameters.Add(Mapeamento.Parameter("?vend_cidade", loja.End_id.End_cidade));
            objCommand.Parameters.Add(Mapeamento.Parameter("?vend_estado",loja.End_id.End_estado));
            objCommand.Parameters.Add(Mapeamento.Parameter("?vend_bairro", loja.End_id.End_bairro));  
            objCommand.Parameters.Add(Mapeamento.Parameter("?vend_rua", loja.End_id.End_rua));  
            objCommand.Parameters.Add(Mapeamento.Parameter("?vend_numero", loja.End_id.End_numero));   
            objCommand.Parameters.Add(Mapeamento.Parameter("?vend_complemento", loja.End_id.End_complemento));   
            objCommand.Parameters.Add(Mapeamento.Parameter("?vloj_id", loja.Loj_id));
            objCommand.Parameters.Add(Mapeamento.Parameter("?vrsp_telefone", loja.Rsp_id.Rsp_telefone));  
            objCommand.Parameters.Add(Mapeamento.Parameter("?vrsp_nome", loja.Rsp_id.Rsp_nome));    
            objCommand.Parameters.Add(Mapeamento.Parameter("?vrsp_cargo", loja.Rsp_id.Rsp_cargo));  


            objCommand.ExecuteNonQuery();   
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            retorno = -2;
        }
        return retorno;
    }
}