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
    public partial class EventForm : Form
    {
        private string em;
        public string EM { get; set; }
        private string value;
        public EventForm(string em)
        {
            InitializeComponent();
            this.em = em;
            value = em;
        }
        public EventForm()
        {
            InitializeComponent();
        }
    }
}
