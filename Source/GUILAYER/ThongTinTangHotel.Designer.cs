namespace GUILAYER
{
    partial class ThongTinTangHotel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThongTinTangHotel));
            this.GroupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.LabelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.TenTangKS = new DevExpress.XtraEditors.TextEdit();
            this.MaSoTang = new DevExpress.XtraEditors.SpinEdit();
            this.LabelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.NutHuy = new DevExpress.XtraEditors.SimpleButton();
            this.NutOK = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.GroupControl1)).BeginInit();
            this.GroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TenTangKS.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaSoTang.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupControl1
            // 
            this.GroupControl1.Controls.Add(this.LabelControl2);
            this.GroupControl1.Controls.Add(this.TenTangKS);
            this.GroupControl1.Controls.Add(this.MaSoTang);
            this.GroupControl1.Controls.Add(this.LabelControl1);
            this.GroupControl1.Location = new System.Drawing.Point(12, 12);
            this.GroupControl1.Name = "GroupControl1";
            this.GroupControl1.Size = new System.Drawing.Size(474, 217);
            this.GroupControl1.TabIndex = 0;
            this.GroupControl1.Text = "THÔNG TIN TẦNG";
            // 
            // LabelControl2
            // 
            this.LabelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.LabelControl2.Appearance.Options.UseFont = true;
            this.LabelControl2.Location = new System.Drawing.Point(20, 137);
            this.LabelControl2.Name = "LabelControl2";
            this.LabelControl2.Size = new System.Drawing.Size(88, 30);
            this.LabelControl2.TabIndex = 3;
            this.LabelControl2.Text = "Tên Tầng";
            // 
            // TenTangKS
            // 
            this.TenTangKS.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TenTangKS.Location = new System.Drawing.Point(142, 134);
            this.TenTangKS.Name = "TenTangKS";
            this.TenTangKS.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.TenTangKS.Properties.Appearance.Options.UseFont = true;
            this.TenTangKS.Size = new System.Drawing.Size(303, 36);
            this.TenTangKS.TabIndex = 2;
            // 
            // MaSoTang
            // 
            this.MaSoTang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MaSoTang.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.MaSoTang.Location = new System.Drawing.Point(142, 48);
            this.MaSoTang.Name = "MaSoTang";
            this.MaSoTang.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.MaSoTang.Properties.Appearance.Options.UseFont = true;
            this.MaSoTang.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.MaSoTang.Properties.IsFloatValue = false;
            this.MaSoTang.Properties.MaskSettings.Set("mask", "N00");
            this.MaSoTang.Size = new System.Drawing.Size(303, 36);
            this.MaSoTang.TabIndex = 1;
            // 
            // LabelControl1
            // 
            this.LabelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.LabelControl1.Appearance.Options.UseFont = true;
            this.LabelControl1.Location = new System.Drawing.Point(20, 54);
            this.LabelControl1.Name = "LabelControl1";
            this.LabelControl1.Size = new System.Drawing.Size(91, 30);
            this.LabelControl1.TabIndex = 0;
            this.LabelControl1.Text = "Tầng Thứ";
            // 
            // NutHuy
            // 
            this.NutHuy.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.NutHuy.Appearance.Options.UseFont = true;
            this.NutHuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NutHuy.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.NutHuy.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("NutHuy.ImageOptions.SvgImage")));
            this.NutHuy.Location = new System.Drawing.Point(279, 252);
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
            this.NutOK.Location = new System.Drawing.Point(391, 252);
            this.NutOK.Name = "NutOK";
            this.NutOK.Size = new System.Drawing.Size(94, 46);
            this.NutOK.TabIndex = 3;
            this.NutOK.Text = "OK";
            this.NutOK.Click += new System.EventHandler(this.NutOK_Click);
            // 
            // ThongTinTangHotel
            // 
            this.AcceptButton = this.NutOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.NutHuy;
            this.ClientSize = new System.Drawing.Size(498, 310);
            this.Controls.Add(this.NutHuy);
            this.Controls.Add(this.NutOK);
            this.Controls.Add(this.GroupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IconOptions.Image = global::GUILAYER.Properties.Resources.Logo;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ThongTinTangHotel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THÔNG TIN TẦNG";
            ((System.ComponentModel.ISupportInitialize)(this.GroupControl1)).EndInit();
            this.GroupControl1.ResumeLayout(false);
            this.GroupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TenTangKS.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaSoTang.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl GroupControl1;
        private DevExpress.XtraEditors.LabelControl LabelControl2;
        private DevExpress.XtraEditors.TextEdit TenTangKS;
        private DevExpress.XtraEditors.SpinEdit MaSoTang;
        private DevExpress.XtraEditors.LabelControl LabelControl1;
        private DevExpress.XtraEditors.SimpleButton NutHuy;
        private DevExpress.XtraEditors.SimpleButton NutOK;
    }
}