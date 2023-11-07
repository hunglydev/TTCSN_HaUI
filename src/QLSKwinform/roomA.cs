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
    public partial class roomA : Form
    {
        private string em;
        public string EM { get; set; }
        private string value;
        public roomA(string em)
        {
            InitializeComponent();
            this.em = em;
             value = em;
        }
        public roomA()
        {
            InitializeComponent();

        }

        private void btnCancel_click(object sender, EventArgs e)
        {
            this.Hide();
            Menu mn = new Menu();
            mn.ShowDialog();
            this.Close();
        }

        private void btnAgree_Click(object sender, EventArgs e)
        {
            string rmName = lbnameRoom.Text;
            //MessageBox.Show(roomName);
            this.Hide();
            addRoom add = new addRoom();
            add.SetDataFormRoom(rmName,value);
            
            add.ShowDialog();
            this.Close();
        }

        private void lbnameRoom_Click(object sender, EventArgs e)
        {

        }
    }
}
