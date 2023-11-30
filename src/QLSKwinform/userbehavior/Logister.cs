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

namespace QLSKwinform
{
    public partial class Logister : Form
    {
        public Logister()
        {
            InitializeComponent();
        }

        //tạo 2 biến cục bộ
        string strCon = @"Data Source=DESKTOP-983J608\SQLEXPRESS;Initial Catalog=QLSK;Integrated Security=True";
        //đối tượng kết nối 
        SqlConnection sqlcon = null;

        private void btnLogis_Click(object sender, EventArgs e)
        {
            if (sqlcon == null)
            {
                sqlcon = new SqlConnection(strCon);
            }
            if (sqlcon.State == ConnectionState.Closed) { sqlcon.Open(); }

            //đối tượng thực thi truy vấn
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            string tendaydu = txtFullName.Text;
            string tenTaiKhoan = txtLogisName.Text;
            string matKhau = txtLogisPass.Text;
            string rematKhau = txtLogisRepass.Text;
            string eMail = txtLogisEmail.Text;
            string sodt = txtSdt.Text;

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
            else if (rematKhau != matKhau)
            {
                MessageBox.Show("Mật khẩu không trùng khớp! Vui lòng nhập lại!");
            }
            else if (tenTaiKhoan == "" || matKhau == "" || rematKhau == "" || eMail == "" || tendaydu == "" || sodt == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
            }

            else if (tenTaiKhoan != "" && matKhau != "" && rematKhau != "" && matKhau == rematKhau && eMail != "" && tendaydu != "" && sodt != "")
            {
                //sqlCmd.CommandText = "INSERT INTO TAIKHOAN VALUES('" + generatedID + "','" + tenTaiKhoan + "','" + matKhau + "','"+tendaydu+"','"+eMail+"','"+sodt+"')";
                sqlCmd.CommandText = "INSERT INTO TAIKHOAN (maTaiKhoan, tenTaiKhoan, matKhau, tenNguoiChuTri, email, sdt)" +
                    " VALUES (@maTK, @tenTaiKhoan, @matKhau, @hoten, @email, @sdt)";
                
                sqlCmd.Parameters.AddWithValue("@maTK", generatedID.ToString());
                sqlCmd.Parameters.AddWithValue("@tenTaiKhoan", txtLogisName.Text);
                sqlCmd.Parameters.AddWithValue("@matKhau", txtLogisPass.Text);
                sqlCmd.Parameters.AddWithValue("@hoten", txtFullName.Text);
                sqlCmd.Parameters.AddWithValue("@email", txtLogisEmail.Text);
                sqlCmd.Parameters.AddWithValue("@sdt", txtSdt.Text);
                //gửi truy vấn vào kết nối
                sqlCmd.Connection = sqlcon;
                sqlCmd.ExecuteNonQuery();
                sqlcon.Close();
                MessageBox.Show("Đăng ký thành công!");
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            formLogin login = new formLogin();
            login.ShowDialog();
            this.Close();
        }

        private void Logister_Load(object sender, EventArgs e)
        {

        }
    }
}
