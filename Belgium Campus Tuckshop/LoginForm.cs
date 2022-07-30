using ClassLibrary;
using MetroSet_UI.Forms;

namespace Belgium_Campus_Tuckshop
{
    public partial class LoginForm : MetroSetForm
    {
        List<PersonModel> cashierList = new List<PersonModel>();
        public LoginForm()
        {
            InitializeComponent();
            LoadCashiers();
        }

        private void LoadCashiers()
        {
            cashierList = SqliteDataAccess.LoadPeople();
        }

        private void btnPassword_Click(object sender, EventArgs e)
        {
            if (mtbxPassword.UseSystemPasswordChar)
            {
                mtbxPassword.UseSystemPasswordChar = false;
            }
            else
            {
                mtbxPassword.UseSystemPasswordChar = true;
            }
        }

        private void mbtnLogin_Click(object sender, EventArgs e)
        {
            bool success = false;
            foreach (var cashier in cashierList)
            {
                if (mtbxUsername.Text == cashier.Username)
                {
                    if (mtbxPassword.Text == cashier.Password)
                    {
                        success = true;
                        MessageBox.Show($"{cashier.Name} Welcome");
                        break;
                    }
                    else
                    {
                        success = false;
                        break;
                    }
                }
                else
                {
                    success = false;
                }
            }

            if (!success)
            {
                MessageBox.Show("Username or password was incorrect");
            }
        }

        private void mbtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}