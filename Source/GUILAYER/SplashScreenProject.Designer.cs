namespace GUILAYER
{
    partial class SplashScreenProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreenProject));
            this.ProgressBarControl = new DevExpress.XtraEditors.MarqueeProgressBarControl();
            this.LabelCopyright = new DevExpress.XtraEditors.LabelControl();
            this.LabelStatus = new DevExpress.XtraEditors.LabelControl();
            this.PeImage = new DevExpress.XtraEditors.PictureEdit();
            this.PeLogo = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ProgressBarControl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PeImage.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PeLogo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ProgressBarControl
            // 
            this.ProgressBarControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProgressBarControl.EditValue = 0;
            this.ProgressBarControl.Location = new System.Drawing.Point(32, 286);
            this.ProgressBarControl.Margin = new System.Windows.Forms.Padding(4);
            this.ProgressBarControl.Name = "ProgressBarControl";
            this.ProgressBarControl.Size = new System.Drawing.Size(536, 15);
            this.ProgressBarControl.TabIndex = 5;
            // 
            // LabelCopyright
            // 
            this.LabelCopyright.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.LabelCopyright.Location = new System.Drawing.Point(32, 353);
            this.LabelCopyright.Margin = new System.Windows.Forms.Padding(4);
            this.LabelCopyright.Name = "LabelCopyright";
            this.LabelCopyright.Size = new System.Drawing.Size(160, 17);
            this.LabelCopyright.TabIndex = 6;
            this.LabelCopyright.Text = "Copyright By Lư Hoàng Tấn";
            // 
            // LabelStatus
            // 
            this.LabelStatus.Location = new System.Drawing.Point(32, 265);
            this.LabelStatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 1);
            this.LabelStatus.Name = "LabelStatus";
            this.LabelStatus.Size = new System.Drawing.Size(54, 17);
            this.LabelStatus.TabIndex = 7;
            this.LabelStatus.Text = "Starting...";
            // 
            // PeImage
            // 
            this.PeImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.PeImage.EditValue = global::GUILAYER.Properties.Resources.Background;
            this.PeImage.Location = new System.Drawing.Point(1, 1);
            this.PeImage.Margin = new System.Windows.Forms.Padding(4);
            this.PeImage.Name = "PeImage";
            this.PeImage.Properties.AllowFocused = false;
            this.PeImage.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.PeImage.Properties.Appearance.Options.UseBackColor = true;
            this.PeImage.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.PeImage.Properties.ShowMenu = false;
            this.PeImage.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.PeImage.Properties.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.None;
            this.PeImage.Size = new System.Drawing.Size(598, 246);
            this.PeImage.TabIndex = 9;
            // 
            // PeLogo
            // 
            this.PeLogo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PeLogo.EditValue = ((object)(resources.GetObject("PeLogo.EditValue")));
            this.PeLogo.Location = new System.Drawing.Point(372, 329);
            this.PeLogo.Margin = new System.Windows.Forms.Padding(4);
            this.PeLogo.Name = "PeLogo";
            this.PeLogo.Properties.AllowFocused = false;
            this.PeLogo.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.PeLogo.Properties.Appearance.Options.UseBackColor = true;
            this.PeLogo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.PeLogo.Properties.ShowMenu = false;
            this.PeLogo.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.PeLogo.Size = new System.Drawing.Size(211, 52);
            this.PeLogo.TabIndex = 8;
            // 
            // SplashScreenProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 394);
            this.Controls.Add(this.PeImage);
            this.Controls.Add(this.PeLogo);
            this.Controls.Add(this.LabelStatus);
            this.Controls.Add(this.LabelCopyright);
            this.Controls.Add(this.ProgressBarControl);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SplashScreenProject";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.Text = "SplashScreenProject";
            ((System.ComponentModel.ISupportInitialize)(this.ProgressBarControl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PeImage.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PeLogo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.MarqueeProgressBarControl ProgressBarControl;
        private DevExpress.XtraEditors.LabelControl LabelCopyright;
        private DevExpress.XtraEditors.LabelControl LabelStatus;
        private DevExpress.XtraEditors.PictureEdit PeLogo;
        private DevExpress.XtraEditors.PictureEdit PeImage;
    }
}
