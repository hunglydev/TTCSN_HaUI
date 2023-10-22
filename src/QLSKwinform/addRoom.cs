using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSKwinform
{
    public partial class addRoom : Form
    {
        private string rmName;
        public string RMNAME {
            get; set;
        }

        private string em;
        public string EM { get; set; }

        public addRoom()
        {
            InitializeComponent();
        }
        /*
         *public addRoom(string rmName){
         *InitializeComponent();
         *this.rmName = rmName;
         *txtRoomName.Text = rmName;
         *}
         */
        public void SetDataFormRoom(string rmName, string em)
        {
            txtRoomName.Text = rmName;
            txtEmail.Text = em;
        }

        

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            
        }

        private void txtRoomName_TextChanged(object sender, EventArgs e)
        {
            //txtRoomName.Text= "456";
        }

        private void btnClosetab_Click(object sender, EventArgs e)
        {
           
            this.Hide();
            Menu mn = new Menu();  
            mn.ShowDialog();
            this.Close();
        }

        
    }
}
