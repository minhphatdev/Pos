using Config;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connect
{
    public class RegionBAL
    {
        DataProvider db;
        public RegionBAL()
        {
            db = new DataProvider();           
        }
        public DataSet getAllItem()
        {
            return db.ExecuteQueryDataSet("select * from viewItem", CommandType.Text,null);
        }

        public DataSet getCategories()
        {
            return db.ExecuteQueryDataSet("select * from viewCategories", CommandType.Text, null);
        }

        public DataSet getItemByType(string id)
        {
            return db.ExecuteQueryDataSet("SELECT * FROM getItemByType(@id)", CommandType.Text, new SqlParameter("@id", id));
        }

    }
}
