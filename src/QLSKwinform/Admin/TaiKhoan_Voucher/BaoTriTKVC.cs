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

namespace QLSKwinform.Admin.TaiKhoan_Voucher
{
    public partial class BaoTriTKVC : Form
    {
        //tạo 2 biến cục bộ
        string strCon = @"Data Source=DESKTOP-983J608\SQLEXPRESS;Initial Catalog=QLSK;Integrated Security=True";
        //đối tượng kết nối 
        SqlConnection sqlcon = null;
        //lưu biến trong cell click
        string mTK, mVou;
        public BaoTriTKVC()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            adminMenu adminMenu = new adminMenu();
            this.Hide();
            adminMenu.ShowDialog();
        }

        private void BaoTriTKVC_Load(object sender, EventArgs e)
        {
            List<TKVC > tKVCs = new List<TKVC>();
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
            sqlcmd.CommandText = "SELECT * FROM TAIKHOAN_VOUCHER";

            //Gui ket qua truy van
            sqlcmd.Connection = sqlcon;
            SqlDataReader reader = sqlcmd.ExecuteReader();
            while (reader.Read())
            {
                TKVC tKVC = new TKVC();
                tKVC.maTaiKhoan = reader.GetString(0);
                tKVC.maVoucher = reader.GetString(1);
                tKVCs.Add(tKVC);
            }
            reader.Close();
            dgvTKVC.DataSource = tKVCs;
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ThemTKVC chiTietTKVC = new ThemTKVC();
            this.Hide();
            chiTietTKVC.ShowDialog();
        }

        private void dgvTKVC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)  return; 
            DataGridViewRow row = dgvTKVC.Rows[e.RowIndex];
            mTK = row.Cells[0].Value.ToString();
            mVou = row.Cells[1].Value.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (mTK == null || mVou == null) {
                MessageBox.Show("Vui lòng chọn vào hàng muốn xóa");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn xóa tài khoản với voucher này không", "Lưu ý", MessageBoxButtons.YesNo);
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
                    sqlcmd.CommandText = "DELETE FROM TAIKHOAN_VOUCHER WHERE maTaiKhoan=@maTaiKhoan AND maVoucher = @maVoucher";
                    sqlcmd.Parameters.AddWithValue("@maTaiKhoan", mTK);
                    sqlcmd.Parameters.AddWithValue("@maVoucher", mVou);
                    sqlcmd.Connection = sqlcon;
                    sqlcmd.ExecuteNonQuery();
                    sqlcon.Close();
                    MessageBox.Show("Xóa tài khoản thành công");

                    this.Hide();
                    BaoTriTKVC baoTriTaiKhoan = new BaoTriTKVC();
                    baoTriTaiKhoan.ShowDialog();

                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                }
            }
        }
    }
}
