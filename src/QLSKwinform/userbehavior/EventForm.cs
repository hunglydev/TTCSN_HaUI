using QLSKwinform.Admin.Phong;
using QLSKwinform.Admin.Voucher;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSKwinform
{
    public partial class EventForm : Form
    {
        //tạo 2 biến cục bộ
        string strCon = @"Data Source=DESKTOP-983J608\SQLEXPRESS;Initial Catalog=QLSK;Integrated Security=True";
        //đối tượng kết nối 
        SqlConnection sqlcon = null;
        private string em;
        public string EM { get; set; }
        private string value;
        private string trangThai;
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu mn = new Menu(value);
            mn.ShowDialog();
            this.Close();
        }

        private void dGVEvent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
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
            sqlcmd.CommandText =  "select maTaiKhoan from TAIKHOAN where email='" + value + "'";
            sqlcmd.Connection = sqlcon;
            string maTK = sqlcmd.ExecuteScalar().ToString();
            //Truy van vao bang tai khoan
            sqlcmd.CommandText = @"SELECT SUKIEN.*, MAX(PHONG.TenPhong) AS TenPhong, MAX(PHONG.giaPhong) AS giaPhong, MAX(TAIKHOAN_VOUCHER.maVoucher) AS maVoucher, MAX(VOUCHER.phanTramGiamGia) AS phanTramGiamGia
FROM SUKIEN
LEFT JOIN 
    PHONG ON SUKIEN.maPhong = PHONG.maPhong	
LEFT JOIN 
    TAIKHOAN_VOUCHER ON TAIKHOAN_VOUCHER.maTaiKhoan = SUKIEN.maTaiKhoan 
LEFT JOIN 
    VOUCHER ON VOUCHER.maVoucher = TAIKHOAN_VOUCHER.maVoucher
WHERE 
    SUKIEN.maTaiKhoan = '"+maTK+"' " +
    "GROUP BY  " +
    "SUKIEN.maTaiKhoan, SUKIEN.maSuKien, SUKIEN.maPhong, SUKIEN.tenSuKien, SUKIEN.soLuongDuKien, SUKIEN.tinhTrangThanhToan, SUKIEN.ghiChu," +
    "SUKIEN.trangThai," +"SUKIEN.thoiGian, SUKIEN.voucherDaSuDung;";

            sqlcmd.Parameters.AddWithValue("@maTK", maTK);



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
                    TinhTrangThanhToan = reader.GetString(5),
                    GhiChu = reader.GetString(6),
                    TrangThai = reader.GetString(7),
                    ThoiGian = reader.GetDateTime(8),
                    MaVoucherDaSuDung = reader.GetString(9),
                    TenPhong = reader.GetString(10),                    
                    GiaPhong = (double)reader.GetValue(11),
                    MaVoucher = reader.GetString(12),
                    PhanTramGiamGia = (double)reader.GetValue(13)
                };
                listSK.Add(skp);
                
            }
           
            reader.Close();
            dGVEvent.DataSource = listSK;
            dGVEvent.Columns[0].Visible = false;
            dGVEvent.Columns[1].Visible = false;
            dGVEvent.Columns[2].Visible = false;
            dGVEvent.Columns[10].Visible = false;
            dGVEvent.Columns[13].Visible = false;
            dGVEvent.Columns[11].Visible = false;
            dGVEvent.Columns[12].Visible = false;
            dGVEvent.AutoSizeColumnsMode=DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void dGVEvent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            DataGridViewRow row = dGVEvent.Rows[e.RowIndex];
            string trangThai = row.Cells[7].Value.ToString();
            string maVoucher = row.Cells[10].Value.ToString();
            double phanTram = (double)row.Cells[13].Value;
            string tenPhong = row.Cells[9].Value.ToString();
   
            if (maVoucher =="")
            {
                SuKienPhongCombined skp = new SuKienPhongCombined()
                {
                    MaTaiKhoan = row.Cells[0].Value.ToString(),
                    MaSuKien = row.Cells[1].Value.ToString(),
                    MaPhong = row.Cells[2].Value.ToString(),
                    TenSukien = row.Cells[3].Value.ToString(),
                    SoLuong = (int)row.Cells[4].Value,
                    TinhTrangThanhToan = row.Cells[5].Value.ToString(),
                    GhiChu = row.Cells[6].Value.ToString(),
                    TrangThai = row.Cells[7].Value.ToString(),
                    ThoiGian = (DateTime)row.Cells[8].Value,
                    MaVoucherDaSuDung = row.Cells[10].Value.ToString(),
                    TenPhong = row.Cells[9].Value.ToString(),
                    GiaPhong = (double)row.Cells[11].Value,
                    MaVoucher = row.Cells[12].Value.ToString(),
                    PhanTramGiamGia = (double)row.Cells[13].Value,


                };
                
                this.Hide();
                InforEvent chiTietSuKien = new InforEvent(skp, value);
                chiTietSuKien.ShowDialog();
            }
            else
            {
                SuKienPhongCombined skp = new SuKienPhongCombined()
                {
                    MaTaiKhoan = row.Cells[0].Value.ToString(),
                    MaSuKien = row.Cells[1].Value.ToString(),
                    MaPhong = row.Cells[2].Value.ToString(),
                    TenSukien = row.Cells[3].Value.ToString(),
                    SoLuong = (int)row.Cells[4].Value,
                    TinhTrangThanhToan = row.Cells[5].Value.ToString(),
                    GhiChu = row.Cells[6].Value.ToString(),
                    TrangThai = row.Cells[7].Value.ToString(),
                    ThoiGian = (DateTime)row.Cells[8].Value,
                    MaVoucherDaSuDung = row.Cells[10].Value.ToString(),
                    TenPhong = row.Cells[9].Value.ToString(),
                    GiaPhong = (double)row.Cells[11].Value * (1-phanTram),
                    MaVoucher = row.Cells[12].Value.ToString(),
                    PhanTramGiamGia = (double)row.Cells[13].Value
                };
  
                this.Hide();
                InforEvent chiTietSuKien = new InforEvent(skp, value);
                chiTietSuKien.ShowDialog();
            }
           

        }
    }
}
