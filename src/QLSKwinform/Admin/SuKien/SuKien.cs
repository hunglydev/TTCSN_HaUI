using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSKwinform.Admin.SuKien
{
    public class SuKien
    {
        public SuKien() { }
        [DisplayName("Mã tài khoản")]
        public string maTaiKhoan {  get; set; }
        [DisplayName("Mã sự kiện")]
        public string maSuKien { get; set; }
        [DisplayName("Mã phòng")]
        public string maPhong {  get; set; }
        [DisplayName("Tên sự kiện")]
        public string tenSuKien { get; set; }
        [DisplayName("Số lượng dự kiến")]
        public int soLuong {  get; set; }
        [DisplayName("Tình trạng thanh toán")]
        public string tinhTrangThanhToan {  get; set; }
        [DisplayName("Ghi chú")]
        public string ghiChu {  get; set; }
        
        [DisplayName("Trạng thái")]
        public string trangThai {  get; set; }
        [DisplayName("Thời gian sự kiện bắt đầu")]
        public DateTime thoiGian {  get; set; }
        [DisplayName("Voucher đã sử dụng")]
        public string voucherDaSuDung { get; set; }
    }
}
