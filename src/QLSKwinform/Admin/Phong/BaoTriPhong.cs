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
    public partial class BaoTriPhong : Form
    {
        //tạo 2 biến cục bộ
        string strCon = @"Data Source=DESKTOP-983J608\SQLEXPRESS;Initial Catalog=QLSK;Integrated Security=True";
        //đối tượng kết nối 
        SqlConnection sqlcon = null;
        public BaoTriPhong()
        {
            InitializeComponent();
        }

        private void BaoTriPhong_Load(object sender, EventArgs e)
        {
            List<Phong> listPhong = new List<Phong>();
            if (sqlcon == null)
            {
                sqlcon = new SqlConnection(strCon);
            }
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
            }
            //Đối tượng thực thi truy vấn
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.Text;

            //Truy van vao bang tai khoan
            sqlcmd.CommandText = "SELECT * FROM PHONG";

            //Gui ket qua truy van
            sqlcmd.Connection = sqlcon;
            SqlDataReader reader = sqlcmd.ExecuteReader();
            while (reader.Read())
            {
                Phong phong = new Phong();
                phong.maPhong = reader.GetString(0);
                phong.tenPhong = reader.GetString(1);
                phong.diaDiem = reader.GetString(2);
                phong.sucChuaToiDa = (int)reader.GetValue(3);
                phong.moTaChiTiet = reader.GetString(4);
                phong.moTaVanTat = reader.GetString(5);
                phong.giaPhong = (double)reader.GetValue(6);
                listPhong.Add(phong);
            }
            reader.Close();
            dgvPhong.DataSource = listPhong;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ThemPhong themPhong = new ThemPhong();
            this.Hide();
            themPhong.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            adminMenu adminMenu = new adminMenu();
            this.Hide();
            adminMenu.ShowDialog();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dgvPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            DataGridViewRow row = dgvPhong.Rows[e.RowIndex];
            Phong phong = new Phong();
            phong.maPhong = row.Cells[0].Value.ToString();
            phong.tenPhong = row.Cells[1].Value.ToString();
            phong.diaDiem = row.Cells[2].Value.ToString();
            phong.sucChuaToiDa =(int) row.Cells[3].Value;
            phong.moTaChiTiet = row.Cells[4].Value.ToString() ;
            phong.moTaVanTat = row.Cells[5].Value.ToString();
            phong.giaPhong = (double)row.Cells[6].Value;
            ChiTietPhong chiTietPhong = new ChiTietPhong(phong);
            this.Hide();
            chiTietPhong.ShowDialog();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
