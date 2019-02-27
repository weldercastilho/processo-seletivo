using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for loj_lojasDB
/// </summary>
public class loj_lojasDB
{
    public static DataSet SelectLoja()
    {
        DataSet ds = new DataSet();
        IDbConnection objConexao;
        IDbCommand objCommand;
        IDataAdapter objDataAdapter;
        string sql = "select loj_id, loj_nome from loj_lojas;";
        objConexao = Mapeamento.Connection();
        objCommand = Mapeamento.Command(sql, objConexao);
        objDataAdapter = Mapeamento.Adapter(objCommand);
        objDataAdapter.Fill(ds); //dataset container de dados
        objConexao.Close();
        objConexao.Dispose();
        objCommand.Dispose();

        return ds;
    }
}