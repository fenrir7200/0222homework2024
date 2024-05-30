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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btm_Click(object sender, EventArgs e)
        {


            btm.Text = "按過嘞";
            Form from = new Formbutton();
            from.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form formTextBox = new FormTextBox();
            formTextBox.Show();
        }

        private void btnbmi_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form formc = new Formc();
            formc.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form formTryCatch = new FormTryCatch();
            formTryCatch.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form formTimer = new FormTimer();
            formTimer.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form formGameFinalPaws = new FormGameFinalPaws();
            formGameFinalPaws.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Form chatForm3 = new chatForm3();
            chatForm3.Show();
        }
    }
}
