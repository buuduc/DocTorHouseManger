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
        public delegate void Truyenchocha();
        public Truyenchocha truyenData;
        private void danhSachNhanVienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (/*danhSachNhanVienBindingSource.Find("MaNhanVien", "")*/ maNhanVienTextEdit.Text == "")
                MessageBox.Show("Mã Nhân Viên không được phép để trống");
            else
            {
                SavePicture();
                this.Validate();
                this.danhSachNhanVienBindingSource.EndEdit();
                this.danhSachNhanVienTableAdapter.Update(this.dsnv_dbDataSet.DanhSachNhanVien);
                this.tableAdapterManager.UpdateAll(this.dsnv_dbDataSet);
                truyenData();
            }
        }

        private void SavePicture()
        {
            String maso = maNhanVienTextEdit.Text;
            string diachi = "E:/Database/Hinhanh/" + maso + ".png";
            bool checkin = IsFileLocked(new FileInfo(diachi));
            if (System.IO.File.Exists(diachi) == true & checkin == false)
            {
                System.IO.File.Delete(diachi);
                pictureEdit1.Image.Save(diachi);

            }
            else if (System.IO.File.Exists(diachi) == true & checkin == true)
            { }
            else
            {
                pictureEdit1.Image.Save(diachi);
            }
            hinhAnhLinkLabel.Text = diachi;
        }
        private void Detail_InformationForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsnv_dbDataSet.DanhSachNhanVien' table. You can move, or remove it, as needed.
            this.danhSachNhanVienTableAdapter.Fill(this.dsnv_dbDataSet.DanhSachNhanVien);
            danhSachNhanVienBindingSource.Position = this.Position;
        }




        private void hinhAnhLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(hinhAnhLinkLabel.Text);
        }

        private void hinhAnhLinkLabel_TextChanged(object sender, EventArgs e)
        {
            if (hinhAnhLinkLabel.Text != "" & System.IO.File.Exists(hinhAnhLinkLabel.Text) == true)
            {
                pictureEdit1.Image = Image.FromFile(hinhAnhLinkLabel.Text);

            }
            else
            {
                pictureEdit1.Image = Image.FromFile("E:/Database/Hinhanh/CorePicture/Admin.png");
            }
            pictureEdit1.Refresh();
        }



        private void simpleButton1_Click(object sender, EventArgs e)
        {
            pictureEdit1.LoadImage();
        }

        private void pictureEdit1_DoubleClick(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(hinhAnhLinkLabel.Text);
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn muốn xoá nhân viên này ? \n Bạn không thể phục hồi nếu đã xoá !",
                         "Cảnh báo !", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:
                    {
                        //danhsachnhanvienTableAdapter.DeleteQuery(masoTextEdit.Text);
                        truyenData();
                        MessageBox.Show("Xoá thành công");
                        this.Close();
                    }
                    break;
                case DialogResult.No:
                    break;
            }
        }

    }
}