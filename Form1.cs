using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace apk
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

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }   

        private void button1_Click(object sender, EventArgs e)
        {
            //MYDB db = new MYDB();

            //string username = textBox1.Text;
            //string password = textBox2.Text;

            //DataTable table = new DataTable();
            //MySqlDataAdapter adapter = new MySqlDataAdapter();
            //MySqlCommand command = new MySqlCommand(
                //"SELECT * FROM `user` WHERE `username` =@usn AND `password` =@pass", db.getConnection());

            //command.Parameters.Add("@usn", MySqlDbType.VarChar).Value= username;
            //command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password;

            //adapter.SelectCommand = command;
            //adapter.Fill(table);

            //if (table.Rows.Count > 0)
            //{
               // this.Close();
            //}
            //else
            //{
                //if (username.Trim().Equals(""))
                //{
                    //MessageBox.Show("Enter Username to Login", "Empty Username", MessageBoxButtons.OK, MessageBoxIcon.Error );
                //}
               // else if (password.Trim().Equals(""))
                //{
                    //MessageBox.Show("Enter Password to Login", "Empty Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
                //else
                //{
                    //MessageBox.Show("Wrong Username or Password", "Wrong Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
           // }
            if (textBox1.Text == "")
            {
                MessageBox.Show("Username atau Password tidak boleh kosong");
            }
            else if (textBox1.Text == "admin" && textBox2.Text == "123456")
            {
                Form2 f2 = new Form2();
                f2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username atau Password salah");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
