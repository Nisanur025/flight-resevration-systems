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

namespace Flight_Reservation_System
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void linkLblBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            this.Hide();
            
        }
        string countryPath = "..\\..\\country.txt";
        private void Form5_Load(object sender, EventArgs e)
        {
;           if (!File.Exists(countryPath))
            {
                MessageBox.Show("Dosya Bulunamadı!");
                return;
            }
            string[] lines = File.ReadAllLines(countryPath);
            foreach (string line in lines)
            {
                cmbBoxTo.Items.Add(line);
                cmbBoxFrom.Items.Add(line);
            }

        }

        private void linkLblShow_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string From = cmbBoxFrom.Text;
            string To = cmbBoxTo.Text;
            string airline = cmbBoxAirline.Text;
            string Fare = cmbBoxFare.Text;

            Form6 frm6 = new Form6(From,To,airline,Fare);
            frm6.Show();
            this.Hide();
        }
    }
}
