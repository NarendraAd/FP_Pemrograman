using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace apk
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (LinkAja.Checked == true)
            {
                Form5 f5 = new Form5();
                f5.Show();
                this.Hide();
            }
            else if (Dana.Checked == true)
            {
                Form5 f5 = new Form5();
                f5.Show();
                this.Hide();
            }
            else if (OVO.Checked == true)
            {
                Form5 f5 = new Form5();
                f5.Show();
                this.Hide();
            }
            else if (Kredivo.Checked == true)
            {
                Form5 f5 = new Form5();
                f5.Show();
                this.Hide();
            }
            else if (ShopeePay.Checked == true)
            {
                Form5 f5 = new Form5();
                f5.Show();
                this.Hide();
            }
            else if (Gopay.Checked == true)
            {
                Form5 f5 = new Form5();
                f5.Show();
                this.Hide();
            }
            else {
                MessageBox.Show("Silahkan Pilih Metode Pembayaran! ");
            }

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
