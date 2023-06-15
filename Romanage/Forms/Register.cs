using Romanage.Data;
using Romanage.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Romanage.Forms
{
    public partial class Register : Form
    {
        private Login MainForm;
        public Register(Login mainForm)
        {
            InitializeComponent();
            MainForm = mainForm;
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void Register_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm.Show();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string name = txbx_name.Text;
            string surname = txbx_surname.Text;
            string email = txbx_email.Text;
            string password = txbx_password.Text;
            string phone = txbx_phone.Text;

            if(String.IsNullOrEmpty(name) == true)
            {
                MessageBox.Show("Ad boş qala bilməz.");
                return;
            }

            if(String.IsNullOrEmpty(surname) == true)
            {
                MessageBox.Show("Soyad boş qala bilməz.");
                return;
            }

            if(String.IsNullOrEmpty(email) == true)
            {
                //TODO : stringin icinde @ isaresi varmi onu yoxla
                MessageBox.Show("E-poçt boş qala bilməz.");
                return;
            }

            if (String.IsNullOrEmpty(phone) == true || phone.Length != 10)
            {
                MessageBox.Show("Telefon nömrəsi standardlara uyğun deyil.(xxxxxxxxxx şəklində olmalıdır)");
                return;
            }


            if (String.IsNullOrEmpty(password) == true || password.Length < 6)
            {
                MessageBox.Show("Şifrə düzgün formatda deyil.");
                return;
            }


            List<User> users = ApplicationDbContext.Users;


            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].Email == email)
                {
                    MessageBox.Show("Bu e-poçt ünvanı ilə artıq qeydiyyatdan keçmisiz.");
                    return;
                }
            }



            int newId = 1;
            if (users.Count != 0)
            {
                newId = users[users.Count - 1].Id + 1;
            }


            User user = new User();
            user.Name = name;
            user.Surname = surname;
            user.Email = email;
            user.Created = DateTime.Now;
            user.Updated = DateTime.Now;
            user.Id = newId;
            user.Phone = phone;
            user.Photo = "";


            SHA256 sha256 = SHA256.Create();

            byte[] buffer = Encoding.UTF8.GetBytes(password);

            byte[] hash = sha256.ComputeHash(buffer);

            user.Password = Convert.ToBase64String(hash);

            ApplicationDbContext.Users.Add(user);

            MessageBox.Show("Ugurlu emeliyyat!");


            this.Close();
        }
    }
}
