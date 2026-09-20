namespace Flight_Reservation_System
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLblBack = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbBoxAirline = new System.Windows.Forms.ComboBox();
            this.cmbBoxFrom = new System.Windows.Forms.ComboBox();
            this.cmbBoxTo = new System.Windows.Forms.ComboBox();
            this.cmbBoxFare = new System.Windows.Forms.ComboBox();
            this.linkLblShow = new System.Windows.Forms.LinkLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.linkLblBack);
            this.panel1.Location = new System.Drawing.Point(0, -7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1144, 67);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(30, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search";
            // 
            // linkLblBack
            // 
            this.linkLblBack.AutoSize = true;
            this.linkLblBack.Font = new System.Drawing.Font("Sitka Heading", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLblBack.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.linkLblBack.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLblBack.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.linkLblBack.Location = new System.Drawing.Point(909, 16);
            this.linkLblBack.Name = "linkLblBack";
            this.linkLblBack.Size = new System.Drawing.Size(97, 48);
            this.linkLblBack.TabIndex = 0;
            this.linkLblBack.TabStop = true;
            this.linkLblBack.Text = " Back";
            this.linkLblBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblBack_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Heading", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(156, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Airline : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Heading", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(414, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 33);
            this.label3.TabIndex = 2;
            this.label3.Text = "From : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Heading", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(633, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 33);
            this.label4.TabIndex = 3;
            this.label4.Text = "To :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Heading", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(811, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 33);
            this.label5.TabIndex = 3;
            this.label5.Text = "Fare :";
            // 
            // cmbBoxAirline
            // 
            this.cmbBoxAirline.FormattingEnabled = true;
            this.cmbBoxAirline.Items.AddRange(new object[] {
            "Turkish Airlines",
            "Lufthansa",
            "Qatar Airways",
            "British Airways",
            "American Airlines"});
            this.cmbBoxAirline.Location = new System.Drawing.Point(147, 267);
            this.cmbBoxAirline.Name = "cmbBoxAirline";
            this.cmbBoxAirline.Size = new System.Drawing.Size(168, 33);
            this.cmbBoxAirline.TabIndex = 4;
            // 
            // cmbBoxFrom
            // 
            this.cmbBoxFrom.FormattingEnabled = true;
            this.cmbBoxFrom.Location = new System.Drawing.Point(363, 267);
            this.cmbBoxFrom.Name = "cmbBoxFrom";
            this.cmbBoxFrom.Size = new System.Drawing.Size(168, 33);
            this.cmbBoxFrom.TabIndex = 5;
            // 
            // cmbBoxTo
            // 
            this.cmbBoxTo.FormattingEnabled = true;
            this.cmbBoxTo.Location = new System.Drawing.Point(564, 267);
            this.cmbBoxTo.Name = "cmbBoxTo";
            this.cmbBoxTo.Size = new System.Drawing.Size(168, 33);
            this.cmbBoxTo.TabIndex = 6;
            // 
            // cmbBoxFare
            // 
            this.cmbBoxFare.FormattingEnabled = true;
            this.cmbBoxFare.Items.AddRange(new object[] {
            "Economy",
            "Business",
            "First Class"});
            this.cmbBoxFare.Location = new System.Drawing.Point(762, 267);
            this.cmbBoxFare.Name = "cmbBoxFare";
            this.cmbBoxFare.Size = new System.Drawing.Size(168, 33);
            this.cmbBoxFare.TabIndex = 7;
            // 
            // linkLblShow
            // 
            this.linkLblShow.AutoSize = true;
            this.linkLblShow.Font = new System.Drawing.Font("Sitka Heading", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLblShow.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLblShow.LinkColor = System.Drawing.Color.Maroon;
            this.linkLblShow.Location = new System.Drawing.Point(476, 402);
            this.linkLblShow.Name = "linkLblShow";
            this.linkLblShow.Size = new System.Drawing.Size(99, 48);
            this.linkLblShow.TabIndex = 8;
            this.linkLblShow.TabStop = true;
            this.linkLblShow.Text = "Show";
            this.linkLblShow.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblShow_LinkClicked);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel2.Location = new System.Drawing.Point(0, 642);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1144, 89);
            this.panel2.TabIndex = 2;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 731);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.linkLblShow);
            this.Controls.Add(this.cmbBoxFare);
            this.Controls.Add(this.cmbBoxTo);
            this.Controls.Add(this.cmbBoxFrom);
            this.Controls.Add(this.cmbBoxAirline);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Page";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel linkLblBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbBoxAirline;
        private System.Windows.Forms.ComboBox cmbBoxFrom;
        private System.Windows.Forms.ComboBox cmbBoxTo;
        private System.Windows.Forms.ComboBox cmbBoxFare;
        private System.Windows.Forms.LinkLabel linkLblShow;
        private System.Windows.Forms.Panel panel2;
    }
}