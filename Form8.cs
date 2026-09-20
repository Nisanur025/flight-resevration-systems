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
using static System.Windows.Forms.LinkLabel;
using WinTextBox = System.Windows.Forms.TextBox;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Flight_Reservation_System
{
    public partial class Form8 : Form
    {
        int passengerCount;
        string SelectedSeats;
        public Form8(int passengerCount, string selectedSeats)
        {
            InitializeComponent();
            this.passengerCount = passengerCount;
            this.SelectedSeats = selectedSeats;
        }
        string userInfoPath = "..\\..\\userInfo.txt";
        string taskPath = "..\\..\\task.txt";
        string cardInfoPath = "..\\..\\cardInfo.txt";
        private void readFile()
        {
            if (!File.Exists(userInfoPath) && !File.Exists(taskPath))
            {
                MessageBox.Show("File not found.");
                return;
            }
            else
            {
                string[] lines = File.ReadAllLines(userInfoPath);
                string name, surname;

                name = lines[0].Split('=')[1];
                surname = lines[1].Split('=')[1];

                label18.Text = name + " " + surname;
                
                string[] lines2 = File.ReadAllLines(taskPath);

                label10.Text = lines2[0] + " - " + lines2[1];
                label11.Text = lines2[2] + " To " + lines2[3];
                label12.Text = lines2[4] + " - " + lines2[5];
                label13.Text = lines2[6];
                label37.Text = lines2[7];
                label15.Text = lines2[8];
                label16.Text = lines2[8];

            }
        }


        private void Form8_Load(object sender, EventArgs e)
        {
            label14.Text = passengerCount.ToString();
            readFile();

        }

        private void rdbCard_CheckedChanged(object sender, EventArgs e)
        {
           if(rdbCard.Checked == true)
           {
                pnlCardInfo.Visible = true;
                pnlBankInfo.Visible = false;
                pnlCardInfo.BringToFront();
                label38.Visible = false;
                btnPay.Visible = true;
            }
        }

        private void rdbTransfer_CheckedChanged(object sender, EventArgs e)
        {
            if(rdbTransfer.Checked == true)
            {
                pnlBankInfo.Visible = true;
                pnlCardInfo.Visible = false;
                pnlBankInfo.BringToFront();
                btnPay.Visible = false;
                label38.Visible = true;
            }
        }

        private void lnkLlbCopyIban_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Clipboard.SetText(label29.Text);
            MessageBox.Show("IBAN Copied");
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox6.Text))
            {
                btnConfirm.Visible = true;
            }
            else
            {
                btnConfirm.Visible = false;
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if(textBox6.Text == "GP20")
            {
                label21.Visible = true;
                label20.Visible = true;
                int price = Convert.ToInt16(label15.Text);
                double newPrice = price - (price * 0.2);
                label21.Text = "-20%"; 
                label16.Text = newPrice.ToString();
            }
            else
            {
                MessageBox.Show("Wrong Code");
            }
            btnConfirm.Visible = false;
        }

        Dictionary<string, string> data = new Dictionary<string, string>();
        private void btnPay_Click(object sender, EventArgs e)
        {
            bool isEqual = false;
            if (rdbCard.Checked == false && rdbTransfer.Checked == false)
            {
                MessageBox.Show("Please Select For Payment");
                return;
                
            }
            else
            {
                // Card control
                string[] lines = File.ReadAllLines(cardInfoPath);
                foreach (string line in lines)
                {
                    if (line.Contains("="))
                    {
                        string[] parts = line.Split('=');
                        data[parts[0].Trim()] = parts[1].Trim();
                    }
                }
                foreach (var item in data)
                {
                    foreach (Control ctrl in pnlCardInfo.Controls)
                    {
                        if (ctrl is WinTextBox txt)
                        {
                            if (txt.Text == item.Value)
                                isEqual = true;
                        }
                    }
                }
                if(isEqual == true)
                {
                    string date = label12.Text;
                    Form9 frm9 = new Form9(passengerCount, date, SelectedSeats);
                    frm9.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show(" Wrong Card Information ");
                    
                }
            }
               
        }

        private void Txt_Click(object sender, EventArgs e)
        {
            // Tıklanan TextBox'ı siyah yap
            WinTextBox clicked = sender as WinTextBox;
            clicked.ForeColor = Color.Black;
            clicked.Clear();
        }
        private void pnlCardInfo_VisibleChanged(object sender, EventArgs e)
        {
            if (pnlCardInfo.Visible)
            {
                foreach (Control ctrl in pnlCardInfo.Controls)
                {
                    if (ctrl is WinTextBox txt)
                    {
                        
                        txt.Click += Txt_Click;
                    }
                }
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form7 frm7 = new Form7();
            frm7.Show();
            this.Hide();
        }
    }
}
