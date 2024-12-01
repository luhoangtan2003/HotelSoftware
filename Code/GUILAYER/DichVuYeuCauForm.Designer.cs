namespace GUILAYER
{
    partial class DichVuYeuCauForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DichVuYeuCauForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BarManager = new DevExpress.XtraBars.BarManager(this.components);
            this.Bar1 = new DevExpress.XtraBars.Bar();
            this.NutThem = new DevExpress.XtraBars.BarButtonItem();
            this.NutSua = new DevExpress.XtraBars.BarButtonItem();
            this.NutXoa = new DevExpress.XtraBars.BarButtonItem();
            this.BarDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.BarDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.BarDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.BarDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.DockManager = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.ThanhPhanLoai = new DevExpress.XtraBars.Docking.DockPanel();
            this.DockPanel_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.LoaiDichVu_SLUE = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.GridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LabelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.TrangThai_SLUE = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.GridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DichVuSearch = new DevExpress.XtraEditors.SearchControl();
            this.LabelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.LoaiHinh_SLUE = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.GridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LabelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.BangDuLieu = new Guna.UI2.WinForms.Guna2DataGridView();
            this.MADICHVU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENDICHVU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MALOAIDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENLOAIDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIADICHVU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MATRANGTHAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENTRANGTHAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MALOAIHINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENLOAIHINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MOTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lock = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DockManager)).BeginInit();
            this.ThanhPhanLoai.SuspendLayout();
            this.DockPanel_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoaiDichVu_SLUE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrangThai_SLUE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DichVuSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoaiHinh_SLUE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BangDuLieu)).BeginInit();
            this.SuspendLayout();
            // 
            // BarManager
            // 
            this.BarManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.Bar1});
            this.BarManager.DockControls.Add(this.BarDockControlTop);
            this.BarManager.DockControls.Add(this.BarDockControlBottom);
            this.BarManager.DockControls.Add(this.BarDockControlLeft);
            this.BarManager.DockControls.Add(this.BarDockControlRight);
            this.BarManager.DockManager = this.DockManager;
            this.BarManager.Form = this;
            this.BarManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.NutThem,
            this.NutXoa,
            this.NutSua});
            this.BarManager.MainMenu = this.Bar1;
            this.BarManager.MaxItemId = 5;
            // 
            // Bar1
            // 
            this.Bar1.BarName = "Main menu";
            this.Bar1.DockCol = 0;
            this.Bar1.DockRow = 0;
            this.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.Bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.NutThem, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.NutSua, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.NutXoa, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.Bar1.OptionsBar.MultiLine = true;
            this.Bar1.OptionsBar.UseWholeRow = true;
            this.Bar1.Text = "Main menu";
            // 
            // NutThem
            // 
            this.NutThem.Caption = "THÊM";
            this.NutThem.Id = 0;
            this.NutThem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("NutThem.ImageOptions.SvgImage")));
            this.NutThem.Name = "NutThem";
            this.NutThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.NutThem_ItemClick);
            // 
            // NutSua
            // 
            this.NutSua.Caption = "CẬP NHẬT";
            this.NutSua.Enabled = false;
            this.NutSua.Id = 3;
            this.NutSua.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("NutSua.ImageOptions.SvgImage")));
            this.NutSua.Name = "NutSua";
            this.NutSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.NutSua_ItemClick);
            // 
            // NutXoa
            // 
            this.NutXoa.Caption = "XÓA";
            this.NutXoa.Enabled = false;
            this.NutXoa.Id = 1;
            this.NutXoa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("NutXoa.ImageOptions.SvgImage")));
            this.NutXoa.Name = "NutXoa";
            this.NutXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.NutXoa_ItemClick);
            // 
            // BarDockControlTop
            // 
            this.BarDockControlTop.CausesValidation = false;
            this.BarDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.BarDockControlTop.Manager = this.BarManager;
            this.BarDockControlTop.Size = new System.Drawing.Size(1883, 35);
            // 
            // BarDockControlBottom
            // 
            this.BarDockControlBottom.CausesValidation = false;
            this.BarDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BarDockControlBottom.Location = new System.Drawing.Point(0, 741);
            this.BarDockControlBottom.Manager = this.BarManager;
            this.BarDockControlBottom.Size = new System.Drawing.Size(1883, 0);
            // 
            // BarDockControlLeft
            // 
            this.BarDockControlLeft.CausesValidation = false;
            this.BarDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.BarDockControlLeft.Location = new System.Drawing.Point(0, 35);
            this.BarDockControlLeft.Manager = this.BarManager;
            this.BarDockControlLeft.Size = new System.Drawing.Size(0, 706);
            // 
            // BarDockControlRight
            // 
            this.BarDockControlRight.CausesValidation = false;
            this.BarDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.BarDockControlRight.Location = new System.Drawing.Point(1883, 35);
            this.BarDockControlRight.Manager = this.BarManager;
            this.BarDockControlRight.Size = new System.Drawing.Size(0, 706);
            // 
            // DockManager
            // 
            this.DockManager.Form = this;
            this.DockManager.MenuManager = this.BarManager;
            this.DockManager.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.ThanhPhanLoai});
            this.DockManager.Style = DevExpress.XtraBars.Docking2010.Views.DockingViewStyle.Light;
            this.DockManager.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "System.Windows.Forms.StatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane",
            "DevExpress.XtraBars.TabFormControl",
            "DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl",
            "DevExpress.XtraBars.ToolbarForm.ToolbarFormControl"});
            // 
            // ThanhPhanLoai
            // 
            this.ThanhPhanLoai.Controls.Add(this.DockPanel_Container);
            this.ThanhPhanLoai.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.ThanhPhanLoai.FloatSize = new System.Drawing.Size(310, 706);
            this.ThanhPhanLoai.ID = new System.Guid("398c50a9-da26-4d1b-b702-39023afc2829");
            this.ThanhPhanLoai.Location = new System.Drawing.Point(0, 35);
            this.ThanhPhanLoai.Name = "ThanhPhanLoai";
            this.ThanhPhanLoai.Options.ShowCloseButton = false;
            this.ThanhPhanLoai.OriginalSize = new System.Drawing.Size(310, 200);
            this.ThanhPhanLoai.Size = new System.Drawing.Size(310, 706);
            this.ThanhPhanLoai.Text = "THANH PHÂN LOẠI";
            // 
            // DockPanel_Container
            // 
            this.DockPanel_Container.Controls.Add(this.LoaiDichVu_SLUE);
            this.DockPanel_Container.Controls.Add(this.LabelControl1);
            this.DockPanel_Container.Controls.Add(this.TrangThai_SLUE);
            this.DockPanel_Container.Controls.Add(this.DichVuSearch);
            this.DockPanel_Container.Controls.Add(this.LabelControl5);
            this.DockPanel_Container.Controls.Add(this.LoaiHinh_SLUE);
            this.DockPanel_Container.Controls.Add(this.LabelControl3);
            this.DockPanel_Container.Controls.Add(this.LabelControl2);
            this.DockPanel_Container.Location = new System.Drawing.Point(0, 33);
            this.DockPanel_Container.Name = "DockPanel_Container";
            this.DockPanel_Container.Size = new System.Drawing.Size(309, 673);
            this.DockPanel_Container.TabIndex = 0;
            // 
            // LoaiDichVu_SLUE
            // 
            this.LoaiDichVu_SLUE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoaiDichVu_SLUE.Location = new System.Drawing.Point(10, 39);
            this.LoaiDichVu_SLUE.MenuManager = this.BarManager;
            this.LoaiDichVu_SLUE.Name = "LoaiDichVu_SLUE";
            this.LoaiDichVu_SLUE.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.LoaiDichVu_SLUE.Properties.Appearance.Options.UseFont = true;
            this.LoaiDichVu_SLUE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LoaiDichVu_SLUE.Properties.DisplayMember = "TENLOAIDV";
            this.LoaiDichVu_SLUE.Properties.NullText = "ALL";
            this.LoaiDichVu_SLUE.Properties.PopupView = this.GridView1;
            this.LoaiDichVu_SLUE.Properties.ValueMember = "MALOAIDV";
            this.LoaiDichVu_SLUE.Size = new System.Drawing.Size(291, 36);
            this.LoaiDichVu_SLUE.TabIndex = 24;
            this.LoaiDichVu_SLUE.EditValueChanged += new System.EventHandler(this.LoaiDichVu_EditValueChanged);
            // 
            // GridView1
            // 
            this.GridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(204)))), ((int)(((byte)(132)))));
            this.GridView1.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.GridView1.Appearance.FocusedRow.Options.UseBackColor = true;
            this.GridView1.Appearance.FocusedRow.Options.UseForeColor = true;
            this.GridView1.Appearance.Row.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.GridView1.Appearance.Row.Options.UseFont = true;
            this.GridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.GridColumn1,
            this.GridColumn2});
            this.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.GridView1.Name = "GridView1";
            this.GridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.GridView1.OptionsView.ShowGroupPanel = false;
            this.GridView1.OptionsView.ShowIndicator = false;
            this.GridView1.RowHeight = 40;
            // 
            // GridColumn1
            // 
            this.GridColumn1.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.GridColumn1.AppearanceHeader.Options.UseFont = true;
            this.GridColumn1.Caption = "TÊN LOẠI DỊCH VỤ";
            this.GridColumn1.FieldName = "TENLOAIDV";
            this.GridColumn1.Name = "GridColumn1";
            this.GridColumn1.Visible = true;
            this.GridColumn1.VisibleIndex = 0;
            // 
            // GridColumn2
            // 
            this.GridColumn2.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.GridColumn2.AppearanceHeader.Options.UseFont = true;
            this.GridColumn2.Caption = "MÔ TẢ";
            this.GridColumn2.FieldName = "MOTA";
            this.GridColumn2.Name = "GridColumn2";
            this.GridColumn2.Visible = true;
            this.GridColumn2.VisibleIndex = 1;
            // 
            // LabelControl1
            // 
            this.LabelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.LabelControl1.Appearance.Options.UseFont = true;
            this.LabelControl1.Location = new System.Drawing.Point(10, 3);
            this.LabelControl1.Name = "LabelControl1";
            this.LabelControl1.Size = new System.Drawing.Size(119, 30);
            this.LabelControl1.TabIndex = 25;
            this.LabelControl1.Text = "Loại Dịch Vụ";
            // 
            // TrangThai_SLUE
            // 
            this.TrangThai_SLUE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TrangThai_SLUE.Location = new System.Drawing.Point(10, 211);
            this.TrangThai_SLUE.MenuManager = this.BarManager;
            this.TrangThai_SLUE.Name = "TrangThai_SLUE";
            this.TrangThai_SLUE.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.TrangThai_SLUE.Properties.Appearance.Options.UseFont = true;
            this.TrangThai_SLUE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TrangThai_SLUE.Properties.DisplayMember = "TENTRANGTHAI";
            this.TrangThai_SLUE.Properties.NullText = "ALL";
            this.TrangThai_SLUE.Properties.PopupView = this.GridView4;
            this.TrangThai_SLUE.Properties.ValueMember = "MATRANGTHAI";
            this.TrangThai_SLUE.Size = new System.Drawing.Size(291, 36);
            this.TrangThai_SLUE.TabIndex = 19;
            this.TrangThai_SLUE.EditValueChanged += new System.EventHandler(this.TrangThai_EditValueChanged);
            // 
            // GridView4
            // 
            this.GridView4.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(204)))), ((int)(((byte)(132)))));
            this.GridView4.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.GridView4.Appearance.FocusedRow.Options.UseBackColor = true;
            this.GridView4.Appearance.FocusedRow.Options.UseForeColor = true;
            this.GridView4.Appearance.Row.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.GridView4.Appearance.Row.Options.UseFont = true;
            this.GridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.GridColumn8,
            this.GridColumn7});
            this.GridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.GridView4.Name = "GridView4";
            this.GridView4.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.GridView4.OptionsView.ShowGroupPanel = false;
            this.GridView4.OptionsView.ShowIndicator = false;
            this.GridView4.RowHeight = 40;
            // 
            // GridColumn8
            // 
            this.GridColumn8.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.GridColumn8.AppearanceHeader.Options.UseFont = true;
            this.GridColumn8.Caption = "TÊN TRẠNG THÁI";
            this.GridColumn8.FieldName = "TENTRANGTHAI";
            this.GridColumn8.Name = "GridColumn8";
            this.GridColumn8.Visible = true;
            this.GridColumn8.VisibleIndex = 0;
            // 
            // GridColumn7
            // 
            this.GridColumn7.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.GridColumn7.AppearanceHeader.Options.UseFont = true;
            this.GridColumn7.Caption = "MÔ TẢ";
            this.GridColumn7.FieldName = "MOTA";
            this.GridColumn7.Name = "GridColumn7";
            this.GridColumn7.Visible = true;
            this.GridColumn7.VisibleIndex = 1;
            // 
            // DichVuSearch
            // 
            this.DichVuSearch.EditValue = "";
            this.DichVuSearch.Location = new System.Drawing.Point(10, 298);
            this.DichVuSearch.MenuManager = this.BarManager;
            this.DichVuSearch.Name = "DichVuSearch";
            this.DichVuSearch.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.DichVuSearch.Properties.Appearance.Options.UseFont = true;
            this.DichVuSearch.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.DichVuSearch.Size = new System.Drawing.Size(290, 36);
            this.DichVuSearch.TabIndex = 21;
            this.DichVuSearch.TextChanged += new System.EventHandler(this.DichVuSearch_TextChanged);
            // 
            // LabelControl5
            // 
            this.LabelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.LabelControl5.Appearance.Options.UseFont = true;
            this.LabelControl5.Location = new System.Drawing.Point(10, 262);
            this.LabelControl5.Name = "LabelControl5";
            this.LabelControl5.Size = new System.Drawing.Size(91, 30);
            this.LabelControl5.TabIndex = 22;
            this.LabelControl5.Text = "Tìm Kiếm";
            // 
            // LoaiHinh_SLUE
            // 
            this.LoaiHinh_SLUE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoaiHinh_SLUE.Location = new System.Drawing.Point(10, 128);
            this.LoaiHinh_SLUE.MenuManager = this.BarManager;
            this.LoaiHinh_SLUE.Name = "LoaiHinh_SLUE";
            this.LoaiHinh_SLUE.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.LoaiHinh_SLUE.Properties.Appearance.Options.UseFont = true;
            this.LoaiHinh_SLUE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LoaiHinh_SLUE.Properties.DisplayMember = "TENLOAIHINH";
            this.LoaiHinh_SLUE.Properties.NullText = "ALL";
            this.LoaiHinh_SLUE.Properties.PopupView = this.GridView2;
            this.LoaiHinh_SLUE.Properties.ValueMember = "MALOAIHINH";
            this.LoaiHinh_SLUE.Size = new System.Drawing.Size(291, 36);
            this.LoaiHinh_SLUE.TabIndex = 20;
            this.LoaiHinh_SLUE.EditValueChanged += new System.EventHandler(this.LoaiHinh_EditValueChanged);
            // 
            // GridView2
            // 
            this.GridView2.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(204)))), ((int)(((byte)(132)))));
            this.GridView2.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.GridView2.Appearance.FocusedRow.Options.UseBackColor = true;
            this.GridView2.Appearance.FocusedRow.Options.UseForeColor = true;
            this.GridView2.Appearance.Row.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.GridView2.Appearance.Row.Options.UseFont = true;
            this.GridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.GridColumn3,
            this.GridColumn5});
            this.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.GridView2.Name = "GridView2";
            this.GridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.GridView2.OptionsView.ShowGroupPanel = false;
            this.GridView2.OptionsView.ShowIndicator = false;
            this.GridView2.RowHeight = 40;
            // 
            // GridColumn3
            // 
            this.GridColumn3.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.GridColumn3.AppearanceHeader.Options.UseFont = true;
            this.GridColumn3.Caption = "TÊN LOẠI HÌNH";
            this.GridColumn3.FieldName = "TENLOAIHINH";
            this.GridColumn3.Name = "GridColumn3";
            this.GridColumn3.Visible = true;
            this.GridColumn3.VisibleIndex = 0;
            // 
            // GridColumn5
            // 
            this.GridColumn5.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.GridColumn5.AppearanceHeader.Options.UseFont = true;
            this.GridColumn5.Caption = "MÔ TẢ";
            this.GridColumn5.FieldName = "MOTA";
            this.GridColumn5.Name = "GridColumn5";
            this.GridColumn5.Visible = true;
            this.GridColumn5.VisibleIndex = 1;
            // 
            // LabelControl3
            // 
            this.LabelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.LabelControl3.Appearance.Options.UseFont = true;
            this.LabelControl3.Location = new System.Drawing.Point(10, 175);
            this.LabelControl3.Name = "LabelControl3";
            this.LabelControl3.Size = new System.Drawing.Size(100, 30);
            this.LabelControl3.TabIndex = 23;
            this.LabelControl3.Text = "Trạng Thái";
            // 
            // LabelControl2
            // 
            this.LabelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.LabelControl2.Appearance.Options.UseFont = true;
            this.LabelControl2.Location = new System.Drawing.Point(10, 92);
            this.LabelControl2.Name = "LabelControl2";
            this.LabelControl2.Size = new System.Drawing.Size(100, 30);
            this.LabelControl2.TabIndex = 21;
            this.LabelControl2.Text = "Hạng Mục";
            // 
            // BangDuLieu
            // 
            this.BangDuLieu.AllowUserToAddRows = false;
            this.BangDuLieu.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.BangDuLieu.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.BangDuLieu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BangDuLieu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
            this.BangDuLieu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BangDuLieu.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.BangDuLieu.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(107)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BangDuLieu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.BangDuLieu.ColumnHeadersHeight = 40;
            this.BangDuLieu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MADICHVU,
            this.TENDICHVU,
            this.MALOAIDV,
            this.TENLOAIDV,
            this.GIADICHVU,
            this.MATRANGTHAI,
            this.TENTRANGTHAI,
            this.MALOAIHINH,
            this.TENLOAIHINH,
            this.MOTA});
            this.BangDuLieu.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(204)))), ((int)(((byte)(132)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BangDuLieu.DefaultCellStyle = dataGridViewCellStyle8;
            this.BangDuLieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BangDuLieu.EnableHeadersVisualStyles = false;
            this.BangDuLieu.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.BangDuLieu.Location = new System.Drawing.Point(310, 35);
            this.BangDuLieu.Name = "BangDuLieu";
            this.BangDuLieu.ReadOnly = true;
            this.BangDuLieu.RowHeadersVisible = false;
            this.BangDuLieu.RowHeadersWidth = 51;
            this.BangDuLieu.RowTemplate.Height = 40;
            this.BangDuLieu.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.BangDuLieu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BangDuLieu.Size = new System.Drawing.Size(1573, 706);
            this.BangDuLieu.TabIndex = 11;
            this.BangDuLieu.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightGrid;
            this.BangDuLieu.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.BangDuLieu.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.BangDuLieu.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.BangDuLieu.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.BangDuLieu.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.BangDuLieu.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
            this.BangDuLieu.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.BangDuLieu.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(107)))), ((int)(((byte)(153)))));
            this.BangDuLieu.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.BangDuLieu.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.BangDuLieu.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.BangDuLieu.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.BangDuLieu.ThemeStyle.HeaderStyle.Height = 40;
            this.BangDuLieu.ThemeStyle.ReadOnly = true;
            this.BangDuLieu.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.BangDuLieu.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.BangDuLieu.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BangDuLieu.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.BangDuLieu.ThemeStyle.RowsStyle.Height = 40;
            this.BangDuLieu.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(204)))), ((int)(((byte)(132)))));
            this.BangDuLieu.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.BangDuLieu.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.BangDuLieu_ColumnHeaderMouseClick);
            this.BangDuLieu.SelectionChanged += new System.EventHandler(this.BangDuLieu_SelectionChanged);
            // 
            // MADICHVU
            // 
            this.MADICHVU.DataPropertyName = "MADICHVU";
            this.MADICHVU.HeaderText = "MÃ DỊCH VỤ";
            this.MADICHVU.MinimumWidth = 6;
            this.MADICHVU.Name = "MADICHVU";
            this.MADICHVU.ReadOnly = true;
            // 
            // TENDICHVU
            // 
            this.TENDICHVU.DataPropertyName = "TENDICHVU";
            this.TENDICHVU.HeaderText = "TÊN DỊCH VỤ";
            this.TENDICHVU.MinimumWidth = 6;
            this.TENDICHVU.Name = "TENDICHVU";
            this.TENDICHVU.ReadOnly = true;
            // 
            // MALOAIDV
            // 
            this.MALOAIDV.DataPropertyName = "MALOAIDV";
            this.MALOAIDV.HeaderText = "MÃ LOẠI DỊCH VỤ";
            this.MALOAIDV.MinimumWidth = 6;
            this.MALOAIDV.Name = "MALOAIDV";
            this.MALOAIDV.ReadOnly = true;
            this.MALOAIDV.Visible = false;
            // 
            // TENLOAIDV
            // 
            this.TENLOAIDV.DataPropertyName = "TENLOAIDV";
            this.TENLOAIDV.HeaderText = "LOẠI DỊCH VỤ";
            this.TENLOAIDV.MinimumWidth = 6;
            this.TENLOAIDV.Name = "TENLOAIDV";
            this.TENLOAIDV.ReadOnly = true;
            // 
            // GIADICHVU
            // 
            this.GIADICHVU.DataPropertyName = "GIADICHVU";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "N0";
            dataGridViewCellStyle7.NullValue = null;
            this.GIADICHVU.DefaultCellStyle = dataGridViewCellStyle7;
            this.GIADICHVU.HeaderText = "GIÁ DỊCH VỤ";
            this.GIADICHVU.MinimumWidth = 6;
            this.GIADICHVU.Name = "GIADICHVU";
            this.GIADICHVU.ReadOnly = true;
            // 
            // MATRANGTHAI
            // 
            this.MATRANGTHAI.DataPropertyName = "MATRANGTHAI";
            this.MATRANGTHAI.HeaderText = "MÃ TRẠNG THÁI";
            this.MATRANGTHAI.MinimumWidth = 6;
            this.MATRANGTHAI.Name = "MATRANGTHAI";
            this.MATRANGTHAI.ReadOnly = true;
            this.MATRANGTHAI.Visible = false;
            // 
            // TENTRANGTHAI
            // 
            this.TENTRANGTHAI.DataPropertyName = "TENTRANGTHAI";
            this.TENTRANGTHAI.HeaderText = "TRẠNG THÁI";
            this.TENTRANGTHAI.MinimumWidth = 6;
            this.TENTRANGTHAI.Name = "TENTRANGTHAI";
            this.TENTRANGTHAI.ReadOnly = true;
            // 
            // MALOAIHINH
            // 
            this.MALOAIHINH.DataPropertyName = "MALOAIHINH";
            this.MALOAIHINH.HeaderText = "MÃ LOẠI HÌNH";
            this.MALOAIHINH.MinimumWidth = 6;
            this.MALOAIHINH.Name = "MALOAIHINH";
            this.MALOAIHINH.ReadOnly = true;
            this.MALOAIHINH.Visible = false;
            // 
            // TENLOAIHINH
            // 
            this.TENLOAIHINH.DataPropertyName = "TENLOAIHINH";
            this.TENLOAIHINH.HeaderText = "LOẠI HÌNH";
            this.TENLOAIHINH.MinimumWidth = 6;
            this.TENLOAIHINH.Name = "TENLOAIHINH";
            this.TENLOAIHINH.ReadOnly = true;
            // 
            // MOTA
            // 
            this.MOTA.DataPropertyName = "MOTA";
            this.MOTA.HeaderText = "MÔ TẢ";
            this.MOTA.MinimumWidth = 6;
            this.MOTA.Name = "MOTA";
            this.MOTA.ReadOnly = true;
            // 
            // Lock
            // 
            this.Lock.Interval = 500;
            this.Lock.Tick += new System.EventHandler(this.DichVuSearchAfterTyping);
            // 
            // DichVuKhachHangForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1883, 741);
            this.Controls.Add(this.BangDuLieu);
            this.Controls.Add(this.ThanhPhanLoai);
            this.Controls.Add(this.BarDockControlLeft);
            this.Controls.Add(this.BarDockControlRight);
            this.Controls.Add(this.BarDockControlBottom);
            this.Controls.Add(this.BarDockControlTop);
            this.IconOptions.Image = global::GUILAYER.Properties.Resources.Logo;
            this.Name = "DichVuKhachHangForm";
            this.Text = " DỊCH VỤ";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DockManager)).EndInit();
            this.ThanhPhanLoai.ResumeLayout(false);
            this.DockPanel_Container.ResumeLayout(false);
            this.DockPanel_Container.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoaiDichVu_SLUE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrangThai_SLUE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DichVuSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoaiHinh_SLUE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BangDuLieu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager BarManager;
        private DevExpress.XtraBars.Bar Bar1;
        private DevExpress.XtraBars.BarButtonItem NutThem;
        private DevExpress.XtraBars.BarButtonItem NutSua;
        private DevExpress.XtraBars.BarButtonItem NutXoa;
        private DevExpress.XtraBars.BarDockControl BarDockControlTop;
        private DevExpress.XtraBars.BarDockControl BarDockControlBottom;
        private DevExpress.XtraBars.BarDockControl BarDockControlLeft;
        private DevExpress.XtraBars.BarDockControl BarDockControlRight;
        private DevExpress.XtraBars.Docking.DockManager DockManager;
        private DevExpress.XtraBars.Docking.DockPanel ThanhPhanLoai;
        private DevExpress.XtraBars.Docking.ControlContainer DockPanel_Container;
        private DevExpress.XtraEditors.SearchLookUpEdit LoaiHinh_SLUE;
        private DevExpress.XtraGrid.Views.Grid.GridView GridView2;
        private DevExpress.XtraGrid.Columns.GridColumn GridColumn5;
        private DevExpress.XtraEditors.LabelControl LabelControl3;
        private DevExpress.XtraEditors.LabelControl LabelControl2;
        private DevExpress.XtraEditors.SearchControl DichVuSearch;
        private DevExpress.XtraEditors.LabelControl LabelControl5;
        private DevExpress.XtraGrid.Columns.GridColumn GridColumn3;
        private DevExpress.XtraEditors.SearchLookUpEdit TrangThai_SLUE;
        private DevExpress.XtraGrid.Views.Grid.GridView GridView4;
        private DevExpress.XtraGrid.Columns.GridColumn GridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn GridColumn7;
        private Guna.UI2.WinForms.Guna2DataGridView BangDuLieu;
        private DevExpress.XtraEditors.SearchLookUpEdit LoaiDichVu_SLUE;
        private DevExpress.XtraGrid.Views.Grid.GridView GridView1;
        private DevExpress.XtraGrid.Columns.GridColumn GridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn GridColumn2;
        private DevExpress.XtraEditors.LabelControl LabelControl1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MADICHVU;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENDICHVU;
        private System.Windows.Forms.DataGridViewTextBoxColumn MALOAIDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENLOAIDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIADICHVU;
        private System.Windows.Forms.DataGridViewTextBoxColumn MATRANGTHAI;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENTRANGTHAI;
        private System.Windows.Forms.DataGridViewTextBoxColumn MALOAIHINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENLOAIHINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MOTA;
        private System.Windows.Forms.Timer Lock;
    }
}