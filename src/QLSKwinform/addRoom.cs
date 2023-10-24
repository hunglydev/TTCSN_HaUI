using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace QLSKwinform
{
    public partial class addRoom : Form
    {
        //tạo 2 biến cục bộ
        string strCon = @"Data Source=TRANMINHHIEU\SQLEXPRESS;Initial Catalog=QLSK;Integrated Security=True";
        //đối tượng kết nối 
        SqlConnection sqlcon = null;
        private List<int> randomNumbers = new List<int>();

        private string rmName;
        public string RMNAME {
            get; set;
        }

        private string em;
        public string EM { get; set; }
        private string value;
       

        public addRoom()
        {
            InitializeComponent();
        }

        public void SetDataFormRoom(string rmName, string em)
        {
            txtRoomName.Text = rmName;
            txtEmail.Text = em;
            value = em;
            txtPay.Text = 0.ToString();

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (sqlcon == null)
            {
                sqlcon = new SqlConnection(strCon);
            }
            if (sqlcon.State == ConnectionState.Closed) { sqlcon.Open(); }

            string tenSK = txtEventName.Text;
            string dd = txtPlace.Text;
            string sl = txtAmout.Text;
            string tt = txtPay.Text;
            string note = txtNote.Text;
            int trangThai = 0 ;
            string tg = "2023 - 12 - 05";
            Random random = new Random();
            int id;
            do
            {
                id = random.Next(1, 10000);
            } while (randomNumbers.Contains(id));
            
            

            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = @"SELECT maTaiKhoan FROM TAIKHOAN where email ='" + value + "'";
            sqlCmd.Connection = sqlcon;
            string maTk = (string)sqlCmd.ExecuteScalar();
            sqlCmd.CommandText = @"INSERT  into SUKIEN VALUES('"+maTk+"','"+"event"+id+"','" + tenSK + "','" + dd + "','" + sl + "','" + tt + "','" + note + "', "+trangThai+"  ,'"+tg+"')";
                sqlCmd.Connection = sqlcon;
                sqlCmd.ExecuteNonQuery();
                sqlcon.Close();
                MessageBox.Show("Đã đăng kí phòng! Vui lòng chờ xác nhận!");
            

        }

        private void txtRoomName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClosetab_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            Menu mn = new Menu(value);  
            mn.ShowDialog();
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void cbVoucher_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(value);
            
                using (SqlConnection sqlcon = new SqlConnection(strCon))
                {
                    string query = "SELECT maVoucher FROM TAIKHOAN_VOUCHER WHERE maTaiKhoan = (SELECT maTaiKhoan FROM TAIKHOAN WHERE email = @Email)";
                    SqlCommand sqlCmd = new SqlCommand(query, sqlcon);
                    sqlCmd.Parameters.AddWithValue("@Email", value);

                    sqlcon.Open();
                    SqlDataReader reader = sqlCmd.ExecuteReader();

                    cbVoucher.Items.Clear(); // Xóa các mục hiện có trong ComboBox

                    while (reader.Read())
                    {
                        string maVoucher = reader.GetString(0);
                        cbVoucher.Items.Add(maVoucher); // Thêm mỗi voucher vào ComboBox
                    }

                    reader.Close();
                }
            
            
            
        }

        private void txtPay_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
    
}
