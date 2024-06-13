using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms
using Sys

namespace N12312101
{
    public partial class chatForm3 : Form
    {
        public chatForm3()
        {
            InitializeComponent();

            if (!File.Exists("OrderDate.csv"))
            File.WritellText("OrderDate.csv", "Time,staples,side,beverages\n"




        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String main = "", drinking = "", sidedishes = "";

            foreach (Control c in panel1.Controls)
            {
                if (c is CheckBox)
                {
                    CheckBox chk = (CheckBox)c;
                    if (chk.Checked)
                    {
                        main += chk.Text+"，";
                    }
                }
            }

            foreach (Control c in panel2.Controls)
            {
                if (c is CheckBox)
                {
                    CheckBox chk = (CheckBox)c;
                    if (chk.Checked)
                    {
                        main +=chk.Text+" "; // main =      }
                }
            }
            main=main.Remove(main.Length-1, 1);
            drinking=drinking.Remove(drinking.Length-1, 1);
            sidedishes=sidedishes.Remove(sidedishes.Length-1, 1);
            MessageBox.Show("主食區:"+main+" 
        }
    }
}
