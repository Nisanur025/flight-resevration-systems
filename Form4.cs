using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flight_Reservation_System
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        private void loadInfo(string path)
        {
            if (!File.Exists(path))
            {
                MessageBox.Show("Dosya bulunamadı!");
                return;
            }

            dataGridView1.Rows.Clear();
            
            // Satırları oku
            string[] lines = File.ReadAllLines(path);

            foreach (string line in lines)
            {
                if (string.IsNullOrWhiteSpace(line))
                    continue;

                string[] parts = line.Split(',');


                dataGridView1.Rows.Add(parts);
            }

        }
        string availableFlightPath = "..\\..\\availableFlights.txt";
        private void Form4_Load(object sender, EventArgs e)
        {
            loadInfo(availableFlightPath);
            dataGridView1.ClearSelection();
        }

        private void lnkLblBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            this.Hide();
            
        }
    }
}
