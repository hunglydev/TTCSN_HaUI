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
           
            txtMaTaiKhoan.Text = sk.maTaiKhoan;
            txtMaSuKien.Text = sk.maSuKien;
            txtTenSuKien.Text = sk.tenSuKien;
            txtGhiChu.Text = sk .ghiChu;
            txtMaPhong.Text = sk.maPhong;
            txtSoLuong.Text = sk.soLuong.ToString();
            dtThoiGian.Value = sk.thoiGian.ToLocalTime();
            txtVoucherDaSuDung.Text = sk.voucherDaSuDung;
            if (sk.trangThai == "đã xác nhận")
            {
                rdDaXacNhan.Checked = true;
            }
            else
            {
                rdChuaXacNhan.Checked = true;
            }
            if (sk.tinhTrangThanhToan == "đã thanh toán")
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
            string thanhToan, trangThai;
            if (rdChuaThanhToan.Checked==true)
            {
                thanhToan = "chưa thanh toán";
            }
            else
            {
                thanhToan = "đã thanh toán";
            }

            if (rdChuaXacNhan.Checked==true)
            {
                trangThai = "chưa xác nhận";

            }
            else
            {
                trangThai = "đã xác nhận";
            }
            using (SqlConnection sqlcon = new SqlConnection(strCon))
            {
                sqlcon.Open();
                //Truy van vao bang tai khoan
                string sqlUpdate = "UPDATE SUKIEN SET " +
                    "tenSuKien = @tenSuKien,  soLuongDuKien = @soLuongDuKien," +
                    "tinhTrangThanhToan = @thanhToan, ghiChu = @ghiChu, trangThai = @trangThai, thoiGian = @thoiGian," +
                    "voucherDaSuDung = @voucherDaSuDung  WHERE maSuKien = @maSuKien";
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
                        sqlcmd.Parameters.AddWithValue("@thanhToan", thanhToan);
                        sqlcmd.Parameters.AddWithValue("@voucherDaSuDung", txtVoucherDaSuDung.Text);
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
