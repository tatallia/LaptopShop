using LaptopShop.LaptopShopDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LaptopShop.Forms
{
    public partial class LaptopsForm : Form
    {
        string allInfoQuery = "SELECT Laptops.Model, Laptops.Producer, Laptops.Processor," +
                " Laptops.Ram, Laptops.Color, Laptops.Hard_disk_cap, Laptops.Size, Laptops.Wt, Laptops.Video_card," +
                " Laptops.Features, Displays.Resolution, Displays.Matte, Displays.Technology, Displays.Size, Displays.Format_, " +
                "Laptops.Manufacturer_warranty, Laptops.Num_available, Laptops.Price, Laptops.Laptop_id" +
                " FROM Laptops, Displays WHERE Laptops.Display_id = Displays.Display_id";

        public LaptopsForm()
        {
            InitializeComponent();

            filterComboBox.DataSource = Requests.GetDataTable("SELECT DISTINCT producer FROM Laptops");
            filterComboBox.DisplayMember = "Producer"; 
            filterComboBox.ValueMember = "Producer"; 
            filterComboBox.ForeColor = Color.Gray;

            laptopsTableAdapter.Fill(laptopShopDataSet.laptops);
            dataGridView1.DataSource = Requests.GetDataTable(allInfoQuery);

            dataGridView1.Columns[0].HeaderText = "Модель";
            dataGridView1.Columns[1].HeaderText = "Виробник";
            dataGridView1.Columns[2].HeaderText = "Процесор";
            dataGridView1.Columns[3].HeaderText = "ОЗП       ";
            dataGridView1.Columns[4].HeaderText = "Колір";
            dataGridView1.Columns[5].HeaderText = "Об'єм жорсткого диску";
            dataGridView1.Columns[6].HeaderText = "Розмір екрану";
            dataGridView1.Columns[7].HeaderText = "Вага       ";
            dataGridView1.Columns[8].HeaderText = "Відеокарта";
            dataGridView1.Columns[9].HeaderText = "Особливості";
            dataGridView1.Columns[10].HeaderText = "Роздільна здатність екрану";
            dataGridView1.Columns[11].HeaderText = "Матовий екран";
            dataGridView1.Columns[12].HeaderText = "Технологія екрану  ";
            dataGridView1.Columns[13].HeaderText = "Розмір екрану";
            dataGridView1.Columns[14].HeaderText = "Формат екрану";
            dataGridView1.Columns[15].HeaderText = "Гарантія виробника";
            dataGridView1.Columns[16].HeaderText = "К-ть наявних";
            dataGridView1.Columns[17].HeaderText = "Ціна      ";
            dataGridView1.Columns[18].Visible = false;

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var add = new EditLaptopForm();
            add.ShowDialog();
            laptopsTableAdapter.Fill(laptopShopDataSet.laptops);
            laptopShopDataSet.AcceptChanges();
            filterComboBox.DataSource = Requests.GetDataTable("SELECT DISTINCT producer FROM Laptops");
            dataGridView1.DataSource = Requests.GetDataTable(allInfoQuery);
            
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            var st = new LaptopShopDataSet.laptopsDataTable();
            laptopsTableAdapter.FillBy(st,
            Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[18].Value));
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
            filterComboBox.DataSource = Requests.GetDataTable("SELECT DISTINCT producer FROM Laptops");
            dataGridView1.DataSource = Requests.GetDataTable(allInfoQuery);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            laptopsTableAdapter.DeleteQuery(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[18].Value));
            laptopsTableAdapter.Fill(laptopShopDataSet.laptops);
            laptopShopDataSet.AcceptChanges();
            filterComboBox.DataSource = Requests.GetDataTable("SELECT DISTINCT producer FROM Laptops");
            dataGridView1.DataSource = Requests.GetDataTable(allInfoQuery);
        }

        private void sortingCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (sortingCheckBox.Checked == false && searchTextBox.Text == "" && filterComboBox.ForeColor == Color.Gray)
            {
                dataGridView1.DataSource = Requests.GetDataTable(allInfoQuery);
            } 
            else if (sortingCheckBox.Checked == true)
            {
                searchTextBox.Text = "";
                filterComboBox.ForeColor = Color.Gray;
                dataGridView1.DataSource = Requests.GetDataTable("SELECT Laptops.Model, Laptops.Producer, Laptops.Processor," +
                    " Laptops.Ram, Laptops.Color, Laptops.Hard_disk_cap, Laptops.Size, Laptops.Wt, Laptops.Video_card," +
                    " Laptops.Features, Displays.Resolution, Displays.Matte, Displays.Technology, Displays.Size, Displays.Format_, " +
                    "Laptops.Manufacturer_warranty, Laptops.Num_available, Laptops.Price, Laptops.Laptop_id" +
                    " FROM Laptops, Displays WHERE Laptops.Display_id = Displays.Display_id ORDER BY Laptops.Price");
            }
            
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (searchTextBox.Text != "")
            {
                filterComboBox.ForeColor = Color.Gray;
                sortingCheckBox.Checked = false;
            }
            dataGridView1.DataSource = Requests.GetDataTable("SELECT Laptops.Model, Laptops.Producer, Laptops.Processor," +
                " Laptops.Ram, Laptops.Color, Laptops.Hard_disk_cap, Laptops.Size, Laptops.Wt, Laptops.Video_card," +
                " Laptops.Features, Displays.Resolution, Displays.Matte, Displays.Technology, Displays.Size, Displays.Format_, " +
                "Laptops.Manufacturer_warranty, Laptops.Num_available, Laptops.Price, Laptops.Laptop_id" +
                 $" FROM Laptops INNER JOIN Displays ON Laptops.Display_id = Displays.Display_id WHERE  UPPER(Laptops.Model) LIKE '%{searchTextBox.Text.ToUpper()}%'");
        }

        private void filterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            filterComboBox.ForeColor = Color.Black;
            searchTextBox.Text = "";
            sortingCheckBox.Checked = false;
            dataGridView1.DataSource = Requests.GetDataTable("SELECT Laptops.Model, Laptops.Producer, Laptops.Processor," +
               " Laptops.Ram, Laptops.Color, Laptops.Hard_disk_cap, Laptops.Size, Laptops.Wt, Laptops.Video_card," +
               " Laptops.Features, Displays.Resolution, Displays.Matte, Displays.Technology, Displays.Size, Displays.Format_, " +
               "Laptops.Manufacturer_warranty, Laptops.Num_available, Laptops.Price, Laptops.Laptop_id" +
                $" FROM Laptops INNER JOIN Displays ON Laptops.Display_id = Displays.Display_id WHERE Laptops.Producer = '{filterComboBox.SelectedValue}'");
        }

        private void dropButton_Click(object sender, EventArgs e)
        {
            filterComboBox.ForeColor = Color.Gray;
            sortingCheckBox.Checked = false;
            if (searchTextBox.Text == "") dataGridView1.DataSource = Requests.GetDataTable(allInfoQuery);
            else searchTextBox.Text = "";
        }
    }
}
