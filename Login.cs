namespace Assignment4
{
    public partial class Login : Form
    {
        private opeartion op = new opeartion();
        public Login()
        {
            InitializeComponent();
        }

        private void lbluser_Click(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string username = txtusername.Text;
            string password = txtpass.Text;

            int userId = op.AuthenticateUser(username, password);

            if (userId != 0 )
            {
                TransactionHistoryform form = new TransactionHistoryform(userId);
                form.ShowDialog();
                
              
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
