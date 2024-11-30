# PHẦN MỀM QUẢN LÝ KHÁCH SẠN LHT
Phần mềm quản lý khách sạn bằng Windows Form với DevExpress và Guna UI.

# Thông tin về tác giả
FB: [Lư Hoàng Tấn](https://facebook.com/luhoangtan2k3)
# Môi trường làm việc
* SQL Server Management Studio 20.
* Microsoft Visual Studio 2022.
* DOTNET Framework 4.8 hoặc 4.8.1.
* UI: DevExpress 24.1.X, Guna 2.X.

# Hình ảnh phần mềm
![](/Resource/Image/QLKS1.png)
![](/Resource/Image/QLKS2.png)
![](/Resource/Image/QLKS3.png)
![](/Resource/Image/QLKS4.png)
![](/Resource/Image/QLKS5.png)

# Công việc đầu tiên
1. Cần cài đặt [DevExpress](/Resource/UI/DevExpress.EXE)
2. Đảm bảo rằng [Guna.UI2.dll](/Resource/UI/Guna.UI2.dll) đã được thêm vào References của class GUILAYER.
3. Cần khởi tạo cơ sở dữ liệu [QLKS.BAK](/Resource/DB/QLKS.BAK) cho hệ quản trị cơ sở dữ liệu SQL Server.

# Lưu ý lỗi phát sinh
Chức năng **HỘP THƯ**(Google Gmail) có thể gây ra lỗi như hình bên dưới khi chạy lần đầu tức bạn vừa git clone dự án về máy. Để giải quyết vấn đề này hãy gỡ cài đặt và cài lại gói Microsoft.Web.WebView2 cho class GUILAYER.
![](/Resource/Image/QLKS6.png)