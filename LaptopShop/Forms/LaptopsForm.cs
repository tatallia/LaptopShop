using LaptopShop.LaptopShopDataSetTableAdapters;
using System;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace LaptopShop.Forms
{
    public partial class LaptopsForm : Form
    {
        string allInfoQuery = "SELECT Laptops.Laptop_id, Laptops.Model, Laptops.Producer, Laptops.Processor," +
           " Laptops.Ram, Laptops.Color, Laptops.Hard_disk_cap, Laptops.Size, Laptops.Wt, Laptops.Video_card," +
           " Laptops.Features, Displays.Resolution, Displays.Matte, Displays.Technology, Displays.Size, Displays.Format_," +
           " Laptops.Manufacturer_warranty, Laptops.Num_available, Laptops.Price" +
           " FROM Laptops, Displays WHERE Laptops.Display_id = Displays.Display_id";
        bool constructorCalled = true;

        public LaptopsForm()
        {
            InitializeComponent();
            laptopsTableAdapter.Fill(laptopShopDataSet.laptops);

            filterComboBox.DataSource = DatabaseManager.GetDataTable("SELECT DISTINCT producer FROM Laptops");
            filterComboBox.DisplayMember = "Producer";
            filterComboBox.ValueMember = "Producer";
            filterComboBox.ForeColor = Color.Gray;

            dataGridView1.DataSource = DatabaseManager.GetDataTable(allInfoQuery);

            dataGridView1.Columns["Laptop_id"].DisplayIndex = 0;
            dataGridView1.Columns[0].HeaderText = "№";
            dataGridView1.Columns[1].HeaderText = "Модель";
            dataGridView1.Columns[2].HeaderText = "Виробник";
            dataGridView1.Columns[3].HeaderText = "Процесор";
            dataGridView1.Columns[4].HeaderText = "ОЗП        ";
            dataGridView1.Columns[5].HeaderText = "Колір";
            dataGridView1.Columns[6].HeaderText = "Об'єм жорст-\nкого диску";
            dataGridView1.Columns[7].HeaderText = "Розмір екрану";
            dataGridView1.Columns[8].HeaderText = "Вага,\nкг";
            dataGridView1.Columns[9].HeaderText = "Відеокарта";
            dataGridView1.Columns[10].HeaderText = "Особливості";
            dataGridView1.Columns[11].HeaderText = "Роздільна здатність екрану";
            dataGridView1.Columns[12].HeaderText = "Матовий екран";
            dataGridView1.Columns[13].HeaderText = "Технологія екрану  ";
            dataGridView1.Columns[14].HeaderText = "Розмір екрану";
            dataGridView1.Columns[15].HeaderText = "Формат екрану";
            dataGridView1.Columns[16].HeaderText = "Гарантія виро-\nбника, роки";
            dataGridView1.Columns[17].HeaderText = "К-ть\nнаявних";
            dataGridView1.Columns[18].HeaderText = "Ціна      ";

            constructorCalled = false;
        }

        private void ApplyFilters()
        {
            StringBuilder queryBuilder = new StringBuilder("SELECT Laptops.Model, Laptops.Producer, Laptops.Processor," +
                    " Laptops.Ram, Laptops.Color, Laptops.Hard_disk_cap, Laptops.Size, Laptops.Wt, Laptops.Video_card," +
                    " Laptops.Features, Displays.Resolution, Displays.Matte, Displays.Technology, Displays.Size, Displays.Format_, " +
                    "Laptops.Manufacturer_warranty, Laptops.Num_available, Laptops.Price, Laptops.Laptop_id" +
                    " FROM Laptops JOIN Displays ON Laptops.Display_id = Displays.Display_id");

            if (filterComboBox.ForeColor != Color.Gray)
            {
                queryBuilder.Append($" WHERE Laptops.Producer = '{filterComboBox.SelectedValue}'");
            }

            if (!string.IsNullOrEmpty(searchTextBox.Text))
            {
                queryBuilder.Append(filterComboBox.ForeColor != Color.Gray ? " AND" : " WHERE");
                queryBuilder.Append($" UPPER(Laptops.Model) LIKE '%{searchTextBox.Text.ToUpper()}%'");
            }

            if (sortingCheckBox.Checked)
            {
                queryBuilder.Append(" ORDER BY Laptops.Price");
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

        private void filterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!constructorCalled)
            {
                filterComboBox.ForeColor = Color.Black;
                ApplyFilters();
            }
        }

        private void dropButton_Click(object sender, EventArgs e)
        {
            filterComboBox.ForeColor = Color.Gray;
            sortingCheckBox.Checked = false;
            searchTextBox.Text = "";
            dataGridView1.DataSource = DatabaseManager.GetDataTable(allInfoQuery);
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 17)
            {
                int quantity;
                if (int.TryParse(e.Value.ToString(), out quantity))
                {
                    if (quantity == 0)
                    {
                        dataGridView1.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Red;
                    }
                }
            }
        }


        private void addButton_Click(object sender, EventArgs e)
        {
            var add = new EditLaptopForm();
            add.nameLabel.Text = "Додавання типу ноутбука";
            add.ShowDialog();
            laptopsTableAdapter.Fill(laptopShopDataSet.laptops);
            laptopShopDataSet.AcceptChanges();
            filterComboBox.DataSource = DatabaseManager.GetDataTable("SELECT DISTINCT producer FROM Laptops");
            filterComboBox.ForeColor = Color.Gray;
            dataGridView1.DataSource = DatabaseManager.GetDataTable(allInfoQuery);

        }

        private void editButton_Click(object sender, EventArgs e)
        {
            try
            {
                var st = new LaptopShopDataSet.laptopsDataTable();
                laptopsTableAdapter.FillBy(st,
                Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
                object[] row = st.Rows[0].ItemArray;
                var edt = new EditLaptopForm(
                Convert.ToInt32(row[0]),
                row[1].ToString(),
                row[2].ToString(),
                row[3].ToString(),
                Convert.ToInt32(row[4]),
                row[5].ToString(),
                row[6].ToString(),
                row[7].ToString(),
                Convert.ToDecimal(row[8]),
                row[9].ToString(),
                row[10].ToString(),
                Convert.ToInt32(row[11]),
                Convert.ToInt32(row[12]),
                Convert.ToInt32(row[13]),
                Convert.ToDecimal(row[14])
                );
                edt.ShowDialog();
                laptopsTableAdapter.Fill(laptopShopDataSet.laptops);
                laptopShopDataSet.AcceptChanges();
                filterComboBox.DataSource = DatabaseManager.GetDataTable("SELECT DISTINCT producer FROM Laptops");
                filterComboBox.ForeColor = Color.Gray;
                dataGridView1.DataSource = DatabaseManager.GetDataTable(allInfoQuery);
            }
            catch
            {
                MessageBox.Show("Ви не обрали рядок, який хочете відредагувати.",
                    "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (!Validation.CanDeleteLaptop(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value)))
            {
                MessageBox.Show("Ви не можете видалити цей ноутбук, бо інформація про   нього ще потрібна для контролю.",
                    "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                laptopsTableAdapter.DeleteQuery(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
                laptopsTableAdapter.Fill(laptopShopDataSet.laptops);
                laptopShopDataSet.AcceptChanges();
                filterComboBox.ForeColor = Color.Gray;
                dataGridView1.DataSource = DatabaseManager.GetDataTable(allInfoQuery);
            }
            catch
            {
                MessageBox.Show("Ви не обрали рядок, який хочете видалити.",
                    "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addInChekButton_Click(object sender, EventArgs e)
        {

            try
            {
                if (dataGridView1.SelectedRows[0].DefaultCellStyle.ForeColor == Color.Red)
                {
                    MessageBox.Show("Цього ноутбуку немає в наявності.",
                       "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var checkForm = Application.OpenForms.OfType<CheckForm>().FirstOrDefault();

                checkForm.InsertDataInGrid(dataGridView1.SelectedRows[0].Cells[0].Value,
                    dataGridView1.SelectedRows[0].Cells[1].Value, dataGridView1.SelectedRows[0].Cells[2].Value, dataGridView1.SelectedRows[0].Cells[18].Value);
                checkForm.CalculateSum();
            }
            catch
            {
                MessageBox.Show("Ви не обрали ноутбук, який хочете додати у чек.",
                    "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void makeCheckButton_Click(object sender, EventArgs e)
        {
            var check = new CheckForm();
            check.FormClosed += CheckForm_FormClosed;
            try
            {
                if (dataGridView1.SelectedRows[0].DefaultCellStyle.ForeColor == Color.Red)
                {
                    MessageBox.Show("Цього ноутбуку немає в наявності.",
                       "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    check.Close();
                    return;
                }

                check.InsertDataInGrid(dataGridView1.SelectedRows[0].Cells[0].Value,
                    dataGridView1.SelectedRows[0].Cells[1].Value, dataGridView1.SelectedRows[0].Cells[2].Value, dataGridView1.SelectedRows[0].Cells[18].Value);

                check.CalculateSum();
            }
            catch (Exception)
            {
                MessageBox.Show("Ви не обрали товар");
            }
            check.Show();

            addInChekButton.Visible = true;
            makeCheckButton.Enabled = false;

        }

        private void CheckForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            dataGridView1.DataSource = DatabaseManager.GetDataTable(allInfoQuery);
            addInChekButton.Visible = false;
            makeCheckButton.Enabled = true;
            dropButton_Click(sender, e);
        }
    }
}
