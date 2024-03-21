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

        private void button0321_Click(object sender, EventArgs e)
        {
            label0321.Text = "下面的按鈕已被按";
            label0321.Size = new System.Drawing.Size(100, 20);
            label0321.BackColor = System.Drawing.Color.Green;
        }

        private void btncount_Click(object sender, EventArgs e)
        {
            string tmp = labcount.Text;
            int sum = Int32.Parse(tmp)+1;
            labcount.Text = sum.ToString();
        }

        private void btncount1_Click(object sender, EventArgs e)
        {
            string tmp = labcount1.Text;
            int sum = Int32.Parse(tmp)-1;
            labcount1.Text = sum.ToString();
        }
    }
}
