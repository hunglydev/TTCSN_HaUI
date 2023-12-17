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
        //tạo 2 biến cục bộ
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
                sk.maTaiKhoan = reader.GetString(0);
                sk.maSuKien = reader.GetString(1);
                sk.tenSuKien = reader.GetString(3);
                sk.maPhong = reader.GetString(2);
                sk.soLuong = (int)reader.GetValue(4);
                sk.tinhTrangThanhToan = reader.GetString(5);
                sk.ghiChu = reader.GetString(6);
                sk.trangThai = reader.GetString(7);
                sk.thoiGian = reader.GetDateTime(8);
                sk.voucherDaSuDung = reader.GetString(9);
                if (sk.trangThai == "chưa xác nhận")
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
            sk.maTaiKhoan = row.Cells[0].Value.ToString();
            sk.maSuKien = row.Cells[1].Value.ToString();
            sk.tenSuKien = row.Cells[3].Value.ToString();
            sk.maPhong = row.Cells[2].Value.ToString();
            sk.soLuong = (int)row.Cells[4].Value;
            sk.tinhTrangThanhToan = row.Cells[5].ToString();
            sk.ghiChu = row.Cells[6].Value.ToString();
            sk.trangThai = row.Cells[7].ToString();
            sk.thoiGian = (DateTime)row.Cells[8].Value;
            sk.voucherDaSuDung = row.Cells[9].Value.ToString();
            ChiTietSuKien chiTietSuKien = new ChiTietSuKien(sk);
            this.Hide();
            chiTietSuKien.ShowDialog();
        }
    }
}

