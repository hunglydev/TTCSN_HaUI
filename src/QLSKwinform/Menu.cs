using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSKwinform
{
    
    public partial class Menu : Form
    {

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
            roomF rmF = new roomF();
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
    }
}
