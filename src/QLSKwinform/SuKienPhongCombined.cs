using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSKwinform
{
    public class SuKienPhongCombined
    {
        [DisplayName("Mã Tài Khoản")]
        public string MaTaiKhoan { get; set; }

        [DisplayName("Mã Sự Kiện")]
        public string MaSuKien { get; set; }

        [DisplayName("Mã Phòng")]
        public string MaPhong { get; set; }

        [DisplayName("Tên Sự Kiện")]
        public string TenSukien { get; set; }

        [DisplayName("Số Lượng")]
        public int SoLuong { get; set; }

        [DisplayName("Tình Trạng Thanh Toán")]
        public int TinhTrangThanhToan { get; set; }

        [DisplayName("Ghi Chú")]
        public string GhiChu { get; set; }

        [DisplayName("Trạng Thái")]
        public int TrangThai { get; set; }

        [DisplayName("Thời Gian")]
        public DateTime ThoiGian { get; set; }

        [DisplayName("Tên Phòng")]
        public string TenPhong { get; set; }
    }
}
