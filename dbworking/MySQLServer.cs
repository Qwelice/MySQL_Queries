using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SQLWorker.dbworking
{
    abstract class MySQLServer
    {
        protected SQLData data;
        protected MySqlConnection connection;
        protected String UrlData
        {
            get => $"server={data.Host};port={data.Port};" +
                $"user={data.Username};password={data.Password}";
        }
        public abstract void resetSQLData(SQLData data);
        public abstract bool Execute(String sql);
        public abstract String ExecuteQuery(String sql);
    }
}
