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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        string seatNo;
        int passengerCount = 0;
        string SelectedSeats;
        private void SeatClick(object sender, EventArgs e)
        {
            
            Button btn = sender as Button;
            seatNo = btn.Text;
            // Koltuk zaten doluysa
            if (btn.Tag != null)
            {
                MessageBox.Show("This seat is already occupied!");
                return;
            }

            if (!rdbFemale.Checked && !rdbMale.Checked)
            {
                MessageBox.Show("Please select gender!");
                return;
            }

            if (rdbFemale.Checked)
            {
                btn.BackColor = Color.Pink;
                btn.ForeColor = Color.White;
                btn.Tag = "Female";
                passengerCount++;
            }

            else if (rdbMale.Checked)
            {
                btn.BackColor = Color.LightBlue;
                btn.ForeColor = Color.White;
                btn.Tag = "Male";
                passengerCount++;
            }

            if (!selectedSeats.Contains(seatNo))
                selectedSeats.Add(seatNo);

            // Seçimi göster (opsiyonel)
            txtSelected.AppendText(btn.Text + " - " + btn.Tag + Environment.NewLine);
            
            SelectedSeats = String.Join(",", txtSelected.Lines);// Form9'da kullanılacak
        }
        string seatStatusPath = "..\\..\\seatStatus.txt";
        private void Form7_Load(object sender, EventArgs e)
        {
            // Tüm butonları ortak event'e bağla
            foreach (Control c in panel3.Controls)
            {
                if (c is Button btn)
                {
                    btn.Click += SeatClick;
                }
            }

            if (!File.Exists(seatStatusPath))
            {
                MessageBox.Show("File not found!");
                return;
            }

            string[] lines = File.ReadAllLines(seatStatusPath);

            foreach (string line in lines)
            {
                if (line.Contains(","))
                {
                    string[] parts = line.Split(',');
                    string seatNo = parts[0].Trim();
                    string gender = parts[1].Trim(); 
                    foreach (Control c in panel3.Controls)
                    {
                        if (c is Button btn)
                        {
                            string btnSeat = btn.Text.Trim();
                            string fileSeat = seatNo.Trim();
                            if (btnSeat == fileSeat)
                            {
                                if (gender == "Female")
                                {
                                    btn.BackColor = Color.Pink;
                                    btn.ForeColor = Color.White;
                                    btn.Tag = "Female";
                                }
                                else if (gender == "Male")
                                {
                                    btn.BackColor = Color.LightBlue;
                                    btn.ForeColor = Color.White;
                                    btn.Tag = "Male";
                                }
                            }

                        }
                    }
                }
            }

        }
        List<string> selectedSeats = new List<string>();

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (selectedSeats.Count == 0)
            {
                MessageBox.Show("Please choose a seat.");
                return;
            }

            string[] lines = File.ReadAllLines(seatStatusPath);

            foreach (string seat in selectedSeats)
            {
                // O koltuğa ait buttonu bulalım
                Button seatBtn = panel3.Controls
                                       .OfType<Button>()
                                       .FirstOrDefault(b => b.Text == seat);

                if (seatBtn == null) continue;

                string gender = seatBtn.Tag?.ToString() ?? "Empty";

                for (int i = 0; i < lines.Length; i++)
                {
                    string[] parts = lines[i].Split(',');

                    if (parts[0] == seat)
                    {
                        lines[i] = $"{seat},{gender}";
                    }
                }
            }

            File.WriteAllLines(seatStatusPath, lines);

            int Count = passengerCount;
            Form8 frm8 = new Form8(Count,SelectedSeats);
            frm8.Show();
            this.Hide();
        }
    }
}
