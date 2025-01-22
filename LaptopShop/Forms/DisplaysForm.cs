using LaptopShop.LaptopShopDataSetTableAdapters;
using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LaptopShop.Forms
{
    public partial class DisplaysForm : Form
    {
        public DisplaysForm()
        {
            InitializeComponent();
        }

        private void ApplyFilters()
        {
            StringBuilder queryBuilder = new StringBuilder("SELECT * FROM Displays");

            if (filterComboBox.ForeColor != Color.Gray && filterComboBox.SelectedItem != null)
            {
                switch (filterComboBox.SelectedItem.ToString())
                {
                    case "так":
                        queryBuilder.Append(" WHERE Matte=1");
                        break;

                    case "ні":
                        queryBuilder.Append(" WHERE Matte=0");
                        break;
                }
            }

            if (!string.IsNullOrEmpty(searchTextBox.Text))
            {
                if (filterComboBox.ForeColor != Color.Gray && filterComboBox.SelectedItem != null)
                {
                    queryBuilder.Append(" AND");
                }
                else
                {
                    queryBuilder.Append(" WHERE");
                }

                queryBuilder.Append($" Size LIKE '%{searchTextBox.Text}%'");
            }

            if (sortingCheckBox.Checked)
            {
                queryBuilder.Append(" ORDER BY Technology");
            }

            dataGridView1.DataSource = DatabaseManager.GetDataTable(queryBuilder.ToString());
        }

        private void ViewDisplaysForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'laptopShopDataSet.displays' table. You can move, or remove it, as needed.
            this.displaysTableAdapter.Fill(this.laptopShopDataSet.displays);

        }

        private void editButton_Click(object sender, EventArgs e)
        {
            try
            {
                var st = new LaptopShopDataSet.displaysDataTable();
                displaysTableAdapter.FillBy(st,
                Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
                object[] row = st.Rows[0].ItemArray;
                var edt = new EditDisplayForm(
                Convert.ToInt32(row[0]),
                (bool)row[1],
                row[2].ToString(),
                row[3].ToString(),
                row[4].ToString(),
                row[5].ToString()
                );
                edt.ShowDialog();
                laptopShopDataSet.AcceptChanges();
                displaysTableAdapter.Fill(laptopShopDataSet.displays);
            }
            catch
            {
                MessageBox.Show("Ви не обрали рядок, який хочете відредагувати.",
                    "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var edt = new EditDisplayForm();
            edt.label1.Text = "Додавання дисплею";
            edt.ShowDialog();
            laptopShopDataSet.AcceptChanges();
            displaysTableAdapter.Fill(laptopShopDataSet.displays);
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void sortingCheckBox_CheckedChanged(object sender, EventArgs e)
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
            dataGridView1.DataSource = DatabaseManager.GetDataTable("SELECT * FROM Displays");
        }
    }
}
