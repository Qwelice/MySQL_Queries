using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLWorker.dbworking
{
    class MyServer : MySQLServer
    {
        public MyServer(SQLData data)
        {
            this.data = data;
            connection = new MySqlConnection(UrlData);
        }

        public override void resetSQLData(SQLData data)
        {
            this.data = data;
        }

        public override bool Execute(string sql)
        {
            var command = new MySqlCommand(sql, connection);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                return true;
            }catch(Exception ex)
            {
                Console.WriteLine($"Ошбика в формировании запроса\n'{sql}'\n" +
                    $"{ex.Message}");
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        public override String ExecuteQuery(string sql)
        {
            var command = new MySqlCommand(sql, connection);
            try
            {
                connection.Open();
                var resultSet = command.ExecuteReader();
                var result = new StringBuilder();
                while (resultSet.Read())
                {
                    for(int i = 0; i < resultSet.FieldCount; i++)
                    {
                        if(i == resultSet.FieldCount - 1)
                        {
                            result.Append(resultSet[i].ToString());
                            continue;
                        }
                        result.Append(resultSet[i] + " ");
                    }
                    result.Append('\n');
                }
                return result.ToString();
            }catch(Exception ex)
            {
                Console.WriteLine($"Ошбика в формировании запроса\n'{sql}'\n" +
                    $"{ex.Message}");
                return "";
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
