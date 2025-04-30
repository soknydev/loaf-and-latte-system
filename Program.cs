using loaf_and_latte_system.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loaf_and_latte_system
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            testDatabaseConnection(); // Call the test function here
        }

        static void testDatabaseConnection()
        {
            try
            {
                var connection = DatabaseConnection.GetInstance();
                connection.Open(); // Try to open the connection
                Console.WriteLine("MySQL connection successful!");
                connection.Close(); // Always close it
            }
            catch (Exception ex)
            {
                Console.WriteLine("MySQL connection failed: " + ex.Message);
            }

            Console.ReadLine();
        }
    }
}
