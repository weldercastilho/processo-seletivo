using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for rsp_responsavel
/// </summary>
public class rsp_responsavelDB
{
    public static int Insert(rsp_responsavel rsp)
    {
        int retorno = 0;

        try
        {
            IDbConnection objConexao;  // Abre a conexao 
            IDbCommand objCommand;  // Cria o comando 
            string sql = "insert into rsp_responsavel(rsp_telefone, rsp_nome, rsp_cargo, loj_id)values(?rsp_telefone, ?rsp_nome, ?rsp_cargo, ?loj_id);";

            objConexao = Mapeamento.Connection();
            objCommand = Mapeamento.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapeamento.Parameter("?rsp_telefone", rsp.Rsp_telefone));
            objCommand.Parameters.Add(Mapeamento.Parameter("?rsp_nome", rsp.Rsp_nome));
            objCommand.Parameters.Add(Mapeamento.Parameter("?rsp_cargo", rsp.Rsp_cargo));
            objCommand.Parameters.Add(Mapeamento.Parameter("?loj_id", rsp.Loj_id.Loj_id));


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

    public static DataSet SelectRspId(int id)
    {
        DataSet ds = new DataSet();
        IDbConnection objConexao;
        IDbCommand objCommand;
        IDataAdapter objDataAdapter;
        string sql = "select * from rsp_responsavel where rsp_id = ?rsp_id;";
        objConexao = Mapeamento.Connection();
        objCommand = Mapeamento.Command(sql, objConexao);
        objCommand.Parameters.Add(Mapeamento.Parameter("?rsp_id", id));
        objDataAdapter = Mapeamento.Adapter(objCommand);
        objDataAdapter.Fill(ds); //dataset container de dados
        objConexao.Close();
        objConexao.Dispose();
        objCommand.Dispose();

        return ds;
    }

    public static DataSet SelectRsp(int id)
    {
        DataSet ds = new DataSet();
        IDbConnection objConexao;
        IDbCommand objCommand;
        IDataAdapter objDataAdapter;
        string sql = "select * from rsp_responsavel inner join loj_lojas using(loj_id) where loj_id = ?loj_id;";
        objConexao = Mapeamento.Connection();
        objCommand = Mapeamento.Command(sql, objConexao);
        objCommand.Parameters.Add(Mapeamento.Parameter("?loj_id", id));
        objDataAdapter = Mapeamento.Adapter(objCommand);
        objDataAdapter.Fill(ds); //dataset container de dados
        objConexao.Close();
        objConexao.Dispose();
        objCommand.Dispose();

        return ds;
    }

    public static int UpDate(rsp_responsavel rsp)
    {
        int retorno = 0;

        try
        {
            IDbConnection objConexao;  // Abre a conexao 
            IDbCommand objCommand;  // Cria o comando 
            string sql = "update rsp_responsavel set rsp_telefone = ?rsp_telefone, rsp_nome = ?rsp_nome, rsp_cargo = ?rsp_cargo where rsp_id = ?rsp_id;";

            objConexao = Mapeamento.Connection();
            objCommand = Mapeamento.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapeamento.Parameter("?rsp_telefone", rsp.Rsp_telefone));
            objCommand.Parameters.Add(Mapeamento.Parameter("?rsp_nome", rsp.Rsp_nome));
            objCommand.Parameters.Add(Mapeamento.Parameter("?rsp_cargo", rsp.Rsp_cargo));
            objCommand.Parameters.Add(Mapeamento.Parameter("?rsp_id", rsp.Rsp_id));


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