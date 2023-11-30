using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace QLSKwinform.Admin
{
    public partial class ChiTietTaiKhoan : Form
    {
        private string maTaiKhoan;
        private string tenTaiKhoan;
        private string matKhau;
        private string tenNguoiChuTri;
        private string email;
        private string sdt;
        //tạo 2 biến cục bộ
        //tạo 2 biến cục bộ
        string strCon = @"Data Source=DESKTOP-983J608\SQLEXPRESS;Initial Catalog=QLSK;Integrated Security=True";
        //đối tượng kết nối 
        SqlConnection sqlcon = null;
        public ChiTietTaiKhoan()
        {
            InitializeComponent();
        }

        private void ChiTietTaiKhoan_Load(object sender, EventArgs e)
        {

        }
        public ChiTietTaiKhoan(string maTaiKhoan, string tenTaiKhoan, string matKhau, string tenNguoiChuTri, string email, string sdt)
        {
            this.maTaiKhoan = maTaiKhoan;
            this.tenTaiKhoan = tenTaiKhoan;
            this.matKhau = matKhau;
            this.tenNguoiChuTri = tenNguoiChuTri;
            this.email = email;
            this.sdt = sdt;
            InitializeComponent();
            txtEmail.Text = email;
            txtMaTaiKhoan.Text = maTaiKhoan;
            txtMatKhau.Text = matKhau;
            txtSDT.Text = sdt;
            txtTenNguoiChuTri.Text = tenNguoiChuTri;
            txtTenTaiKhoan.Text = tenTaiKhoan;
            txtMaTaiKhoan.Enabled = false;
        }

        private void btnTroLai_Click(object sender, EventArgs e)
        {
            this.Hide();
            BaoTriTaiKhoan baoTriTaiKhoan = new BaoTriTaiKhoan();
            baoTriTaiKhoan.ShowDialog();
        }

        private void btnLuu_Click(object sender, EventArgs e)
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

            // Kiểm tra xem địa chỉ email đã được sử dụng bởi tài khoản khác chưa
            sqlcmd.CommandText = "SELECT maTaiKhoan FROM TAIKHOAN WHERE email = @email AND maTaiKhoan != @maTaiKhoan";
            sqlcmd.Parameters.AddWithValue("@email", txtEmail.Text);
            sqlcmd.Parameters.AddWithValue("@maTaiKhoan", txtMaTaiKhoan.Text);
            sqlcmd.Connection = sqlcon;

            string result =(string) sqlcmd.ExecuteScalar();

            if (result != null)
            {
                // Địa chỉ email đã được sử dụng bởi tài khoản khác
                MessageBox.Show("Email đã tồn tại cho một tài khoản khác, vui lòng nhập lại");
            }
            else
            {
                // Tiếp tục cập nhật thông tin tài khoản
                sqlcmd.CommandText = "UPDATE TAIKHOAN SET tenTaiKhoan = @tenTaiKhoan, " +
                               "matKhau = @matKhau, tenNguoiChuTri = @tenNguoiChuTri, email = @email, sdt = @sdt WHERE maTaiKhoan = @maTaiKhoan";

                // Thêm các tham số và giá trị tương ứng
                sqlcmd.Parameters.AddWithValue("@tenTaiKhoan", txtTenTaiKhoan.Text);
                sqlcmd.Parameters.AddWithValue("@matKhau", txtMatKhau.Text);
                sqlcmd.Parameters.AddWithValue("@tenNguoiChuTri", txtTenNguoiChuTri.Text);
                sqlcmd.Parameters.AddWithValue("@sdt", txtSDT.Text);
                //sqlcmd.Parameters.AddWithValue("@maTaiKhoan", txtMaTaiKhoan.Text);

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
                BaoTriTaiKhoan baoTriTaiKhoan = new BaoTriTaiKhoan();
                baoTriTaiKhoan.ShowDialog();


            }
            }

        private void btnXoa_Click(object sender, EventArgs e)
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
                sqlcmd.CommandText = "DELETE FROM TAIKHOAN_VOUCHER WHERE maTaiKhoan=@maTaiKhoan";
                sqlcmd.Parameters.AddWithValue("@maTaiKhoan", txtMaTaiKhoan.Text);
                sqlcmd.Connection = sqlcon;
                sqlcmd.CommandText = "DELETE FROM SUKIEN WHERE maTaiKhoan=@maTaiKhoan";
                sqlcmd.Connection = sqlcon;
                sqlcmd.CommandText = "DELETE FROM TAIKHOAN WHERE maTaiKhoan=@maTaiKhoan";
                sqlcmd.Connection = sqlcon;
                sqlcmd.ExecuteNonQuery();
                sqlcon.Close();
                MessageBox.Show("Xóa tài khoản thành công");

                this.Hide();
                BaoTriTaiKhoan baoTriTaiKhoan = new BaoTriTaiKhoan();
                baoTriTaiKhoan.ShowDialog();

            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
           
        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTenNguoiChuTri_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTenTaiKhoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMaTaiKhoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
