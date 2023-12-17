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
    
    public partial class Menu : Form
    {
        //tạo 2 biến cục bộ
        string strCon = @"Data Source=DESKTOP-983J608\SQLEXPRESS;Initial Catalog=QLSK;Integrated Security=True";
        //đối tượng kết nối 
        SqlConnection sqlcon = null;
        private string em;
        public string EM { get; set; }
        private string value;
        public Menu(string em)
        {
            InitializeComponent();
            this.em = em;
            value = em;
        }
        public Menu()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            this.Hide();
            roomF rmF = new roomF(em);
            rmF.ShowDialog();
            this.Close();
        }

        private void picRoom1_Click(object sender, EventArgs e)
        {
            this.Hide();
            roomA rmA= new roomA(em);
            rmA.ShowDialog();
            this.Close();
        }

        private void lbRoomA_Click(object sender, EventArgs e)
        {
            this.Hide();
            roomA rmA = new roomA(em);
            rmA.ShowDialog();
            this.Close();
        }

        private void lbMountA_Click(object sender, EventArgs e)
        {
            this.Hide();
            roomA rmA = new roomA(em);
            rmA.ShowDialog();
            this.Close();
        }

        private void picRoom2_Click(object sender, EventArgs e)
        {
            this.Hide();
            roomB rmB = new roomB(em);
            rmB.ShowDialog();
            this.Close();
        }

        private void lbRoomB_Click(object sender, EventArgs e)
        {
            this.Hide();
            roomB rmB = new roomB(em);
            rmB.ShowDialog();
            this.Close();
        }

        private void lbAmountB_Click(object sender, EventArgs e)
        {
            this.Hide();
            roomB rmB = new roomB(em);
            rmB.ShowDialog();
            this.Close();
        }

        private void picRoom3_Click(object sender, EventArgs e)
        {
            this.Hide();
            roomC rmC = new roomC(em);
            rmC.ShowDialog();
            this.Close();
        }

        private void lbRoom3_Click(object sender, EventArgs e)
        {
            this.Hide();
            roomC rmC = new roomC(em);
            rmC.ShowDialog();
            this.Close();
        }

        private void lbAmountC_Click(object sender, EventArgs e)
        {
            this.Hide();
            roomC rmC = new roomC(em);
            rmC.ShowDialog();
            this.Close();
        }

        private void picRoom4_Click(object sender, EventArgs e)
        {
            this.Hide();
            roomD rmD = new roomD(em);
            rmD.ShowDialog();
            this.Close();
        }

        private void lbRoomD_Click(object sender, EventArgs e)
        {
            this.Hide();
            roomD rmD = new roomD(em);
            rmD.ShowDialog();
            this.Close();
        }

        private void lbAmountD_Click(object sender, EventArgs e)
        {
            this.Hide();
            roomD rmD = new roomD(em);
            rmD.ShowDialog();
            this.Close();
        }

        private void picRoom5_Click(object sender, EventArgs e)
        {
            this.Hide();
            roomE rmE = new roomE(em);
            rmE.ShowDialog();
            this.Close();
        }

        private void lbAmountE_Click(object sender, EventArgs e)
        {
            this.Hide();
            roomE rmE = new roomE(em);
            rmE.ShowDialog();
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Hide();
            roomE rmE = new roomE(em);
            rmE.ShowDialog();
            this.Close();
        }

        private void picRoom6_Click(object sender, EventArgs e)
        {
            this.Hide();
            roomF rmF = new roomF(em);
            rmF.ShowDialog();
            this.Close();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.Hide();
            roomF rmF = new roomF(em);
            rmF.ShowDialog();
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            formLogin frlogin = new formLogin();
            frlogin.ShowDialog();
            this.Close();
        }

        private void btnEvented_Click(object sender, EventArgs e)
        {
            this.Hide();
            EventForm eve = new EventForm(em);
            eve.ShowDialog();
            this.Close();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            if (sqlcon == null)
            {
                sqlcon = new SqlConnection(strCon);
            }
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
            }
            //đối tượng thực thi truy vấn
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;



            //câu lệnh truy vấn vào tài khoản admin
            sqlCmd.CommandText = "SELECT tenPhong  FROM PHONG WHERE maPhong = 'P01'";
            //gửi truy vấn vào kết nối
            sqlCmd.Connection = sqlcon;
            lbRoomA.Text = (string)sqlCmd.ExecuteScalar();
            sqlCmd.CommandText = "SELECT diaDiem  FROM PHONG WHERE maPhong = 'P01'";
            //gửi truy vấn vào kết nối
            sqlCmd.Connection = sqlcon;
            lbDiaDiemA.Text = (string)sqlCmd.ExecuteScalar();
            sqlCmd.CommandText = "SELECT sucChuaToiDa FROM PHONG WHERE maPhong = 'P01'";
            //gửi truy vấn vào kết nối
            sqlCmd.Connection = sqlcon;
            lbMountA.Text = "Sức chứa: " + sqlCmd.ExecuteScalar().ToString();

            //câu lệnh truy vấn vào tài khoản admin
            sqlCmd.CommandText = "SELECT tenPhong  FROM PHONG WHERE maPhong = 'P02'";
            //gửi truy vấn vào kết nối
            sqlCmd.Connection = sqlcon;
            lbRoomB.Text = (string)sqlCmd.ExecuteScalar();
            sqlCmd.CommandText = "SELECT diaDiem  FROM PHONG WHERE maPhong = 'P02'";
            //gửi truy vấn vào kết nối
            sqlCmd.Connection = sqlcon;
            lbDiaDiemB.Text = (string)sqlCmd.ExecuteScalar();
            sqlCmd.CommandText = "SELECT sucChuaToiDa FROM PHONG WHERE maPhong = 'P02'";
            //gửi truy vấn vào kết nối
            sqlCmd.Connection = sqlcon;
            lbAmountB.Text = "Sức chứa: " + sqlCmd.ExecuteScalar().ToString();

            //câu lệnh truy vấn vào tài khoản admin
            sqlCmd.CommandText = "SELECT tenPhong  FROM PHONG WHERE maPhong = 'P03'";
            //gửi truy vấn vào kết nối
            sqlCmd.Connection = sqlcon;
            lbRoomC.Text = (string)sqlCmd.ExecuteScalar();
            sqlCmd.CommandText = "SELECT diaDiem  FROM PHONG WHERE maPhong = 'P03'";
            //gửi truy vấn vào kết nối
            sqlCmd.Connection = sqlcon;
            lbDiaDiemC.Text = (string)sqlCmd.ExecuteScalar();
            sqlCmd.CommandText = "SELECT sucChuaToiDa FROM PHONG WHERE maPhong = 'P03'";
            //gửi truy vấn vào kết nối
            sqlCmd.Connection = sqlcon;
            lbAmountC.Text = "Sức chứa: " + sqlCmd.ExecuteScalar().ToString();

            //câu lệnh truy vấn vào tài khoản admin
            sqlCmd.CommandText = "SELECT tenPhong  FROM PHONG WHERE maPhong = 'P04'";
            //gửi truy vấn vào kết nối
            sqlCmd.Connection = sqlcon;
            lbRoomD.Text = (string)sqlCmd.ExecuteScalar();
            sqlCmd.CommandText = "SELECT diaDiem  FROM PHONG WHERE maPhong = 'P04'";
            //gửi truy vấn vào kết nối
            sqlCmd.Connection = sqlcon;
            lbDiaDiemD.Text = (string)sqlCmd.ExecuteScalar();
            sqlCmd.CommandText = "SELECT sucChuaToiDa FROM PHONG WHERE maPhong = 'P04'";
            //gửi truy vấn vào kết nối
            sqlCmd.Connection = sqlcon;
            lbAmountD.Text = "Sức chứa: " + sqlCmd.ExecuteScalar().ToString();

            //câu lệnh truy vấn vào tài khoản admin
            sqlCmd.CommandText = "SELECT tenPhong  FROM PHONG WHERE maPhong = 'P05'";
            //gửi truy vấn vào kết nối
            sqlCmd.Connection = sqlcon;
            lbRoomE.Text = (string)sqlCmd.ExecuteScalar();
            sqlCmd.CommandText = "SELECT diaDiem  FROM PHONG WHERE maPhong = 'P05'";
            //gửi truy vấn vào kết nối
            sqlCmd.Connection = sqlcon;
            lbDiaDiemE.Text = (string)sqlCmd.ExecuteScalar();
            sqlCmd.CommandText = "SELECT sucChuaToiDa FROM PHONG WHERE maPhong = 'P05'";
            //gửi truy vấn vào kết nối
            sqlCmd.Connection = sqlcon;
            lbAmountE.Text = "Sức chứa: " + sqlCmd.ExecuteScalar().ToString();

            //câu lệnh truy vấn vào tài khoản admin
            sqlCmd.CommandText = "SELECT tenPhong  FROM PHONG WHERE maPhong = 'P06'";
            //gửi truy vấn vào kết nối
            sqlCmd.Connection = sqlcon;
            lbRoomF.Text = (string)sqlCmd.ExecuteScalar();
            sqlCmd.CommandText = "SELECT diaDiem  FROM PHONG WHERE maPhong = 'P06'";
            //gửi truy vấn vào kết nối
            sqlCmd.Connection = sqlcon;
            lbDiaDiemF.Text = (string)sqlCmd.ExecuteScalar();
            sqlCmd.CommandText = "SELECT sucChuaToiDa FROM PHONG WHERE maPhong = 'P06'";
            //gửi truy vấn vào kết nối
            sqlCmd.Connection = sqlcon;
            lbAmountF.Text = "Sức chứa: " + sqlCmd.ExecuteScalar().ToString();
        }
    }
}
