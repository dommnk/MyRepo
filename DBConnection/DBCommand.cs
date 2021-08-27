using System;
using System.Collections.Generic;

namespace DBConnection
{
    public class DBCommand 
    {
        public DbConnection DBConnection;
        private string Instruction;
        public DBCommand(DbConnection DBConnection, string instruction)
        {
            if(!string.IsNullOrEmpty(DBConnection.ConnectionString))
            {
                this.DBConnection = DBConnection;
            }
            else
            {
                throw new ArgumentNullException("Connection string cannot be empty");
            }

            if(!string.IsNullOrEmpty(instruction))
            {
                this.Instruction = instruction;
            }
            else
            {
                throw new ArgumentNullException("Instruction cannot be empty.");
            }

        }

        public void Execute()
        {
                DBConnection.OpenConnection();
                Console.WriteLine("Command: {0}", Instruction);
                DBConnection.CloseConnection();
        }



    }
}
