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

namespace QLSKwinform.Admin.Voucher
{
    public partial class ThemVoucher : Form
    {
        //tạo 2 biến cục bộ
        string strCon = @"Data Source=DESKTOP-983J608\SQLEXPRESS;Initial Catalog=QLSK;Integrated Security=True";
        //đối tượng kết nối 
        SqlConnection sqlcon = null;
        private List<int> randomNumbers = new List<int>();
        public ThemVoucher()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dtBatDau.Value > dtKetThuc.Value)
            {
                MessageBox.Show("Vui lòng chỉnh lại thời gian hợp lệ");

            }
            else
            {
                if (sqlcon == null)
                {
                    sqlcon = new SqlConnection(strCon);
                }
                if (sqlcon.State == ConnectionState.Closed) { sqlcon.Open(); }
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.CommandType = CommandType.Text;

                List<string> existingAccountIDs = new List<string>();
                sqlCmd.CommandText = "SELECT maVoucher FROM VOUCHER";
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
                    generatedID = "V" + id.ToString();
                } while (existingAccountIDs.Contains(generatedID));
                double giamGia = double.Parse(txtGiamGia.Text) / 100;
                sqlCmd.CommandText = "INSERT INTO VOUCHER VALUES(@maVoucher, @phanTramGiamGia, @moTaVoucher,@thoiGianBatDau, @thoiGianKetThuc)";
                sqlCmd.Parameters.AddWithValue("@maVoucher", generatedID);
                sqlCmd.Parameters.AddWithValue("@phanTramGiamGia", giamGia);
                sqlCmd.Parameters.AddWithValue("@moTaVoucher", txtMoTa.Text);
                sqlCmd.Parameters.AddWithValue("@thoiGianBatDau", dtBatDau.Value.ToString("yyyy-MM-dd"));
                sqlCmd.Parameters.AddWithValue("@thoiGianKetThuc", dtKetThuc.Value.ToString("yyyy-MM-dd"));
                sqlCmd.ExecuteNonQuery();
                sqlcon.Close();
                MessageBox.Show("Thêm Voucher thành công");

                this.Hide();
                BaoTriVoucher baoTriVoucher = new BaoTriVoucher();
                baoTriVoucher.ShowDialog();
            }
           
        }

        private void ThemVoucher_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            BaoTriVoucher baoTriVoucher = new BaoTriVoucher();
            baoTriVoucher.ShowDialog();
        }
    }
}
