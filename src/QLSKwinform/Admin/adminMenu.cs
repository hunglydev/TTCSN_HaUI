using QLSKwinform.Admin.Phong;
using QLSKwinform.Admin.SuKien;
using QLSKwinform.Admin.TaiKhoan_Voucher;
using QLSKwinform.Admin.Voucher;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSKwinform
{
    public partial class adminMenu : Form
    {
        public adminMenu()
        {
            InitializeComponent();
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            this.Hide();
            BaoTriTaiKhoan baoTriTaiKhoan = new BaoTriTaiKhoan();
            baoTriTaiKhoan.ShowDialog();
            
        }

        private void btnSuKien_Click(object sender, EventArgs e)
        {
            this.Hide();
            BaoTriSuKien baoTriSuKien = new BaoTriSuKien();
            baoTriSuKien.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            BaoTriPhong baoTriPhong = new BaoTriPhong();
            baoTriPhong.ShowDialog();
        }

        private void btnVoucher_Click(object sender, EventArgs e)
        {
            BaoTriVoucher voucher = new BaoTriVoucher();
            this.Hide();
            voucher.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BaoTriTKVC baoTriTKVC = new BaoTriTKVC();
            this.Hide();
            baoTriTKVC.ShowDialog();
        }

        private void adminMenu_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            formLogin formLogin = new formLogin();
            this.Hide();
            formLogin.ShowDialog();
        }
    }
}
