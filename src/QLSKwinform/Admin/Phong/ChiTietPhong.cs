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

namespace QLSKwinform.Admin.Phong
{
    public partial class ChiTietPhong : Form
    {
        //tạo 2 biến cục bộ
        string strCon = @"Data Source=DESKTOP-983J608\SQLEXPRESS;Initial Catalog=QLSK;Integrated Security=True";
        //đối tượng kết nối 
        SqlConnection sqlcon = null;
        public ChiTietPhong()
        {
            InitializeComponent();
        }
        public ChiTietPhong(Phong phong)
        {
            InitializeComponent();
            txtMaPhong.Enabled = false;
            txtMaPhong.Text = phong.maPhong;
            txtDiaDiem.Text = phong.diaDiem;
            txtTenPhong.Text = phong.tenPhong;
            txtSucChuaToiDa.Text = phong.sucChuaToiDa.ToString();
            txtMoTaChiTiet.Text = phong.moTaChiTiet;
            txtMoTaVanTat.Text = phong.moTaVanTat;
            txtGiaPhong.Text = phong.giaPhong.ToString();
        }

        private void ChiTietPhong_Load(object sender, EventArgs e)
        {
             
        }

        private void button2_Click(object sender, EventArgs e)
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
            sqlcmd.CommandText = "UPDATE PHONG SET tenPhong = @tenPhong, sucChuaToiDa = @sucChuaToiDa, " +
                "moTaChiTiet = @moTaChiTiet, moTaVanTat = @moTaVanTat, diaDiem = @diaDiem, giaPhong = @giaPhong WHERE maPhong = @maPhong";
            sqlcmd.Parameters.AddWithValue("@maPhong", txtMaPhong.Text);
            sqlcmd.Parameters.AddWithValue("@tenPhong", txtTenPhong.Text);
            sqlcmd.Parameters.AddWithValue("@moTaChiTiet", txtMoTaChiTiet.Text);
            sqlcmd.Parameters.AddWithValue("@moTaVanTat", txtMoTaVanTat.Text);
            sqlcmd.Parameters.AddWithValue("@diaDiem", txtDiaDiem.Text);
            sqlcmd.Parameters.AddWithValue("@sucChuaToiDa", int.Parse(txtSucChuaToiDa.Text));
            sqlcmd.Parameters.AddWithValue("@giaPhong", double.Parse(txtGiaPhong.Text));
            
            sqlcmd.Connection = sqlcon;
            sqlcmd.ExecuteNonQuery();
            sqlcon.Close();
            MessageBox.Show("Sửa thông tin thành công");
            BaoTriPhong baoTriPhong = new BaoTriPhong();
            this.Hide();
            baoTriPhong.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            BaoTriPhong phong = new BaoTriPhong();
            phong.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn xóa tài khoản này không", "Lưu ý", MessageBoxButtons.YesNo);
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
                sqlcmd.CommandText = "DELETE FROM PHONG WHERE maPhong=@maPhong";
                sqlcmd.Parameters.AddWithValue("@maVoucher", txtMaPhong.Text);
                sqlcmd.Connection = sqlcon;
                sqlcmd.ExecuteNonQuery();
                sqlcon.Close();
                MessageBox.Show("Xóa phòng thành công");
                this.Hide();
                BaoTriPhong baoTriPhong = new BaoTriPhong();
                baoTriPhong.ShowDialog();
            }
        }
    }
}
    

