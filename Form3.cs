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
using System.Drawing.Printing;

namespace Flight_Reservation_System
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        string userPath = "..\\..\\userinfo.txt";
        string flightPath = "..\\..\\Flight_Ticket.txt";
        string paymentPath = "..\\..\\paymentinfo.txt";
        string flightTicketPath = "..\\..\\Flight_Ticket.txt";
        private void Form3_Load(object sender, EventArgs e)
        {
            panelUser.Visible = false;
            panelTicket.Visible = false;
            panelPayment.Visible = false;
            panelWelcome.Visible = true;
        }
        private void ShowPanel(Panel panel)
        {
            Panel[] panels = { panelTicket, panelUser, panelPayment };

            foreach (Panel p in panels)
            {
                if (p == panel)
                {
                    panelWelcome.Visible = false;
                    p.BringToFront();
                    p.Visible = true;
                    
                }
                else
                {
                    p.Visible = false;
                }
            }
        }

        Dictionary<string, string> data = new Dictionary<string, string>();

        private void LoadInfo(string path)
        {
            if (!File.Exists(path))
            {
                MessageBox.Show("File not found");
                return;
            }

            string[] lines = File.ReadAllLines(path);

            // sözlüğe çevir
            foreach (string line in lines)
            {
                if (line.Contains("="))
                {
                    string[] parts = line.Split('=');
                    data[parts[0].Trim()] = parts[1].Trim();
                }
            }


            
        }

        private void FillPanelFromData(Panel panel)
        {
            //Panel içindeki textboxlara doldur
            foreach (Control ctrl in panel.Controls)
            {
                if (ctrl is TextBox txt)
                {
                    string key = txt.Name.Replace("txt", "").ToLower();   // txtName → name

                    if (data.ContainsKey(key))
                    {
                        txt.Text = data[key];
                    }
                }
                else if (ctrl is Label lbl)
                {
                    string key = lbl.Name.Replace("lbl", "");   // lblName → Nme

                    if (data.ContainsKey(key))
                    {
                        lbl.Text = data[key];
                    }
                }


            }


        }

        private void SetTextBoxesReadOnly(Panel p)
        {
            foreach (Control ctrl in p.Controls)
            {
                if (ctrl is TextBox txt)
                {
                    txt.ReadOnly = true;
                    txt.BackColor = Color.White;
                    txt.ForeColor = Color.Black;
                    txt.Cursor = Cursors.Default;

                }
            }
        }

        private void WriteFile(string path, Panel p)
        {
           
            TextBox[] order =
            {
                            txtName,
                txtSurname,
                txtEmail,
                txtPassword,
                txtAddress,
                txtCountry,
                txtPhone
            };

            List<string> lines = new List<string>();

            foreach (TextBox txt in order)
            {
                lines.Add(txt.Tag + "=" + txt.Text);
            }

            File.WriteAllLines(path, lines);

        }
        private void HandleUpdate(string path, Panel p , Button B)
        {

            if (B.Text == "Update")
            {

                foreach (Control ctrl in p.Controls)
                {
                    if (ctrl is TextBox txt)
                    {
                        txt.ReadOnly = false;
                        txt.Clear();
                    }
                }

                B.Text = "Complete";
            }
            else if (B.Text == "Complete")
            {
                WriteFile(path,p);
                MessageBox.Show("Information has been successfully updated!");

                B.Text = "Update";
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoadInfo(userPath);
            FillPanelFromData(panelUser);
            SetTextBoxesReadOnly(panelUser);
            ShowPanel(panelUser);
        }

        private void linkLblTickets_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowPanel(panelTicket);
            if (File.Exists(flightPath))
            {
                panelTicketInfo.Visible = true;
                label11.Visible = false;
                LoadInfo(flightPath);
                FillPanelFromData(panelTicketInfo);
            }
            else
            {
                label11.Visible = true;
                panelTicketInfo.Visible = false;
            }

        }

        private void linkLblPayment_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoadInfo(paymentPath);
            FillPanelFromData(panelPayment);
            SetTextBoxesReadOnly(panelPayment);
            ShowPanel(panelPayment);
        }

        private void btnPaymentUpdate_Click(object sender, EventArgs e)
        {
            HandleUpdate(paymentPath,panelPayment,btnPaymentUpdate);
        }

        private void btnUserInfoUpdate_Click(object sender, EventArgs e)
        {
            HandleUpdate(userPath, panelUser, btnUserInfoUpdate);
        }

        private void linkLblBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to cancel? ", "Confirm",                                        // Başlık
                                                    MessageBoxButtons.YesNo,                       // Butonlar
                                                    MessageBoxIcon.Question);
            if(result == DialogResult.Yes )
            {
                
                if (File.Exists(flightTicketPath))
                {
                    File.Delete(flightTicketPath);
                    
                }    
            }
            if (!File.Exists(flightTicketPath))
            {
                label11.Visible = true;
                panelTicketInfo.Visible = false;
            }
        }
    }
}