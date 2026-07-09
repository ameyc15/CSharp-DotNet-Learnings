using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day12_Arrays_Static_PartialClass
{
    internal class DatabaseConfig
    {
        public static string ConnectionString { get; private set; }
        public static string DatabaseName { get; private set; }
        public static int MaxConnection { get; private set; }
        public static DateTime AppStartTime { get; private set; }

        // Instance Fields 
        public string QueryName { get; set; }

        // static constructor 
        // No access modifier = always implicitly private
        // No Parameters Allowed 
        // Runs only once when class is first used
        static DatabaseConfig()
        {
            Console.WriteLine("Static DatabaseConfig : Runs Only Once");
            ConnectionString = "Server = localhost; Database=MyDb";
            DatabaseName = "CompanyDb";
            MaxConnection = 100;
            AppStartTime = DateTime.Now;
        }

        // Regular Instance Constructor
        // Runs Everytime object is created 

        public DatabaseConfig(string queryName)
        {
            QueryName = queryName;
            Console.WriteLine($"Instance Constructor Called For: {QueryName}");
        }

        public void DisplayConfig()
        {
            Console.WriteLine($"Connection : {ConnectionString}");
            Console.WriteLine($"Database : {DatabaseName}");
            Console.WriteLine($"Max Connections : {MaxConnection}");
            Console.WriteLine($"App Started At : {AppStartTime}");
            Console.WriteLine($"Query Name : {QueryName}");
        }

    }
    
}
