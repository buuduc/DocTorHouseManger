using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;
using System.IO;

namespace DocTorHouseManger
{

    public static class configMNG
    {   static configMNG()
        {

        }
        public static void Run()
        {
           
            string txt = ConnectionString;
            int cuoi = txt.IndexOf("Data Source=");
            string cout = txt.Substring(cuoi+ "Data Source=".Length);
            MessageBox.Show(cout);
            if (!System.IO.File.Exists(cout))
            {
                Checkking();
            }
            else
            {
                try
                {
                    filepatch = cout.Substring(0, cout.Length - @"\Quanlynhanvien\dsnv_db.mdb".Length)+"/";
                    var GG = new GuiChinh();
                    GG.ShowDialog();

                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                    throw;
                }
            }

        }

        public static void Checkking()
        {
           

            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
            {

                
                if (System.IO.File.Exists(fbd.SelectedPath + @"\Quanlynhanvien\dsnv_db.mdb"))
                {
                    
                    filepatch = @fbd.SelectedPath + "/";
                    ConnectionString = fbd.SelectedPath;
                    try
                    {   
                        var GG = new GuiChinh();
                        GG.ShowDialog();

                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.ToString());
                        throw;
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy cơ sở dữ liệu","thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }

        }
        private static Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        public static string ConnectionString
        {
            get
            {
                return config.ConnectionStrings.ConnectionStrings["DocTorHouseManger.Properties.Settings.dsnv_dbConnectionString"].ConnectionString;
            }
            set
            {
                //config.ConnectionStrings.ConnectionStrings.Remove("DocTorHouseManger.Properties.Settings.dsnv_dbConnectionString");
                //config.ConnectionStrings.ConnectionStrings.Add(new ConnectionStringSettings("DocTorHouseManger.Properties.Settings.dsnv_dbConnectionString", "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + @value + @"\Quanlynhanvien\dsnv_db.mdb"));
                //config.Save(ConfigurationSaveMode.Modified);
                //ConfigurationManager.RefreshSection("connectionStrings");
                ////config.AppSettings.Settings["UserId"].Value = "myUserId";
                config.ConnectionStrings.ConnectionStrings["DocTorHouseManger.Properties.Settings.dsnv_dbConnectionString"].ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + @value+ @"\Quanlynhanvien\dsnv_db.mdb";
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("connectionStrings");


            }
    }
        public static string filepatch;
    }
}
