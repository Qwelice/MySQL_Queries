using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLWorker.dbworking
{
    class SQLData
    {
        private String host;
        private int port;
        private String username;
        private String password;

        public String Host
        {
            get => host;
        }
        public int Port { 
            get => port; 
        }
        public String Username
        {
            get => username;
        }
        public String Password
        {
            get => password;
        }
        public SQLData()
        {
            host = "localhost";
            port = 3306;
            username = "root";
            password = "root";
        }

        public SQLData(String host, int port)
        {
            this.host = host;
            this.port = port;
            username = "root";
            password = "root";
        }

        public SQLData(String username, String password)
        {
            host = "localhost";
            port = 3306;
            this.username = username;
            this.password = password;
        }

        public SQLData(String host, int port, String username, String password)
        {
            this.host = host;
            this.port = port;
            this.username = username;
            this.password = password;
        }
    }
}
