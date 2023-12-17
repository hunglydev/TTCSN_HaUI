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
        //tạo 2 biến cục bộ
        string strCon = @"Data Source=DESKTOP-983J608\SQLEXPRESS;Initial Catalog=QLSK;Integrated Security=True";
        //đối tượng kết nối 
        SqlConnection sqlcon = null;
        private List<int> randomNumbers = new List<int>();

        private string rmName;
        public string RMNAME
        {
            get; set;
        }
        private string em;
        public string EM { get; set; }
        private string roomid;
        public string ROOMID { get; set; }
        private string value;
        private string rmID;


        public addRoom()
        {
            InitializeComponent();
            txtEventHost.ReadOnly = true;
            txtTele.ReadOnly = true;
            txtRoomName.ReadOnly = true;
            txtEmail.ReadOnly = true;
        }

        public void SetDataFormRoom(string rmName, string em, string roomid)
        {
            txtRoomName.Text = rmName;
            txtEmail.Text = em;
            value = em;
            rmID = roomid;

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

            string sl = txtAmout.Text;
            string note = txtNote.Text;
            string tinhTrangThanhToan = "chưa thanh toán";
            string trangThai = "chưa xác nhận";
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            List<string> existingAccountIDs = new List<string>();
            sqlCmd.CommandText = "SELECT maSuKien FROM SUKIEN";
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
                generatedID = "event" + id.ToString();
            } while (existingAccountIDs.Contains(generatedID));

            //SqlCommand sqlCmd = new SqlCommand();
            //sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT maTaiKhoan FROM TAIKHOAN where email ='" + value + "'";
            sqlCmd.Connection = sqlcon;
            string maTk = (string)sqlCmd.ExecuteScalar();

            //MessageBox.Show(voucher);

            if (cbVoucher.SelectedItem != null)
            {
                if (dtpThoiGían.Value <= DateTime.Now)
                {
                    MessageBox.Show("Thời gian phải sau ngày hiện tại");
                }
                else
                {
                    if (tenSK != "" && sl != "")
                    {
                        if (IsRoomBooked(sqlcon, rmID, dtpThoiGían.Value))
                        {
                            MessageBox.Show("Phòng đã kín tại thời điểm này. Vui lòng chọn thời điểm khác hoặc chọn phòng khác!");
                            return;
                        }
                        else
                        {
                            string voucher = cbVoucher.SelectedItem.ToString();
                            sqlCmd.CommandText = "begin transaction; INSERT  into SUKIEN VALUES('" + maTk + "','" + generatedID + "','" + rmID + "',N'" + tenSK + "','" + sl + "',N'" + tinhTrangThanhToan + "'   ,'" + note + "',N'" + trangThai + "'  ,'" + dtpThoiGían.Value.ToString("yyyy-MM-dd") + "',N'"+cbVoucher.SelectedItem.ToString()+"'); " +
                                "Delete From TAIKHOAN_VOUCHER WHERE maVoucher = '" + voucher + "' and maTaiKhoan =(SELECT maTaiKhoan FROM TAIKHOAN where email ='" + value + "') ; commit ";

                            // sqlCmd.CommandText = "";
                            sqlCmd.Connection = sqlcon;
                            sqlCmd.ExecuteNonQuery();
                            sqlcon.Close();
                            MessageBox.Show("Đã đăng kí phòng! Vui lòng chờ xác nhận!");
                            this.Hide();
                            Menu mn = new Menu(value);
                            mn.ShowDialog();
                            this.Close();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                    }
                }

            }
            else
            {
                if (dtpThoiGían.Value <= DateTime.Now)
                {
                    MessageBox.Show("Thời gian phải sau ngày hiện tại");
                }
                else
                {
                    if (tenSK != "" && sl != "")
                    {
                        if (IsRoomBooked(sqlcon, rmID, dtpThoiGían.Value))
                        {
                            MessageBox.Show("Phòng đã kín tại thời điểm này. Vui lòng chọn thời điểm khác hoặc chọn phòng khác!");
                            return;
                        }
                        else
                        {
                            sqlCmd.CommandText = " INSERT into SUKIEN VALUES('" + maTk + "','" + generatedID + "','" + rmID + "',N'" + tenSK + "','" + sl + "',N'" + tinhTrangThanhToan + "'   ,'" + note + "',N'" + trangThai + "'  ,'" + dtpThoiGían.Value.ToString("yyyy-MM-dd") + "',''); ";
                            // sqlCmd.CommandText = "";
                            sqlCmd.Connection = sqlcon;
                            sqlCmd.ExecuteNonQuery();
                            sqlcon.Close();
                            MessageBox.Show("Đã đăng kí phòng! Vui lòng chờ xác nhận!");
                            this.Hide();
                            Menu mn = new Menu(value);
                            mn.ShowDialog();
                            this.Close();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                    }
                }

            }


        }
        private bool IsRoomBooked(SqlConnection connection, string roomId, DateTime eventTime)
        {
            using (SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM SUKIEN WHERE MaPhong = @RoomId AND TrangThai = 1 AND ThoiGian = @EventTime", connection))
            {
                command.Parameters.AddWithValue("@RoomId", roomId);
                command.Parameters.AddWithValue("@EventTime", eventTime);
                int count = (int)command.ExecuteScalar();
                return count > 0;
            }
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

        

        private void txtPay_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void addRoom_Load(object sender, EventArgs e)
        {
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
                ;
                reader.Close();
            }


            using (SqlConnection sqlcon = new SqlConnection(strCon))
            {
                string query1 = "SELECT tenNguoiChuTri FROM TAIKHOAN where email ='" + value + "'";
                SqlCommand sqlCmd1 = new SqlCommand(query1, sqlcon);
                string query2 = "SELECT sdt FROM TAIKHOAN where email ='" + value + "'";
                SqlCommand sqlCmd2 = new SqlCommand(query2, sqlcon);
                sqlcon.Open();
                txtEventHost.Text = (string)sqlCmd1.ExecuteScalar();
                txtTele.Text = (string)sqlCmd2.ExecuteScalar();
            }
        }
    }
    
}
