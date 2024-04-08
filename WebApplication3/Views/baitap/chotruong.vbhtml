@Code
    ViewData("Title") = "Bài 1"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<%@ Page Language="C#" %>
<!DOCTYPE html>
<html>
<head>
    <title>Xin chào</title>
    <style>
        h2 {
            color: blue;
            font-size: 24px;
        }

        .image-container {
            text-align: center;
            margin-top: 20px;
        }

            .image-container img {
                width: 200px;
                height: 200px;
                border-radius: 50%;
            }
    </style>
</head>
<body>
    <h2>Xin chào mn</h2>
    <h2>hôm nay em sẽ giới thiệu trường Đại học Nguyễn Trãi</h2>
    <h2>
        Tên trường: Trường Đại học Nguyễn Trãi (Tên viết tắt: NTU)<br />
        Tên Tiếng Anh: Nguyen Trai University<br />
        Địa chỉ:<br />
        Cơ sở 1: 266 Đội Cấn, Ba Đình, Hà Nội<br />
        Cơ sở 2: 36A Phạm Văn Đồng, Bắc Từ Liêm, Hà Nội<br />
        Cơ sở 3: Số 28A Lê Trọng Tấn, Hà Đông, Hà Nội<br />
        Website: <a href="http://daihocnguyentrai.edu.vn">http://daihocnguyentrai.edu.vn</a><br />
        Facebook: <a href="https://www.facebook.com/daihocnguyentrai.edu.vn/">https://www.facebook.com/daihocnguyentrai.edu.vn/</a><br />
        Mã tuyển sinh: NTU<br />
        Email tuyển sinh: daihocnguyentrai.edu.vn@gmail.com<br />
        Số điện thoại tuyển sinh: 024.3748.1759, 024.3748.1830
    </h2>
    <div class="image-container">
        <img src="path/to/your/image.jpg" alt="Trường Đại học Nguyễn Trãi" />
    </div>
</body>
</html>
