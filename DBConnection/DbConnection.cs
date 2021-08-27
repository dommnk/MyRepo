using System;

namespace DBConnection
{
    public abstract class DbConnection
    {
        public string ConnectionString { get; set; }
        public TimeSpan Timeout { get; set; }

        public DateTime DateOfOpenning;
        public DateTime DateOfConnection;
        public DateTime DateOfClosing;

        public DbConnection(string connectionString)
        {
            if(!String.IsNullOrEmpty(connectionString))
            {
                this.ConnectionString = connectionString;
                
            } 
            else
            {
                throw new ArgumentNullException("Connection string cannot be empty.");
            }
        }

        public abstract void OpenConnection();
        public abstract void CloseConnection();
    }
}
