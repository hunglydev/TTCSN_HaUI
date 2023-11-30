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

namespace QLSKwinform.Admin.Voucher
{
    public partial class BaoTriVoucher : Form
    {
        //tạo 2 biến cục bộ
        string strCon = @"Data Source=DESKTOP-983J608\SQLEXPRESS;Initial Catalog=QLSK;Integrated Security=True";
        //đối tượng kết nối 
        SqlConnection sqlcon = null;
        public BaoTriVoucher()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            adminMenu adminMenu = new adminMenu();
            this.Hide();
            adminMenu.ShowDialog();
        }

        private void BaoTriVoucher_Load(object sender, EventArgs e)
        {
            List<Voucher> vouchers = new List<Voucher>();
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
            sqlcmd.CommandText = "SELECT * FROM VOUCHER";
            sqlcmd.Connection = sqlcon;
            SqlDataReader reader = sqlcmd.ExecuteReader();
            while(reader.Read())
            {
                Voucher voucher = new Voucher();
                voucher.maVoucher = reader.GetString(0);
                voucher.phanTramGiamGia =  (double)reader.GetValue(1);
                voucher.moTaVoucher = reader.GetString(2);
                voucher.thoiGianBatDau = reader.GetDateTime(3);
                voucher.thoiGianKetThuc= reader.GetDateTime(4);
                vouchers.Add(voucher);
            }
            reader.Close();
            dgvVoucher.DataSource = vouchers;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvVoucher_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) { return; }
            DataGridViewRow row = dgvVoucher.Rows[e.RowIndex];
            Voucher voucher = new Voucher();
            voucher.maVoucher = row.Cells[0].Value.ToString();
            voucher.phanTramGiamGia =(double) row.Cells[1].Value;
            voucher.moTaVoucher= row.Cells[2].Value.ToString();
            voucher.thoiGianBatDau =(DateTime) row.Cells[3].Value;
            voucher.thoiGianKetThuc = (DateTime)row.Cells[4].Value;
            ChiTietVoucher ct = new ChiTietVoucher(voucher);
            this.Hide();
            ct.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ThemVoucher voucher = new ThemVoucher();
            this.Hide();
            voucher.ShowDialog();
        }
    }
}
