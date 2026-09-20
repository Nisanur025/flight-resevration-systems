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
    public partial class Form6 : Form
    {
        string From, To, airline, Fare; // Form5'den gelen veriler

        string taskPath = "..\\..\\task.txt";
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {//İçeriğe Tıklandığında
            
            if (e.ColumnIndex == 10 && e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Tüm satırı liste olarak almak istersen:
                List<string> allLines = new List<string>();
                foreach (DataGridViewCell cell in row.Cells)
                    allLines.Add(cell.Value?.ToString());

                allLines.RemoveRange(allLines.Count - 2, 2);

                List<string> taskList = new List<string>();

                for (int i = 0; i < allLines.Count - 2; i++)
                {
                    taskList.Add(allLines[i]);
                }
                File.WriteAllLines(taskPath, allLines);


                Form7 frm7 = new Form7();
                frm7.Show();
                this.Hide();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form5 frm5 = new Form5();
            frm5.Show();
            this.Hide();
        }

        public Form6(string From, string To, string airline, string Fare)
        {
            InitializeComponent();
            this.From = From;
            this.To = To;
            this.airline = airline;
            this.Fare = Fare;
        }
        string availableFlightPath = "..\\..\\availableFlights.txt";
        private void Form6_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
            string[] lines = File.ReadAllLines(availableFlightPath);

            bool found = false;
            foreach (var line in lines)
            {
                string[] parts = line.Split(',');

                string f_airline = parts[0];  
                string f_from = parts[2]; 
                string f_to = parts[3];       
                string f_fare = parts[6];      //Economy,firstClass..

                // FİLTRELEME
                if (f_from == From && f_to == To && f_airline == airline && f_fare == Fare)
                {
                    dataGridView1.Rows.Add(parts);
                    found = true;
                    dataGridView1.Visible = true;
                }
               
            }
            if (!found)
            {
                label1.Visible = true;
                dataGridView1.Visible = false;
                label1.Text = "No Flight Found";
            }
        }
    }
}
