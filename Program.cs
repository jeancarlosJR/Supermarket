using Supermarket._Repositories;
using Supermarket.Views;
using Supermarket._Repositories;
using Supermarket.Models;
using Supermarket.Views;
using Supermarket.Properties;
using System.Configuration;
using Supermarket.Presenters;

namespace Supermarket
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
            string sqlConnectionString = Settings.Default.SqlConnection;
            IMainView view=new MainView();
            new MainPresenter(view, sqlConnectionString);
            Application.Run((Form)view);
        }
    }
}
