using QLSKwinform.Admin;
using QLSKwinform.Admin.TaiKhoan;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace QLSKwinform
{
    public partial class BaoTriTaiKhoan : Form
    {

        //tạo 2 biến cục bộ
        //tạo 2 biến cục bộ
        string strCon = @"Data Source=DESKTOP-983J608\SQLEXPRESS;Initial Catalog=QLSK;Integrated Security=True";
        //đối tượng kết nối 
        SqlConnection sqlcon = null;
        public BaoTriTaiKhoan()
        {
            InitializeComponent();

        }
      
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
       
        }

        private void button1_Click(object sender, EventArgs e)
        {
          ThemTaiKhoan ttk = new ThemTaiKhoan();
            this.Hide();
            ttk.ShowDialog();
       
        }
        


        private void BaoTriTaiKhoan_Load(object sender, EventArgs e)
        {
            List<TaiKhoan> listTK = new List<TaiKhoan>();

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
            sqlcmd.CommandText = "SELECT * FROM TAIKHOAN";

            //Gui ket qua truy van
            sqlcmd.Connection = sqlcon;
            SqlDataReader reader = sqlcmd.ExecuteReader();

            while (reader.Read())
            {
                string maTaiKhoan = reader.GetString(0);
                string taiKhoan = reader.GetString(1);
                string matKhau = reader.GetString(2);
                string tenNguoiChuTri = reader.GetString(3);
                string email = reader.GetString(4);
                string sdt = reader.GetString(5);
                TaiKhoan tk = new TaiKhoan() { MaTaiKhoan = maTaiKhoan, TenTaiKhoan = taiKhoan, MatKhau = matKhau, TenNguoiChuTri = tenNguoiChuTri, Email = email, Sdt = sdt };
                listTK.Add(tk);

            }
            reader.Close();
            dgvTaiKhoan.DataSource = listTK;
        }

        private void btnTroLai_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminMenu adm = new adminMenu();
            adm.ShowDialog();
        }

        private void dgvTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            DataGridViewRow row = dgvTaiKhoan.Rows[e.RowIndex];

            string maTaiKhoan = row.Cells[0].Value.ToString();
            string tenTaiKhoan = row.Cells[1].Value.ToString();
            string matKhau = row.Cells[2].Value.ToString();
            string tenNguoiChuTri = row.Cells[3].Value.ToString();
            string email = row.Cells[4].Value.ToString();
            string sdt = row.Cells[5].Value.ToString();
            ChiTietTaiKhoan cttk = new ChiTietTaiKhoan(maTaiKhoan, tenTaiKhoan, matKhau, tenNguoiChuTri, email, sdt);
            this.Hide();
            cttk.ShowDialog();
        }
    }
}
