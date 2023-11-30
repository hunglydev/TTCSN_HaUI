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
    public partial class ThemTKVC : Form
    {
        //tạo 2 biến cục bộ
        string strCon = @"Data Source=DESKTOP-983J608\SQLEXPRESS;Initial Catalog=QLSK;Integrated Security=True";
        //đối tượng kết nối 
        SqlConnection sqlcon = null;
        public ThemTKVC()
        {
            InitializeComponent();
        }
        

        private void ChiTietTKVC_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLSKDataSet3.VOUCHER' table. You can move, or remove it, as needed.
            this.vOUCHERTableAdapter.Fill(this.qLSKDataSet3.VOUCHER);
             //TODO: This line of code loads data into the 'qLSKDataSet2.TAIKHOAN' table. You can move, or remove it, as needed.
            this.tAIKHOANTableAdapter.Fill(this.qLSKDataSet2.TAIKHOAN);
            // TODO: This line of code loads data into the 'qLSKDataSet1.TAIKHOAN_VOUCHER' table. You can move, or remove it, as needed.
            this.tAIKHOAN_VOUCHERTableAdapter1.Fill(this.qLSKDataSet1.TAIKHOAN_VOUCHER);
            // TODO: This line of code loads data into the 'qLSKDataSet.TAIKHOAN_VOUCHER' table. You can move, or remove it, as needed.
            this.tAIKHOAN_VOUCHERTableAdapter.Fill(this.qLSKDataSet.TAIKHOAN_VOUCHER);
    

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BaoTriTKVC tKVC = new BaoTriTKVC();
            this.Hide();
            tKVC.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (sqlcon == null)
            {
                sqlcon = new SqlConnection(strCon);
            }
            if (sqlcon.State == ConnectionState.Closed) { sqlcon.Open(); }

            //đối tượng thực thi truy vấn
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            string maTK = cbMaTaiKhoan.Text;
            string maVou = cbMaVoucher.Text;
            sqlCmd.CommandText = "INSERT INTO TAIKHOAN_VOUCHER VALUES (@maTaiKhoan, @maVoucher)";
            sqlCmd.Parameters.AddWithValue("@maTaiKhoan", maTK);
            sqlCmd.Parameters.AddWithValue("@maVoucher", maVou);
            sqlCmd.Connection = sqlcon;
            
            sqlCmd.ExecuteNonQuery();
            sqlcon.Close();
            MessageBox.Show("Thêm Voucher cho tài khoản thành công");
            BaoTriTKVC baoTriTKVC = new BaoTriTKVC();
            this.Hide();
            baoTriTKVC.ShowDialog();
        }
    }
}
