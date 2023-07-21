namespace BDMS.UI
{
    partial class EmployeeUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeUI));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Title = new System.Windows.Forms.Label();
            this.panel_Menu = new System.Windows.Forms.Panel();
            this.btn_logout = new System.Windows.Forms.Button();
            this.panel_Rmenu = new System.Windows.Forms.Panel();
            this.btn_viewR = new System.Windows.Forms.Button();
            this.btn_searchR = new System.Windows.Forms.Button();
            this.btn_uptR = new System.Windows.Forms.Button();
            this.btn_delR = new System.Windows.Forms.Button();
            this.btn_addR = new System.Windows.Forms.Button();
            this.btn_recipient = new System.Windows.Forms.Button();
            this.panel_Dmenu = new System.Windows.Forms.Panel();
            this.btn_viewD = new System.Windows.Forms.Button();
            this.btn_searchD = new System.Windows.Forms.Button();
            this.btn_uptD = new System.Windows.Forms.Button();
            this.btn_delD = new System.Windows.Forms.Button();
            this.btn_AddD = new System.Windows.Forms.Button();
            this.btn_donor = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pass = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.Label();
            this.btn_change = new System.Windows.Forms.Button();
            this.panel_main = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel_Menu.SuspendLayout();
            this.panel_Rmenu.SuspendLayout();
            this.panel_Dmenu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.Title);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 76);
            this.panel1.TabIndex = 6;
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
            // panel_Menu
            // 
            this.panel_Menu.AutoScroll = true;
            this.panel_Menu.BackColor = System.Drawing.Color.Snow;
            this.panel_Menu.Controls.Add(this.btn_logout);
            this.panel_Menu.Controls.Add(this.panel_Rmenu);
            this.panel_Menu.Controls.Add(this.btn_recipient);
            this.panel_Menu.Controls.Add(this.panel_Dmenu);
            this.panel_Menu.Controls.Add(this.btn_donor);
            this.panel_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Menu.Location = new System.Drawing.Point(0, 76);
            this.panel_Menu.Name = "panel_Menu";
            this.panel_Menu.Size = new System.Drawing.Size(175, 385);
            this.panel_Menu.TabIndex = 7;
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.Red;
            this.btn_logout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.Font = new System.Drawing.Font("JetBrains Mono SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.btn_logout.ForeColor = System.Drawing.Color.Black;
            this.btn_logout.Location = new System.Drawing.Point(0, 349);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(158, 50);
            this.btn_logout.TabIndex = 3;
            this.btn_logout.Text = "Log out";
            this.btn_logout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // panel_Rmenu
            // 
            this.panel_Rmenu.Controls.Add(this.btn_viewR);
            this.panel_Rmenu.Controls.Add(this.btn_searchR);
            this.panel_Rmenu.Controls.Add(this.btn_uptR);
            this.panel_Rmenu.Controls.Add(this.btn_delR);
            this.panel_Rmenu.Controls.Add(this.btn_addR);
            this.panel_Rmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Rmenu.Location = new System.Drawing.Point(0, 224);
            this.panel_Rmenu.Name = "panel_Rmenu";
            this.panel_Rmenu.Size = new System.Drawing.Size(158, 125);
            this.panel_Rmenu.TabIndex = 3;
            // 
            // btn_viewR
            // 
            this.btn_viewR.BackColor = System.Drawing.Color.Red;
            this.btn_viewR.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_viewR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_viewR.Font = new System.Drawing.Font("JetBrains Mono SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_viewR.ForeColor = System.Drawing.Color.White;
            this.btn_viewR.Location = new System.Drawing.Point(0, 100);
            this.btn_viewR.Name = "btn_viewR";
            this.btn_viewR.Size = new System.Drawing.Size(158, 25);
            this.btn_viewR.TabIndex = 4;
            this.btn_viewR.Text = "View all Recipients";
            this.btn_viewR.UseVisualStyleBackColor = false;
            this.btn_viewR.Click += new System.EventHandler(this.btn_viewR_Click);
            // 
            // btn_searchR
            // 
            this.btn_searchR.BackColor = System.Drawing.Color.Red;
            this.btn_searchR.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_searchR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_searchR.Font = new System.Drawing.Font("JetBrains Mono SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_searchR.ForeColor = System.Drawing.Color.White;
            this.btn_searchR.Location = new System.Drawing.Point(0, 75);
            this.btn_searchR.Name = "btn_searchR";
            this.btn_searchR.Size = new System.Drawing.Size(158, 25);
            this.btn_searchR.TabIndex = 3;
            this.btn_searchR.Text = "Search Recipient";
            this.btn_searchR.UseVisualStyleBackColor = false;
            this.btn_searchR.Click += new System.EventHandler(this.btn_searchR_Click);
            // 
            // btn_uptR
            // 
            this.btn_uptR.BackColor = System.Drawing.Color.Red;
            this.btn_uptR.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_uptR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_uptR.Font = new System.Drawing.Font("JetBrains Mono SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_uptR.ForeColor = System.Drawing.Color.White;
            this.btn_uptR.Location = new System.Drawing.Point(0, 50);
            this.btn_uptR.Name = "btn_uptR";
            this.btn_uptR.Size = new System.Drawing.Size(158, 25);
            this.btn_uptR.TabIndex = 2;
            this.btn_uptR.Text = "Update Recipient";
            this.btn_uptR.UseVisualStyleBackColor = false;
            this.btn_uptR.Click += new System.EventHandler(this.btn_uptR_Click);
            // 
            // btn_delR
            // 
            this.btn_delR.BackColor = System.Drawing.Color.Red;
            this.btn_delR.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_delR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delR.Font = new System.Drawing.Font("JetBrains Mono SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delR.ForeColor = System.Drawing.Color.White;
            this.btn_delR.Location = new System.Drawing.Point(0, 25);
            this.btn_delR.Name = "btn_delR";
            this.btn_delR.Size = new System.Drawing.Size(158, 25);
            this.btn_delR.TabIndex = 1;
            this.btn_delR.Text = "Delete Recipient";
            this.btn_delR.UseVisualStyleBackColor = false;
            this.btn_delR.Click += new System.EventHandler(this.btn_delR_Click);
            // 
            // btn_addR
            // 
            this.btn_addR.BackColor = System.Drawing.Color.Red;
            this.btn_addR.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_addR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addR.Font = new System.Drawing.Font("JetBrains Mono SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addR.ForeColor = System.Drawing.Color.White;
            this.btn_addR.Location = new System.Drawing.Point(0, 0);
            this.btn_addR.Name = "btn_addR";
            this.btn_addR.Size = new System.Drawing.Size(158, 25);
            this.btn_addR.TabIndex = 0;
            this.btn_addR.Text = "Add Recipient";
            this.btn_addR.UseVisualStyleBackColor = false;
            this.btn_addR.Click += new System.EventHandler(this.btn_addR_Click);
            // 
            // btn_recipient
            // 
            this.btn_recipient.BackColor = System.Drawing.Color.Red;
            this.btn_recipient.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_recipient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_recipient.Font = new System.Drawing.Font("JetBrains Mono SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.btn_recipient.ForeColor = System.Drawing.Color.Black;
            this.btn_recipient.Location = new System.Drawing.Point(0, 174);
            this.btn_recipient.Name = "btn_recipient";
            this.btn_recipient.Size = new System.Drawing.Size(158, 50);
            this.btn_recipient.TabIndex = 2;
            this.btn_recipient.Text = "Recipient Menu";
            this.btn_recipient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_recipient.UseVisualStyleBackColor = false;
            this.btn_recipient.Click += new System.EventHandler(this.btn_recipient_Click);
            // 
            // panel_Dmenu
            // 
            this.panel_Dmenu.Controls.Add(this.btn_viewD);
            this.panel_Dmenu.Controls.Add(this.btn_searchD);
            this.panel_Dmenu.Controls.Add(this.btn_uptD);
            this.panel_Dmenu.Controls.Add(this.btn_delD);
            this.panel_Dmenu.Controls.Add(this.btn_AddD);
            this.panel_Dmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Dmenu.Location = new System.Drawing.Point(0, 50);
            this.panel_Dmenu.Name = "panel_Dmenu";
            this.panel_Dmenu.Size = new System.Drawing.Size(158, 124);
            this.panel_Dmenu.TabIndex = 1;
            // 
            // btn_viewD
            // 
            this.btn_viewD.BackColor = System.Drawing.Color.Red;
            this.btn_viewD.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_viewD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_viewD.Font = new System.Drawing.Font("JetBrains Mono SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_viewD.ForeColor = System.Drawing.Color.White;
            this.btn_viewD.Location = new System.Drawing.Point(0, 100);
            this.btn_viewD.Name = "btn_viewD";
            this.btn_viewD.Size = new System.Drawing.Size(158, 25);
            this.btn_viewD.TabIndex = 4;
            this.btn_viewD.Text = "View all Donors";
            this.btn_viewD.UseVisualStyleBackColor = false;
            this.btn_viewD.Click += new System.EventHandler(this.btn_viewD_Click);
            // 
            // btn_searchD
            // 
            this.btn_searchD.BackColor = System.Drawing.Color.Red;
            this.btn_searchD.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_searchD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_searchD.Font = new System.Drawing.Font("JetBrains Mono SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_searchD.ForeColor = System.Drawing.Color.White;
            this.btn_searchD.Location = new System.Drawing.Point(0, 75);
            this.btn_searchD.Name = "btn_searchD";
            this.btn_searchD.Size = new System.Drawing.Size(158, 25);
            this.btn_searchD.TabIndex = 3;
            this.btn_searchD.Text = "Search Donor";
            this.btn_searchD.UseVisualStyleBackColor = false;
            this.btn_searchD.Click += new System.EventHandler(this.btn_searchD_Click);
            // 
            // btn_uptD
            // 
            this.btn_uptD.BackColor = System.Drawing.Color.Red;
            this.btn_uptD.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_uptD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_uptD.Font = new System.Drawing.Font("JetBrains Mono SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_uptD.ForeColor = System.Drawing.Color.White;
            this.btn_uptD.Location = new System.Drawing.Point(0, 50);
            this.btn_uptD.Name = "btn_uptD";
            this.btn_uptD.Size = new System.Drawing.Size(158, 25);
            this.btn_uptD.TabIndex = 2;
            this.btn_uptD.Text = "Update Donor";
            this.btn_uptD.UseVisualStyleBackColor = false;
            this.btn_uptD.Click += new System.EventHandler(this.btn_uptD_Click);
            // 
            // btn_delD
            // 
            this.btn_delD.BackColor = System.Drawing.Color.Red;
            this.btn_delD.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_delD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delD.Font = new System.Drawing.Font("JetBrains Mono SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delD.ForeColor = System.Drawing.Color.White;
            this.btn_delD.Location = new System.Drawing.Point(0, 25);
            this.btn_delD.Name = "btn_delD";
            this.btn_delD.Size = new System.Drawing.Size(158, 25);
            this.btn_delD.TabIndex = 1;
            this.btn_delD.Text = "Delete Donor";
            this.btn_delD.UseVisualStyleBackColor = false;
            this.btn_delD.Click += new System.EventHandler(this.btn_delD_Click);
            // 
            // btn_AddD
            // 
            this.btn_AddD.BackColor = System.Drawing.Color.Red;
            this.btn_AddD.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_AddD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddD.Font = new System.Drawing.Font("JetBrains Mono SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddD.ForeColor = System.Drawing.Color.White;
            this.btn_AddD.Location = new System.Drawing.Point(0, 0);
            this.btn_AddD.Name = "btn_AddD";
            this.btn_AddD.Size = new System.Drawing.Size(158, 25);
            this.btn_AddD.TabIndex = 0;
            this.btn_AddD.Text = "Add Donor";
            this.btn_AddD.UseVisualStyleBackColor = false;
            this.btn_AddD.Click += new System.EventHandler(this.btn_AddD_Click);
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
            this.btn_donor.Size = new System.Drawing.Size(158, 50);
            this.btn_donor.TabIndex = 1;
            this.btn_donor.Text = "Donor Menu";
            this.btn_donor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_donor.UseVisualStyleBackColor = false;
            this.btn_donor.Click += new System.EventHandler(this.btn_donor_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(175, 76);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(609, 50);
            this.panel2.TabIndex = 9;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Red;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.pass, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.user, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_change, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(609, 50);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pass
            // 
            this.pass.AutoSize = true;
            this.pass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pass.Font = new System.Drawing.Font("JetBrains Mono SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass.ForeColor = System.Drawing.Color.White;
            this.pass.Location = new System.Drawing.Point(205, 0);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(196, 50);
            this.pass.TabIndex = 1;
            this.pass.Text = "Password";
            this.pass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.Dock = System.Windows.Forms.DockStyle.Fill;
            this.user.Font = new System.Drawing.Font("JetBrains Mono SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user.ForeColor = System.Drawing.Color.White;
            this.user.Location = new System.Drawing.Point(3, 0);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(196, 50);
            this.user.TabIndex = 0;
            this.user.Text = "Username";
            this.user.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_change
            // 
            this.btn_change.BackColor = System.Drawing.Color.Red;
            this.btn_change.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_change.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_change.Font = new System.Drawing.Font("JetBrains Mono SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_change.Location = new System.Drawing.Point(407, 3);
            this.btn_change.Name = "btn_change";
            this.btn_change.Size = new System.Drawing.Size(199, 44);
            this.btn_change.TabIndex = 2;
            this.btn_change.Text = "Change Password";
            this.btn_change.UseVisualStyleBackColor = false;
            this.btn_change.Click += new System.EventHandler(this.btn_change_Click);
            // 
            // panel_main
            // 
            this.panel_main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_main.BackColor = System.Drawing.Color.Snow;
            this.panel_main.Location = new System.Drawing.Point(175, 126);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(609, 335);
            this.panel_main.TabIndex = 10;
            // 
            // EmployeeUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel_Menu);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(775, 475);
            this.Name = "EmployeeUI";
            this.Text = "Blood Donation Management System";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EmployeeUI_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_Menu.ResumeLayout(false);
            this.panel_Rmenu.ResumeLayout(false);
            this.panel_Dmenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Panel panel_Menu;
        private System.Windows.Forms.Button btn_donor;
        private System.Windows.Forms.Panel panel_Dmenu;
        private System.Windows.Forms.Button btn_recipient;
        private System.Windows.Forms.Panel panel_Rmenu;
        private System.Windows.Forms.Button btn_viewD;
        private System.Windows.Forms.Button btn_searchD;
        private System.Windows.Forms.Button btn_uptD;
        private System.Windows.Forms.Button btn_delD;
        private System.Windows.Forms.Button btn_AddD;
        private System.Windows.Forms.Button btn_addR;
        private System.Windows.Forms.Button btn_viewR;
        private System.Windows.Forms.Button btn_searchR;
        private System.Windows.Forms.Button btn_uptR;
        private System.Windows.Forms.Button btn_delR;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label user;
        private System.Windows.Forms.Label pass;
        private System.Windows.Forms.Button btn_change;
        private System.Windows.Forms.Panel panel_main;
    }
}