namespace GUILAYER
{
    partial class BinForm
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
            this.Image = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.Image.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // Image
            // 
            this.Image.AllowDrop = true;
            this.Image.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Image.EditValue = global::GUILAYER.Properties.Resources.Bin;
            this.Image.Location = new System.Drawing.Point(0, 0);
            this.Image.Margin = new System.Windows.Forms.Padding(4);
            this.Image.Name = "Image";
            this.Image.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.Image.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.Image.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.Image.Size = new System.Drawing.Size(300, 300);
            this.Image.TabIndex = 0;
            this.Image.DragDrop += new System.Windows.Forms.DragEventHandler(this.Image_DragDrop);
            this.Image.DragEnter += new System.Windows.Forms.DragEventHandler(this.Image_DragEnter);
            // 
            // BinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.Image);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IconOptions.Image = global::GUILAYER.Properties.Resources.Logo;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BinForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recycle Bin";
            ((System.ComponentModel.ISupportInitialize)(this.Image.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PictureEdit Image;
    }
}