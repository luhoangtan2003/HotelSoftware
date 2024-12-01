namespace GUILAYER
{
    partial class ChuongThongBaoForm
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
            this.LabelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.Picture = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelControl1
            // 
            this.LabelControl1.Appearance.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl1.Appearance.Options.UseFont = true;
            this.LabelControl1.Location = new System.Drawing.Point(158, 65);
            this.LabelControl1.Name = "LabelControl1";
            this.LabelControl1.Size = new System.Drawing.Size(355, 20);
            this.LabelControl1.TabIndex = 7;
            this.LabelControl1.Text = "SẮP/ĐANG CÓ GIAO DỊCH CẦN XỬ LÝ";
            // 
            // Picture
            // 
            this.Picture.Dock = System.Windows.Forms.DockStyle.Left;
            this.Picture.EditValue = global::GUILAYER.Properties.Resources.Transaction;
            this.Picture.Location = new System.Drawing.Point(0, 0);
            this.Picture.Name = "Picture";
            this.Picture.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.Picture.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.Picture.Properties.ShowMenu = false;
            this.Picture.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.Picture.Size = new System.Drawing.Size(150, 150);
            this.Picture.TabIndex = 0;
            // 
            // ChuongThongBaoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 150);
            this.Controls.Add(this.LabelControl1);
            this.Controls.Add(this.Picture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IconOptions.Image = global::GUILAYER.Properties.Resources.Logo;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChuongThongBaoForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "CHUÔNG THÔNG BÁO";
            this.TopMost = true;
            this.LocationChanged += new System.EventHandler(this.Form_LocationChanged);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.Picture.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PictureEdit Picture;
        private DevExpress.XtraEditors.LabelControl LabelControl1;
    }
}