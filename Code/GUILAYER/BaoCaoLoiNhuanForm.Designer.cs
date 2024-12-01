namespace GUILAYER
{
    partial class BaoCaoLoiNhuanForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaoCaoLoiNhuanForm));
            this.AccordionControl = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.ThongKeDoanhThu = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.ThongKeTheoM = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.ThongKeTheoD = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.PhanTichDoanhThu = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.PhanTichTheoM = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.PhanTichTheoD = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.Screens = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.AccordionControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Screens)).BeginInit();
            this.SuspendLayout();
            // 
            // AccordionControl
            // 
            this.AccordionControl.Appearance.AccordionControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(96)))), ((int)(((byte)(130)))));
            this.AccordionControl.Appearance.AccordionControl.Options.UseBackColor = true;
            this.AccordionControl.Appearance.Group.Default.ForeColor = System.Drawing.Color.White;
            this.AccordionControl.Appearance.Group.Default.Options.UseForeColor = true;
            this.AccordionControl.Appearance.Item.Hovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(204)))), ((int)(((byte)(132)))));
            this.AccordionControl.Appearance.Item.Hovered.ForeColor = System.Drawing.Color.Black;
            this.AccordionControl.Appearance.Item.Hovered.Options.UseBackColor = true;
            this.AccordionControl.Appearance.Item.Hovered.Options.UseForeColor = true;
            this.AccordionControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AccordionControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.AccordionControl.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.ThongKeDoanhThu,
            this.PhanTichDoanhThu});
            this.AccordionControl.Location = new System.Drawing.Point(0, 0);
            this.AccordionControl.Margin = new System.Windows.Forms.Padding(185, 185, 185, 185);
            this.AccordionControl.Name = "AccordionControl";
            this.AccordionControl.Size = new System.Drawing.Size(310, 741);
            this.AccordionControl.TabIndex = 0;
            this.AccordionControl.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            this.AccordionControl.ElementClick += new DevExpress.XtraBars.Navigation.ElementClickEventHandler(this.Menu_ItemClick);
            // 
            // ThongKeDoanhThu
            // 
            this.ThongKeDoanhThu.Appearance.Default.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThongKeDoanhThu.Appearance.Default.Options.UseFont = true;
            this.ThongKeDoanhThu.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.ThongKeTheoM,
            this.ThongKeTheoD});
            this.ThongKeDoanhThu.Expanded = true;
            this.ThongKeDoanhThu.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ThongKeDoanhThu.ImageOptions.SvgImage")));
            this.ThongKeDoanhThu.Name = "ThongKeDoanhThu";
            this.ThongKeDoanhThu.Text = "THỐNG KÊ";
            // 
            // ThongKeTheoM
            // 
            this.ThongKeTheoM.Appearance.Default.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.ThongKeTheoM.Appearance.Default.Options.UseFont = true;
            this.ThongKeTheoM.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ThongKeTheoM.ImageOptions.SvgImage")));
            this.ThongKeTheoM.Name = "ThongKeTheoM";
            this.ThongKeTheoM.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.ThongKeTheoM.Text = "THEO THÁNG";
            // 
            // ThongKeTheoD
            // 
            this.ThongKeTheoD.Appearance.Default.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.ThongKeTheoD.Appearance.Default.Options.UseFont = true;
            this.ThongKeTheoD.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ThongKeTheoD.ImageOptions.SvgImage")));
            this.ThongKeTheoD.Name = "ThongKeTheoD";
            this.ThongKeTheoD.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.ThongKeTheoD.Text = "THEO NGÀY";
            // 
            // PhanTichDoanhThu
            // 
            this.PhanTichDoanhThu.Appearance.Default.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhanTichDoanhThu.Appearance.Default.Options.UseFont = true;
            this.PhanTichDoanhThu.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.PhanTichTheoM,
            this.PhanTichTheoD});
            this.PhanTichDoanhThu.Expanded = true;
            this.PhanTichDoanhThu.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("PhanTichDoanhThu.ImageOptions.SvgImage")));
            this.PhanTichDoanhThu.Name = "PhanTichDoanhThu";
            this.PhanTichDoanhThu.Text = "PHÂN TÍCH";
            // 
            // PhanTichTheoM
            // 
            this.PhanTichTheoM.Appearance.Default.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.PhanTichTheoM.Appearance.Default.Options.UseFont = true;
            this.PhanTichTheoM.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("PhanTichTheoM.ImageOptions.SvgImage")));
            this.PhanTichTheoM.Name = "PhanTichTheoM";
            this.PhanTichTheoM.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.PhanTichTheoM.Text = "THEO THÁNG";
            // 
            // PhanTichTheoD
            // 
            this.PhanTichTheoD.Appearance.Default.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.PhanTichTheoD.Appearance.Default.Options.UseFont = true;
            this.PhanTichTheoD.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("PhanTichTheoD.ImageOptions.SvgImage")));
            this.PhanTichTheoD.Name = "PhanTichTheoD";
            this.PhanTichTheoD.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.PhanTichTheoD.Text = "THEO NGÀY";
            // 
            // Screens
            // 
            this.Screens.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Screens.Location = new System.Drawing.Point(310, 0);
            this.Screens.Margin = new System.Windows.Forms.Padding(185, 185, 185, 185);
            this.Screens.Name = "Screens";
            this.Screens.Size = new System.Drawing.Size(1573, 741);
            this.Screens.TabIndex = 1;
            // 
            // BaoCaoLoiNhuanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1883, 741);
            this.Controls.Add(this.Screens);
            this.Controls.Add(this.AccordionControl);
            this.IconOptions.Image = global::GUILAYER.Properties.Resources.Logo;
            this.Name = "BaoCaoLoiNhuanForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THỐNG KÊ DOANH THU";
            ((System.ComponentModel.ISupportInitialize)(this.AccordionControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Screens)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.AccordionControl AccordionControl;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ThongKeDoanhThu;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ThongKeTheoM;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ThongKeTheoD;
        private DevExpress.XtraBars.Navigation.AccordionControlElement PhanTichDoanhThu;
        private DevExpress.XtraBars.Navigation.AccordionControlElement PhanTichTheoM;
        private DevExpress.XtraBars.Navigation.AccordionControlElement PhanTichTheoD;
        private DevExpress.XtraEditors.PanelControl Screens;
    }
}