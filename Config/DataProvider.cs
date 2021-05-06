using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Config
{
    public class DataProvider
    {
        SqlConnection cnn;
        SqlCommand cmd;
        SqlDataAdapter adp;

       
        string strConnect = @"Data Source=DESKTOP-GE4O00P\SQLEXPRESS;Initial Catalog=QuanLyQuanCafe;Integrated Security=True";

        public DataSet MyExecuteNonQuery(string v, CommandType storedProcedure)
        {
            throw new NotImplementedException();
        }

        public DataProvider()
        {
            cnn = new SqlConnection(strConnect);
            cmd = cnn.CreateCommand();
        }
        // Select query
        public DataSet ExecuteQueryDataSet(
            string strSQL, CommandType ct, params SqlParameter[] param)
        {
            cmd.CommandText = strSQL;
            cmd.CommandType = ct;
            cmd.Parameters.Clear();
            if (param != null)
            {
                foreach (SqlParameter p in param)
                    cmd.Parameters.Add(p);
            }
            adp = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();
            adp.Fill(ds);
            return ds;
        }

        public string ExecuteQueryXML(string strSQL, CommandType ct, params SqlParameter[] p)
        {
            cmd.CommandText = strSQL;
            cmd.CommandType = ct;
            adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            return ds.GetXml();
        }
        // action query
        public bool MyExecuteNonQuery(string strSQL, CommandType ct, ref string error,
            params SqlParameter[] param)
        {
            bool f = false;
            cnn.Open();
            cmd.Parameters.Clear();
            cmd.CommandText = strSQL;
            cmd.CommandType = ct;
            foreach (SqlParameter p in param)
                cmd.Parameters.Add(p);
            try
            {
                cmd.ExecuteNonQuery();
                f = true;
            }
            catch (SqlException ex)
            {
                error = ex.Message;
            }
            finally
            {
                cnn.Close();
            }
            return f;
        }
    }
}
