using System.Collections.Generic;

namespace DBConnection
{
    class Program
    {
        static void Main(string[] args)
        {
            var Commands = new List<DBCommand>();
            Commands.Add(new DBCommand(new SqlConnection("SQLChannel"), "SELECT * FROM SOMEWHERE"));
            Commands.Add(new DBCommand(new OracleConnection("OracleChannel"), "SELECT SOMETHING FROM DB"));

            foreach(DBCommand DataBase in Commands)
            {
                DataBase.Execute();
            }
        }
    }
}
