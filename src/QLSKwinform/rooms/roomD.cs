﻿using System;
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
    public partial class roomD : Form
    {
        private string em;
        public string EM { get; set; }
        private string value;
        private string roomid;
        public string ROOMID
        {
            get { return roomid; }
            set { roomid = value; }
        }
        public roomD(string em)
        {
            InitializeComponent();
            this.em = em;
            value = em;
        }
        public roomD()
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
            roomid = "P04";
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
    }
}
