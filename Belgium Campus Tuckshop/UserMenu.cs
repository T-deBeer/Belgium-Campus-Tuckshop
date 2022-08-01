using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroSet_UI.Forms;

namespace Belgium_Campus_Tuckshop
{
    public partial class UserMenu : MetroSetForm
    {
        public UserMenu()
        {
            InitializeComponent();
        }

        private void mbtnSalesMenu_Click(object sender, EventArgs e)
        {
            SalesScreen salesScreenForm = new SalesScreen();
            salesScreenForm.ShowDialog();
            
            this.Close();
        }

        private void mbtnItemsMenu_Click(object sender, EventArgs e)
        {
            ItemsForms menuItemsForms = new ItemsForms();
            menuItemsForms.ShowDialog();
            this.Close();
        }

        private void mbtnSalesHistory_Click(object sender, EventArgs e)
        {
            SalesReport SalesHistory = new SalesReport();
            SalesHistory.ShowDialog();
            this.Close();
        }

        private void mbtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mbtnSignOut_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm(); 
            loginForm.ShowDialog();
            this.Close();
        }
    }
}
