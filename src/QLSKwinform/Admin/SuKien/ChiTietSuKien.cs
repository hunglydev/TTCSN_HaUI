using QLSKwinform.Admin.Voucher;
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
    public partial class ChiTietSuKien : Form
    {
        //tạo 2 biến cục bộ
        string strCon = @"Data Source=DESKTOP-983J608\SQLEXPRESS;Initial Catalog=QLSK;Integrated Security=True";
        //đối tượng kết nối 
        SqlConnection sqlcon = null;

        private SuKien suKien = new SuKien();
        public ChiTietSuKien()
        {
            InitializeComponent();
        }
        public ChiTietSuKien(SuKien sk)
        {
            InitializeComponent();
            suKien.MaTaiKhoan = sk.MaTaiKhoan;
            suKien.MaSuKien = sk.MaSuKien;
            suKien.TenSukien = sk.TenSukien;
            suKien.MaPhong = sk.MaPhong;
            suKien.SoLuong = sk.SoLuong;
            suKien.TinhTrangThanhToan = sk.TinhTrangThanhToan;
            suKien.GhiChu = sk.GhiChu;
            suKien.TrangThai = sk.TrangThai;
            suKien.ThoiGian = sk.ThoiGian;
            txtMaTaiKhoan.Text = suKien.MaTaiKhoan;
            txtMaSuKien.Text = suKien.MaSuKien;
            txtTenSuKien.Text = suKien.TenSukien;
            txtGhiChu.Text = suKien.GhiChu;
            txtMaPhong.Text = suKien.MaPhong;
            txtSoLuong.Text = suKien.SoLuong.ToString();
            dtThoiGian.Value = suKien.ThoiGian.ToLocalTime();
            if (suKien.TrangThai == 1)
            {
                rdDaXacNhan.Checked = true;
            }
            else
            {
                rdChuaXacNhan.Checked = true;
            }
            if (suKien.TinhTrangThanhToan == 1)
            {
                rdDaThanhToan.Checked = true;
            }
            else
            {
                rdChuaThanhToan.Checked = true;
            }
        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            BaoTriSuKien baoTriSuKien = new BaoTriSuKien();
            baoTriSuKien.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn duyệt phòng này không", "Lưu ý", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }
            else
            {
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandType = CommandType.Text;
                sqlcmd.CommandText = "UPDATE SUKIEN SET trangThai = @trangThai where maSuKien = @maSuKien";
            }
        }

        private void ChiTietSuKien_Load(object sender, EventArgs e)
        {

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

        private void button3_Click(object sender, EventArgs e)
        {
            int thanhToan, trangThai;
            if (rdChuaThanhToan.Checked)
            {
                thanhToan = 0;
            }
            else
            {
                thanhToan = 1;
            }
            if (rdChuaXacNhan.Checked)
            {
                trangThai = 0;

            }
            else
            {
                trangThai = 1;
            }
            using (SqlConnection sqlcon = new SqlConnection(strCon))
            {
                sqlcon.Open();
                //Truy van vao bang tai khoan
                string sqlUpdate = "UPDATE SUKIEN SET " +
                    "tenSuKien = @tenSuKien,  soLuongDuKien = @soLuongDuKien," +
                    "tinhTrangThanhToan = @thanhToan, ghiChu = @ghiChu, trangThai = @trangThai, thoiGian = @thoiGian  WHERE maSuKien = @maSuKien";
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn sửa sự kiện này không?", "Xác nhận sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(result == DialogResult.Yes)
                {
                    
                    
                    using (SqlCommand sqlcmd = new SqlCommand(sqlUpdate, sqlcon))
                    {
                        sqlcmd.Parameters.AddWithValue("@tenSuKien", txtTenSuKien.Text);
                        sqlcmd.Parameters.AddWithValue("@thoiGian", dtThoiGian.Value);
                        sqlcmd.Parameters.AddWithValue("@ghiChu", txtGhiChu.Text);
                        sqlcmd.Parameters.AddWithValue("@soLuongDuKien", int.Parse(txtSoLuong.Text));
                        sqlcmd.Parameters.AddWithValue("@trangThai", trangThai);
                        sqlcmd.Parameters.AddWithValue("@thanhToan",thanhToan);
           
                        sqlcmd.Parameters.AddWithValue("@maSuKien", txtMaSuKien.Text);
                        if (IsRoomBooked(sqlcon, txtMaPhong.Text, dtThoiGian.Value))
                        {
                            MessageBox.Show("Phòng đã kín vào thời điểm này. Vui lòng chọn thời điểm khác.");
                            return;
                        }
                        else
                        {
                            sqlcmd.ExecuteNonQuery();
                        }

                    }
                    this.Hide();
                    BaoTriSuKien baoTriSuKien = new BaoTriSuKien();
                    baoTriSuKien.ShowDialog();
                }
            }
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBatDau_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int thanhToan, trangThai;
            if (rdChuaThanhToan.Checked)
            {
                thanhToan = 0;
            }
            else
            {
                thanhToan = 1;
            }
            if (rdChuaXacNhan.Checked)
            {
                trangThai = 0;

            }
            else
            {
                trangThai = 1;
            }
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn xóa sự kiện này không", "Lưu ý", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (sqlcon == null)
                {
                    sqlcon = new SqlConnection(strCon);
                }

                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }

                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandType = CommandType.Text;
                sqlcmd.CommandText = "DELETE FROM SUKIEN WHERE maSuKien=@maSuKien";

                sqlcmd.Parameters.AddWithValue("@maSuKien", txtMaSuKien.Text);

                sqlcmd.Connection = sqlcon;
              
                sqlcmd.ExecuteNonQuery();
                sqlcon.Close();
                MessageBox.Show("Xóa sự kiện thành công");
                this.Hide();
                BaoTriSuKien baoTriVoucher = new BaoTriSuKien();
                baoTriVoucher.ShowDialog();
            }
        }
    }
}
