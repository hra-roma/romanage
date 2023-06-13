namespace Romanage.Forms
{
    partial class Register
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
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            btn_login = new Button();
            txbx_password = new TextBox();
            txbx_name = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txbx_email = new TextBox();
            txbx_surname = new TextBox();
            txbx_phone = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(87, 281);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 16;
            label3.Text = "Şifrə";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(87, 49);
            label2.Name = "label2";
            label2.Size = new Size(28, 20);
            label2.TabIndex = 15;
            label2.Text = "Ad";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(74, -8);
            label1.Name = "label1";
            label1.Size = new Size(267, 54);
            label1.TabIndex = 14;
            label1.Text = "romanage.az";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 221, 0);
            panel2.Location = new Point(478, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 426);
            panel2.TabIndex = 13;
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.FromArgb(255, 221, 0);
            btn_login.BackgroundImageLayout = ImageLayout.None;
            btn_login.FlatAppearance.BorderColor = Color.FromArgb(255, 221, 0);
            btn_login.FlatAppearance.BorderSize = 0;
            btn_login.FlatStyle = FlatStyle.Popup;
            btn_login.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_login.Location = new Point(89, 358);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(224, 71);
            btn_login.TabIndex = 12;
            btn_login.Text = "Qeydiyyat";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // txbx_password
            // 
            txbx_password.BorderStyle = BorderStyle.FixedSingle;
            txbx_password.Location = new Point(89, 304);
            txbx_password.Name = "txbx_password";
            txbx_password.PasswordChar = '*';
            txbx_password.Size = new Size(224, 27);
            txbx_password.TabIndex = 11;
            // 
            // txbx_name
            // 
            txbx_name.BorderStyle = BorderStyle.FixedSingle;
            txbx_name.Location = new Point(88, 72);
            txbx_name.Name = "txbx_name";
            txbx_name.Size = new Size(227, 27);
            txbx_name.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(87, 155);
            label4.Name = "label4";
            label4.Size = new Size(53, 20);
            label4.TabIndex = 20;
            label4.Text = "E-poçt";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(87, 102);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 19;
            label5.Text = "Soyad";
            // 
            // txbx_email
            // 
            txbx_email.BorderStyle = BorderStyle.FixedSingle;
            txbx_email.Location = new Point(87, 178);
            txbx_email.Name = "txbx_email";
            txbx_email.Size = new Size(224, 27);
            txbx_email.TabIndex = 18;
            // 
            // txbx_surname
            // 
            txbx_surname.BorderStyle = BorderStyle.FixedSingle;
            txbx_surname.Location = new Point(89, 125);
            txbx_surname.Name = "txbx_surname";
            txbx_surname.Size = new Size(227, 27);
            txbx_surname.TabIndex = 17;
            // 
            // txbx_phone
            // 
            txbx_phone.BorderStyle = BorderStyle.FixedSingle;
            txbx_phone.Location = new Point(87, 241);
            txbx_phone.Name = "txbx_phone";
            txbx_phone.Size = new Size(224, 27);
            txbx_phone.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(87, 218);
            label6.Name = "label6";
            label6.Size = new Size(58, 20);
            label6.TabIndex = 22;
            label6.Text = "Telefon";
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(txbx_phone);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(txbx_email);
            Controls.Add(txbx_surname);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(btn_login);
            Controls.Add(txbx_password);
            Controls.Add(txbx_name);
            Name = "Register";
            Text = "Register";
            FormClosed += Register_FormClosed;
            Load += Register_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private Button btn_login;
        private TextBox txbx_password;
        private TextBox txbx_name;
        private Label label4;
        private Label label5;
        private TextBox txbx_email;
        private TextBox txbx_surname;
        private TextBox txbx_phone;
        private Label label6;
    }
}