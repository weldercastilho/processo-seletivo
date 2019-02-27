using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for pdt_produto
/// </summary>
public class pdt_produtoDB
{
    public static int Insert(pdt_produto pdt)
    {
        int retorno = 0;

        try
        {
            IDbConnection objConexao;  // Abre a conexao 
            IDbCommand objCommand;  // Cria o comando 
            string sql = "insert into pdt_produto(pdt_nome, pdt_preco, pdt_descricao, loj_id)values(?pdt_nome, ?pdt_preco, ?pdt_descricao, ?loj_id);";

            objConexao = Mapeamento.Connection();
            objCommand = Mapeamento.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapeamento.Parameter("?pdt_nome", pdt.Pdt_nome));
            objCommand.Parameters.Add(Mapeamento.Parameter("?pdt_preco", pdt.Pdt_preco));
            objCommand.Parameters.Add(Mapeamento.Parameter("?pdt_descricao", pdt.Pdt_descricao));
            objCommand.Parameters.Add(Mapeamento.Parameter("?loj_id", pdt.Loj_id.Loj_id));


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