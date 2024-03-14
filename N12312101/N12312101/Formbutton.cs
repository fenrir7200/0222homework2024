using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N12312101
{
    public partial class Formbutton : Form
    {
        public Formbutton()
        {
            InitializeComponent();
        }

        private void buttonclick_Click(object sender, EventArgs e)
        {
            if (buttonclick.Text == "按我")
                buttonclick.Text = "我已經被按過了";
            else if (buttonclick.Text == "我已經被按過了")
                buttonclick.Text = "按我";
        }
    }
}
