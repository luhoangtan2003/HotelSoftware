namespace GUILAYER
{
    partial class KhachHangForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KhachHangForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BarManager = new DevExpress.XtraBars.BarManager(this.components);
            this.Bar1 = new DevExpress.XtraBars.Bar();
            this.NutThem = new DevExpress.XtraBars.BarButtonItem();
            this.BarDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.BarDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.BarDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.BarDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.DockManager = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.ThanhPhanLoai = new DevExpress.XtraBars.Docking.DockPanel();
            this.DockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.GioiTinh_SLUE = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.GridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.QuocTich_SLUE = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.SearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KhachSearch = new DevExpress.XtraEditors.SearchControl();
            this.LabelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.SuaPopOn = new DevExpress.XtraBars.BarButtonItem();
            this.BangDuLieu = new Guna.UI2.WinForms.Guna2DataGridView();
            this.IDKHACH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HOVATEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAGT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENGIONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOLIENHE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMAIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QUEQUAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAQT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENNUOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BangTuyChonKhach = new DevExpress.XtraBars.PopupMenu(this.components);
            this.Lock = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DockManager)).BeginInit();
            this.ThanhPhanLoai.SuspendLayout();
            this.DockPanel1_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GioiTinh_SLUE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuocTich_SLUE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KhachSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BangDuLieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BangTuyChonKhach)).BeginInit();
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
            this.SuaPopOn});
            this.BarManager.MainMenu = this.Bar1;
            this.BarManager.MaxItemId = 6;
            // 
            // Bar1
            // 
            this.Bar1.BarName = "Main menu";
            this.Bar1.DockCol = 0;
            this.Bar1.DockRow = 0;
            this.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.Bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.NutThem, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.Bar1.OptionsBar.MultiLine = true;
            this.Bar1.OptionsBar.UseWholeRow = true;
            this.Bar1.Text = "Main menu";
            // 
            // NutThem
            // 
            this.NutThem.Caption = "THÊM KH";
            this.NutThem.Id = 0;
            this.NutThem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("NutThem.ImageOptions.SvgImage")));
            this.NutThem.Name = "NutThem";
            this.NutThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.NutThem_ItemClick);
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
            this.ThanhPhanLoai.Controls.Add(this.DockPanel1_Container);
            this.ThanhPhanLoai.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.ThanhPhanLoai.FloatSize = new System.Drawing.Size(310, 706);
            this.ThanhPhanLoai.ID = new System.Guid("f3b71a7f-d8d2-4316-96d1-f1be8da2e9d7");
            this.ThanhPhanLoai.Location = new System.Drawing.Point(0, 35);
            this.ThanhPhanLoai.Name = "ThanhPhanLoai";
            this.ThanhPhanLoai.Options.ShowCloseButton = false;
            this.ThanhPhanLoai.OriginalSize = new System.Drawing.Size(310, 200);
            this.ThanhPhanLoai.Size = new System.Drawing.Size(310, 706);
            this.ThanhPhanLoai.Text = "THANH PHÂN LOẠI";
            // 
            // DockPanel1_Container
            // 
            this.DockPanel1_Container.Controls.Add(this.GioiTinh_SLUE);
            this.DockPanel1_Container.Controls.Add(this.QuocTich_SLUE);
            this.DockPanel1_Container.Controls.Add(this.KhachSearch);
            this.DockPanel1_Container.Controls.Add(this.LabelControl5);
            this.DockPanel1_Container.Controls.Add(this.LabelControl2);
            this.DockPanel1_Container.Controls.Add(this.LabelControl1);
            this.DockPanel1_Container.Location = new System.Drawing.Point(0, 33);
            this.DockPanel1_Container.Name = "DockPanel1_Container";
            this.DockPanel1_Container.Size = new System.Drawing.Size(309, 673);
            this.DockPanel1_Container.TabIndex = 0;
            // 
            // GioiTinh_SLUE
            // 
            this.GioiTinh_SLUE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GioiTinh_SLUE.Location = new System.Drawing.Point(10, 39);
            this.GioiTinh_SLUE.MenuManager = this.BarManager;
            this.GioiTinh_SLUE.Name = "GioiTinh_SLUE";
            this.GioiTinh_SLUE.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.GioiTinh_SLUE.Properties.Appearance.Options.UseFont = true;
            this.GioiTinh_SLUE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.GioiTinh_SLUE.Properties.DisplayMember = "GIOITINH";
            this.GioiTinh_SLUE.Properties.NullText = "ALL";
            this.GioiTinh_SLUE.Properties.PopupView = this.GridView1;
            this.GioiTinh_SLUE.Properties.ValueMember = "MAGT";
            this.GioiTinh_SLUE.Size = new System.Drawing.Size(290, 36);
            this.GioiTinh_SLUE.TabIndex = 19;
            this.GioiTinh_SLUE.EditValueChanged += new System.EventHandler(this.GioiTinh_EditValueChanged);
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
            this.GridColumn3,
            this.GridColumn4});
            this.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.GridView1.Name = "GridView1";
            this.GridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.GridView1.OptionsView.ShowGroupPanel = false;
            this.GridView1.OptionsView.ShowIndicator = false;
            this.GridView1.RowHeight = 40;
            // 
            // GridColumn3
            // 
            this.GridColumn3.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.GridColumn3.AppearanceHeader.Options.UseFont = true;
            this.GridColumn3.Caption = "MÃ GIỐNG";
            this.GridColumn3.FieldName = "MAGT";
            this.GridColumn3.Name = "GridColumn3";
            this.GridColumn3.Visible = true;
            this.GridColumn3.VisibleIndex = 0;
            // 
            // GridColumn4
            // 
            this.GridColumn4.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.GridColumn4.AppearanceHeader.Options.UseFont = true;
            this.GridColumn4.Caption = "GIỚI TÍNH";
            this.GridColumn4.FieldName = "GIOITINH";
            this.GridColumn4.Name = "GridColumn4";
            this.GridColumn4.Visible = true;
            this.GridColumn4.VisibleIndex = 1;
            // 
            // QuocTich_SLUE
            // 
            this.QuocTich_SLUE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.QuocTich_SLUE.Location = new System.Drawing.Point(10, 131);
            this.QuocTich_SLUE.MenuManager = this.BarManager;
            this.QuocTich_SLUE.Name = "QuocTich_SLUE";
            this.QuocTich_SLUE.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.QuocTich_SLUE.Properties.Appearance.Options.UseFont = true;
            this.QuocTich_SLUE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.QuocTich_SLUE.Properties.DisplayMember = "QUOCTICH";
            this.QuocTich_SLUE.Properties.NullText = "ALL";
            this.QuocTich_SLUE.Properties.PopupView = this.SearchLookUpEdit1View;
            this.QuocTich_SLUE.Properties.ValueMember = "MAQT";
            this.QuocTich_SLUE.Size = new System.Drawing.Size(290, 36);
            this.QuocTich_SLUE.TabIndex = 18;
            this.QuocTich_SLUE.EditValueChanged += new System.EventHandler(this.QuocTich_EditValueChanged);
            // 
            // SearchLookUpEdit1View
            // 
            this.SearchLookUpEdit1View.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(204)))), ((int)(((byte)(132)))));
            this.SearchLookUpEdit1View.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.SearchLookUpEdit1View.Appearance.FocusedRow.Options.UseBackColor = true;
            this.SearchLookUpEdit1View.Appearance.FocusedRow.Options.UseForeColor = true;
            this.SearchLookUpEdit1View.Appearance.Row.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.SearchLookUpEdit1View.Appearance.Row.Options.UseFont = true;
            this.SearchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.GridColumn1,
            this.GridColumn2});
            this.SearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.SearchLookUpEdit1View.Name = "SearchLookUpEdit1View";
            this.SearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.SearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            this.SearchLookUpEdit1View.OptionsView.ShowIndicator = false;
            this.SearchLookUpEdit1View.RowHeight = 40;
            // 
            // GridColumn1
            // 
            this.GridColumn1.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.GridColumn1.AppearanceHeader.Options.UseFont = true;
            this.GridColumn1.Caption = "MÃ QT";
            this.GridColumn1.FieldName = "MAQT";
            this.GridColumn1.Name = "GridColumn1";
            this.GridColumn1.Visible = true;
            this.GridColumn1.VisibleIndex = 0;
            // 
            // GridColumn2
            // 
            this.GridColumn2.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.GridColumn2.AppearanceHeader.Options.UseFont = true;
            this.GridColumn2.Caption = "QUỐC TỊCH";
            this.GridColumn2.FieldName = "QUOCTICH";
            this.GridColumn2.Name = "GridColumn2";
            this.GridColumn2.Visible = true;
            this.GridColumn2.VisibleIndex = 1;
            // 
            // KhachSearch
            // 
            this.KhachSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.KhachSearch.EditValue = "";
            this.KhachSearch.Location = new System.Drawing.Point(10, 220);
            this.KhachSearch.MenuManager = this.BarManager;
            this.KhachSearch.Name = "KhachSearch";
            this.KhachSearch.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.KhachSearch.Properties.Appearance.Options.UseFont = true;
            this.KhachSearch.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.KhachSearch.Size = new System.Drawing.Size(290, 36);
            this.KhachSearch.TabIndex = 23;
            this.KhachSearch.TextChanged += new System.EventHandler(this.KhachSearch_TextChanged);
            // 
            // LabelControl5
            // 
            this.LabelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.LabelControl5.Appearance.Options.UseFont = true;
            this.LabelControl5.Location = new System.Drawing.Point(10, 184);
            this.LabelControl5.Name = "LabelControl5";
            this.LabelControl5.Size = new System.Drawing.Size(91, 30);
            this.LabelControl5.TabIndex = 24;
            this.LabelControl5.Text = "Tìm Kiếm";
            // 
            // LabelControl2
            // 
            this.LabelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.LabelControl2.Appearance.Options.UseFont = true;
            this.LabelControl2.Location = new System.Drawing.Point(10, 95);
            this.LabelControl2.Name = "LabelControl2";
            this.LabelControl2.Size = new System.Drawing.Size(89, 30);
            this.LabelControl2.TabIndex = 29;
            this.LabelControl2.Text = "Quốc Gia";
            // 
            // LabelControl1
            // 
            this.LabelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.LabelControl1.Appearance.Options.UseFont = true;
            this.LabelControl1.Location = new System.Drawing.Point(10, 3);
            this.LabelControl1.Name = "LabelControl1";
            this.LabelControl1.Size = new System.Drawing.Size(85, 30);
            this.LabelControl1.TabIndex = 27;
            this.LabelControl1.Text = "Giới Tính";
            // 
            // SuaPopOn
            // 
            this.SuaPopOn.Caption = "CẬP NHẬT";
            this.SuaPopOn.Id = 5;
            this.SuaPopOn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("SuaPopOn.ImageOptions.SvgImage")));
            this.SuaPopOn.Name = "SuaPopOn";
            this.SuaPopOn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.NutSua_ItemClick);
            // 
            // BangDuLieu
            // 
            this.BangDuLieu.AllowUserToAddRows = false;
            this.BangDuLieu.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.BangDuLieu.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.BangDuLieu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BangDuLieu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
            this.BangDuLieu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BangDuLieu.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.BangDuLieu.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(107)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BangDuLieu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.BangDuLieu.ColumnHeadersHeight = 40;
            this.BangDuLieu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDKHACH,
            this.HOVATEN,
            this.MAGT,
            this.TENGIONG,
            this.SOLIENHE,
            this.EMAIL,
            this.QUEQUAN,
            this.MAQT,
            this.TENNUOC});
            this.BangDuLieu.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(204)))), ((int)(((byte)(132)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BangDuLieu.DefaultCellStyle = dataGridViewCellStyle6;
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
            this.BangDuLieu.TabIndex = 12;
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
            this.BangDuLieu.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BangDuLieu.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.BangDuLieu.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.BangDuLieu.ThemeStyle.HeaderStyle.Height = 40;
            this.BangDuLieu.ThemeStyle.ReadOnly = true;
            this.BangDuLieu.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.BangDuLieu.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.BangDuLieu.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BangDuLieu.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.BangDuLieu.ThemeStyle.RowsStyle.Height = 40;
            this.BangDuLieu.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(204)))), ((int)(((byte)(132)))));
            this.BangDuLieu.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.BangDuLieu.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.BangDuLieu_ColumnHeaderMouseClick);
            this.BangDuLieu.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BangDuLieu_MouseClick);
            // 
            // IDKHACH
            // 
            this.IDKHACH.DataPropertyName = "IDKHACH";
            this.IDKHACH.HeaderText = "MÃ KHÁCH HÀNG";
            this.IDKHACH.MinimumWidth = 6;
            this.IDKHACH.Name = "IDKHACH";
            this.IDKHACH.ReadOnly = true;
            // 
            // HOVATEN
            // 
            this.HOVATEN.DataPropertyName = "HOVATEN";
            this.HOVATEN.HeaderText = "HỌ VÀ TÊN";
            this.HOVATEN.MinimumWidth = 6;
            this.HOVATEN.Name = "HOVATEN";
            this.HOVATEN.ReadOnly = true;
            // 
            // MAGT
            // 
            this.MAGT.DataPropertyName = "MAGT";
            this.MAGT.HeaderText = "MÃ GIỚI TÍNH";
            this.MAGT.MinimumWidth = 6;
            this.MAGT.Name = "MAGT";
            this.MAGT.ReadOnly = true;
            this.MAGT.Visible = false;
            // 
            // TENGIONG
            // 
            this.TENGIONG.DataPropertyName = "GIOITINH";
            this.TENGIONG.HeaderText = "GIỚI TÍNH";
            this.TENGIONG.MinimumWidth = 6;
            this.TENGIONG.Name = "TENGIONG";
            this.TENGIONG.ReadOnly = true;
            // 
            // SOLIENHE
            // 
            this.SOLIENHE.DataPropertyName = "SOLIENHE";
            this.SOLIENHE.HeaderText = "SỐ LIÊN HỆ";
            this.SOLIENHE.MinimumWidth = 6;
            this.SOLIENHE.Name = "SOLIENHE";
            this.SOLIENHE.ReadOnly = true;
            // 
            // EMAIL
            // 
            this.EMAIL.DataPropertyName = "EMAIL";
            this.EMAIL.HeaderText = "EMAIL";
            this.EMAIL.MinimumWidth = 6;
            this.EMAIL.Name = "EMAIL";
            this.EMAIL.ReadOnly = true;
            // 
            // QUEQUAN
            // 
            this.QUEQUAN.DataPropertyName = "QUEQUAN";
            this.QUEQUAN.HeaderText = "QUÊN QUÁN";
            this.QUEQUAN.MinimumWidth = 6;
            this.QUEQUAN.Name = "QUEQUAN";
            this.QUEQUAN.ReadOnly = true;
            // 
            // MAQT
            // 
            this.MAQT.DataPropertyName = "MAQT";
            this.MAQT.HeaderText = "MÃ QUỐC TỊCH";
            this.MAQT.MinimumWidth = 6;
            this.MAQT.Name = "MAQT";
            this.MAQT.ReadOnly = true;
            this.MAQT.Visible = false;
            // 
            // TENNUOC
            // 
            this.TENNUOC.DataPropertyName = "QUOCTICH";
            this.TENNUOC.HeaderText = "QUỐC TỊCH";
            this.TENNUOC.MinimumWidth = 6;
            this.TENNUOC.Name = "TENNUOC";
            this.TENNUOC.ReadOnly = true;
            // 
            // BangTuyChonKhach
            // 
            this.BangTuyChonKhach.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.SuaPopOn)});
            this.BangTuyChonKhach.Manager = this.BarManager;
            this.BangTuyChonKhach.Name = "BangTuyChonKhach";
            // 
            // Lock
            // 
            this.Lock.Interval = 500;
            this.Lock.Tick += new System.EventHandler(this.KhachSearchAfterTyping);
            // 
            // KhachHangForm
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
            this.Name = "KhachHangForm";
            this.Text = "KHÁCH HÀNG";
            this.Load += new System.EventHandler(this.KhachHangForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DockManager)).EndInit();
            this.ThanhPhanLoai.ResumeLayout(false);
            this.DockPanel1_Container.ResumeLayout(false);
            this.DockPanel1_Container.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GioiTinh_SLUE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuocTich_SLUE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KhachSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BangDuLieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BangTuyChonKhach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager BarManager;
        private DevExpress.XtraBars.Bar Bar1;
        private DevExpress.XtraBars.BarButtonItem NutThem;
        private DevExpress.XtraBars.BarDockControl BarDockControlTop;
        private DevExpress.XtraBars.BarDockControl BarDockControlBottom;
        private DevExpress.XtraBars.BarDockControl BarDockControlLeft;
        private DevExpress.XtraBars.BarDockControl BarDockControlRight;
        private DevExpress.XtraBars.Docking.DockManager DockManager;
        private DevExpress.XtraBars.Docking.DockPanel ThanhPhanLoai;
        private DevExpress.XtraBars.Docking.ControlContainer DockPanel1_Container;
        private Guna.UI2.WinForms.Guna2DataGridView BangDuLieu;
        private DevExpress.XtraEditors.LabelControl LabelControl1;
        private DevExpress.XtraEditors.LabelControl LabelControl2;
        private DevExpress.XtraEditors.SearchControl KhachSearch;
        private DevExpress.XtraEditors.LabelControl LabelControl5;
        private DevExpress.XtraEditors.SearchLookUpEdit QuocTich_SLUE;
        private DevExpress.XtraGrid.Views.Grid.GridView SearchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn GridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn GridColumn2;
        private DevExpress.XtraEditors.SearchLookUpEdit GioiTinh_SLUE;
        private DevExpress.XtraGrid.Views.Grid.GridView GridView1;
        private DevExpress.XtraGrid.Columns.GridColumn GridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn GridColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDKHACH;
        private System.Windows.Forms.DataGridViewTextBoxColumn HOVATEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAGT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENGIONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOLIENHE;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMAIL;
        private System.Windows.Forms.DataGridViewTextBoxColumn QUEQUAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAQT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENNUOC;
        private DevExpress.XtraBars.BarButtonItem SuaPopOn;
        private DevExpress.XtraBars.PopupMenu BangTuyChonKhach;
        private System.Windows.Forms.Timer Lock;
    }
}