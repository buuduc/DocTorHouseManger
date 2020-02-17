using System;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraGrid;

namespace DocTorHouseManger
{
    public partial class GuiChinh : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public GuiChinh()
        {
            InitializeComponent();
            AddTabPage();
        }

        private bool CheckIn = false;
        static public int Position { get; set; }
        private void GuiChinh_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsnv_dbDataSet.DanhSachNhanVien' table. You can move, or remove it, as needed.
            this.danhSachNhanVienTableAdapter.Fill(this.dsnv_dbDataSet.DanhSachNhanVien);


        }

        private void danhSachNhanVienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (CheckIn)
            {
                DialogResult dr = MessageBox.Show("BẠN VỪA SỬ DỤNG THAO TÁC XOÁ,KHI LƯU BẠN SẼ KHÔNG LẤY LẠI ĐƯỢC DỮ LIỆU \n bạn có chắc muốn lưu thay đổi không ?", "Cảnh báo !", MessageBoxButtons.YesNo);
                switch (dr)
                {
                    case DialogResult.No:
                        return;
                }
            }
            this.Validate();
            this.danhSachNhanVienBindingSource.EndEdit();
            this.danhSachNhanVienTableAdapter.Update(this.dsnv_dbDataSet.DanhSachNhanVien);
            this.tableAdapterManager.UpdateAll(this.dsnv_dbDataSet);
            this.CheckIn = false;
            MessageBox.Show("Lưu Thành CÔng !");
        }

        private void RefreshButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.danhSachNhanVienTableAdapter.Fill(this.dsnv_dbDataSet.DanhSachNhanVien);
            this.CheckIn = false;
        }

        private void DetailButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Detail_InformationForm DetailForm = new Detail_InformationForm();
            DetailForm.Position = danhSachNhanVienBindingSource.Position;
            DetailForm.truyenData = new Detail_InformationForm.Truyenchocha(UpdateData);
            DetailForm.ShowDialog();
            danhSachNhanVienBindingSource.Position = DetailForm.Position;
            DetailForm.Close();
            
        }
        private void UpdateData()
        {
            this.danhSachNhanVienTableAdapter.Fill(this.dsnv_dbDataSet.DanhSachNhanVien);
        }

        private void AddPersonButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Add_InformationForm AddForm = new Add_InformationForm();
            //AddForm.Position = danhSachNhanVienBindingSource.Position;
            AddForm.truyenData = new Add_InformationForm.Truyenchocha(UpdateData);
            AddForm.ShowDialog();
            danhSachNhanVienBindingSource.Position = AddForm.Position;
            AddForm.Close();
        }

        private void DelPersonButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Dele_InformationForm DelForm = new Dele_InformationForm();
            //DelForm.Position = danhSachNhanVienBindingSource.Position;
            DelForm.Position = danhSachNhanVienBindingSource.Position;
            DelForm.truyenData = new Dele_InformationForm.Truyenchocha(UpdateData);
            DelForm.ShowDialog();
            DelForm.Close();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            this.CheckIn = true;
        }

        private void ExportEcelBTN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GetView();
            SaveFileDialog saveFileDialog1 = new SaveFileDialog(){Filter = "XLSX Image|*.xlsx",Title = "Lưu file Excel"};
            if (saveFileDialog1.ShowDialog()==DialogResult.OK)
            {
                string patch = saveFileDialog1.FileName;
                CurrentGrid.ExportToXlsx(patch);
                System.Diagnostics.Process.Start(patch);
            }
        }
        //private DevExpress.XtraGrid.GridControl currentGrid = danhSachNhanVienGridControl
        private void PrintBTN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            //var a = xtraTabControl1.SelectedTabPage.Controls[0];
            //CurrentGrid = a as GridControl;
            //CurrentGrid.ExportToXlsx("test.xlsx");
            //System.Diagnostics.Process.Start("test.xlsx");
        }
        static GridControl CurrentGrid;
        private void GetView()
        {
            var a = xtraTabControl1.SelectedTabPage.Controls[0];
            CurrentGrid = a as GridControl;
        }

       
        private void PDFbTN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GetView();
            SaveFileDialog saveFileDialog1 = new SaveFileDialog() { Filter = "PDF Image|*.pdf", Title = "Lưu file pdf" };
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
            string patch = saveFileDialog1.FileName;
            CurrentGrid.ExportToPdf(patch);
            System.Diagnostics.Process.Start(patch);
            }
        }

        private void AddTabPage()
        {
            DevExpress.XtraTab.XtraTabPage tabpage = new DevExpress.XtraTab.XtraTabPage();
            DevExpress.XtraGrid.GridControl tabctrl = new GridControl();
            tabpage.Controls.Add(tabctrl);
            tabctrl.Dock = DockStyle.Fill;
            tabctrl.DataSource = danhSachNhanVienBindingSource;
            xtraTabControl1.TabPages.Add(tabpage);

        }
    }
}