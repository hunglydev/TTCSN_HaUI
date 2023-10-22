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
        string strCon = @"Data Source=TRANMINHHIEU\SQLEXPRESS;Initial Catalog=DATABASEQLSK;Integrated Security=True";
        //đối tượng kết nối 
        SqlConnection sqlcon = null;

        private List<int> randomNumbers = new List<int>();

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
            string tenTaiKhoan = txtLogisName.Text;
            string matKhau = txtLogisPass.Text;
            string rematKhau = txtLogisRepass.Text;
            string eMail = txtLogisEmail.Text;
            Random random = new Random();
            int id;
            do
            {
                id = random.Next(1, 10000);
            } while (randomNumbers.Contains(id));
            
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
            }else if (result2 != null)
            {
                MessageBox.Show("Email đã tồn tại! Vui lòng nhập lại!");
            }
            else if(rematKhau != matKhau)
            {
                MessageBox.Show("Mật khẩu không trùng khớp! Vui lòng nhập lại!");
            }else if(tenTaiKhoan =="" || matKhau =="" || rematKhau =="" || eMail == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
            }
            
            else  if (tenTaiKhoan != "" && matKhau != "" && rematKhau != "" && matKhau == rematKhau && eMail !="")
            {
                sqlCmd.CommandText = "INSERT INTO TAIKHOAN (maTaiKhoan, tenTaiKhoan, matKhau, email ) VALUES('" + "user"+id.ToString() + "','" + tenTaiKhoan + "','" + matKhau + "','"+eMail+"')";

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
    }
}
