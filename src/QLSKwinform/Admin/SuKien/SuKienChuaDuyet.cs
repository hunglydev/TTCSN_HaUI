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

namespace QLSKwinform.Admin.SuKien
{
    public partial class SuKienChuaDuyet : Form
    {
        string strCon = @"Data Source=DESKTOP-983J608\SQLEXPRESS;Initial Catalog=QLSK;Integrated Security=True";
        //đối tượng kết nối 
        SqlConnection sqlcon = null;
        public SuKienChuaDuyet()
        {
            InitializeComponent();
        }

        private void dgvBaoTriSuKien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SuKienChuaDuyet_Load(object sender, EventArgs e)
        {
            List<SuKien> listSK = new List<SuKien>();
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
            sqlcmd.CommandText = "SELECT * FROM SUKIEN";

            //Gui ket qua truy van
            sqlcmd.Connection = sqlcon;
            SqlDataReader reader = sqlcmd.ExecuteReader();


            while (reader.Read())
            {
                SuKien sk = new SuKien();
                sk.MaTaiKhoan = reader.GetString(0);
                sk.MaSuKien = reader.GetString(1);
                sk.TenSukien = reader.GetString(3);
                sk.MaPhong = reader.GetString(2);
                sk.SoLuong = (int)reader.GetValue(4);
                sk.TinhTrangThanhToan = (int)reader.GetValue(5);
                sk.GhiChu = reader.GetString(6);
                sk.TrangThai = (int)reader.GetValue(7);
                sk.ThoiGian = reader.GetDateTime(8);
                if (sk.TrangThai == 0)
                {
                    listSK.Add(sk);
                }

            }
            reader.Close();
            dgvSuKienChuaDuyet.DataSource = listSK;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            BaoTriSuKien btsk = new BaoTriSuKien();
            btsk.ShowDialog();
        }

        private void dgvSuKienChuaDuyet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            SuKien sk = new SuKien();
            DataGridViewRow row = dgvSuKienChuaDuyet.Rows[e.RowIndex];
            sk.MaTaiKhoan = row.Cells[0].Value.ToString();
            sk.MaSuKien = row.Cells[1].Value.ToString();
            sk.TenSukien = row.Cells[3].Value.ToString();
            sk.MaPhong = row.Cells[2].Value.ToString();
            sk.SoLuong = (int)row.Cells[4].Value;
            sk.TinhTrangThanhToan = (int)row.Cells[5].Value;
            sk.GhiChu = row.Cells[6].Value.ToString();
            sk.TrangThai = (int)row.Cells[7].Value;
            sk.ThoiGian = (DateTime)row.Cells[8].Value;
            ChiTietSuKien chiTietSuKien = new ChiTietSuKien(sk);
            this.Hide();
            chiTietSuKien.ShowDialog();
        }
    }
}

