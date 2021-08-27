using System.Threading;
using System;

namespace DBConnection
{
    public class SqlConnection : DbConnection
        
    {
        
        public SqlConnection(string connectionString)
            :base(connectionString)
        {
            this.ConnectionString = connectionString;
            DateOfOpenning = DateTime.Now;
        }
       
        public override void OpenConnection()
        {
            Console.WriteLine("Opening SQL connection");

            DateOfConnection = DateTime.Now;
            Timeout = DateOfConnection - DateOfOpenning;
            
            if(Timeout.Seconds < 5)
            {
                Console.WriteLine("SQL connection has been opened.");
                Console.WriteLine("Connection string name: {0}.", ConnectionString);
                Thread.Sleep(1500);
                Console.WriteLine("...");
                Thread.Sleep(1500);
            }
            
        }

        public override void CloseConnection()
        {
            DateOfClosing = System.DateTime.Now;
            System.Console.WriteLine("DB SQL Connection closed at: {0}\n", DateOfClosing);
            Thread.Sleep(1500);
        }

    }
}
