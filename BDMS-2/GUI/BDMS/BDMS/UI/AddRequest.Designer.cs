namespace BDMS.UI
{
    partial class AddRequest
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
            this.lbl_head = new System.Windows.Forms.Label();
            this.cb_BG = new System.Windows.Forms.ComboBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_head
            // 
            this.lbl_head.AutoSize = true;
            this.lbl_head.Font = new System.Drawing.Font("JetBrains Mono SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_head.ForeColor = System.Drawing.Color.Red;
            this.lbl_head.Location = new System.Drawing.Point(64, 9);
            this.lbl_head.Name = "lbl_head";
            this.lbl_head.Size = new System.Drawing.Size(476, 31);
            this.lbl_head.TabIndex = 0;
            this.lbl_head.Text = "Select the Bloodgroup for Request";
            // 
            // cb_BG
            // 
            this.cb_BG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_BG.Font = new System.Drawing.Font("JetBrains Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_BG.ForeColor = System.Drawing.Color.Red;
            this.cb_BG.FormattingEnabled = true;
            this.cb_BG.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-",
            "O+",
            "O-"});
            this.cb_BG.Location = new System.Drawing.Point(177, 73);
            this.cb_BG.Name = "cb_BG";
            this.cb_BG.Size = new System.Drawing.Size(233, 29);
            this.cb_BG.TabIndex = 1;
            this.cb_BG.Click += new System.EventHandler(this.cb_BG_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.Red;
            this.btn_add.Font = new System.Drawing.Font("JetBrains Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.Snow;
            this.btn_add.Location = new System.Drawing.Point(241, 273);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(121, 34);
            this.btn_add.TabIndex = 2;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // AddRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(593, 346);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.cb_BG);
            this.Controls.Add(this.lbl_head);
            this.Name = "AddRequest";
            this.Text = "AddRequest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_head;
        private System.Windows.Forms.ComboBox cb_BG;
        private System.Windows.Forms.Button btn_add;
    }
}