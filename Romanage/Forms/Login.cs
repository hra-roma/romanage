using Romanage.Data;
using Romanage.Forms;

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

            //TODO : Bazaya muraciet
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            Register register = new Register(this);
            register.Show();

        }
    }
}