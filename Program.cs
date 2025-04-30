using loaf_and_latte_system.Config;
using System;
using System.Windows.Forms;
using loaf_and_latte_system.UI;

namespace loaf_and_latte_system
{
    static class Program
    {

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //testDatabaseConnection(); // Call the test function here
            Application.Run(new LoginForm()); // Start the application with the LoginForm
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
