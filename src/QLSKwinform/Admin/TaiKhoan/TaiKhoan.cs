using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSKwinform
{
    internal class TaiKhoan
    {
        private string maTaiKhoan;
        private string tenTaiKhoan;
        private string matKhau;
        private string tenNguoiChuTri;
        private string email;
        private string sdt;

        [DisplayName("Mã Tài Khoản")]
        public string MaTaiKhoan { get; set; }

        [DisplayName("Tài Khoản")]
        public string TenTaiKhoan { get; set; }

        [DisplayName("Mật Khẩu")]
        public string MatKhau { get; set; }

        [DisplayName("Tên Người Chủ Trì")]
        public string TenNguoiChuTri { get; set; }

        [DisplayName("Email")]
        public string Email { get; set; }

        [DisplayName("Số Điện Thoại")]
        public string Sdt { get; set; }

    
    }
}
