// Server Name: GPC

using Assignment_10._3.Data;
using Microsoft.EntityFrameworkCore;

namespace Assignment_10._3
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
            Records.carContext = new CarContext();
            Records.carContext.Database.EnsureCreated(); // Ensure database is created and seeded
            Records.carContext.CarSet.Load();
            Application.Run(new Form1());
        }
    }
}