using LOGICLAYER;
using System;
using System.Linq;
using System.Windows.Forms;

namespace GUILAYER
{
    public partial class ThongTinKhachSan : DevExpress.XtraEditors.XtraForm
    {
        public ThongTinKhachSan()
        {
            InitializeComponent();
        }

        public void Account_Load()
        {
            MailUsername.Text = Environment.GetEnvironmentVariable("MailUsername", EnvironmentVariableTarget.User);

            MailPassword.Text = Environment.GetEnvironmentVariable("MailPassword", EnvironmentVariableTarget.User);

            SetHotNumber.Text = Environment.GetEnvironmentVariable("PhoneNumber", EnvironmentVariableTarget.User);
        }

        private void Form_Load(object sender, EventArgs e)
        {
            Account_Load();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            if (HamChucNang.ShowAlert("Bạn có muốn thay đổi thông tin tài khoản của khách sạn?") == DialogResult.OK)
            {
                String GetMailUsername = MailUsername.Text.ToUpper().Trim();

                Environment.SetEnvironmentVariable("MailUsername", GetMailUsername, EnvironmentVariableTarget.User);

                String GetMailPassword = MailPassword.Text.ToUpper().Trim();

                Environment.SetEnvironmentVariable("MailPassword", GetMailPassword, EnvironmentVariableTarget.User);

                String SetUpPhoneNumber = SetHotNumber.Text.Trim();

                Environment.SetEnvironmentVariable("PhoneNumber", SetUpPhoneNumber, EnvironmentVariableTarget.User);

                Account_Load();
            }
            else
            {
                Account_Load();
            }
        }
    }
}