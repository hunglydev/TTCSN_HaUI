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

namespace QLSKwinform.Admin.Phong
{
    public partial class ThemPhong : Form
    {
        //tạo 2 biến cục bộ
        string strCon = @"Data Source=DESKTOP-983J608\SQLEXPRESS;Initial Catalog=QLSK;Integrated Security=True";
        //đối tượng kết nối 
        SqlConnection sqlcon = null;
        private List<int> randomNumbers = new List<int>();
        public ThemPhong()
        {
            InitializeComponent();
        }

        private void ThemPhong_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (sqlcon == null)
            {
                sqlcon = new SqlConnection(strCon);
            }
            if (sqlcon.State == ConnectionState.Closed) { sqlcon.Open(); }
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;

            List<string> existingAccountIDs = new List<string>();
            sqlCmd.CommandText = "SELECT maPhong FROM PHONG";
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
                generatedID = "P" + id.ToString();
            } while (existingAccountIDs.Contains(generatedID));
            sqlCmd.CommandText = "INSERT INTO PHONG VALUES (@maPhong, @tenPhong, @diaDiem, @sucChuaToiDa, @moTaChiTiet, @moTaVanTat, @giaPhong)";
            sqlCmd.Parameters.AddWithValue("@maPhong", generatedID);
            sqlCmd.Parameters.AddWithValue("@tenPhong", txtTenPhong.Text);
            sqlCmd.Parameters.AddWithValue("@diaDiem", txtDiaDiem.Text);
            sqlCmd.Parameters.AddWithValue("@sucChuaToiDa", int.Parse(txtSucChuaToiDa.Text));
            sqlCmd.Parameters.AddWithValue("moTaVanTat", txtMoTaVanTat.Text);
            sqlCmd.Parameters.AddWithValue("@maPmoTaChiTiet", txtMoTaChiTiet.Text);
            sqlCmd.Parameters.AddWithValue("@maPmoTaChiTiet", double.Parse(txtGiaPhong.Text));
            sqlCmd.ExecuteNonQuery();
            sqlcon.Close();
            MessageBox.Show("Thêm phòng thành công");

            this.Hide();
            BaoTriPhong baoTriPhong = new BaoTriPhong();
            baoTriPhong.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BaoTriPhong baoTriPhong = new BaoTriPhong();
            this.Hide();
            baoTriPhong.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
