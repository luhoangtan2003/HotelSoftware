using DATALAYER;
using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace LOGICLAYER
{
    public class NoticeToCustomers
    {
        String MailUsername = Environment.GetEnvironmentVariable("MailUsername", EnvironmentVariableTarget.User);

        String MailPassword = Environment.GetEnvironmentVariable("MailPassword", EnvironmentVariableTarget.User);

        String GetHotNumber = Environment.GetEnvironmentVariable("PhoneNumber", EnvironmentVariableTarget.User);

        String HotelSoftwareName = Application.ProductName;

        public SmtpClient SetConnect()
        {
            SmtpClient Client = new();

            Client.Timeout = 10000;

            Client.ServerCertificateValidationCallback = (Sender, Certificate, Chain, Policy)

                                       => Policy == System.Net.Security.SslPolicyErrors.None;

            Client.Connect("smtp.gmail.com", 587, SecureSocketOptions.StartTls);

            return Client;
        }

        public void SendMail(MimeMessage MessageBox)
        {
            if (HamChucNang.IsFieldNull(MessageBox))
            {
                return;
            }
            using SmtpClient Client = SetConnect();

            Client.Authenticate(MailUsername, MailPassword);

            Client.Send(MessageBox);

            Client.Disconnect(true);
        }

        public MimeMessage Building
        (
            String RecipientName,

            String RecipientMail,

            String SubjectMail, BodyBuilder Content
        )
        {
            MimeMessage Message = new MimeMessage();


            if (!IsValidEmail(MailUsername) || String.IsNullOrEmpty(MailPassword))
            {
                HamChucNang.ShowError("Thông tin người gửi không đúng hoặc thiếu");

                return null;
            }

            MailboxAddress SenderAddress = new MailboxAddress(HotelSoftwareName, MailUsername);

            Message.From.Add(SenderAddress);

            MailboxAddress RecipientAddress = new MailboxAddress(RecipientName, RecipientMail);

            Message.To.Add(RecipientAddress);

            Message.Subject = SubjectMail;

            Message.Body = Content.ToMessageBody();

            return Message;
        }

        public Boolean IsValidEmail(String Email)

        => !String.IsNullOrEmpty(Email) && Regex.IsMatch(Email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");


        public BodyBuilder NoiDungDatPhongThanhCong
        (
            KHACHHANG_TBL KhachHang,

            LOAIPHONG_TBL LoaiPhong,

            DatPhongOCustom DatPhong
        )
        {
            BodyBuilder Content = new BodyBuilder();

            Content.TextBody = $@"
                Thông báo đặt phòng thành công
                Kính chào {KhachHang.HOVATEN}
                Chúng tôi xin thông báo rằng đặt phòng của quý khách đã được hoàn tất với các thông tin sau:
                - Mã phòng đặt: {DatPhong.MAPHONGDAT}
                - Tên phòng nghỉ: {DatPhong.TENPHONG}
                - Phân loại: {LoaiPhong.TENLOAIPHONG}
                - Thời hạn: {DatPhong.THOIHAN}
                - Ngày đặt: {DatPhong.NGAYDAT}
                - Ngày lấy phòng: {DatPhong.NGAYLAY}
                - Ngày trả phòng: {DatPhong.NGAYTRA}
                - Loại hình: {DatPhong.TENLOAIHINH}
                - Giá phòng: {DatPhong.GIAPHONG:C0}
                - Trạng thái: {DatPhong.TENTRANGTHAI}
                - Ghi chú(nếu có) : {DatPhong.GHICHU}
                Quý khách vui lòng kiểm tra lại thông tin. Nếu có bất kỳ thắc mắc nào, xin vui lòng liên hệ: 
                    Phone: {GetHotNumber}             
                    Email: {MailUsername}
                Trân trọng,
                Đội ngũ quản lý khách sạn LHT Hotel";

            return Content;
        }

        public BodyBuilder NoiDungXacNhanBoDatPhong
        (
            DatPhongOCustom DatPhong
        )
        {
            BodyBuilder Content = new BodyBuilder();

            Content.TextBody = $@"
                Thông báo về việc hủy đặt phòng
                Kính chào {DatPhong.HOVATEN}
                Chúng tôi thông báo rằng yêu cầu hủy đặt phòng của quý khách đã được xử lý như sau:
                - Mã phòng đặt: {DatPhong.MAPHONGDAT}
                - Tên phòng nghỉ: {DatPhong.TENPHONG}
                - Ngày đặt phòng: {DatPhong.NGAYDAT}
                - Trạng thái: Đã hủy ngày {DateTime.Now}
                - Lý do: Hủy theo yêu cẩu của khách hàng
                Nếu quý khách có bất kỳ thắc mắc nào về việc hủy đặt phòng, xin vui lòng liên hệ:
                    Phone: {GetHotNumber}
                    Email: {MailUsername}
                Trân trọng,
                Đội ngũ quản lý khách sạn LHT Hotel";

            return Content;
        }

        public BodyBuilder NoiDungXacNhanNhanPhong
        (
            DatPhongOCustom DatPhong
        )
        {
            BodyBuilder Content = new BodyBuilder();

            Content.TextBody = $@"
                Xác nhận nhận phòng
                Kính chào {DatPhong.HOVATEN}
                Quý khách đã nhận phòng thành công với các thông tin:
                - Mã phòng đặt: {DatPhong.MAPHONGDAT}
                - Tên phòng: {DatPhong.TENPHONG}
                - Ngày nhận: {DateTime.Now}
                - Ngày thanh toán: {DatPhong.NGAYTRA}
                Nếu cần hỗ trợ, vui lòng liên hệ:
                    Phone: {GetHotNumber}
                    Email: {MailUsername}
                Trân trọng,
                Đội ngũ quản lý khách sạn LHT Hotel";

            return Content;
        }
    }
}