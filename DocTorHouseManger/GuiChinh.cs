using System;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;

namespace DocTorHouseManger
{
    public partial class GuiChinh : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public GuiChinh()
        {
            InitializeComponent();
            AddTabPage("Chi Tiết");
            xtraTabControl1.TabIndex = 3;

        }

        private bool CheckIn = false;
        static public int Position { get; set; }
        private void GuiChinh_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsnv_dbDataSet.DanhSachNhanVien' table. You can move, or remove it, as needed.
            this.danhSachNhanVienTableAdapter.Fill(this.dsnv_dbDataSet.DanhSachNhanVien);
            danhSachNhanVienBindingNavigator.BindingSource = danhSachNhanVienBindingSource;

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
            this.danhSachNhanVienTableAdapter.Fill(this.dsnv_dbDataSet.DanhSachNhanVien) ;
            this.CheckIn = false;
            
            foreach (DevExpress.XtraTab.XtraTabPage tabpage in xtraTabControl1.TabPages)
            {
                var a = tabpage.Controls[0];
                if (tabpage.Controls[0] as GridControl == null)
                {
                    CustomConTrol k = tabpage.Controls[0] as CustomConTrol;
                    k.Refresh();
                }
            }
        }

        private void DetailButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Detail_InformationForm DetailForm = new Detail_InformationForm();
            DetailForm.Position = danhSachNhanVienBindingNavigator.BindingSource.Position;
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
            DelForm.Position = danhSachNhanVienBindingNavigator.BindingSource.Position;
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
            CurrentGrid.ShowPrintPreview();
        }
        static GridControl CurrentGrid;
        private void GetView()
        {
            var a = xtraTabControl1.SelectedTabPage.Controls[0];
            CurrentGrid = a as GridControl;
            if (CurrentGrid == null)
            {
                CustomConTrol CurentUsercontrol = a as CustomConTrol;
                CurrentGrid = CurentUsercontrol.Controls[0] as GridControl;
            }
        }

       
        private void PDFbTN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            SaveFileDialog saveFileDialog1 = new SaveFileDialog() { Filter = "PDF Image|*.pdf", Title = "Lưu file pdf" };
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
            string patch = saveFileDialog1.FileName;
            CurrentGrid.ExportToPdf(patch);
            System.Diagnostics.Process.Start(patch);
            }
        }

        private void AddTabPage(string text)
        {
            //DevExpress.XtraGrid.GridControl gridctrl = new GridControl();
            //tabpage.Controls.Add(gridctrl);
            //gridctrl.Dock = DockStyle.Fill;

            //GridView gridView1 = new GridView();
            ////GridColumn MaNhanViencol = gridView1.Columns["Mã Nhân Viên"];
            ////gridView1.Columns.Add(new GridColumn() { Caption = "Mã Nhân Viên" });
            ////gridView1.Columns.Add(new GridColumn() { Caption = "Mã Nhân Viên" });
            //gridctrl.MainView = gridView1;
            //gridctrl.DataSource = danhSachNhanVienBindingSource;
            ////gridView1.Columns
            ////gridView1.Columns.ca
            //xtraTabControl1.TabPages.Add(tabpage);
            DevExpress.XtraTab.XtraTabPage tabpage = new DevExpress.XtraTab.XtraTabPage();
            tabpage.Text = text;
            CustomConTrol Table = new CustomConTrol();
            tabpage.Controls.Add(Table);
            Table.Dock= System.Windows.Forms.DockStyle.Fill;
            xtraTabControl1.TabPages.Add(tabpage);



            var a = Table.Controls[0];
            GridControl CurentControl = a as GridControl;
            danhSachNhanVienBindingNavigator.BindingSource = (BindingSource)CurentControl.DataSource;

        }

        private void xtraTabControl1_CloseButtonClick(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đóng tab này ?", "EXIT", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                xtraTabControl1.TabPages.RemoveAt(xtraTabControl1.SelectedTabPageIndex);
        }

        private void ThemBangBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (AddTableName addTableName = new AddTableName())
            {

                addTableName.ShowDialog();
                if (addTableName.enforce)
                {
                AddTabPage(addTableName.TableName);

                }
            }
        }

        private void xtraTabControl1_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            GetView();
            if (xtraTabControl1.SelectedTabPage.Controls[0] as GridControl == null)
            {
                danhSachNhanVienBindingNavigator.BindingSource = (BindingSource)CurrentGrid.DataSource;
            }
            else
            {
                danhSachNhanVienBindingNavigator.BindingSource = danhSachNhanVienBindingSource;
            }
        }

        private void DoiTen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (ChangeTableName changeTableName = new ChangeTableName())
            {
                changeTableName.TableName = xtraTabControl1.SelectedTabPage.Text;
                changeTableName.ShowDialog();
                if (changeTableName.enforce)
                {
                    xtraTabControl1.SelectedTabPage.Text = changeTableName.TableName;

                }
            }
        }
    }
}