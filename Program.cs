/// Design a personal phone /address book using Dictionary collection.
/// Write a person class to store details of person like :
/// FirstName , LastName , Mobile Phone , Work Phone and Address.

namespace Assignment_4._1._1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}