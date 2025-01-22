using LaptopShop.LaptopShopDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        // public EditForm
    }
}
