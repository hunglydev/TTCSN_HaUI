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

namespace QLSKwinform
{
    public partial class formLogin : Form
    {
        //tạo 2 biến cục bộ
        string strCon = @"Data Source=TRANMINHHIEU\SQLEXPRESS;Initial Catalog=QLSK;Integrated Security=True";
        //đối tượng kết nối 
        SqlConnection sqlcon = null;

        public formLogin()
        {
            InitializeComponent();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(sqlcon == null)
            {
                sqlcon = new SqlConnection(strCon);
            }            if(sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
            }

            //đối tượng thực thi truy vấn
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            string tenTaiKhoan = txtTenDangNhap.Text;
            string matKhau = txtMatKhau.Text;

            //câu lệnh truy vấn vào tài khoản admin
            sqlCmd.CommandText = "SELECT matKhau FROM TAIKHOAN WHERE tenTaiKhoan = '"+tenTaiKhoan+"'";

            //gửi truy vấn vào kết nối
            sqlCmd.Connection = sqlcon;

            //nhận kết quả
            string password = (string)sqlCmd.ExecuteScalar();

            //câu lệnh truy vấn vào tài khoản admin

            sqlCmd.CommandText = "SELECT tenTaiKhoan from TAIKHOAN WHERE tenTaiKhoan='admin2'";
            sqlCmd.Connection = sqlcon;
            string result = (string) sqlCmd.ExecuteScalar();

            if ( result != tenTaiKhoan && password == matKhau)
            {
                sqlCmd.CommandText = "SELECT email FROM TAIKHOAN WHERE tenTaiKhoan = '" + tenTaiKhoan + "'";
                sqlCmd.Connection = sqlcon;
                string em = (string)sqlCmd.ExecuteScalar();
                //MessageBox.Show(em);
                this.Hide();
                //MessageBox.Show("Đăng nhập thành công!");
                Menu mn = new Menu(em);
                mn.ShowDialog();
                this.Close();
            }
            if (result == tenTaiKhoan && password == matKhau)
            {
                this.Hide();
                MessageBox.Show("Đăng nhập thành công!");
                adminMenu admn = new adminMenu();
                admn.ShowDialog();
                this.Close();
            }
            else if (matKhau == "" || tenTaiKhoan == "")
            {
                MessageBox.Show("Vui lòng không để trống tài khoản hoặc mật khẩu!");
            }
            else if (password != matKhau)
            {
                MessageBox.Show("Mật khẩu sai hoặc tài khoản không tồn tại! Vui lòng nhập lại!");
                txtMatKhau.Text = null;
            }

        }

        private void btnLogis_Click(object sender, EventArgs e)
        {
            this.Hide();
            Logister logis = new Logister();
            logis.ShowDialog();
            this.Close();
        }
    }
}
