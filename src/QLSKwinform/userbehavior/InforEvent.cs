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
    public partial class InforEvent : Form
    {
        string strCon = @"Data Source=TRANMINHHIEU\SQLEXPRESS;Initial Catalog=QLSK;Integrated Security=True";
        //đối tượng kết nối 
        SqlConnection sqlcon = null;
        private string em;
        public string EM { get; set; }
        string value;
        string maSK;
        string rmID;
        public InforEvent(SuKienPhongCombined skp, string em)
        {
            this.em = em;
            value = em;
            InitializeComponent();
            txtTenSuKien.Text = skp.TenSukien.ToString();
            txtDiaDiem.Text = skp.TenPhong.ToString();
            txtSoLuong.Text = skp.SoLuong.ToString();
            txtGhiChu.Text = skp.GhiChu.ToString();
            dateTimePicker1.Text = skp.ThoiGian.ToString();
            maSK = skp.MaSuKien.ToString();
            rmID = skp.MaPhong.ToString();
        }

        private void btnAgree_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlcon = new SqlConnection(strCon))
            {
                sqlcon.Open();
                //Truy van vao bang tai khoan
                string sqlUpdate = "UPDATE SUKIEN SET tenSuKien = @TenSuKien, thoiGian = @ThoiGian, ghiChu = @GhiChu, soLuongDuKien = @SoLuongDuKien WHERE maSuKien = @MaSuKien";
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn sửa sự kiện này không?", "Xác nhận sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {


                    using (SqlCommand sqlcmd = new SqlCommand(sqlUpdate, sqlcon))
                    {
                        sqlcmd.Parameters.AddWithValue("@TenSuKien", txtTenSuKien.Text);
                        sqlcmd.Parameters.AddWithValue("@ThoiGian", dateTimePicker1.Value);
                        sqlcmd.Parameters.AddWithValue("@GhiChu", txtGhiChu.Text);
                        int soLuongDuKien;
                        if (int.TryParse(txtSoLuong.Text, out soLuongDuKien))
                        {
                            sqlcmd.Parameters.AddWithValue("@SoLuongDuKien", soLuongDuKien);
                        }
                        else
                        {
                            // Xử lý trường hợp không thể chuyển đổi thành số nguyên
                            // (ví dụ: thông báo lỗi, gán giá trị mặc định, ...)
                        }
                        sqlcmd.Parameters.AddWithValue("@MaSuKien", maSK);
                        if (IsRoomBooked(sqlcon, rmID, dateTimePicker1.Value))
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
                    EventForm ev = new EventForm(value);
                    ev.ShowDialog();
                    this.Close();



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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlcon = new SqlConnection(strCon))
            {
                sqlcon.Open();
                //Truy van vao bang tai khoan
                string sqlDelete = "DELETE FROM SUKIEN WHERE maSuKien = @MaSuKien";
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa sự kiện này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    using (SqlCommand sqlcmd = new SqlCommand(sqlDelete, sqlcon))
                    {
                        sqlcmd.Parameters.AddWithValue("@MaSuKien", maSK);
                        sqlcmd.ExecuteNonQuery();
                    }
                    this.Hide();
                    EventForm ev = new EventForm(em);
                    ev.ShowDialog();
                    this.Close();
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            EventForm evf = new EventForm();
            evf.ShowDialog();
            this.Close();
        }
    }
}
