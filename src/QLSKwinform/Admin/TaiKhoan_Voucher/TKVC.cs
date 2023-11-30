using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSKwinform.Admin.TaiKhoan_Voucher
{
    public class TKVC
    {
        [DisplayName("Mã tài khoản")]
        public string maTaiKhoan {  get; set; }
        [DisplayName("Mã Voucher")]
        public string maVoucher { get; set; }
        public TKVC() { }
    }
}
