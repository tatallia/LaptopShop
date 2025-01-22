using LaptopShop.LaptopShopDataSetTableAdapters;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace LaptopShop.Forms
{
    public partial class EditClientForm : Form
    {
        int bonuses = 0;
        /// true - якщо запис модифікується, false - якщо створюється новий
        readonly bool edit;

        public EditClientForm()
        {
            InitializeComponent();
            edit = false;
            clientsTableAdapter.Fill(laptopShopDataSet.clients);
        }

        public EditClientForm(string email, string surname, string name, int bonuses, string number) : this()
        {
            edit = true;
            emailTextBox.Enabled = false;
            emailLabel.ForeColor = Color.Gray;
            surnameTextBox.Text = surname;
            nameTextBox.Text = name;
            phoneNumberTextBox.Text = number;
            emailTextBox.Text = email;
            this.bonuses = bonuses;
        }

        private void OK_button_Click(object sender, EventArgs e)
        {
            if (Validation.AreAllTextBoxesFilled(this))
            {
                if (edit)
                {
                    clientsTableAdapter.UpdateQuery(
                        emailTextBox.Text,
                        surnameTextBox.Text,
                        nameTextBox.Text,
                        bonuses,
                        phoneNumberTextBox.Text);
                }
                else
                {
                    clientsTableAdapter.InsertQuery(
                        emailTextBox.Text,
                        surnameTextBox.Text,
                        nameTextBox.Text,
                        bonuses,
                        phoneNumberTextBox.Text);
                }
                Close();
            }
        }

        private void surnameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Validation.IsValidName(e);
        }

        private void nameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Validation.IsValidName(e);
        }

        private void phoneNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Validation.IsValidPhoneNumber(phoneNumberTextBox.Text, e);
        }

        private void emailTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = !Validation.IsValidEmail(emailTextBox.Text);
        }
    }
}
