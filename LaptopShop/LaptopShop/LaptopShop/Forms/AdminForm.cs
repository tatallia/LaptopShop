using LaptopShop.Forms;
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
using System.Data.SqlClient;

namespace LaptopShop
{
    public partial class AdminForm : Form
    {
        private bool edit;
        
        public AdminForm()
        {
            InitializeComponent();
           
        }
        private void VisibleThings(string s)
        {
            searchingLabel.Visible = false;
            sortingCheckBox.Visible = false;
            filtrationСheckBox.Visible = false;
            searchingTextBox.Visible = false;
            commonLabel.Text = s;
            commonLabel.Visible = true;
            commonDataGridView.Visible = true;
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'laptopShopDataSet.workers' table. You can move, or remove it, as needed.
            this.workersTableAdapter.Fill(this.laptopShopDataSet.workers);

        }

        private void reviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //bindingNavigator1.BindingSource = workersBindingSource;
            commonDataGridView.DataSource = workersBindingSource;
            commonDataGridView.Columns[0].HeaderText = "№";
            commonDataGridView.Columns[2].HeaderText = "Ім'я";
            commonDataGridView.Columns[1].HeaderText = "Прізвище";
            commonDataGridView.Columns[3].HeaderText = "E-mail";
            commonDataGridView.Columns[4].HeaderText = "Телефон";
            commonDataGridView.Columns[5].HeaderText = "Адмін";
            commonDataGridView.Columns[6].Visible = false;
            commonDataGridView.Columns[7].HeaderText = "Логін";

            VisibleThings("Інформація про робітників");

            searchingLabel.Visible = true;
            searchingTextBox.Visible = true;
            searchingTextBox.Text = "";
            sortingCheckBox.Visible = true;
            filtrationСheckBox.Visible = true;
        }

