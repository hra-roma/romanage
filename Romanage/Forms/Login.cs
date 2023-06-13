using Romanage.Data;
using Romanage.Forms;
using Romanage.Models;

namespace Romanage
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string email = txbx_email.Text;
            string password = txbx_password.Text;

            List<User> users = ApplicationDbContext.Users;


            bool hasUser = false;
            User loggedUser = null;
            for(int i = 0; i < users.Count; i++)
            {
                if (users[i].Email == email)
                {
                    hasUser = true;
                    loggedUser = users[i];
                    break;
                }
            }

            if(hasUser == false)
            {
                MessageBox.Show("Istifadəçi adı və ya şifrə yanlışdır.");
                return;
            }



            if(loggedUser.Password != password)
            {
                MessageBox.Show("Istifadəçi adı və ya şifrə yanlışdır.");
                return;
            }

            //TODO: open events form

            MessageBox.Show("Xos geldiniz.");



        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            Register register = new Register(this);
            register.Show();

        }
    }
}