namespace Flight_Reservation_System
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAvailableFlight = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Thistle;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btnSearch.FlatAppearance.BorderSize = 2;
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Sitka Heading", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSearch.Location = new System.Drawing.Point(729, 236);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(254, 262);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Search Flights";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnAvailableFlight
            // 
            this.btnAvailableFlight.BackColor = System.Drawing.Color.Thistle;
            this.btnAvailableFlight.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btnAvailableFlight.FlatAppearance.BorderSize = 2;
            this.btnAvailableFlight.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAvailableFlight.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAvailableFlight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAvailableFlight.Font = new System.Drawing.Font("Sitka Heading", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAvailableFlight.Location = new System.Drawing.Point(389, 236);
            this.btnAvailableFlight.Name = "btnAvailableFlight";
            this.btnAvailableFlight.Size = new System.Drawing.Size(264, 262);
            this.btnAvailableFlight.TabIndex = 1;
            this.btnAvailableFlight.Text = "Available Flights";
            this.btnAvailableFlight.UseVisualStyleBackColor = false;
            this.btnAvailableFlight.Click += new System.EventHandler(this.btnAvailableFlight_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.Color.Thistle;
            this.btnProfile.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btnProfile.FlatAppearance.BorderSize = 2;
            this.btnProfile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnProfile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Font = new System.Drawing.Font("Sitka Heading", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnProfile.Location = new System.Drawing.Point(45, 236);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(264, 262);
            this.btnProfile.TabIndex = 2;
            this.btnProfile.Text = "Profile Information";
            this.btnProfile.UseVisualStyleBackColor = false;
            this.btnProfile.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1082, 721);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.btnAvailableFlight);
            this.Controls.Add(this.btnSearch);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAvailableFlight;
        private System.Windows.Forms.Button btnProfile;
    }
}