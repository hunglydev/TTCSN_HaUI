using QLSKwinform;
using QLSKwinform.Admin.Phong;
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
    public partial class EventForm : Form 
    {
        string strCon = @"Data Source=TRANMINHHIEU\SQLEXPRESS;Initial Catalog=QLSK;Integrated Security=True";
        //đối tượng kết nối 
        SqlConnection sqlcon = null;
        private string em;
        public string EM { get; set; }
        private string value;
        private int trangThai;
        public EventForm(string em)
        {
            InitializeComponent();
            this.em = em;
            value = em;
        }
        public EventForm()
        {
            InitializeComponent();
        }

        //public string thanhToan(int trangThai)
        //{
        //    if (trangThai == 1)
        //    {
        //        return "Đã thanh toán";
        //    }
        //    return "Chưa thanh toán";
        //}
        public string TrangThai(int trangThai)
        {
            if (trangThai == 1) { return "Đã đặt phòng"; }
            return "Chưa đặt phòng";
        }

        private void dGVEvent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            
            DataGridViewRow row = dGVEvent.Rows[e.RowIndex];
            int trangThai = (int)row.Cells[7].Value;
            if(trangThai == 0)
            {
                SuKienPhongCombined skp = new SuKienPhongCombined()
                {
                    MaTaiKhoan = row.Cells[0].Value.ToString(),
                    MaSuKien = row.Cells[1].Value.ToString(),
                    MaPhong = row.Cells[2].Value.ToString(),
                    TenSukien = row.Cells[3].Value.ToString(),
                    SoLuong = (int)row.Cells[4].Value,
                    TinhTrangThanhToan = (int)row.Cells[5].Value,
                    GhiChu = row.Cells[6].Value.ToString(),
                    TrangThai = trangThai,
                    ThoiGian = (DateTime)row.Cells[8].Value,
                    TenPhong = row.Cells[9].Value.ToString()
                };
                
                this.Hide();
                InforEvent chiTietSuKien = new InforEvent(skp,value);
                chiTietSuKien.ShowDialog();
            }
            else{
                MessageBox.Show("Phòng đã xác nhận. Không thể thay đổi.");
            }

            
 
}

        private void EventForm_Load(object sender, EventArgs e)
        {
            List<SuKienPhongCombined> listSK = new List<SuKienPhongCombined>();
  
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
            sqlcmd.CommandText = "SELECT SUKIEN.*, PHONG.TenPhong FROM SUKIEN " +
                "INNER JOIN PHONG ON SUKIEN.MaPhong = PHONG.MaPhong";

            //Gui ket qua truy van
            sqlcmd.Connection = sqlcon;
            SqlDataReader reader = sqlcmd.ExecuteReader();
            while (reader.Read())
            {

                SuKienPhongCombined skp = new SuKienPhongCombined
                {
                    MaTaiKhoan = reader.GetString(0),
                    MaSuKien = reader.GetString(1),
                    MaPhong = reader.GetString(2),
                    TenSukien = reader.GetString(3),
                    SoLuong = (int)reader.GetValue(4),
                    TinhTrangThanhToan = (int)reader.GetValue(5),
                    GhiChu = reader.GetString(6),
                    TrangThai = (int)reader.GetValue(7),
                    ThoiGian = reader.GetDateTime(8),
                    TenPhong = reader.GetString(9)
                };
                listSK.Add(skp);
            }
            reader.Close();
            

            dGVEvent.DataSource = listSK;
            dGVEvent.Columns[0].Visible = false;
            dGVEvent.Columns[1].Visible = false;
            dGVEvent.Columns[2].Visible = false;
            dGVEvent.AutoSizeColumnsMode=DataGridViewAutoSizeColumnsMode.AllCells;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu mn = new Menu(value);
            mn.ShowDialog();
            this.Close();
        }

        private void dGVEvent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            DataGridViewRow row = dGVEvent.Rows[e.RowIndex];
            int trangThai = (int)row.Cells[7].Value;
            if (trangThai == 0)
            {
                SuKienPhongCombined skp = new SuKienPhongCombined()
                {
                    MaTaiKhoan = row.Cells[0].Value.ToString(),
                    MaSuKien = row.Cells[1].Value.ToString(),
                    MaPhong = row.Cells[2].Value.ToString(),
                    TenSukien = row.Cells[3].Value.ToString(),
                    SoLuong = (int)row.Cells[4].Value,
                    TinhTrangThanhToan = (int)row.Cells[5].Value,
                    GhiChu = row.Cells[6].Value.ToString(),
                    TrangThai = trangThai,
                    ThoiGian = (DateTime)row.Cells[8].Value,
                    TenPhong = row.Cells[9].Value.ToString()
                };

                this.Hide();
                InforEvent chiTietSuKien = new InforEvent(skp, value);
                chiTietSuKien.ShowDialog();
            }
            else
            {
                MessageBox.Show("Phòng đã xác nhận. Không thể thay đổi.");
            }

        }
    }
}
