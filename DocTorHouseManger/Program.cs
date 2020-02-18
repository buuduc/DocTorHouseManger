using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace DocTorHouseManger
{
   
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Configuration config;
            //config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            //var a = ConfigurationManager.ConnectionStrings[1];
            //var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");
            //string a= config.ConnectionStrings.ConnectionStrings["DocTorHouseManger.Properties.Settings.dsnv_dbConnectionString"].ConnectionString;
            //config.ConnectionStrings.ConnectionStrings["DocTorHouseManger.Properties.Settings.dsnv_dbConnectionString1"].ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + @"E:\Database\Quanlynhanvien\dsnv_db.mdb";
            //config.Save(ConfigurationSaveMode.Modified, true);
            //ConfigurationManager.RefreshSection("connectionStrings");

            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new GuiChinh());
            configMNG.Run();


        }
        

        
    }
}
