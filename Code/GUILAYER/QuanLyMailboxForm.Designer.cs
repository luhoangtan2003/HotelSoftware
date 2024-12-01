namespace GUILAYER
{
    partial class QuanLyMailboxForm
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
            this.Mailbox = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)(this.Mailbox)).BeginInit();
            this.SuspendLayout();
            // 
            // Mailbox
            // 
            this.Mailbox.AllowExternalDrop = true;
            this.Mailbox.CreationProperties = null;
            this.Mailbox.DefaultBackgroundColor = System.Drawing.Color.White;
            this.Mailbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Mailbox.Location = new System.Drawing.Point(0, 0);
            this.Mailbox.Name = "Mailbox";
            this.Mailbox.Size = new System.Drawing.Size(1883, 741);
            this.Mailbox.TabIndex = 0;
            this.Mailbox.ZoomFactor = 1D;
            // 
            // QuanLyMailboxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1883, 741);
            this.Controls.Add(this.Mailbox);
            this.IconOptions.Image = global::GUILAYER.Properties.Resources.Logo;
            this.Name = "QuanLyMailboxForm";
            this.Text = "GMAIL";
            this.Load += new System.EventHandler(this.QuanLyMailboxForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Mailbox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 Mailbox;
    }
}