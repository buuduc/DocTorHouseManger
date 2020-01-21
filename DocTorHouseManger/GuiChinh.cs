using System;
using System.Linq;

namespace DocTorHouseManger
{
    public partial class GuiChinh : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public GuiChinh()
        {
            InitializeComponent();

        }



        private void GuiChinh_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsnv_dbDataSet.DanhSachNhanVien' table. You can move, or remove it, as needed.
            this.danhSachNhanVienTableAdapter.Fill(this.dsnv_dbDataSet.DanhSachNhanVien);


        }

        private void danhSachNhanVienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.danhSachNhanVienBindingSource.EndEdit();
            this.danhSachNhanVienTableAdapter.Update(this.dsnv_dbDataSet.DanhSachNhanVien);
            this.tableAdapterManager.UpdateAll(this.dsnv_dbDataSet);

        }

        private void RefreshButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.danhSachNhanVienTableAdapter.Fill(this.dsnv_dbDataSet.DanhSachNhanVien);
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
    }
}