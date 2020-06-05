using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kurs
{
    public partial class vibor : Form
    {
        public vibor()
        {
            InitializeComponent();
        }

        private void vibor_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            sot1 sot1 = new sot1();
            sot1.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            dol2 dol2 = new dol2();
            dol2.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            lec3 lec3 = new lec3();
            lec3.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            bol4 bol4 = new bol4();
            bol4.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            poc5 poc5 = new poc5();
            poc5.Show();
        }
    }
}
