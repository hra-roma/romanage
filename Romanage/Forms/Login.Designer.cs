namespace Romanage
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txbx_email = new TextBox();
            txbx_password = new TextBox();
            btn_login = new Button();
            panel2 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // txbx_email
            // 
            txbx_email.BorderStyle = BorderStyle.FixedSingle;
            txbx_email.Location = new Point(147, 137);
            txbx_email.Name = "txbx_email";
            txbx_email.Size = new Size(227, 27);
            txbx_email.TabIndex = 0;
            // 
            // txbx_password
            // 
            txbx_password.BorderStyle = BorderStyle.FixedSingle;
            txbx_password.Location = new Point(147, 209);
            txbx_password.Name = "txbx_password";
            txbx_password.PasswordChar = '*';
            txbx_password.Size = new Size(224, 27);
            txbx_password.TabIndex = 1;
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.FromArgb(255, 221, 0);
            btn_login.BackgroundImageLayout = ImageLayout.None;
            btn_login.FlatAppearance.BorderColor = Color.FromArgb(255, 221, 0);
            btn_login.FlatAppearance.BorderSize = 0;
            btn_login.FlatStyle = FlatStyle.Popup;
            btn_login.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_login.Location = new Point(147, 264);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(224, 71);
            btn_login.TabIndex = 2;
            btn_login.Text = "Daxil ol";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 221, 0);
            panel2.Location = new Point(538, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 426);
            panel2.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(133, 12);
            label1.Name = "label1";
            label1.Size = new Size(267, 54);
            label1.TabIndex = 5;
            label1.Text = "romanage.az";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(149, 108);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 6;
            label2.Text = "E-poçt";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(149, 186);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 7;
            label3.Text = "Şifrə";
            // 
            // button1
            // 
            button1.Location = new Point(182, 381);
            button1.Name = "button1";
            button1.Size = new Size(140, 57);
            button1.TabIndex = 8;
            button1.Text = "Qeydiyyatdan keç";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(227, 345);
            label4.Name = "label4";
            label4.Size = new Size(43, 20);
            label4.TabIndex = 9;
            label4.Text = "və ya";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(btn_login);
            Controls.Add(txbx_password);
            Controls.Add(txbx_email);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Login";
            Text = "Giriş";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txbx_email;
        private TextBox txbx_password;
        private Button btn_login;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Label label4;
    }
}