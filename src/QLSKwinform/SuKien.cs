using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSKwinform
{
    public class SuKien
    {
        private string maTaiKhoan;
        private string maSuKien;
        private string maPhong;
        private string tenSuKien;
        private string diaDiem;
        private int soLuong;
        private int tinhTrangThanhToan;
        private string ghiChu;
        private int trangThai;
        private DateTime thoiGian;
        [DisplayName("Mã tài khoản")]
        public string MaTaiKhoan { get => maTaiKhoan; set => maTaiKhoan = value; }
        [DisplayName("Mã sự kiện")]
        public string MaSuKien { get => maSuKien; set => maSuKien = value; }
        [DisplayName("Mã phòng")]
        public string MaPhong { get => maPhong; set => maPhong = value; }
        [DisplayName("Tên sự kiện")]
        public string TenSukien { get => tenSuKien; set => tenSuKien = value; }
        [DisplayName("Địa điểm")]
        public string DiaDiem { get => diaDiem; set => diaDiem = value; }
        [DisplayName("Số lượng dự kiến")]
        public int SoLuong { get => soLuong; set => soLuong = value; }
        [DisplayName("Tình trạng thanh toán")]
        public int TinhTrangThanhToan { get => tinhTrangThanhToan; set => tinhTrangThanhToan = value; }
        [DisplayName("Ghi chú")]
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
        [DisplayName("Trạng thái")]
        public int TrangThai { get => trangThai; set => trangThai = value; }
        [DisplayName("Thời gian sự kiện bắt đầu")]
        public DateTime ThoiGian { get => thoiGian; set => thoiGian = value; }

        public string thanhToan()
        {
            if (tinhTrangThanhToan == 1)
            {
                return "Đã thanh toán";
            }
            return "Chưa thanh toán";
        }
        public string TrangThai1()
        {
            if (trangThai == 1) { return "Đã đặt phòng"; }
            return "Chưa đặt phòng";
        }
    }
}