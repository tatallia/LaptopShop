using LaptopShop.LaptopShopDataSetTableAdapters;
using Microsoft.Office.Interop.Word;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace LaptopShop.Forms
{
    public partial class EditWorkerForm : Form
    {

        private readonly int id;
        /// true - якщо запис модифікується, false - якщо створюється новий
        readonly bool edit;

        public EditWorkerForm()
        {
            InitializeComponent();
            edit = false;
            workersTableAdapter.Fill(laptopShopDataSet.workers);
        }
        public EditWorkerForm(int id, string surname, string name, string email, string phone_number, bool admin,
            string password, string login) : this()
        {
            edit = true;
            this.id = id;
            first_nameTextBox.Text = name;
            surnameTextBox.Text = surname;
            emailTextBox.Text = email;
            phone_numberTextBox.Text = phone_number;
            adminCheckBox.Checked = admin;
            passwordTextBox.Text = password;
            loginTextBox.Text = login;
        }

        private void OK_button_Click(object sender, EventArgs e)
        {
            if (Validation.AreAllTextBoxesFilled(this))
            {
                if (edit)
                {
                    workersTableAdapter.UpdateQuery(
                        surnameTextBox.Text,
                        first_nameTextBox.Text,
                        emailTextBox.Text,
                        phone_numberTextBox.Text,
                        adminCheckBox.Checked,
                        passwordTextBox.Text,
                        loginTextBox.Text, id);
                }
                else
                {
                    workersTableAdapter.InsertQuery(
                        surnameTextBox.Text,
                        first_nameTextBox.Text,
                        emailTextBox.Text,
                        phone_numberTextBox.Text,
                        adminCheckBox.Checked,
                        passwordTextBox.Text,
                        loginTextBox.Text);
                }
                Close();
            }
        }

        private void firstNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Validation.IsValidName(e);
        }
        private void surnameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Validation.IsValidName(e);
        }

        private void emailTextBox_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = !Validation.IsValidEmail(emailTextBox.Text);
        }

        private void phone_numberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Validation.IsValidPhoneNumber(phone_numberTextBox.Text, e);
        }

        private void passwordTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Validation.IsEngTextWithNum(e);
        }

        private void loginTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Validation.IsEngTextWithNum(e);
        }

        private void loginTextBox_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = !Validation.IsLoginUnique(loginTextBox.Text);
        }
    }
}
