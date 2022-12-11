namespace BloodBankManagementSystem
{
    partial class CreateAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateAccount));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonCreateAccount = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxBlood = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.labelStatus = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(37)))), ((int)(((byte)(44)))));
            this.label1.Location = new System.Drawing.Point(416, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 123);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create a new account\r\n\r\n\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(350, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(350, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password";
            // 
            // buttonCreateAccount
            // 
            this.buttonCreateAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(37)))), ((int)(((byte)(44)))));
            this.buttonCreateAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCreateAccount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCreateAccount.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateAccount.ForeColor = System.Drawing.Color.Honeydew;
            this.buttonCreateAccount.Location = new System.Drawing.Point(355, 472);
            this.buttonCreateAccount.Name = "buttonCreateAccount";
            this.buttonCreateAccount.Size = new System.Drawing.Size(198, 36);
            this.buttonCreateAccount.TabIndex = 7;
            this.buttonCreateAccount.Text = "CreateAccount";
            this.buttonCreateAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonCreateAccount.UseVisualStyleBackColor = false;
            this.buttonCreateAccount.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(636, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(892, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 28);
            this.label7.TabIndex = 11;
            this.label7.Text = "X";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // comboBoxBlood
            // 
            this.comboBoxBlood.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBoxBlood.FormattingEnabled = true;
            this.comboBoxBlood.Items.AddRange(new object[] {
            "A-",
            "B-",
            "AB-",
            "O-",
            "A+",
            "B+",
            "AB+",
            "O+"});
            this.comboBoxBlood.Location = new System.Drawing.Point(638, 136);
            this.comboBoxBlood.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxBlood.Name = "comboBoxBlood";
            this.comboBoxBlood.Size = new System.Drawing.Size(237, 24);
            this.comboBoxBlood.TabIndex = 29;
            this.comboBoxBlood.SelectedIndexChanged += new System.EventHandler(this.comboBoxBlood_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("MV Boli", 15F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(634, 93);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(139, 26);
            this.label12.TabIndex = 28;
            this.label12.Text = "Blood Group";
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBoxGender.Location = new System.Drawing.Point(638, 374);
            this.comboBoxGender.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(237, 24);
            this.comboBoxGender.TabIndex = 27;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Font = new System.Drawing.Font("MV Boli", 10F);
            this.textBoxAddress.Location = new System.Drawing.Point(640, 212);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(236, 29);
            this.textBoxAddress.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("MV Boli", 15F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(634, 181);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 26);
            this.label11.TabIndex = 25;
            this.label11.Text = "Address";
            // 
            // textBoxAge
            // 
            this.textBoxAge.Font = new System.Drawing.Font("MV Boli", 10F);
            this.textBoxAge.Location = new System.Drawing.Point(638, 298);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(237, 29);
            this.textBoxAge.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("MV Boli", 15F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(634, 256);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 26);
            this.label10.TabIndex = 23;
            this.label10.Text = "Age";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("MV Boli", 15F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(633, 330);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 26);
            this.label9.TabIndex = 22;
            this.label9.Text = "Gender";
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("MV Boli", 10F);
            this.textBoxName.Location = new System.Drawing.Point(355, 298);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(246, 29);
            this.textBoxName.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("MV Boli", 15F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(350, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 26);
            this.label6.TabIndex = 30;
            this.label6.Text = "Name";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("MV Boli", 10F);
            this.textBoxPassword.Location = new System.Drawing.Point(355, 211);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(246, 29);
            this.textBoxPassword.TabIndex = 32;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Font = new System.Drawing.Font("MV Boli", 10F);
            this.textBoxUsername.Location = new System.Drawing.Point(355, 127);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(246, 29);
            this.textBoxUsername.TabIndex = 33;
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(37)))), ((int)(((byte)(44)))));
            this.buttonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLogin.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.ForeColor = System.Drawing.Color.Honeydew;
            this.buttonLogin.Location = new System.Drawing.Point(638, 472);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(198, 36);
            this.buttonLogin.TabIndex = 34;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.BackColor = System.Drawing.Color.Transparent;
            this.labelStatus.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Bold);
            this.labelStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(37)))), ((int)(((byte)(44)))));
            this.labelStatus.Location = new System.Drawing.Point(462, 439);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(0, 17);
            this.labelStatus.TabIndex = 35;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Font = new System.Drawing.Font("MV Boli", 10F);
            this.textBoxPhone.Location = new System.Drawing.Point(355, 372);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(246, 29);
            this.textBoxPhone.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("MV Boli", 15F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(350, 330);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 26);
            this.label8.TabIndex = 36;
            this.label8.Text = "Phone";
            // 
            // CreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(932, 556);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxBlood);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.comboBoxGender);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonCreateAccount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Blood Bank Management System";
            this.Load += new System.EventHandler(this.FormBank_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonCreateAccount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxBlood;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Label label8;
    }
}