        private void AdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void editWorkerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            edit = true;
            var st = new LaptopShopDataSet.workersDataTable();
            workersTableAdapter.FillBy(st,
            Convert.ToInt32(commonDataGridView.SelectedRows[0].Cells[0].Value));
            object[] row = st.Rows[0].ItemArray;
            var edt = new EditWorkerForm(
                Convert.ToInt32(row[0]),
                row[1].ToString(),
                row[2].ToString(),
                row[3].ToString(),
                row[4].ToString(),
                (bool)row[5],
                row[6].ToString(),
                row[7].ToString()
            );
            edt.ShowDialog();
            workersTableAdapter.Fill(laptopShopDataSet.workers);
            laptopShopDataSet.AcceptChanges();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var edt = new EditWorkerForm();
            edt.label1.Text = "Додавання робітника";
            edt.ShowDialog();
            workersTableAdapter.Fill(laptopShopDataSet.workers);
            laptopShopDataSet.AcceptChanges();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            workersTableAdapter.DeleteQuery(Convert.ToInt32(commonDataGridView.SelectedRows[0].Cells[0].Value));
            workersTableAdapter.Fill(laptopShopDataSet.workers);
            laptopShopDataSet.AcceptChanges();
        }

        private void top5ConsultantsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            commonDataGridView.DataSource = Requests.GetDataTable("SELECT TOP 5 Workers.Surname, Workers.First_name, SUM(Cheks.Sum_paid) as total " +
                "FROM Workers JOIN Sales ON Workers.Worker_id = Sales.Worker_id JOIN Cheks ON Sales.Sale_id = Cheks.Sale_id " +
                "GROUP BY Workers.Surname, Workers.First_name ORDER BY total DESC");
            commonDataGridView.Columns[0].HeaderText = "Ім'я";
            commonDataGridView.Columns[1].HeaderText = "Прізвище";
            commonDataGridView.Columns[2].HeaderText = "Сума";

            VisibleThings("ТОП-5 консультантів");
        }

        private void top5ClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            commonDataGridView.DataSource = Requests.GetDataTable("SELECT TOP 5 Clients.Surname, Clients.First_name, Clients.Email, SUM(Cheks.Num_laptops) as laptops " +
                "FROM Clients JOIN Sales ON Clients.Email = Sales.Email JOIN Cheks ON Sales.Sale_id = Cheks.Sale_id " +
                "GROUP BY Clients.Surname, Clients.First_name, Clients.Email ORDER BY laptops DESC");
            commonDataGridView.Columns[0].HeaderText = "Ім'я";
            commonDataGridView.Columns[2].HeaderText = "E-mail";
            commonDataGridView.Columns[1].HeaderText = "Прізвище";
            commonDataGridView.Columns[3].HeaderText = "Кількість куплених ноутбуків";

            VisibleThings("ТОП-5 клієнтів");
        }

        private void top10LaptopsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            commonDataGridView.DataSource = Requests.GetDataTable("SELECT TOP 10 Laptops.Model, Laptops.Producer," +
                " Laptops.Processor, Laptops.Ram, Laptops.Color, Laptops.Hard_disk_cap, Laptops.Size," +
                " Laptops.Wt, Laptops.Video_card, Laptops.Features, Displays.Resolution, Displays.Matte," +
                " Displays.Technology, SUM(Cheks.Num_laptops) as quantity " +
                "FROM Laptops JOIN Cheks ON Laptops.Laptop_id = Cheks.Laptop_id JOIN Displays ON Displays.Display_id = Laptops.Display_id" +
                " GROUP BY Laptops.Model, Laptops.Producer, Laptops.Processor, Laptops.Ram," +
                " Laptops.Color, Laptops.Hard_disk_cap, Laptops.Size, Laptops.Wt, Laptops.Video_card," +
                " Laptops.Features, Displays.Resolution, Displays.Matte, " +
                " Displays.Technology ORDER BY quantity DESC");

            commonDataGridView.Columns[0].HeaderText = "Модель";
            commonDataGridView.Columns[1].HeaderText = "Виробник";
            commonDataGridView.Columns[2].HeaderText = "Процесор";
            commonDataGridView.Columns[3].HeaderText = "ОЗП";
            commonDataGridView.Columns[4].HeaderText = "Колір";
            commonDataGridView.Columns[5].HeaderText = "Об'єм жорсткого диску";
            commonDataGridView.Columns[6].HeaderText = "Розмір екрану";
            commonDataGridView.Columns[7].HeaderText = "Вага";
            commonDataGridView.Columns[8].HeaderText = "Відеокарта";
            commonDataGridView.Columns[9].HeaderText = "Особливості";
            commonDataGridView.Columns[10].HeaderText = "Роздільна здатність екрану";
            commonDataGridView.Columns[11].HeaderText = "Матовий екран";
            commonDataGridView.Columns[12].HeaderText = "Технологія екрану";
            commonDataGridView.Columns[13].HeaderText = "Кількість проданих";

            VisibleThings("ТОП-10 ноутбуків");
        }

        private void searchingTextBox_TextChanged(object sender, EventArgs e)
        {
            if(searchingTextBox.Text != "")
            {
                filtrationСheckBox.Checked = false;
                sortingCheckBox.Checked = false;
            }
            commonDataGridView.DataSource = Requests.GetDataTable($"SELECT * FROM Workers WHERE UPPER(Surname) " +
                $"LIKE N'%{searchingTextBox.Text.ToUpper()}%'");

        }

        private void sortingCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (sortingCheckBox.Checked)
            {
                filtrationСheckBox.Checked = false;
                if (searchingTextBox.Text != "") searchingTextBox.Text = "";
                commonDataGridView.DataSource = Requests.GetDataTable("SELECT * FROM Workers ORDER BY Surname ASC");
            }
            else if (filtrationСheckBox.Checked == false && searchingTextBox.Text == "")
            {
                commonDataGridView.DataSource = Requests.GetDataTable("SELECT * FROM Workers");
            }
        }

        private void filtrationСheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (filtrationСheckBox.Checked)
            {
                sortingCheckBox.Checked = false;
                if(searchingTextBox.Text != "") searchingTextBox.Text = "";
                commonDataGridView.DataSource = Requests.GetDataTable("SELECT * FROM Workers WHERE Admin=1");
            } 
            else if (sortingCheckBox.Checked == false && searchingTextBox.Text == "")
            {
                commonDataGridView.DataSource = Requests.GetDataTable("SELECT * FROM Workers");
            }
        }
    }
}
