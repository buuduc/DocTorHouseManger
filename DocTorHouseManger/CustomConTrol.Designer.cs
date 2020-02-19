namespace DocTorHouseManger
{
    partial class CustomConTrol
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomConTrol));
            this.dsnv_dbDataSet = new DocTorHouseManger.dsnv_dbDataSet();
            this.danhSachNhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.danhSachNhanVienTableAdapter = new DocTorHouseManger.dsnv_dbDataSetTableAdapters.DanhSachNhanVienTableAdapter();
            this.tableAdapterManager = new DocTorHouseManger.dsnv_dbDataSetTableAdapters.TableAdapterManager();
            this.danhSachNhanVienBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.danhSachNhanVienBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.danhSachNhanVienGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaNhanVien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHoTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgaySinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNoiSinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGioiTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDanToc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTonGiao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colThuongTru = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTamTru = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSDT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHonNhan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCMND = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayCapCMND = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNoiCapCMND = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTK_NganHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenNganHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChiNhanhNganHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTrinhDoDaoTao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNoiDaoTao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChuyenNganh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colViTriCongViec = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDonViCongTac = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayThuViec = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayChinhThuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLoaiHopDong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTrangThai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGhichu = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dsnv_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhSachNhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhSachNhanVienBindingNavigator)).BeginInit();
            this.danhSachNhanVienBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.danhSachNhanVienGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dsnv_dbDataSet
            // 
            this.dsnv_dbDataSet.DataSetName = "dsnv_dbDataSet";
            this.dsnv_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // danhSachNhanVienBindingSource
            // 
            this.danhSachNhanVienBindingSource.DataMember = "DanhSachNhanVien";
            this.danhSachNhanVienBindingSource.DataSource = this.dsnv_dbDataSet;
            // 
            // danhSachNhanVienTableAdapter
            // 
            this.danhSachNhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DanhSachNhanVienTableAdapter = this.danhSachNhanVienTableAdapter;
            this.tableAdapterManager.HinhanhTableAdapter = null;
            this.tableAdapterManager.ThongtincongviecTableAdapter = null;
            this.tableAdapterManager.ThongtinnhanvienTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DocTorHouseManger.dsnv_dbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // danhSachNhanVienBindingNavigator
            // 
            this.danhSachNhanVienBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.danhSachNhanVienBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.danhSachNhanVienBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.danhSachNhanVienBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.danhSachNhanVienBindingNavigatorSaveItem});
            this.danhSachNhanVienBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.danhSachNhanVienBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.danhSachNhanVienBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.danhSachNhanVienBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.danhSachNhanVienBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.danhSachNhanVienBindingNavigator.Name = "danhSachNhanVienBindingNavigator";
            this.danhSachNhanVienBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.danhSachNhanVienBindingNavigator.Size = new System.Drawing.Size(545, 25);
            this.danhSachNhanVienBindingNavigator.TabIndex = 0;
            this.danhSachNhanVienBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // danhSachNhanVienBindingNavigatorSaveItem
            // 
            this.danhSachNhanVienBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.danhSachNhanVienBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("danhSachNhanVienBindingNavigatorSaveItem.Image")));
            this.danhSachNhanVienBindingNavigatorSaveItem.Name = "danhSachNhanVienBindingNavigatorSaveItem";
            this.danhSachNhanVienBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.danhSachNhanVienBindingNavigatorSaveItem.Text = "Save Data";
            this.danhSachNhanVienBindingNavigatorSaveItem.Click += new System.EventHandler(this.danhSachNhanVienBindingNavigatorSaveItem_Click);
            // 
            // danhSachNhanVienGridControl
            // 
            this.danhSachNhanVienGridControl.DataSource = this.danhSachNhanVienBindingSource;
            this.danhSachNhanVienGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.danhSachNhanVienGridControl.Location = new System.Drawing.Point(0, 25);
            this.danhSachNhanVienGridControl.MainView = this.gridView1;
            this.danhSachNhanVienGridControl.Name = "danhSachNhanVienGridControl";
            this.danhSachNhanVienGridControl.Size = new System.Drawing.Size(545, 344);
            this.danhSachNhanVienGridControl.TabIndex = 1;
            this.danhSachNhanVienGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaNhanVien,
            this.colSTT,
            this.colHoTen,
            this.colNgaySinh,
            this.colNoiSinh,
            this.colGioiTinh,
            this.colDanToc,
            this.colTonGiao,
            this.colThuongTru,
            this.colTamTru,
            this.colEmail,
            this.colSDT,
            this.colHonNhan,
            this.colCMND,
            this.colNgayCapCMND,
            this.colNoiCapCMND,
            this.colTK_NganHang,
            this.colTenNganHang,
            this.colChiNhanhNganHang,
            this.colTrinhDoDaoTao,
            this.colNoiDaoTao,
            this.colChuyenNganh,
            this.colViTriCongViec,
            this.colDonViCongTac,
            this.colNgayThuViec,
            this.colNgayChinhThuc,
            this.colLoaiHopDong,
            this.colTrangThai,
            this.colGhichu});
            this.gridView1.GridControl = this.danhSachNhanVienGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colMaNhanVien
            // 
            this.colMaNhanVien.Caption = "Mã Nhân Viên";
            this.colMaNhanVien.FieldName = "MaNhanVien";
            this.colMaNhanVien.Name = "colMaNhanVien";
            this.colMaNhanVien.Visible = true;
            this.colMaNhanVien.VisibleIndex = 0;
            // 
            // colSTT
            // 
            this.colSTT.FieldName = "STT";
            this.colSTT.Name = "colSTT";
            this.colSTT.Visible = true;
            this.colSTT.VisibleIndex = 2;
            // 
            // colHoTen
            // 
            this.colHoTen.Caption = "Họ Tên";
            this.colHoTen.FieldName = "HoTen";
            this.colHoTen.Name = "colHoTen";
            this.colHoTen.Visible = true;
            this.colHoTen.VisibleIndex = 3;
            // 
            // colNgaySinh
            // 
            this.colNgaySinh.Caption = "Ngày Sinh";
            this.colNgaySinh.FieldName = "NgaySinh";
            this.colNgaySinh.Name = "colNgaySinh";
            this.colNgaySinh.Visible = true;
            this.colNgaySinh.VisibleIndex = 4;
            // 
            // colNoiSinh
            // 
            this.colNoiSinh.Caption = "Nơi Sinh";
            this.colNoiSinh.FieldName = "NoiSinh";
            this.colNoiSinh.Name = "colNoiSinh";
            this.colNoiSinh.Visible = true;
            this.colNoiSinh.VisibleIndex = 5;
            // 
            // colGioiTinh
            // 
            this.colGioiTinh.Caption = "Giới Tính";
            this.colGioiTinh.FieldName = "GioiTinh";
            this.colGioiTinh.Name = "colGioiTinh";
            this.colGioiTinh.Visible = true;
            this.colGioiTinh.VisibleIndex = 1;
            // 
            // colDanToc
            // 
            this.colDanToc.Caption = "Dân Tộc";
            this.colDanToc.FieldName = "DanToc";
            this.colDanToc.Name = "colDanToc";
            this.colDanToc.Visible = true;
            this.colDanToc.VisibleIndex = 6;
            // 
            // colTonGiao
            // 
            this.colTonGiao.Caption = "Tôn Giáo";
            this.colTonGiao.FieldName = "TonGiao";
            this.colTonGiao.Name = "colTonGiao";
            this.colTonGiao.Visible = true;
            this.colTonGiao.VisibleIndex = 7;
            // 
            // colThuongTru
            // 
            this.colThuongTru.Caption = "Thường Trú";
            this.colThuongTru.FieldName = "ThuongTru";
            this.colThuongTru.Name = "colThuongTru";
            this.colThuongTru.Visible = true;
            this.colThuongTru.VisibleIndex = 8;
            // 
            // colTamTru
            // 
            this.colTamTru.Caption = "Tạm Trú";
            this.colTamTru.FieldName = "TamTru";
            this.colTamTru.Name = "colTamTru";
            this.colTamTru.Visible = true;
            this.colTamTru.VisibleIndex = 9;
            // 
            // colEmail
            // 
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 10;
            // 
            // colSDT
            // 
            this.colSDT.Caption = "SĐT";
            this.colSDT.FieldName = "SDT";
            this.colSDT.Name = "colSDT";
            this.colSDT.Visible = true;
            this.colSDT.VisibleIndex = 11;
            // 
            // colHonNhan
            // 
            this.colHonNhan.Caption = "Hôn Nhân";
            this.colHonNhan.FieldName = "HonNhan";
            this.colHonNhan.Name = "colHonNhan";
            this.colHonNhan.Visible = true;
            this.colHonNhan.VisibleIndex = 12;
            // 
            // colCMND
            // 
            this.colCMND.Caption = "Số CMND";
            this.colCMND.FieldName = "CMND";
            this.colCMND.Name = "colCMND";
            this.colCMND.Visible = true;
            this.colCMND.VisibleIndex = 13;
            // 
            // colNgayCapCMND
            // 
            this.colNgayCapCMND.Caption = "Ngày Cấp";
            this.colNgayCapCMND.FieldName = "NgayCapCMND";
            this.colNgayCapCMND.Name = "colNgayCapCMND";
            this.colNgayCapCMND.Visible = true;
            this.colNgayCapCMND.VisibleIndex = 14;
            // 
            // colNoiCapCMND
            // 
            this.colNoiCapCMND.Caption = "Nơi Cấp";
            this.colNoiCapCMND.FieldName = "NoiCapCMND";
            this.colNoiCapCMND.Name = "colNoiCapCMND";
            this.colNoiCapCMND.Visible = true;
            this.colNoiCapCMND.VisibleIndex = 15;
            // 
            // colTK_NganHang
            // 
            this.colTK_NganHang.Caption = "TK Ngân Hàng";
            this.colTK_NganHang.FieldName = "TK_NganHang";
            this.colTK_NganHang.Name = "colTK_NganHang";
            this.colTK_NganHang.Visible = true;
            this.colTK_NganHang.VisibleIndex = 18;
            // 
            // colTenNganHang
            // 
            this.colTenNganHang.Caption = "Tên Ngân Hàng";
            this.colTenNganHang.FieldName = "TenNganHang";
            this.colTenNganHang.Name = "colTenNganHang";
            this.colTenNganHang.Visible = true;
            this.colTenNganHang.VisibleIndex = 17;
            // 
            // colChiNhanhNganHang
            // 
            this.colChiNhanhNganHang.Caption = "Chi Nhánh";
            this.colChiNhanhNganHang.FieldName = "ChiNhanhNganHang";
            this.colChiNhanhNganHang.Name = "colChiNhanhNganHang";
            this.colChiNhanhNganHang.Visible = true;
            this.colChiNhanhNganHang.VisibleIndex = 16;
            // 
            // colTrinhDoDaoTao
            // 
            this.colTrinhDoDaoTao.Caption = "Trình Độ";
            this.colTrinhDoDaoTao.FieldName = "TrinhDoDaoTao";
            this.colTrinhDoDaoTao.Name = "colTrinhDoDaoTao";
            this.colTrinhDoDaoTao.Visible = true;
            this.colTrinhDoDaoTao.VisibleIndex = 19;
            // 
            // colNoiDaoTao
            // 
            this.colNoiDaoTao.Caption = "Nơi Đào Tạo";
            this.colNoiDaoTao.FieldName = "NoiDaoTao";
            this.colNoiDaoTao.Name = "colNoiDaoTao";
            this.colNoiDaoTao.Visible = true;
            this.colNoiDaoTao.VisibleIndex = 20;
            // 
            // colChuyenNganh
            // 
            this.colChuyenNganh.Caption = "Chuyên Ngành";
            this.colChuyenNganh.FieldName = "ChuyenNganh";
            this.colChuyenNganh.Name = "colChuyenNganh";
            this.colChuyenNganh.Visible = true;
            this.colChuyenNganh.VisibleIndex = 21;
            // 
            // colViTriCongViec
            // 
            this.colViTriCongViec.Caption = "Vị Trí Công Việc";
            this.colViTriCongViec.FieldName = "ViTriCongViec";
            this.colViTriCongViec.Name = "colViTriCongViec";
            this.colViTriCongViec.Visible = true;
            this.colViTriCongViec.VisibleIndex = 22;
            // 
            // colDonViCongTac
            // 
            this.colDonViCongTac.Caption = "Đơn Vị Công Tác";
            this.colDonViCongTac.FieldName = "DonViCongTac";
            this.colDonViCongTac.Name = "colDonViCongTac";
            this.colDonViCongTac.Visible = true;
            this.colDonViCongTac.VisibleIndex = 27;
            // 
            // colNgayThuViec
            // 
            this.colNgayThuViec.Caption = "Ngày Thử Việc";
            this.colNgayThuViec.FieldName = "NgayThuViec";
            this.colNgayThuViec.Name = "colNgayThuViec";
            this.colNgayThuViec.Visible = true;
            this.colNgayThuViec.VisibleIndex = 23;
            // 
            // colNgayChinhThuc
            // 
            this.colNgayChinhThuc.Caption = "Ngày Chính Thức";
            this.colNgayChinhThuc.FieldName = "NgayChinhThuc";
            this.colNgayChinhThuc.Name = "colNgayChinhThuc";
            this.colNgayChinhThuc.Visible = true;
            this.colNgayChinhThuc.VisibleIndex = 24;
            // 
            // colLoaiHopDong
            // 
            this.colLoaiHopDong.Caption = "Loại Hợp Đồng";
            this.colLoaiHopDong.FieldName = "LoaiHopDong";
            this.colLoaiHopDong.Name = "colLoaiHopDong";
            this.colLoaiHopDong.Visible = true;
            this.colLoaiHopDong.VisibleIndex = 25;
            // 
            // colTrangThai
            // 
            this.colTrangThai.Caption = "Trạng Thái";
            this.colTrangThai.FieldName = "TrangThai";
            this.colTrangThai.Name = "colTrangThai";
            this.colTrangThai.Visible = true;
            this.colTrangThai.VisibleIndex = 26;
            // 
            // colGhichu
            // 
            this.colGhichu.Caption = "Ghi Chú";
            this.colGhichu.FieldName = "Ghichu";
            this.colGhichu.Name = "colGhichu";
            this.colGhichu.Visible = true;
            this.colGhichu.VisibleIndex = 28;
            // 
            // CustomConTrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.danhSachNhanVienGridControl);
            this.Controls.Add(this.danhSachNhanVienBindingNavigator);
            this.Name = "CustomConTrol";
            this.Size = new System.Drawing.Size(545, 369);
            ((System.ComponentModel.ISupportInitialize)(this.dsnv_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhSachNhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhSachNhanVienBindingNavigator)).EndInit();
            this.danhSachNhanVienBindingNavigator.ResumeLayout(false);
            this.danhSachNhanVienBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.danhSachNhanVienGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dsnv_dbDataSet dsnv_dbDataSet;
        private System.Windows.Forms.BindingSource danhSachNhanVienBindingSource;
        private dsnv_dbDataSetTableAdapters.DanhSachNhanVienTableAdapter danhSachNhanVienTableAdapter;
        private dsnv_dbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator danhSachNhanVienBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton danhSachNhanVienBindingNavigatorSaveItem;
        private DevExpress.XtraGrid.GridControl danhSachNhanVienGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMaNhanVien;
        private DevExpress.XtraGrid.Columns.GridColumn colSTT;
        private DevExpress.XtraGrid.Columns.GridColumn colHoTen;
        private DevExpress.XtraGrid.Columns.GridColumn colNgaySinh;
        private DevExpress.XtraGrid.Columns.GridColumn colNoiSinh;
        private DevExpress.XtraGrid.Columns.GridColumn colGioiTinh;
        private DevExpress.XtraGrid.Columns.GridColumn colDanToc;
        private DevExpress.XtraGrid.Columns.GridColumn colTonGiao;
        private DevExpress.XtraGrid.Columns.GridColumn colThuongTru;
        private DevExpress.XtraGrid.Columns.GridColumn colTamTru;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colSDT;
        private DevExpress.XtraGrid.Columns.GridColumn colHonNhan;
        private DevExpress.XtraGrid.Columns.GridColumn colCMND;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayCapCMND;
        private DevExpress.XtraGrid.Columns.GridColumn colNoiCapCMND;
        private DevExpress.XtraGrid.Columns.GridColumn colTK_NganHang;
        private DevExpress.XtraGrid.Columns.GridColumn colTenNganHang;
        private DevExpress.XtraGrid.Columns.GridColumn colChiNhanhNganHang;
        private DevExpress.XtraGrid.Columns.GridColumn colTrinhDoDaoTao;
        private DevExpress.XtraGrid.Columns.GridColumn colNoiDaoTao;
        private DevExpress.XtraGrid.Columns.GridColumn colChuyenNganh;
        private DevExpress.XtraGrid.Columns.GridColumn colViTriCongViec;
        private DevExpress.XtraGrid.Columns.GridColumn colDonViCongTac;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayThuViec;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayChinhThuc;
        private DevExpress.XtraGrid.Columns.GridColumn colLoaiHopDong;
        private DevExpress.XtraGrid.Columns.GridColumn colTrangThai;
        private DevExpress.XtraGrid.Columns.GridColumn colGhichu;
    }
}
