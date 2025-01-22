using LaptopShop.LaptopShopDataSetTableAdapters;
using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LaptopShop.Forms
{
    public partial class ClientsForm : Form
    {
        string allInfoQuery = "SELECT Surname, First_name, phone_number, email, num_bonuses FROM Clients";

        public ClientsForm()
        {
            InitializeComponent();
            clientsTableAdapter.Fill(laptopShopDataSet.clients);

            filterComboBox.ForeColor = Color.Gray;

            dataGridView1.DataSource = DatabaseManager.GetDataTable(allInfoQuery);

            dataGridView1.Columns[0].HeaderText = "Прізвище";
            dataGridView1.Columns[1].HeaderText = "Ім'я";
            dataGridView1.Columns[2].HeaderText = "Номер телефону";
            dataGridView1.Columns[3].HeaderText = "E-mail";
            dataGridView1.Columns[4].HeaderText = "Бонуси";

        }

        private void ApplyFilters()
        {
            StringBuilder queryBuilder = new StringBuilder("SELECT * FROM Clients");

            if (filterComboBox.ForeColor != Color.Gray)
            {
                switch (filterComboBox.SelectedItem.ToString())
                {
                    case "0":
                        queryBuilder.Append(" WHERE Num_Bonuses=0");
                        break;

                    case "1":
                        queryBuilder.Append(" WHERE Num_Bonuses=1");
                        break;

                    default:
                        queryBuilder.Append(" WHERE Num_Bonuses=2");
                        break;
                }
            }

            if (!string.IsNullOrEmpty(searchTextBox.Text))
            {
                queryBuilder.Append(filterComboBox.ForeColor != Color.Gray ? " AND" : " WHERE");
                queryBuilder.Append($"  Email LIKE '%{searchTextBox.Text}%'");
            }

            if (sortingCheckBox.Checked)
            {
                queryBuilder.Append(" ORDER BY Surname ASC");
            }

            dataGridView1.DataSource = DatabaseManager.GetDataTable(queryBuilder.ToString());
        }

        private void editButton_Click(object sender, EventArgs e)
        {   try
            {
                var st = new LaptopShopDataSet.clientsDataTable();
                clientsTableAdapter.FillBy(st, dataGridView1.SelectedRows[0].Cells[3].Value.ToString());
                object[] row = st.Rows[0].ItemArray;
                var edt = new EditClientForm(
                row[0].ToString(),
                row[1].ToString(),
                row[2].ToString(),
                Convert.ToInt32(row[3]),
                row[4].ToString());
                edt.ShowDialog();
                laptopShopDataSet.AcceptChanges();
                clientsTableAdapter.Fill(laptopShopDataSet.clients);
                filterComboBox.ForeColor = Color.Gray;
                dataGridView1.DataSource = DatabaseManager.GetDataTable(allInfoQuery);
            } 
            catch 
            {
                MessageBox.Show("Ви не обрали рядок, який хочете відредагувати.",
                    "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void sortingCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void filterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            filterComboBox.ForeColor = Color.Black;
            ApplyFilters();
        }

        private void dropButton_Click(object sender, EventArgs e)
        {
            filterComboBox.ForeColor = Color.Gray;
            sortingCheckBox.Checked = false;
            searchTextBox.Text = "";
            dataGridView1.DataSource = DatabaseManager.GetDataTable(allInfoQuery);
        }
    }
}
