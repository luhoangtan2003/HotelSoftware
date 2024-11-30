namespace GUILAYER
{
    partial class ThongTinNhanPhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThongTinNhanPhong));
            this.LabelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.IDKhach = new DevExpress.XtraEditors.TextEdit();
            this.NutOK = new DevExpress.XtraEditors.SimpleButton();
            this.NutHuy = new DevExpress.XtraEditors.SimpleButton();
            this.KhachHang_SLUE = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.GridView9 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GridColumn17 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GridColumn18 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ThongBaoDatPhong = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.IDKhach.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KhachHang_SLUE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView9)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelControl1
            // 
            this.LabelControl1.Appearance.Font = new System.Drawing.Font("Verdana", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl1.Appearance.Options.UseFont = true;
            this.LabelControl1.Location = new System.Drawing.Point(12, 12);
            this.LabelControl1.Name = "LabelControl1";
            this.LabelControl1.Size = new System.Drawing.Size(279, 26);
            this.LabelControl1.TabIndex = 0;
            this.LabelControl1.Text = "NHẬP MÃ CCCD/CMND";
            // 
            // IDKhach
            // 
            this.IDKhach.Location = new System.Drawing.Point(12, 117);
            this.IDKhach.Name = "IDKhach";
            this.IDKhach.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.IDKhach.Properties.Appearance.Options.UseFont = true;
            this.IDKhach.Size = new System.Drawing.Size(292, 36);
            this.IDKhach.TabIndex = 1;
            // 
            // NutOK
            // 
            this.NutOK.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.NutOK.Appearance.Options.UseFont = true;
            this.NutOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NutOK.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("NutOK.ImageOptions.SvgImage")));
            this.NutOK.Location = new System.Drawing.Point(210, 169);
            this.NutOK.Name = "NutOK";
            this.NutOK.Size = new System.Drawing.Size(94, 46);
            this.NutOK.TabIndex = 3;
            this.NutOK.Text = "OK";
            this.NutOK.Click += new System.EventHandler(this.NutOK_Click);
            // 
            // NutHuy
            // 
            this.NutHuy.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.NutHuy.Appearance.Options.UseFont = true;
            this.NutHuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NutHuy.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.NutHuy.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("NutHuy.ImageOptions.SvgImage")));
            this.NutHuy.Location = new System.Drawing.Point(98, 169);
            this.NutHuy.Name = "NutHuy";
            this.NutHuy.Size = new System.Drawing.Size(94, 46);
            this.NutHuy.TabIndex = 4;
            this.NutHuy.Text = "HỦY";
            // 
            // KhachHang_SLUE
            // 
            this.KhachHang_SLUE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KhachHang_SLUE.Enabled = false;
            this.KhachHang_SLUE.Location = new System.Drawing.Point(12, 57);
            this.KhachHang_SLUE.Name = "KhachHang_SLUE";
            this.KhachHang_SLUE.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.KhachHang_SLUE.Properties.Appearance.Options.UseFont = true;
            this.KhachHang_SLUE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.KhachHang_SLUE.Properties.DisplayMember = "HOVATEN";
            this.KhachHang_SLUE.Properties.PopupView = this.GridView9;
            this.KhachHang_SLUE.Properties.ValueMember = "IDKHACH";
            this.KhachHang_SLUE.Size = new System.Drawing.Size(292, 36);
            this.KhachHang_SLUE.TabIndex = 18;
            // 
            // GridView9
            // 
            this.GridView9.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(204)))), ((int)(((byte)(132)))));
            this.GridView9.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.GridView9.Appearance.FocusedRow.Options.UseBackColor = true;
            this.GridView9.Appearance.FocusedRow.Options.UseForeColor = true;
            this.GridView9.Appearance.Row.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.GridView9.Appearance.Row.Options.UseFont = true;
            this.GridView9.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.GridColumn17,
            this.GridColumn18});
            this.GridView9.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.GridView9.Name = "GridView9";
            this.GridView9.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.GridView9.OptionsView.ShowGroupPanel = false;
            this.GridView9.OptionsView.ShowIndicator = false;
            this.GridView9.RowHeight = 40;
            // 
            // GridColumn17
            // 
            this.GridColumn17.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.GridColumn17.AppearanceHeader.Options.UseFont = true;
            this.GridColumn17.Caption = "ID KHÁCH";
            this.GridColumn17.FieldName = "IDKHACH";
            this.GridColumn17.Name = "GridColumn17";
            this.GridColumn17.Visible = true;
            this.GridColumn17.VisibleIndex = 0;
            // 
            // GridColumn18
            // 
            this.GridColumn18.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.GridColumn18.AppearanceHeader.Options.UseFont = true;
            this.GridColumn18.Caption = "HỌ VÀ TÊN";
            this.GridColumn18.FieldName = "HOVATEN";
            this.GridColumn18.Name = "GridColumn18";
            this.GridColumn18.Visible = true;
            this.GridColumn18.VisibleIndex = 1;
            // 
            // ThongBaoDatPhong
            // 
            this.ThongBaoDatPhong.AllowHotTrack = false;
            this.ThongBaoDatPhong.AppearanceCaption.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThongBaoDatPhong.AppearanceCaption.Options.UseFont = true;
            this.ThongBaoDatPhong.AppearanceText.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThongBaoDatPhong.AppearanceText.Options.UseFont = true;
            this.ThongBaoDatPhong.BeforeFormShow += new DevExpress.XtraBars.Alerter.AlertFormEventHandler(this.DinhDangKhungThongBao_BeforeFormShow);
            // 
            // ThongTinNhanPhong
            // 
            this.AcceptButton = this.NutOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.NutHuy;
            this.ClientSize = new System.Drawing.Size(315, 228);
            this.Controls.Add(this.KhachHang_SLUE);
            this.Controls.Add(this.NutHuy);
            this.Controls.Add(this.NutOK);
            this.Controls.Add(this.IDKhach);
            this.Controls.Add(this.LabelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IconOptions.Image = global::GUILAYER.Properties.Resources.Logo;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ThongTinNhanPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THÔNG TIN NHẬN PHÒNG";
            this.Load += new System.EventHandler(this.FormLoading);
            ((System.ComponentModel.ISupportInitialize)(this.IDKhach.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KhachHang_SLUE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl LabelControl1;
        private DevExpress.XtraEditors.TextEdit IDKhach;
        private DevExpress.XtraEditors.SimpleButton NutOK;
        private DevExpress.XtraEditors.SimpleButton NutHuy;
        private DevExpress.XtraEditors.SearchLookUpEdit KhachHang_SLUE;
        private DevExpress.XtraGrid.Views.Grid.GridView GridView9;
        private DevExpress.XtraGrid.Columns.GridColumn GridColumn17;
        private DevExpress.XtraGrid.Columns.GridColumn GridColumn18;
        private DevExpress.XtraBars.Alerter.AlertControl ThongBaoDatPhong;
    }
}