namespace FireBuddy.UI
{
    partial class Start
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start));
            this.btns = new System.Windows.Forms.TableLayoutPanel();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_opt = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.option_btns = new System.Windows.Forms.TableLayoutPanel();
            this.back_btn = new System.Windows.Forms.Button();
            this.play_btn = new System.Windows.Forms.Button();
            this.instruction_btn = new System.Windows.Forms.Button();
            this.credit_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sub_panel = new System.Windows.Forms.Panel();
            this.btns.SuspendLayout();
            this.option_btns.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btns
            // 
            this.btns.AutoSize = true;
            this.btns.BackColor = System.Drawing.Color.Transparent;
            this.btns.ColumnCount = 3;
            this.btns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.btns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.btns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.btns.Controls.Add(this.btn_start, 0, 0);
            this.btns.Controls.Add(this.btn_opt, 1, 0);
            this.btns.Controls.Add(this.btn_exit, 2, 0);
            this.btns.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btns.Location = new System.Drawing.Point(0, 393);
            this.btns.Name = "btns";
            this.btns.RowCount = 1;
            this.btns.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.btns.Size = new System.Drawing.Size(800, 57);
            this.btns.TabIndex = 3;
            // 
            // btn_start
            // 
            this.btn_start.BackColor = System.Drawing.Color.Black;
            this.btn_start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_start.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_start.FlatAppearance.BorderSize = 0;
            this.btn_start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_start.Font = new System.Drawing.Font("Matura MT Script Capitals", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_start.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_start.Location = new System.Drawing.Point(3, 3);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(260, 51);
            this.btn_start.TabIndex = 1;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = false;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_opt
            // 
            this.btn_opt.BackColor = System.Drawing.Color.Black;
            this.btn_opt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_opt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_opt.FlatAppearance.BorderSize = 0;
            this.btn_opt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_opt.Font = new System.Drawing.Font("Matura MT Script Capitals", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_opt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_opt.Location = new System.Drawing.Point(269, 3);
            this.btn_opt.Name = "btn_opt";
            this.btn_opt.Size = new System.Drawing.Size(260, 51);
            this.btn_opt.TabIndex = 1;
            this.btn_opt.Text = "Options";
            this.btn_opt.UseVisualStyleBackColor = false;
            this.btn_opt.Click += new System.EventHandler(this.btn_opt_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Black;
            this.btn_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Matura MT Script Capitals", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_exit.Location = new System.Drawing.Point(535, 3);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(262, 51);
            this.btn_exit.TabIndex = 1;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // title
            // 
            this.title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("Jokerman", 72F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.DarkOrange;
            this.title.Location = new System.Drawing.Point(115, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(578, 140);
            this.title.TabIndex = 1;
            this.title.Text = "Fire Buddy";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // option_btns
            // 
            this.option_btns.AutoSize = true;
            this.option_btns.BackColor = System.Drawing.Color.Transparent;
            this.option_btns.ColumnCount = 4;
            this.option_btns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.48979F));
            this.option_btns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.17007F));
            this.option_btns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.17007F));
            this.option_btns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.17007F));
            this.option_btns.Controls.Add(this.back_btn, 3, 0);
            this.option_btns.Controls.Add(this.play_btn, 0, 0);
            this.option_btns.Controls.Add(this.instruction_btn, 1, 0);
            this.option_btns.Controls.Add(this.credit_btn, 2, 0);
            this.option_btns.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.option_btns.Location = new System.Drawing.Point(0, 336);
            this.option_btns.Name = "option_btns";
            this.option_btns.RowCount = 1;
            this.option_btns.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.option_btns.Size = new System.Drawing.Size(800, 57);
            this.option_btns.TabIndex = 4;
            // 
            // back_btn
            // 
            this.back_btn.BackColor = System.Drawing.Color.Black;
            this.back_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.back_btn.FlatAppearance.BorderSize = 0;
            this.back_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_btn.Font = new System.Drawing.Font("Matura MT Script Capitals", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.back_btn.Location = new System.Drawing.Point(600, 3);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(197, 51);
            this.back_btn.TabIndex = 6;
            this.back_btn.Text = "Back";
            this.back_btn.UseVisualStyleBackColor = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // play_btn
            // 
            this.play_btn.BackColor = System.Drawing.Color.Black;
            this.play_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.play_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.play_btn.FlatAppearance.BorderSize = 0;
            this.play_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.play_btn.Font = new System.Drawing.Font("Matura MT Script Capitals", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.play_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.play_btn.Location = new System.Drawing.Point(3, 3);
            this.play_btn.Name = "play_btn";
            this.play_btn.Size = new System.Drawing.Size(189, 51);
            this.play_btn.TabIndex = 1;
            this.play_btn.Text = "How to Play";
            this.play_btn.UseVisualStyleBackColor = false;
            this.play_btn.Click += new System.EventHandler(this.play_btn_Click);
            // 
            // instruction_btn
            // 
            this.instruction_btn.BackColor = System.Drawing.Color.Black;
            this.instruction_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.instruction_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.instruction_btn.FlatAppearance.BorderSize = 0;
            this.instruction_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.instruction_btn.Font = new System.Drawing.Font("Matura MT Script Capitals", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instruction_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.instruction_btn.Location = new System.Drawing.Point(198, 3);
            this.instruction_btn.Name = "instruction_btn";
            this.instruction_btn.Size = new System.Drawing.Size(195, 51);
            this.instruction_btn.TabIndex = 1;
            this.instruction_btn.Text = "Instruction";
            this.instruction_btn.UseVisualStyleBackColor = false;
            this.instruction_btn.Click += new System.EventHandler(this.instruction_btn_Click);
            // 
            // credit_btn
            // 
            this.credit_btn.BackColor = System.Drawing.Color.Black;
            this.credit_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.credit_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.credit_btn.FlatAppearance.BorderSize = 0;
            this.credit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.credit_btn.Font = new System.Drawing.Font("Matura MT Script Capitals", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.credit_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.credit_btn.Location = new System.Drawing.Point(399, 3);
            this.credit_btn.Name = "credit_btn";
            this.credit_btn.Size = new System.Drawing.Size(195, 51);
            this.credit_btn.TabIndex = 1;
            this.credit_btn.Text = "Credits";
            this.credit_btn.UseVisualStyleBackColor = false;
            this.credit_btn.Click += new System.EventHandler(this.credit_btn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.title);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 144);
            this.panel1.TabIndex = 6;
            // 
            // sub_panel
            // 
            this.sub_panel.BackColor = System.Drawing.Color.Transparent;
            this.sub_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sub_panel.Location = new System.Drawing.Point(0, 144);
            this.sub_panel.Name = "sub_panel";
            this.sub_panel.Size = new System.Drawing.Size(800, 192);
            this.sub_panel.TabIndex = 7;
            this.sub_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.sub_panel_Paint);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sub_panel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.option_btns);
            this.Controls.Add(this.btns);
            this.Name = "Start";
            this.Text = "Start";
            this.btns.ResumeLayout(false);
            this.option_btns.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel btns;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_opt;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.TableLayoutPanel option_btns;
        private System.Windows.Forms.Button play_btn;
        private System.Windows.Forms.Button instruction_btn;
        private System.Windows.Forms.Button credit_btn;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel sub_panel;
    }
}