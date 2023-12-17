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
        public string TinhTrangThanhToan { get; set; }

        [DisplayName("Ghi Chú")]
        public string GhiChu { get; set; }

        [DisplayName("Trạng Thái")]
        public string TrangThai { get; set; }

        [DisplayName("Thời Gian")]
        public DateTime ThoiGian { get; set; }

        [DisplayName("Tên Phòng")]
        public string TenPhong { get; set; }

        [DisplayName("Mã voucher đã sử dụng")]
        public string MaVoucherDaSuDung { get; set; }

        [DisplayName("Giá phòng")]
        public double GiaPhong { get; set; }

        [DisplayName("Mã voucher")]
        public string MaVoucher { get; set; }

        [DisplayName("Phần trăm giảm giá")]
        public double PhanTramGiamGia { get; set; }
    }
}
