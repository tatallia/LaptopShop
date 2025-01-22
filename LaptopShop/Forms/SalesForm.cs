using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LaptopShop.Forms
{
    public partial class SalesForm : Form
    {
        string allInfoQuery = "SELECT Sales.Sale_id, FORMAT (Sales.Date_, 'yyyy-MM-dd') as date, Checks.Laptop_id, Checks.Num_Laptops, Clients.Surname," +
            " Clients.First_name, Clients.Email FROM Sales JOIN Checks ON Checks.Sale_id = Sales.Sale_id LEFT JOIN Clients ON Sales.Email = Clients.Email";
        public SalesForm()
        {
            InitializeComponent();
            salesTableAdapter.Fill(laptopShopDataSet.sales);

            dataGridView1.DataSource = DatabaseManager.GetDataTable(allInfoQuery);

            dataGridView1.Columns[0].HeaderText = "№";
            dataGridView1.Columns[1].HeaderText = "Дата";
            dataGridView1.Columns[2].HeaderText = "Ноутбук";
            dataGridView1.Columns[3].HeaderText = "Кількість";
            dataGridView1.Columns[4].HeaderText = "Прізвище\nклієнта";
            dataGridView1.Columns[5].HeaderText = "Ім'я\nклієнта";
            dataGridView1.Columns[6].HeaderText = "Email\nклієнта";
        }

        private void ApplyFilters()
        {
            StringBuilder queryBuilder = new StringBuilder("SELECT Sales.Sale_id," +
                 "FORMAT (Sales.Date_, 'yyyy-MM-dd') as date, Checks.Laptop_id, Checks.Num_Laptops, " +
                 "Clients.Surname, Clients.First_name, Clients.Email FROM Sales JOIN " +
                 "Checks ON Checks.Sale_id = Sales.Sale_id LEFT JOIN Clients ON Sales.Email = Clients.Email");

            if (!string.IsNullOrEmpty(searchTextBox.Text))
            {
                queryBuilder.Append($" WHERE FORMAT(Sales.Date_, 'yyyy-MM-dd') LIKE '%{searchTextBox.Text}%'");
            }

            if (sortingCheckBox.Checked)
            {
                queryBuilder.Append(" ORDER BY Clients.Surname");
            }

            dataGridView1.DataSource = DatabaseManager.GetDataTable(queryBuilder.ToString());
        }

        private void sortingCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

    }
}
