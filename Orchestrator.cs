using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Organogram2
{

    class Program
    {
        private static List<int> parentID = new List<int>();
        private static List<int> initialRowID = new List<int>();
        private static List<int> sortedRowID = new List<int>();
        private static List<string> name = new List<string>();
        private static List<string> software = new List<string>();
        private static List<string> position = new List<string>();

        private static string arrow = " -> ";

        static void Main(string[] args)
        {

            //file pathname
            string path = "/Users/dominikstolarz/Projects/Organogram2/Organogram2/companies_data.csv";

            /* Saves relevant csv data to lists.
             * There are two lists which contain rowIDs, 
             * the difference bettwen them is that one
             * is sorted ascending and the other is as 
             * provided in file.
             */
            using (var reader = new StreamReader(path))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    initialRowID.Add(Int32.Parse(values[0]));
                    sortedRowID.Add(Int32.Parse(values[0]));
                    parentID.Add(Int32.Parse(values[1]));
                    name.Add(values[2] + " " + values[3] + ", ");
                    software.Add(values[4] + ", ");
                    position.Add(values[6]);
                }
            }

            sortedRowID.Sort();

            //DisplayAllUsers();
            DisplayUser(1);

        }

        /* This method lists all users in a hierarchical view
         * It uses reccursive method DisplayChildRecords()
         * After all child records have been displayed for user with
         * id at first position, next one is displayed with all child
         * records, and next one, till the end of list
         */
        static void DisplayAllUsers()
        {
            foreach (int id in sortedRowID)
            {
                Console.WriteLine(DisplayInfo(initialRowID.IndexOf(id)));
                DisplayChildRecords(id);
                arrow = " -> ";
            }
        }

        /* This method displays one user and all of the related records to 
         * that user, provided that user exists in csv file with given 
         * row id. Uncomment line 51 and comment line 50 to see the difference
         */
        static void DisplayUser(int id)
        {
            Console.WriteLine(DisplayInfo(initialRowID.IndexOf(id)));
            DisplayChildRecords(id);
        }

        /* This method displays all child records and 
         * it is reccursive which allows to cater for
         * n-depth level of child records
         */
        static void DisplayChildRecords(int id, bool flag = false)
        {
            var indexes = Enumerable.Range(0, parentID.Count)
               .Where(i => parentID[i] == id)
               .OrderBy(i => initialRowID[i])
               .ToList();
            if (flag && indexes.Count > 0)
            {
                flag = false;
                arrow = "    " + arrow;
            }

            foreach (var index in indexes)
            {
                Console.WriteLine(arrow + DisplayInfo(index));
                DisplayChildRecords(initialRowID[index], true);

            }
        }

        // This method simply returns string with info of a user
        static string DisplayInfo(int i)
        {
            return name[i] + software[i] + position[i];
        }

    }

}
