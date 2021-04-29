using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLWorker.dbworking;

namespace SQLWorker
{
    class Program
    {
        static void Main(string[] args)
        {
            MyServer server = new MyServer(new SQLData());
            Console.WriteLine(server.ExecuteQuery("SHOW DATABASES"));
            server.Execute("CREATE DATABASE IF NOT EXISTS`mysweetdb`");
            Console.WriteLine(server.ExecuteQuery("SHOW DATABASES"));
            server.Execute("DROP DATABASE `mysweetdb`");
            Console.WriteLine(server.ExecuteQuery("SHOW DATABASES"));
            Console.WriteLine(server.ExecuteQuery("SELECT NOW()"));
            Console.ReadKey();
        }
    }
}
