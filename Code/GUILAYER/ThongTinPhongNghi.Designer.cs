namespace GUILAYER
{
    partial class ThongTinPhongNghi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThongTinPhongNghi));
            this.GroupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.LabelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.TrangThai = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.GridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.LabelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.TinhTrang = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.GridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Loai_SLUE = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.GridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Tang_SLUE = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.GridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.TenPhong = new DevExpress.XtraEditors.TextEdit();
            this.LabelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.MaSoPhong = new DevExpress.XtraEditors.TextEdit();
            this.LabelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.NutHuy = new DevExpress.XtraEditors.SimpleButton();
            this.NutOK = new DevExpress.XtraEditors.SimpleButton();
            this.GridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GroupControl1)).BeginInit();
            this.GroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrangThai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TinhTrang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Loai_SLUE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tang_SLUE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TenPhong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaSoPhong.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupControl1
            // 
            this.GroupControl1.Controls.Add(this.LabelControl6);
            this.GroupControl1.Controls.Add(this.TrangThai);
            this.GroupControl1.Controls.Add(this.LabelControl5);
            this.GroupControl1.Controls.Add(this.TinhTrang);
            this.GroupControl1.Controls.Add(this.Loai_SLUE);
            this.GroupControl1.Controls.Add(this.Tang_SLUE);
            this.GroupControl1.Controls.Add(this.TenPhong);
            this.GroupControl1.Controls.Add(this.LabelControl4);
            this.GroupControl1.Controls.Add(this.LabelControl3);
            this.GroupControl1.Controls.Add(this.LabelControl2);
            this.GroupControl1.Controls.Add(this.MaSoPhong);
            this.GroupControl1.Controls.Add(this.LabelControl1);
            this.GroupControl1.Location = new System.Drawing.Point(12, 12);
            this.GroupControl1.Name = "GroupControl1";
            this.GroupControl1.Size = new System.Drawing.Size(808, 318);
            this.GroupControl1.TabIndex = 0;
            this.GroupControl1.Text = "THÔNG TIN PHÒNG";
            // 
            // LabelControl6
            // 
            this.LabelControl6.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.LabelControl6.Appearance.Options.UseFont = true;
            this.LabelControl6.Location = new System.Drawing.Point(14, 242);
            this.LabelControl6.Name = "LabelControl6";
            this.LabelControl6.Size = new System.Drawing.Size(100, 30);
            this.LabelControl6.TabIndex = 23;
            this.LabelControl6.Text = "Trạng Thái";
            // 
            // TrangThai
            // 
            this.TrangThai.Cursor = System.Windows.Forms.Cursors.No;
            this.TrangThai.EditValue = "AVAILABLE";
            this.TrangThai.Location = new System.Drawing.Point(128, 239);
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.TrangThai.Properties.Appearance.Options.UseFont = true;
            this.TrangThai.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TrangThai.Properties.DisplayMember = "TENTRANGTHAI";
            this.TrangThai.Properties.PopupView = this.GridView4;
            this.TrangThai.Properties.ReadOnly = true;
            this.TrangThai.Properties.ValueMember = "MATRANGTHAI";
            this.TrangThai.Size = new System.Drawing.Size(290, 36);
            this.TrangThai.TabIndex = 22;
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
            this.GridColumn7,
            this.GridColumn8});
            this.GridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.GridView4.Name = "GridView4";
            this.GridView4.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.GridView4.OptionsView.ShowGroupPanel = false;
            this.GridView4.OptionsView.ShowIndicator = false;
            this.GridView4.RowHeight = 40;
            // 
            // LabelControl5
            // 
            this.LabelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.LabelControl5.Appearance.Options.UseFont = true;
            this.LabelControl5.Location = new System.Drawing.Point(14, 174);
            this.LabelControl5.Name = "LabelControl5";
            this.LabelControl5.Size = new System.Drawing.Size(101, 30);
            this.LabelControl5.TabIndex = 21;
            this.LabelControl5.Text = "Tình Trạng";
            // 
            // TinhTrang
            // 
            this.TinhTrang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TinhTrang.Location = new System.Drawing.Point(128, 171);
            this.TinhTrang.Name = "TinhTrang";
            this.TinhTrang.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.TinhTrang.Properties.Appearance.Options.UseFont = true;
            this.TinhTrang.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TinhTrang.Properties.DisplayMember = "TENTINHTRANG";
            this.TinhTrang.Properties.PopupView = this.GridView3;
            this.TinhTrang.Properties.ValueMember = "MATINHTRANG";
            this.TinhTrang.Size = new System.Drawing.Size(290, 36);
            this.TinhTrang.TabIndex = 20;
            // 
            // GridView3
            // 
            this.GridView3.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(204)))), ((int)(((byte)(132)))));
            this.GridView3.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.GridView3.Appearance.FocusedRow.Options.UseBackColor = true;
            this.GridView3.Appearance.FocusedRow.Options.UseForeColor = true;
            this.GridView3.Appearance.Row.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.GridView3.Appearance.Row.Options.UseFont = true;
            this.GridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.GridColumn6,
            this.GridColumn4});
            this.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.GridView3.Name = "GridView3";
            this.GridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.GridView3.OptionsView.ShowGroupPanel = false;
            this.GridView3.OptionsView.ShowIndicator = false;
            this.GridView3.RowHeight = 40;
            // 
            // Loai_SLUE
            // 
            this.Loai_SLUE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Loai_SLUE.Location = new System.Drawing.Point(506, 103);
            this.Loai_SLUE.Name = "Loai_SLUE";
            this.Loai_SLUE.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.Loai_SLUE.Properties.Appearance.Options.UseFont = true;
            this.Loai_SLUE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Loai_SLUE.Properties.DisplayMember = "TENLOAIPHONG";
            this.Loai_SLUE.Properties.PopupView = this.GridView2;
            this.Loai_SLUE.Properties.ValueMember = "MALOAIPHONG";
            this.Loai_SLUE.Size = new System.Drawing.Size(290, 36);
            this.Loai_SLUE.TabIndex = 19;
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
            // Tang_SLUE
            // 
            this.Tang_SLUE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Tang_SLUE.Location = new System.Drawing.Point(506, 34);
            this.Tang_SLUE.Name = "Tang_SLUE";
            this.Tang_SLUE.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.Tang_SLUE.Properties.Appearance.Options.UseFont = true;
            this.Tang_SLUE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Tang_SLUE.Properties.DisplayMember = "TENTANG";
            this.Tang_SLUE.Properties.PopupView = this.GridView1;
            this.Tang_SLUE.Properties.ValueMember = "TANGTHU";
            this.Tang_SLUE.Size = new System.Drawing.Size(290, 36);
            this.Tang_SLUE.TabIndex = 18;
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
            this.GridColumn2,
            this.GridColumn1});
            this.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.GridView1.Name = "GridView1";
            this.GridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.GridView1.OptionsView.ShowGroupPanel = false;
            this.GridView1.OptionsView.ShowIndicator = false;
            this.GridView1.RowHeight = 40;
            // 
            // TenPhong
            // 
            this.TenPhong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TenPhong.Location = new System.Drawing.Point(128, 103);
            this.TenPhong.Name = "TenPhong";
            this.TenPhong.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.TenPhong.Properties.Appearance.Options.UseFont = true;
            this.TenPhong.Size = new System.Drawing.Size(290, 36);
            this.TenPhong.TabIndex = 17;
            // 
            // LabelControl4
            // 
            this.LabelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.LabelControl4.Appearance.Options.UseFont = true;
            this.LabelControl4.Location = new System.Drawing.Point(14, 106);
            this.LabelControl4.Name = "LabelControl4";
            this.LabelControl4.Size = new System.Drawing.Size(104, 30);
            this.LabelControl4.TabIndex = 16;
            this.LabelControl4.Text = "Tên Phòng";
            // 
            // LabelControl3
            // 
            this.LabelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.LabelControl3.Appearance.Options.UseFont = true;
            this.LabelControl3.Location = new System.Drawing.Point(446, 106);
            this.LabelControl3.Name = "LabelControl3";
            this.LabelControl3.Size = new System.Drawing.Size(39, 30);
            this.LabelControl3.TabIndex = 14;
            this.LabelControl3.Text = "Loại";
            // 
            // LabelControl2
            // 
            this.LabelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.LabelControl2.Appearance.Options.UseFont = true;
            this.LabelControl2.Location = new System.Drawing.Point(446, 37);
            this.LabelControl2.Name = "LabelControl2";
            this.LabelControl2.Size = new System.Drawing.Size(48, 30);
            this.LabelControl2.TabIndex = 4;
            this.LabelControl2.Text = "Tầng";
            // 
            // MaSoPhong
            // 
            this.MaSoPhong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MaSoPhong.Location = new System.Drawing.Point(128, 39);
            this.MaSoPhong.Name = "MaSoPhong";
            this.MaSoPhong.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.MaSoPhong.Properties.Appearance.Options.UseFont = true;
            this.MaSoPhong.Size = new System.Drawing.Size(290, 36);
            this.MaSoPhong.TabIndex = 3;
            // 
            // LabelControl1
            // 
            this.LabelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.LabelControl1.Appearance.Options.UseFont = true;
            this.LabelControl1.Location = new System.Drawing.Point(14, 42);
            this.LabelControl1.Name = "LabelControl1";
            this.LabelControl1.Size = new System.Drawing.Size(99, 30);
            this.LabelControl1.TabIndex = 2;
            this.LabelControl1.Text = "Mã Phòng";
            // 
            // NutHuy
            // 
            this.NutHuy.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.NutHuy.Appearance.Options.UseFont = true;
            this.NutHuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NutHuy.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.NutHuy.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("NutHuy.ImageOptions.SvgImage")));
            this.NutHuy.Location = new System.Drawing.Point(616, 349);
            this.NutHuy.Name = "NutHuy";
            this.NutHuy.Size = new System.Drawing.Size(94, 46);
            this.NutHuy.TabIndex = 4;
            this.NutHuy.Text = "HỦY";
            // 
            // NutOK
            // 
            this.NutOK.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.NutOK.Appearance.Options.UseFont = true;
            this.NutOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NutOK.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("NutOK.ImageOptions.SvgImage")));
            this.NutOK.Location = new System.Drawing.Point(726, 349);
            this.NutOK.Name = "NutOK";
            this.NutOK.Size = new System.Drawing.Size(94, 46);
            this.NutOK.TabIndex = 3;
            this.NutOK.Text = "OK";
            this.NutOK.Click += new System.EventHandler(this.NutOK_Click);
            // 
            // GridColumn7
            // 
            this.GridColumn7.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.GridColumn7.AppearanceHeader.Options.UseFont = true;
            this.GridColumn7.Caption = "TÊN TRẠNG THÁI";
            this.GridColumn7.FieldName = "TENTRANGTHAI";
            this.GridColumn7.Name = "GridColumn7";
            this.GridColumn7.Visible = true;
            this.GridColumn7.VisibleIndex = 0;
            // 
            // GridColumn8
            // 
            this.GridColumn8.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.GridColumn8.AppearanceHeader.Options.UseFont = true;
            this.GridColumn8.Caption = "MÔ TẢ";
            this.GridColumn8.FieldName = "MOTA";
            this.GridColumn8.Name = "GridColumn8";
            this.GridColumn8.Visible = true;
            this.GridColumn8.VisibleIndex = 1;
            // 
            // GridColumn6
            // 
            this.GridColumn6.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.GridColumn6.AppearanceHeader.Options.UseFont = true;
            this.GridColumn6.Caption = "TÊN TÌNH TRẠNG";
            this.GridColumn6.FieldName = "TENTINHTRANG";
            this.GridColumn6.Name = "GridColumn6";
            this.GridColumn6.Visible = true;
            this.GridColumn6.VisibleIndex = 0;
            // 
            // GridColumn4
            // 
            this.GridColumn4.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.GridColumn4.AppearanceHeader.Options.UseFont = true;
            this.GridColumn4.Caption = "MÔ TẢ";
            this.GridColumn4.FieldName = "MOTA";
            this.GridColumn4.Name = "GridColumn4";
            this.GridColumn4.Visible = true;
            this.GridColumn4.VisibleIndex = 1;
            // 
            // GridColumn3
            // 
            this.GridColumn3.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.GridColumn3.AppearanceHeader.Options.UseFont = true;
            this.GridColumn3.Caption = "TÊN LOẠI";
            this.GridColumn3.FieldName = "TENLOAIPHONG";
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
            // GridColumn2
            // 
            this.GridColumn2.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.GridColumn2.AppearanceHeader.Options.UseFont = true;
            this.GridColumn2.Caption = "TẦNG THỨ";
            this.GridColumn2.FieldName = "TANGTHU";
            this.GridColumn2.Name = "GridColumn2";
            this.GridColumn2.Visible = true;
            this.GridColumn2.VisibleIndex = 0;
            // 
            // GridColumn1
            // 
            this.GridColumn1.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.GridColumn1.AppearanceHeader.Options.UseFont = true;
            this.GridColumn1.Caption = "TÊN TẦNG";
            this.GridColumn1.FieldName = "TENTANG";
            this.GridColumn1.Name = "GridColumn1";
            this.GridColumn1.Visible = true;
            this.GridColumn1.VisibleIndex = 1;
            // 
            // ThongTinPhongNghi
            // 
            this.AcceptButton = this.NutOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.NutHuy;
            this.ClientSize = new System.Drawing.Size(835, 408);
            this.Controls.Add(this.NutHuy);
            this.Controls.Add(this.NutOK);
            this.Controls.Add(this.GroupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IconOptions.Image = global::GUILAYER.Properties.Resources.Logo;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ThongTinPhongNghi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THÔNG TIN PHÒNG";
            this.Load += new System.EventHandler(this.ThemPhongForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GroupControl1)).EndInit();
            this.GroupControl1.ResumeLayout(false);
            this.GroupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrangThai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TinhTrang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Loai_SLUE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tang_SLUE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TenPhong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaSoPhong.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl GroupControl1;
        private DevExpress.XtraEditors.TextEdit MaSoPhong;
        private DevExpress.XtraEditors.LabelControl LabelControl1;
        private DevExpress.XtraEditors.LabelControl LabelControl2;
        private DevExpress.XtraEditors.LabelControl LabelControl3;
        private DevExpress.XtraEditors.SimpleButton NutHuy;
        private DevExpress.XtraEditors.SimpleButton NutOK;
        private DevExpress.XtraEditors.TextEdit TenPhong;
        private DevExpress.XtraEditors.LabelControl LabelControl4;
        private DevExpress.XtraEditors.SearchLookUpEdit Tang_SLUE;
        private DevExpress.XtraGrid.Views.Grid.GridView GridView1;
        private DevExpress.XtraGrid.Columns.GridColumn GridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn GridColumn1;
        private DevExpress.XtraEditors.SearchLookUpEdit Loai_SLUE;
        private DevExpress.XtraGrid.Views.Grid.GridView GridView2;
        private DevExpress.XtraGrid.Columns.GridColumn GridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn GridColumn5;
        private DevExpress.XtraEditors.LabelControl LabelControl5;
        private DevExpress.XtraEditors.SearchLookUpEdit TinhTrang;
        private DevExpress.XtraGrid.Views.Grid.GridView GridView3;
        private DevExpress.XtraGrid.Columns.GridColumn GridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn GridColumn4;
        private DevExpress.XtraEditors.LabelControl LabelControl6;
        private DevExpress.XtraEditors.SearchLookUpEdit TrangThai;
        private DevExpress.XtraGrid.Views.Grid.GridView GridView4;
        private DevExpress.XtraGrid.Columns.GridColumn GridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn GridColumn8;
    }
}