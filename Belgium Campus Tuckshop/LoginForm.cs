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

        // Initializes a list of cashiers.

        private void LoadCashiers()
        {
            cashierList = SqliteDataAccess.LoadPeople();
        }

        // Makes the entered password visbile/ invisible
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

        // Compares the user entries for Username and Password against the cashier list.
        // If successful , the user is taken to the user menu.
        // If unsuccessful , user is prompted with a message.
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
                        UserMenu userMenu = new UserMenu(); 
                        userMenu.Show();
                        this.Hide();
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

        // Exits the application.
        private void mbtnExit_Click(object sender, EventArgs e)
        {
            var confirmation = MessageBox.Show("Are you sure you want to exit.", "Exit the Program", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmation == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}