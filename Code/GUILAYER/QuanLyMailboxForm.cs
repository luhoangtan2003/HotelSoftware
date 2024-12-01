using LOGICLAYER;
using Microsoft.Web.WebView2.Core;
using System;
using System.IO;
using System.Linq;

#pragma warning disable CRR0034, CRR0033, CRR0029

namespace GUILAYER
{
    public partial class QuanLyMailboxForm : DevExpress.XtraEditors.XtraForm
    {
        public QuanLyMailboxForm()
        {
            InitializeComponent();
        }

        private async void QuanLyMailboxForm_Load(object sender, EventArgs e)
        {
            String WVData = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "LHT Hotel", "WebView2 Data");

            Directory.CreateDirectory(WVData);

            CoreWebView2Environment Envi = await CoreWebView2Environment.CreateAsync(null, WVData);

            if (!String.IsNullOrEmpty(CoreWebView2Environment.GetAvailableBrowserVersionString()))
            {
                await Mailbox.EnsureCoreWebView2Async(Envi);

                String PathMail = "https://mail.google.com";

                if (Uri.IsWellFormedUriString(PathMail, UriKind.Absolute))
                {
                    Mailbox.CoreWebView2.Navigate(PathMail);
                }
                else
                {
                    HamChucNang.ShowError("Đường dẫn url của bạn bị lỗi");

                    Close();
                }
            }
            else
            {
                HamChucNang.ShowError("Microsoft WebView2 chưa được cài đặt trên máy của bạn!!!");

                Close();
            }
        }
    }
}