using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Flight_Reservation_System
{
    public partial class Form9 : Form
    {
        int PassengerCount;
        string date,SelectedSeats;
        
        public Form9(int passengerCount, string date, string selectedSeats)
        {
            InitializeComponent();
            this.PassengerCount = passengerCount;
            this.date = date;
            this.SelectedSeats = selectedSeats;
        }

        Random rnd = new Random();
        int code, num;
        private void RandomCode()
        {
           
            int[] nums = { 1243, 1343, 5676, 8754, 2345, 5678, 7897};
            code = rnd.Next(7);
            num = nums[code];
            MessageBox.Show("password : " + num + "\nYou have only have 1.5 min");
        }
        
        private void Form9_Load(object sender, EventArgs e)
        {
            RandomCode();
            timer1.Start();
        }
        int min = 1, sec = 50;

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "TXT File | *.txt";
            sfd.FileName = "Flight_Ticket.txt";

            // PNR üret
            Random rnd = new Random();
            string[] pnrCodes = { "1X5F", "4Gb6", "7m8F", "9KL3", "23N2" };
            string PNR = pnrCodes[rnd.Next(pnrCodes.Length)];

            // Bilet sözlüğü
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("Passenger", PassengerCount.ToString());
            dic.Add("Date", date);
            dic.Add("Seats", SelectedSeats);
            dic.Add("PNR", PNR);

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                // Tüm metni oluştur
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("----------- TICKET -----------");
                sb.AppendLine("");

                foreach (var item in dic)
                {
                    sb.AppendLine(item.Key + " = " + item.Value);
                }

                File.WriteAllText(sfd.FileName, sb.ToString());

                MessageBox.Show("Bilet başarıyla indirildi!");

            }
            Form2 frm2 = new Form2();
            frm2.Show();
            this.Hide();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if (sec == 0)
            {
                if (min == 0)
                {
                    timer1.Stop();
                    label3.Text = "00 : 00";
                    label2.Visible = true;
                    label2.Text = "Time out, try again";
                    button1.Text = "Send Code";
                    return;
                }

                min--;
                sec = 59;
            }
            else
            {
                sec--;
            }

            label3.Text = $"0{min} : {sec}";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            linkLabel1.Visible = false;

            if (textBox1.Text != num.ToString())
            {
                label2.Visible = true;
                label2.Text = "Wrong Code";
                textBox1.Clear();
            }
            else
            {
                linkLabel1.Visible = true;
                label2.Visible = true;
                label2.Text = "Payment Successful";
                timer1.Stop();
                label3.Visible = false;
            }

            if(button1.Text == "Send Code")
            {
                label2.Visible = false;
                button1.Text = "Submit";
                RandomCode();
                // Değerler sıfırlandığı için Timer'ı başlatmama rağmen 0 'dan başlayacak
                min = 1;
                sec = 59;
                timer1.Start();
                
            }
            
        }
    }
}
