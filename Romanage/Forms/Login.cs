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
    }
}