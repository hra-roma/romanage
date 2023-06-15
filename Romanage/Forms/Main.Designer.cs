namespace Romanage.Forms
{
    partial class Main
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
            panel1 = new Panel();
            btn_basket = new Button();
            btn_contact = new Button();
            btn_about = new Button();
            btn_profil = new Button();
            btn_events = new Button();
            pnl_events = new Panel();
            pnl_profil = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_basket);
            panel1.Controls.Add(btn_contact);
            panel1.Controls.Add(btn_about);
            panel1.Controls.Add(btn_profil);
            panel1.Controls.Add(btn_events);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 62);
            panel1.TabIndex = 0;
            // 
            // btn_basket
            // 
            btn_basket.Location = new Point(659, 8);
            btn_basket.Name = "btn_basket";
            btn_basket.Size = new Size(99, 43);
            btn_basket.TabIndex = 4;
            btn_basket.Text = "Səbət";
            btn_basket.UseVisualStyleBackColor = true;
            // 
            // btn_contact
            // 
            btn_contact.Location = new Point(381, 8);
            btn_contact.Name = "btn_contact";
            btn_contact.Size = new Size(99, 43);
            btn_contact.TabIndex = 3;
            btn_contact.Text = "Əlaqə";
            btn_contact.UseVisualStyleBackColor = true;
            // 
            // btn_about
            // 
            btn_about.Location = new Point(258, 8);
            btn_about.Name = "btn_about";
            btn_about.Size = new Size(99, 43);
            btn_about.TabIndex = 2;
            btn_about.Text = "Haqqımızda";
            btn_about.UseVisualStyleBackColor = true;
            // 
            // btn_profil
            // 
            btn_profil.Location = new Point(139, 8);
            btn_profil.Name = "btn_profil";
            btn_profil.Size = new Size(99, 43);
            btn_profil.TabIndex = 1;
            btn_profil.Text = "Profil";
            btn_profil.UseVisualStyleBackColor = true;
            btn_profil.Click += btn_profil_Click;
            // 
            // btn_events
            // 
            btn_events.Location = new Point(12, 8);
            btn_events.Name = "btn_events";
            btn_events.Size = new Size(99, 43);
            btn_events.TabIndex = 0;
            btn_events.Text = "Hadisələr";
            btn_events.UseVisualStyleBackColor = true;
            btn_events.Click += btn_events_Click;
            // 
            // pnl_events
            // 
            pnl_events.Location = new Point(12, 93);
            pnl_events.Name = "pnl_events";
            pnl_events.Size = new Size(841, 281);
            pnl_events.TabIndex = 1;
            // 
            // pnl_profil
            // 
            pnl_profil.Location = new Point(12, 93);
            pnl_profil.Name = "pnl_profil";
            pnl_profil.Size = new Size(841, 284);
            pnl_profil.TabIndex = 1;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(892, 407);
            Controls.Add(panel1);
            Controls.Add(pnl_events);
            Controls.Add(pnl_profil);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Main";
            Text = "Ana səhifə";
            FormClosed += Main_FormClosed;
            Load += Main_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btn_basket;
        private Button btn_contact;
        private Button btn_about;
        private Button btn_profil;
        private Button btn_events;
        private Panel pnl_events;
        private Panel pnl_profil;
    }
}