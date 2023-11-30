using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSKwinform.Admin.Voucher
{
    public class Voucher
    {
        [DisplayName ("Mã Voucher")]
        public string maVoucher {  get; set; }
        [DisplayName("Phần trăm giảm giá")]
        public double phanTramGiamGia {  get; set; }
        [DisplayName("Mô tả voucher")]
        public string moTaVoucher {  get; set; }
        [DisplayName("Thời gian bắt đầu")]
        public DateTime thoiGianBatDau {  get; set; }
        [DisplayName("Thời gian kết thúc")]
        public DateTime thoiGianKetThuc {  get; set; }
        public Voucher()
        {

        }
    }
}
