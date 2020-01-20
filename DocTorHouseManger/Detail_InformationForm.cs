using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;

namespace DocTorHouseManger
{
    public partial class Detail_InformationForm : DevExpress.XtraEditors.XtraForm
    {
        public Detail_InformationForm()
        {
            InitializeComponent();
        }
        public int Position { get; set; }
        protected virtual bool IsFileLocked(FileInfo file)
        {
            try
            {
                using (FileStream stream = file.Open(FileMode.Open, FileAccess.Read, FileShare.None))
                {
                    stream.Close();
                }
            }
            catch (IOException)
            {
                //the file is unavailable because it is:
                //still being written to
                //or being processed by another thread
                //or does not exist (has already been processed)
                return true;
            }

            //file is not locked
            return false;
        }

        private void danhSachNhanVienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.danhSachNhanVienBindingSource.EndEdit();
            this.danhSachNhanVienTableAdapter.Update(this.dsnv_dbDataSet.DanhSachNhanVien);
            this.tableAdapterManager.UpdateAll(this.dsnv_dbDataSet);

        }

        private void Detail_InformationForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsnv_dbDataSet.DanhSachNhanVien' table. You can move, or remove it, as needed.
            this.danhSachNhanVienTableAdapter.Fill(this.dsnv_dbDataSet.DanhSachNhanVien);

        }
    }
   
}