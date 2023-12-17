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
    public partial class roomE : Form
    {
        //tạo 2 biến cục bộ
        string strCon = @"Data Source=DESKTOP-983J608\SQLEXPRESS;Initial Catalog=QLSK;Integrated Security=True";
        //đối tượng kết nối 
        SqlConnection sqlcon = null;
        private string em;
        public string EM { get; set; }
        private string value;
        private string roomid;
        public string ROOMID
        {
            get { return roomid; }
            set { roomid = value; }
        }
        public roomE(string em)
        {
            InitializeComponent();
            this.em = em;
            value = em;
        }
        public roomE()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu mn = new Menu(em);
            mn.ShowDialog();
            this.Close();
        }

        private void btnAgree_Click(object sender, EventArgs e)
        {
            string rmName = lbnameRoom.Text;
            roomid = "P05";
            //MessageBox.Show(roomName);
            this.Hide();
            addRoom add = new addRoom();
            add.SetDataFormRoom(rmName, value, roomid);

            add.ShowDialog();
            this.Close();
        }

        private void lbRoomA_Click(object sender, EventArgs e)
        {

        }

        private void roomE_Load(object sender, EventArgs e)
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
            lbnameRoom.Text = (string)sqlCmd.ExecuteScalar();
            sqlCmd.CommandText = "SELECT moTaChiTiet  FROM PHONG WHERE maPhong = 'P01'";
            //gửi truy vấn vào kết nối
            sqlCmd.Connection = sqlcon;
            txtDescript.Text = (string)sqlCmd.ExecuteScalar();
            sqlCmd.CommandText = "SELECT diaDiem  FROM PHONG WHERE maPhong = 'P01'";
            //gửi truy vấn vào kết nối
            sqlCmd.Connection = sqlcon;
            lbDiaDiem.Text = (string)sqlCmd.ExecuteScalar();
        }
    }
}
