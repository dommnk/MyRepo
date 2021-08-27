using System.Threading;
using System;

namespace DBConnection
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString)
            :base(connectionString)
        {
            ConnectionString = connectionString;
            DateOfOpenning = DateTime.Now;
        }

        public override void OpenConnection()
        {
            Console.WriteLine("Opening Oracle connection");
            DateOfConnection = DateTime.Now;
            Timeout = DateOfConnection - DateOfOpenning;

            if (Timeout.Seconds < 5)
            {
                Console.WriteLine("Oracle connection has been opened.");
                Console.WriteLine("Connection string name: {0}.", ConnectionString);
                Thread.Sleep(1500);
                Console.WriteLine("...");
                Thread.Sleep(1500);
            }

        }

        public override void CloseConnection()
        {
            DateOfClosing = DateTime.Now;
            Console.WriteLine("DB Oracle Connection closed at: {0}\n", DateOfClosing);
        }
    }
}
