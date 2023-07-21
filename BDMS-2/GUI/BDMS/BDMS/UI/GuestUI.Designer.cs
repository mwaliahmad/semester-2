namespace BDMS.UI
{
    partial class GuestUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GuestUI));
            this.btn_donor = new System.Windows.Forms.Button();
            this.btn_recipient = new System.Windows.Forms.Button();
            this.btn_request = new System.Windows.Forms.Button();
            this.panel_Menu = new System.Windows.Forms.Panel();
            this.btn_logout = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_main = new System.Windows.Forms.Panel();
            this.panel_Menu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_donor
            // 
            this.btn_donor.BackColor = System.Drawing.Color.Red;
            this.btn_donor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_donor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_donor.Font = new System.Drawing.Font("JetBrains Mono SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.btn_donor.ForeColor = System.Drawing.Color.Black;
            this.btn_donor.Location = new System.Drawing.Point(0, 0);
            this.btn_donor.Name = "btn_donor";
            this.btn_donor.Size = new System.Drawing.Size(175, 50);
            this.btn_donor.TabIndex = 1;
            this.btn_donor.Text = "Search Donor";
            this.btn_donor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_donor.UseVisualStyleBackColor = false;
            this.btn_donor.Click += new System.EventHandler(this.btn_donor_Click);
            // 
            // btn_recipient
            // 
            this.btn_recipient.BackColor = System.Drawing.Color.Red;
            this.btn_recipient.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_recipient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_recipient.Font = new System.Drawing.Font("JetBrains Mono SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.btn_recipient.ForeColor = System.Drawing.Color.Black;
            this.btn_recipient.Location = new System.Drawing.Point(0, 50);
            this.btn_recipient.Name = "btn_recipient";
            this.btn_recipient.Size = new System.Drawing.Size(175, 50);
            this.btn_recipient.TabIndex = 2;
            this.btn_recipient.Text = "Search Recipient";
            this.btn_recipient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_recipient.UseVisualStyleBackColor = false;
            this.btn_recipient.Click += new System.EventHandler(this.btn_recipient_Click);
            // 
            // btn_request
            // 
            this.btn_request.BackColor = System.Drawing.Color.Red;
            this.btn_request.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_request.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_request.Font = new System.Drawing.Font("JetBrains Mono SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.btn_request.ForeColor = System.Drawing.Color.Black;
            this.btn_request.Location = new System.Drawing.Point(0, 100);
            this.btn_request.Name = "btn_request";
            this.btn_request.Size = new System.Drawing.Size(175, 50);
            this.btn_request.TabIndex = 3;
            this.btn_request.Text = "Add Request";
            this.btn_request.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_request.UseVisualStyleBackColor = false;
            this.btn_request.Click += new System.EventHandler(this.btn_request_Click);
            // 
            // panel_Menu
            // 
            this.panel_Menu.AutoScroll = true;
            this.panel_Menu.BackColor = System.Drawing.Color.Snow;
            this.panel_Menu.Controls.Add(this.btn_logout);
            this.panel_Menu.Controls.Add(this.btn_request);
            this.panel_Menu.Controls.Add(this.btn_recipient);
            this.panel_Menu.Controls.Add(this.btn_donor);
            this.panel_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Menu.Location = new System.Drawing.Point(0, 76);
            this.panel_Menu.Name = "panel_Menu";
            this.panel_Menu.Size = new System.Drawing.Size(175, 385);
            this.panel_Menu.TabIndex = 10;
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.Red;
            this.btn_logout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.Font = new System.Drawing.Font("JetBrains Mono SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.btn_logout.ForeColor = System.Drawing.Color.Black;
            this.btn_logout.Location = new System.Drawing.Point(0, 150);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(175, 50);
            this.btn_logout.TabIndex = 4;
            this.btn_logout.Text = "Log out";
            this.btn_logout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // Title
            // 
            this.Title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("JetBrains Mono NL SemiBold", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.Red;
            this.Title.Location = new System.Drawing.Point(14, 9);
            this.Title.Margin = new System.Windows.Forms.Padding(3);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(758, 50);
            this.Title.TabIndex = 0;
            this.Title.Text = "Blood Donation Management System";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.Title);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 76);
            this.panel1.TabIndex = 9;
            // 
            // panel_main
            // 
            this.panel_main.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_main.BackColor = System.Drawing.Color.Snow;
            this.panel_main.Location = new System.Drawing.Point(175, 76);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(609, 385);
            this.panel_main.TabIndex = 11;
            // 
            // GuestUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.panel_Menu);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(775, 475);
            this.Name = "GuestUI";
            this.Text = "Blood Donation Management System";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GuestUI_FormClosing);
            this.panel_Menu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_donor;
        private System.Windows.Forms.Button btn_recipient;
        private System.Windows.Forms.Button btn_request;
        private System.Windows.Forms.Panel panel_Menu;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_main;
    }
}