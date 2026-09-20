using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Drawing2D;
using System.Security.Cryptography.X509Certificates;

namespace Flight_Reservation_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {// Login Butonu
            // Dosyadan okuma yapıp Eşleşiyorsa form 2'yi açsın
            string Path = @"..\..\login.txt";
            if (File.Exists(Path))
            {
                string[] lines = File.ReadAllLines(Path);

                string savedEmail = lines[0]; // 025example@gmail.com
                string savedPassword = lines[1]; // 025Example

                if (txtEmail.Text == savedEmail && txtPassword.Text == savedPassword)
                {
                    Form2 frm2 = new Form2();
                    frm2.Show();
                    this.Hide();
                }
                else
                {
                    lblWarning.Visible = true;
                    lblWarning.Text = "Username or Password Incorrect!";
                }

            }
            else
            {
                MessageBox.Show("File not found");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblWarning.Visible = false;
        }

        private void txtEmail_MouseClick(object sender, MouseEventArgs e)
        {
            lblWarning.Visible = false;
            txtEmail.Text = "";
            txtPassword.Text = "";
        }

        
    }
}
