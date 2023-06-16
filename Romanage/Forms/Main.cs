using Romanage.Data;
using Romanage.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Romanage.Forms
{
    public partial class Main : Form
    {
        private Login LoginForm;

        public Main(Login loginForm)
        {
            InitializeComponent();
            LoginForm = loginForm;

            pnl_profil.Hide();

            this.AutoScroll = true;
            pnl_events.AutoScroll = true;

            btn_events.BackColor = Color.FromArgb(255, 221, 0);

        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginForm.Close();
        }

        private void btn_profil_Click(object sender, EventArgs e)
        {
            pnl_events.Hide();
            pnl_profil.Show();
            btn_events.BackColor = Color.White;
            btn_profil.BackColor = Color.FromArgb(255, 221, 0);
        }

        private void btn_events_Click(object sender, EventArgs e)
        {
            btn_events.BackColor = Color.FromArgb(255, 221, 0);
            btn_profil.BackColor = Color.White;
            pnl_events.Show();
            pnl_profil.Hide();


        }

        private void Main_Load(object sender, EventArgs e)
        {
            List<Event> events = ApplicationDbContext.Events;

            int x = 10;
            int y = 10;
            for (int i = 0; i < events.Count; i++)
            {
                // Create a Panel control
                FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel();

                flowLayoutPanel.FlowDirection = FlowDirection.TopDown;
                flowLayoutPanel.BorderStyle = BorderStyle.FixedSingle;
                //flowLayoutPanel.Dock = DockStyle.Fill;

                flowLayoutPanel.Location = new Point(x, y);

                flowLayoutPanel.Size = new Size(250, 100);

                flowLayoutPanel.DoubleClick += Flowlayout_dblclick;


                // Create three Label controls
                Label label1 = new Label();
                label1.Text = events[i].Name;
                label1.AutoSize = true;

                Label label2 = new Label();
                label2.Text = events[i].Address;
                label2.AutoSize = true;

                Label label3 = new Label();
                label3.Text = Convert.ToString(events[i].Price);
                label3.AutoSize = true;

                Label label4 = new Label();
                label4.Text = events[i].Id.ToString();
                label4.AutoSize = true;
                label4.Hide();

                // Add the Label controls to the Panel
                flowLayoutPanel.Controls.Add(label1);
                flowLayoutPanel.Controls.Add(label2);
                flowLayoutPanel.Controls.Add(label3);
                flowLayoutPanel.Controls.Add(label4);

                pnl_events.Controls.Add(flowLayoutPanel);

                x += 260;

                if ((i + 1) % 3 == 0)
                {
                    y += 110;
                    x = 10;
                }
            }
        }

        private void Flowlayout_dblclick(object? sender, EventArgs e)
        {
            FlowLayoutPanel panel = (FlowLayoutPanel)sender;
            Label label = (Label)panel.Controls[3];

            MessageBox.Show(label.Text);
            int eventId = Convert.ToInt32(label.Text);

            //TODO: izah et
        }
    }
}
