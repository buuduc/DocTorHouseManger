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
    public partial class Dele_InformationForm : DevExpress.XtraEditors.XtraForm
    {
        public Dele_InformationForm()
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
            string Tex;
            if (this.CheckIn)
            { Tex = "BẠN VỪA SỬ DỤNG THAO TÁC XOÁ,KHI LƯU BẠN SẼ KHÔNG LẤY LẠI ĐƯỢC DỮ LIỆU \n bạn có chắc muốn lưu thay đổi không ?"; }
            else
            { Tex = " Bạn có chắc muốn lưu thay đổi không ?"; }
            DialogResult dr = MessageBox.Show(Tex,
                          "Cảnh báo !", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:
                    {
                        if (/*danhSachNhanVienBindingSource.Find("MaNhanVien", "")*/maNhanVienLabel2.Text == "")
                            MessageBox.Show("Mã Nhân Viên không được phép để trống");
                        else
                        {
                            try
                            {
                                danhSachNhanVienTableAdapter.DeleteByMaNhanVien(maNhanVienLabel2.Text);
                                SavePicture();
                                this.Validate();
                                this.danhSachNhanVienBindingSource.EndEdit();
                                this.tableAdapterManager.UpdateAll(this.dsnv_dbDataSet);
                                truyenData();
                                MessageBox.Show("Lưu Thành Công !");
                                this.CheckIn = false;
                                this.Close();
                            }
                            catch (System.Data.ConstraintException)
                            {
                                MessageBox.Show("Mã Nhân Viên bị trùng. không thể lưu");
                                break;
                            }
                            finally
                            {
                                MessageBox.Show("Lỗi Khộng Xác Định !");
                            }
                        }

                    }
                    break;
                case DialogResult.No:
                    break;
            }


        }

        private void Dele_InformationForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsnv_dbDataSet.DanhSachNhanVien' table. You can move, or remove it, as needed.
            this.danhSachNhanVienTableAdapter.Fill(this.dsnv_dbDataSet.DanhSachNhanVien);

            danhSachNhanVienBindingSource.Position = this.Position;
            this.CheckIn = true;
        }
        static string FilePatch = configMNG.filepatch;
        private void SavePicture()
        {
            String maso = maNhanVienLabel2.Text;
            string diachi = FilePatch+"Hinhanh/" + maso + ".png";
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
            hinhAnhLinkLabel.Text = "Hinhanh/" + maso + ".png";
        }




        private void hinhAnhLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(hinhAnhLinkLabel.Text);
        }

        private void hinhAnhLinkLabel_TextChanged(object sender, EventArgs e)
        {
            if (hinhAnhLinkLabel.Text != "" & System.IO.File.Exists(FilePatch + hinhAnhLinkLabel.Text) == true)
            {
                pictureEdit1.Image = Image.FromFile(FilePatch + hinhAnhLinkLabel.Text);

            }
            else
            {
                pictureEdit1.Image = Image.FromFile(FilePatch + "Hinhanh/CorePicture/Admin.png");
            }
            pictureEdit1.Refresh();
        }




        private void pictureEdit1_DoubleClick(object sender, EventArgs e)
        {
            System.IO.File.Delete(FilePatch+"Hinhanh/CorePicture/TempPicture.png");
            pictureEdit1.Image.Save(FilePatch+"Hinhanh/CorePicture/TempPicture.png");
            System.Diagnostics.Process.Start(FilePatch+"Hinhanh/CorePicture/TempPicture.png");

        }
        private bool CheckIn = false;
        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            this.CheckIn = true;

        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string Tex;
            if (this.CheckIn)
            { Tex = "KHI LƯU BẠN SẼ KHÔNG THỂ LẤY LẠI ĐƯỢC DỮ LIỆU \n bạn có chắc muốn xoá nhân viên này ?"; }
            else
            { Tex = " Bạn có chắc muốn lưu thay đổi không ?"; }
            DialogResult dr = MessageBox.Show(Tex,
                          "Cảnh báo !", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:
                    {
                        if (/*danhSachNhanVienBindingSource.Find("MaNhanVien", "")*/maNhanVienLabel2.Text == "")
                            MessageBox.Show("Mã Nhân Viên không được phép để trống");
                        else
                        {
                            try
                            {
                                danhSachNhanVienTableAdapter.DeleteByMaNhanVien(maNhanVienLabel2.Text);
                                SavePicture();
                                this.Validate();
                                this.danhSachNhanVienBindingSource.EndEdit();
                                this.tableAdapterManager.UpdateAll(this.dsnv_dbDataSet);
                                truyenData();
                                MessageBox.Show("Lưu Thành Công !");
                                this.CheckIn = false;
                                this.Close();
                            }
                            catch (System.Data.ConstraintException)
                            {
                                MessageBox.Show("Mã Nhân Viên bị trùng. không thể lưu");
                                break;
                            }
                        }

                    }
                    break;
                case DialogResult.No:
                    break;
            }
        }


    }
}