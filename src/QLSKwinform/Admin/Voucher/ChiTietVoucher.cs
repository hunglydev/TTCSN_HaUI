using QLSKwinform.Admin.SuKien;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSKwinform.Admin.Voucher
{
    public partial class ChiTietVoucher : Form
    {
        //tạo 2 biến cục bộ
        string strCon = @"Data Source=DESKTOP-983J608\SQLEXPRESS;Initial Catalog=QLSK;Integrated Security=True";
        //đối tượng kết nối 
        SqlConnection sqlcon = null;
        public ChiTietVoucher()
        {
            InitializeComponent();
        }
        public ChiTietVoucher(Voucher voucher1)
        {
            InitializeComponent();
            txtMaVoucher.Text =voucher1.maVoucher;
            txtGiamGia.Text = (voucher1.phanTramGiamGia*100).ToString();
            txtMoTa.Text = voucher1.moTaVoucher;
            dtBatDau.Value = voucher1.thoiGianBatDau.ToLocalTime();
            dtKetThuc.Value = voucher1.thoiGianKetThuc.ToLocalTime();
            txtMaVoucher.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBatDau_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BaoTriVoucher baoTriVoucher = new BaoTriVoucher();
            this.Hide();
            baoTriVoucher.ShowDialog();
        }

        private void ChiTietVoucher_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dtBatDau.Value > dtKetThuc.Value)
            {
                MessageBox.Show("Vui lòng chỉnh lại thời gian hợp lệ");
               
            }
            else {
                if (sqlcon == null)
                {
                    sqlcon = new SqlConnection(strCon);
                }

                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandType = CommandType.Text;
                sqlcmd.CommandText = "UPDATE VOUCHER SET  phanTramGiamGia = @phanTramGiamGia, moTaVoucher = @moTaVoucher, thoiGianBatDau = " +
                    "@thoiGianBatDau, thoiGianKetThuc = @thoiGianKetThuc WHERE maVoucher = @maVoucher";
                double giamGia = double.Parse(txtGiamGia.Text) / 100;
                sqlcmd.Parameters.AddWithValue("@maVoucher", txtMaVoucher.Text);
                sqlcmd.Parameters.AddWithValue("@phanTramGiamGia", giamGia);
                sqlcmd.Parameters.AddWithValue("@moTaVoucher", txtMoTa.Text);
                sqlcmd.Parameters.AddWithValue("@thoiGianBatDau", dtBatDau.Value.ToString("yyyy-MM-dd"));
                sqlcmd.Parameters.AddWithValue("@thoiGianKetThuc", dtKetThuc.Value.ToString("yyyy-MM-dd"));
                // Gửi truy vấn vào kết nối
                sqlcmd.Connection = sqlcon;

                // Thực hiện truy vấn
                sqlcmd.ExecuteNonQuery();

                // Đóng kết nối
                sqlcon.Close();

                // Hiển thị thông báo thành công
                MessageBox.Show("Sửa thông tin thành công");

                // Đóng form hiện tại và hiển thị form BaoTriTaiKhoan
                this.Hide();
                BaoTriVoucher baoTriVoucher = new BaoTriVoucher();
                baoTriVoucher.ShowDialog();
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn xóa tài khoản này không", "Lưu ý", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (sqlcon == null)
                {
                    sqlcon = new SqlConnection(strCon);
                }

                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }

                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandType = CommandType.Text;
                sqlcmd.CommandText = "DELETE FROM VOUCHER WHERE maVoucher=@maVoucher";
                sqlcmd.Parameters.AddWithValue("@maVoucher", txtMaVoucher.Text);
                sqlcmd.Connection= sqlcon;
                sqlcmd.CommandText = "DELETE FROM TAIKHOAN_VOUCHER WHERE maVoucher=@maVoucher";
                sqlcmd.Connection = sqlcon;
                sqlcmd.ExecuteNonQuery();
                sqlcon.Close();
                MessageBox.Show("Xóa Voucher thành công");
                this.Hide();
                BaoTriVoucher baoTriVoucher = new BaoTriVoucher();
                baoTriVoucher.ShowDialog();

            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }
    }
}
