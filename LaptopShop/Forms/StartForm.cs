using LaptopShop.Forms;
using System;
using System.Windows.Forms;

namespace LaptopShop
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void admin_login_Click(object sender, EventArgs e)
        {
            if (DatabaseManager.GetEntryPermission(loginTextBox.Text, passwordTextBox.Text, true))
            {
                var form = new AdminForm();
                form.Show();
                Hide();
            } 
            else
            {
                MessageBox.Show("Логін або пароль є неправильним.", "Помилка",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void consultant_login_Click(object sender, EventArgs e)
        {
            if (DatabaseManager.GetEntryPermission(loginTextBox.Text, passwordTextBox.Text, false))
            {
                var form = new ConsultantForm();
                form.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Логін або пароль є неправильним.", "Помилка",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
