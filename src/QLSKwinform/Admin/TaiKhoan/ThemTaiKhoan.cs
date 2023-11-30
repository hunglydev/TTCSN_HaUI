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

namespace QLSKwinform.Admin.TaiKhoan
{
    public partial class ThemTaiKhoan : Form
    {
        // Tạo biến kết nối và danh sách các số nguyên ngẫu nhiên
        //tạo 2 biến cục bộ
        string strCon = @"Data Source=DESKTOP-983J608\SQLEXPRESS;Initial Catalog=QLSK;Integrated Security=True";
        //đối tượng kết nối 
        SqlConnection sqlcon = null;
        private List<int> randomNumbers = new List<int>();

        public ThemTaiKhoan()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (sqlcon == null)
            {
                sqlcon = new SqlConnection(strCon);
            }
            if (sqlcon.State == ConnectionState.Closed) { sqlcon.Open(); }

            //đối tượng thực thi truy vấn
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            string hoten = txtTenNguoiChuTri.Text;
            string tenTaiKhoan = txtTenTaiKhoan.Text;
            string matKhau = txtMatKhau.Text;
            string eMail = txtEmail.Text;
            string sodt = txtSDT.Text;

            List<string> existingAccountIDs = new List<string>();
            sqlCmd.CommandText = "SELECT maTaiKhoan FROM TAIKHOAN";
            sqlCmd.Connection = sqlcon;
            SqlDataReader reader = sqlCmd.ExecuteReader();
            while (reader.Read())
            {
                string existingID = reader.GetString(0);
                existingAccountIDs.Add(existingID);
            }
            reader.Close();
            Random random = new Random();
            string generatedID;
            do
            {
                int id = random.Next(1, 10000);
                generatedID = "user" + id.ToString();
            } while (existingAccountIDs.Contains(generatedID));

            //truy vấn tên tài khoản
            sqlCmd.CommandText = "SELECT tenTaiKhoan FROM TAIKHOAN WHERE tenTaiKhoan='" + tenTaiKhoan + "'";
            sqlCmd.Connection = sqlcon;
            string result1 = (string)sqlCmd.ExecuteScalar();
            // MessageBox.Show("result = " + results);
            //truy vấn email
            sqlCmd.CommandText = "SELECT email FROM TAIKHOAN WHERE email='" + eMail + "'";
            sqlCmd.Connection = sqlcon;
            string result2 = (string)sqlCmd.ExecuteScalar();

            if (result1 != null)
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại! Vui lòng nhập tên đăng nhập khác");
            }
            else if (result2 != null)
            {
                MessageBox.Show("Email đã tồn tại! Vui lòng nhập lại!");
            }
            else if (tenTaiKhoan == "" || matKhau == "" || eMail == "" || hoten == "" || sodt == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
            }

            else
            {
                sqlCmd.CommandText = "INSERT INTO TAIKHOAN VALUES ('@maTK','@tenTK', '@mK','@hoten', '@email', '@sdt')";
                sqlCmd.Parameters.AddWithValue("@maTaiKhoan", generatedID);
                    sqlCmd.Parameters.AddWithValue("@tenTaiKhoan", txtTenTaiKhoan.Text);
                    sqlCmd.Parameters.AddWithValue("@matKhau", txtMatKhau.Text);
                    sqlCmd.Parameters.AddWithValue("@hoten", txtTenNguoiChuTri.Text);
                    sqlCmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    sqlCmd.Parameters.AddWithValue("@sdt", txtSDT.Text);
                //gửi truy vấn vào kết nối
                sqlCmd.CommandText = "INSERT INTO TAIKHOAN VALUES('" + generatedID + "','" + txtTenTaiKhoan.Text + "','" + txtMatKhau.Text + "'," +
                    "'" + txtTenNguoiChuTri.Text + "','" + txtEmail.Text + "','" + txtSDT.Text + "')";

                sqlCmd.Connection = sqlcon;
                sqlCmd.ExecuteNonQuery();
                sqlcon.Close();
                MessageBox.Show("Thêm tài khoản thành công!");
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            BaoTriTaiKhoan baoTri = new BaoTriTaiKhoan();
            this.Hide();
            baoTri.ShowDialog();
        }

        private void ThemTaiKhoan_Load(object sender, EventArgs e)
        {

        }
    }
}
