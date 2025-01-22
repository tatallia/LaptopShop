using LaptopShop.Forms;
using LaptopShop.LaptopShopDataSetTableAdapters;
using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
            editWorkerToolStripMenuItem.Enabled = false;
            deleteWorkerToolStripMenuItem.Enabled = false;
            addWorkerToolStripMenuItem.Enabled = false;
        }

        private void ApplyFilters()
        {
            StringBuilder queryBuilder = new StringBuilder("SELECT * FROM Workers");

            if (filtrationСheckBox.Checked)
            {
                queryBuilder.Append(" WHERE Admin=1");
            }

            if (!string.IsNullOrEmpty(searchingTextBox.Text))
            {
                queryBuilder.Append(filtrationСheckBox.Checked ? " AND" : " WHERE");
                queryBuilder.Append($" UPPER(First_name) LIKE N'%{searchingTextBox.Text.ToUpper()}%'");
            }

            if (sortingCheckBox.Checked)
            {
                queryBuilder.Append(" ORDER BY Surname ASC");
            }

            commonDataGridView.DataSource = DatabaseManager.GetDataTable(queryBuilder.ToString());
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

            editWorkerToolStripMenuItem.Enabled = true;
            deleteWorkerToolStripMenuItem.Enabled = true;
            addWorkerToolStripMenuItem.Enabled = true;
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
            try
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
                laptopShopDataSet.AcceptChanges();
                workersTableAdapter.Fill(laptopShopDataSet.workers);
            } 
            catch 
            {
                MessageBox.Show("Ви не обрали рядок, який хочете відредагувати.",
                    "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var edt = new EditWorkerForm();
            edt.label1.Text = "Додавання робітника";
            edt.ShowDialog();
            laptopShopDataSet.AcceptChanges();
            workersTableAdapter.Fill(laptopShopDataSet.workers);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Convert.ToInt32(commonDataGridView.SelectedRows[0].Cells[0].Value) == DatabaseManager.UserID)
            {
                MessageBox.Show("Ви не можете видалити себе.",
                    "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            try
            {
                workersTableAdapter.DeleteQuery(Convert.ToInt32(commonDataGridView.SelectedRows[0].Cells[0].Value));
                laptopShopDataSet.AcceptChanges();
                workersTableAdapter.Fill(laptopShopDataSet.workers);
            }
            catch
            {
                MessageBox.Show("Ви не обрали рядок, який хочете видалити.",
                    "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void top5ConsultantsMenuItem_Click(object sender, EventArgs e)
        {
            commonDataGridView.DataSource = DatabaseManager.GetDataTable("SELECT TOP 5 Workers.Surname, Workers.First_name, SUM(Checks.Sum_paid) as total " +
                "FROM Workers JOIN Sales ON Workers.Worker_id = Sales.Worker_id JOIN Checks ON Sales.Sale_id = Checks.Sale_id " +
                "GROUP BY Workers.Surname, Workers.First_name ORDER BY total DESC");
            if (commonDataGridView.RowCount < 1)
            {
                VisibleThings($"Статистика недоступна. Консультантів ще немає у базі.");
                commonDataGridView.Visible = false;
            }
            else
            {
                commonDataGridView.Columns[1].HeaderText = "Ім'я      ";
                commonDataGridView.Columns[0].HeaderText = "Прізвище       ";
                commonDataGridView.Columns[2].HeaderText = "Сума";

                VisibleThings("ТОП-5 консультантів");
            }
        }

        private void top5ClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            commonDataGridView.DataSource = DatabaseManager.GetDataTable("SELECT TOP 5 Clients.Surname, Clients.First_name, Clients.Email, SUM(Checks.Num_laptops) as laptops " +
                "FROM Clients JOIN Sales ON Clients.Email = Sales.Email JOIN Checks ON Sales.Sale_id = Checks.Sale_id " +
                "GROUP BY Clients.Surname, Clients.First_name, Clients.Email ORDER BY laptops DESC");

            if (commonDataGridView.RowCount < 1)
            {
                VisibleThings($"Статистика недоступна. Клієнтів ще немає у базі.");
                commonDataGridView.Visible = false;
            }
            else
            {
                commonDataGridView.Columns[1].HeaderText = "Ім'я      ";
                commonDataGridView.Columns[2].HeaderText = "E-mail";
                commonDataGridView.Columns[0].HeaderText = "Прізвище       ";
                commonDataGridView.Columns[3].HeaderText = "Кількість куплених ноутбуків";

                VisibleThings("ТОП-5 клієнтів");
            }
        }

        private void top10LaptopsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            commonDataGridView.DataSource = DatabaseManager.GetDataTable("SELECT TOP 10 Laptops.Laptop_id, Laptops.Model, Laptops.Producer," +
                " Laptops.Processor, Laptops.Ram, Laptops.Color, Laptops.Hard_disk_cap, Laptops.Size," +
                " Laptops.Wt, Laptops.Video_card, Laptops.Features, Displays.Resolution, Displays.Matte," +
                " Displays.Technology, SUM(Checks.Num_laptops) as quantity " +
                "FROM Laptops JOIN Checks ON Laptops.Laptop_id = Checks.Laptop_id JOIN Displays " +
                "ON Displays.Display_id = Laptops.Display_id GROUP BY Laptops.Laptop_id, Laptops.Model, Laptops.Producer," +
                " Laptops.Processor, Laptops.Ram, Laptops.Color, Laptops.Hard_disk_cap, Laptops.Size," +
                " Laptops.Wt, Laptops.Video_card, Laptops.Features, Displays.Resolution, Displays.Matte," +
                " Displays.Technology ORDER BY quantity DESC");

            if (commonDataGridView.RowCount < 1)
            {
                VisibleThings($"Статистика недоступна. Немає ноутбуків, що були продані.");
                commonDataGridView.Visible = false;
            }
            else
            {
                commonDataGridView.Columns[0].HeaderText = "№";
                commonDataGridView.Columns[1].HeaderText = "Модель";
                commonDataGridView.Columns[2].HeaderText = "Виробник";
                commonDataGridView.Columns[3].HeaderText = "Процесор";
                commonDataGridView.Columns[4].HeaderText = "ОЗП";
                commonDataGridView.Columns[5].HeaderText = "Колір";
                commonDataGridView.Columns[6].HeaderText = "Об'єм жорсткого диску";
                commonDataGridView.Columns[7].HeaderText = "Розмір екрану";
                commonDataGridView.Columns[8].HeaderText = "Вага";
                commonDataGridView.Columns[9].HeaderText = "Відеокарта";
                commonDataGridView.Columns[10].HeaderText = "Особливості";
                commonDataGridView.Columns[11].HeaderText = "Роздільна здатність екрану";
                commonDataGridView.Columns[12].HeaderText = "Матовий екран";
                commonDataGridView.Columns[13].HeaderText = "Технологія екрану";
                commonDataGridView.Columns[14].HeaderText = "Кількість проданих";

                VisibleThings("ТОП-10 ноутбуків");
            }
        }

        private void searchingTextBox_TextChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void sortingCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void filtrationСheckBox_CheckedChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }


        private void allTimeReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisibleThings("Зачекайте, звіт друкується...");
            commonDataGridView.Visible = false;

            commonDataGridView.DataSource = DatabaseManager.GetDataTable("SELECT FORMAT(Sales.Date_, 'dd.MM.yyyy') AS Date, Laptops.Laptop_id, " +
                "Laptops.Producer, Checks.Num_laptops, Checks.Sum_paid, Checks.Sum_without_discount, Workers.Email" +
                " FROM Checks " +
                " JOIN Laptops ON Checks.Laptop_id = Laptops.Laptop_id" +
                " JOIN Sales ON Checks.Sale_id = Sales.Sale_id" +
                " LEFT JOIN Workers ON Sales.Worker_id = Workers.Worker_id;");

            if (commonDataGridView.RowCount < 1)
            {
                VisibleThings("Немає зафіксованих продажів.");
                commonDataGridView.Visible = false;
            }
            else
            {
                Word exp = new Word();//створюємо наш обєкт ворду
                exp.loadWord();//завантажуємо ворд, і показуємо на екрані
                exp.setFont(1, 0, 0, 18, 0, "Times New Roman", exp.ACenter);//задаємо шрифт та форматування, яким будемо виводити загоовок
                                                                            //виводимо заголовок і дату формування звіту
                exp.wordapp.Selection.TypeText("Список продаж станом на " + DateTime.Now.ToString());
                exp.wordapp.Selection.TypeParagraph();//вставляємо рядок
                exp.setFont(0, 0, 0, 13);//змінюємо розмір шрифту, щоб не передавати в функцію вставки таблиці форматування

                commonDataGridView.Columns[0].HeaderText = "Дата";
                commonDataGridView.Columns[1].HeaderText = "№ ноут-\nбуку";
                commonDataGridView.Columns[2].HeaderText = "Виробник";
                commonDataGridView.Columns[3].HeaderText = "К-ть   ";
                commonDataGridView.Columns[4].HeaderText = "Оплачена\nсума";
                commonDataGridView.Columns[5].HeaderText = "Сума\nбез знижки";
                commonDataGridView.Columns[6].HeaderText = "E-mail\nконсультанта";
                exp.insertTable(commonDataGridView);//вставляємо таблицю
                this.WindowState = FormWindowState.Minimized;

                commonLabel.Text = "Звіт готовий.";
            }
            
        }

        private void periodReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisibleThings("Вибір періоду...");
            commonDataGridView.Visible = false;

            commonDataGridView.DataSource = DatabaseManager.GetDataTable("SELECT MIN(date_), MAX(date_) FROM sales");

            try
            {
                var period = new PeriodForm(
                    Convert.ToDateTime(commonDataGridView.Rows[0].Cells[0].Value),
                    Convert.ToDateTime(commonDataGridView.Rows[0].Cells[1].Value));
                var result = period.ShowDialog();

                if (result == DialogResult.OK)
                {
                    VisibleThings("Зачекайте, звіт друкується...");
                    commonDataGridView.Visible = false;

                    commonDataGridView.DataSource = DatabaseManager.GetDataTable("SELECT FORMAT(Sales.Date_, 'dd.MM.yyyy') AS Date, Laptops.Laptop_id, " +
                        "Laptops.Producer, Checks.Num_laptops, Checks.Sum_paid, Checks.Sum_without_discount, Workers.Email" +
                        " FROM Checks" +
                        " JOIN Laptops ON Checks.Laptop_id = Laptops.Laptop_id" +
                        " JOIN Sales ON Checks.Sale_id = Sales.Sale_id" +
                        " LEFT JOIN Workers ON Sales.Worker_id = Workers.Worker_id" +
                        $" WHERE Sales.Date_ >= '{period.startDate}' AND Sales.Date_ <= '{period.endDate}'");

                    if (commonDataGridView.RowCount < 1)
                    {
                        commonLabel.Text = "Статистика у цей період недоступна. " +
                            $"\nЖодних продаж не було здійснено з {period.startDate} до {period.endDate.Replace(" 23:59:59", "")}.";
                    }
                    else
                    {
                        Word exp = new Word();//створюємо наш обєкт ворду
                        exp.loadWord();//завантажуємо ворд, і показуємо на екрані
                        exp.setFont(1, 0, 0, 18, 0, "Times New Roman", exp.ACenter);//задаємо шрифт та форматування, яким будемо виводити загоовок
                                                                                    //виводимо заголовок і дату формування звіту

                        string formattedStartDate = DateTime.Parse(period.startDate).ToString("dd.MM.yyyy");
                        string formattedEndDate = DateTime.Parse(period.endDate.Replace(" 23:59:59", "")).ToString("dd.MM.yyyy");

                        // Тепер ви можете використовувати ці змінні у вашому рядку
                        exp.wordapp.Selection.TypeText($"Список продаж з {formattedStartDate} до {formattedEndDate}");

                        exp.wordapp.Selection.TypeParagraph();//вставляємо рядок
                        exp.setFont(0, 0, 0, 13);//змінюємо розмір шрифту, щоб не передавати в функцію вставки таблиці форматування

                        commonDataGridView.Columns[0].HeaderText = "Дата";
                        commonDataGridView.Columns[1].HeaderText = "№ ноут-\nбуку";
                        commonDataGridView.Columns[2].HeaderText = "Виробник";
                        commonDataGridView.Columns[3].HeaderText = "К-ть";
                        commonDataGridView.Columns[4].HeaderText = "Оплачена\nсума";
                        commonDataGridView.Columns[5].HeaderText = "Сума\nбез знижки";
                        commonDataGridView.Columns[6].HeaderText = "E-mail\nконсультанта";
                        exp.insertTable(commonDataGridView);//вставляємо таблицю
                        this.WindowState = FormWindowState.Minimized;
                        commonLabel.Text = "Звіт готовий.";
                    }
                }
                else
                {
                    commonLabel.Text = "";
                }
            }
            catch (Exception)
            {
                commonLabel.Text = "Немає зафіксованих продажів.";
            }
        }

        private void periopTop5ConsultantsMenuItem_Click(object sender, EventArgs e)
        {
            VisibleThings("Вибір періоду...");
            commonDataGridView.Visible = false;

            commonDataGridView.DataSource = DatabaseManager.GetDataTable("SELECT MIN(date_), MAX(date_) FROM sales");

            try
            {
                var period = new PeriodForm(
                    Convert.ToDateTime(commonDataGridView.Rows[0].Cells[0].Value),
                    Convert.ToDateTime(commonDataGridView.Rows[0].Cells[1].Value));
                var result = period.ShowDialog();

                if (result == DialogResult.OK)
                {
                    commonDataGridView.DataSource = DatabaseManager.GetDataTable("SELECT TOP 5 Workers.Surname, Workers.First_name, SUM(Checks.Sum_paid) as total " +
                    "FROM Workers JOIN Sales ON Workers.Worker_id = Sales.Worker_id JOIN Checks ON Sales.Sale_id = Checks.Sale_id " +
                    $" WHERE Sales.Date_ >= '{period.startDate}' AND Sales.Date_ <= '{period.endDate}'" +
                    "GROUP BY Workers.Surname, Workers.First_name ORDER BY total DESC");

                    if (commonDataGridView.RowCount < 1)
                    {
                        commonLabel.Text = "Статистика у цей період недоступна. " +
                            $"\nЖодних продаж не було здійснено з {period.startDate} до {period.endDate.Replace(" 23:59:59", "")}.";
                    }
                    else
                    {
                        commonDataGridView.Columns[1].HeaderText = "Ім'я      ";
                        commonDataGridView.Columns[0].HeaderText = "Прізвище       ";
                        commonDataGridView.Columns[2].HeaderText = "Сума";

                        VisibleThings($"ТОП-5 консультантів (з {period.startDate} до {period.endDate.Replace(" 23:59:59", "")})");
                    }
                }
                else
                {
                    commonLabel.Text = "";
                }
            } 
            catch(Exception)
            {
                commonLabel.Text = "Статистика недоступна. Консультантів ще немає у базі.";
            }
        }

        private void periopTop5ClientsMenuItem_Click(object sender, EventArgs e)
        {
            VisibleThings("Вибір періоду...");
            commonDataGridView.Visible = false;

            commonDataGridView.DataSource = DatabaseManager.GetDataTable("SELECT MIN(date_), MAX(date_) FROM sales");
            try
            {
                var period = new PeriodForm(
                    Convert.ToDateTime(commonDataGridView.Rows[0].Cells[0].Value),
                    Convert.ToDateTime(commonDataGridView.Rows[0].Cells[1].Value));
                var result = period.ShowDialog();

                if (result == DialogResult.OK)
                {
                    commonDataGridView.DataSource = DatabaseManager.GetDataTable("SELECT TOP 5 Clients.Surname, Clients.First_name, Clients.Email, SUM(Checks.Num_laptops) as laptops " +
                    "FROM Clients JOIN Sales ON Clients.Email = Sales.Email JOIN Checks ON Sales.Sale_id = Checks.Sale_id " +
                    $" WHERE Sales.Date_ >= '{period.startDate}' AND Sales.Date_ <= '{period.endDate}'" +
                    "GROUP BY Clients.Surname, Clients.First_name, Clients.Email ORDER BY laptops DESC");

                    if (commonDataGridView.RowCount < 1)
                    {
                        commonLabel.Text = "Статистика у цей період недоступна. " +
                            $"\nЖодних продаж не було здійснено з {period.startDate} до {period.endDate.Replace(" 23:59:59", "")}.";
                    }
                    else
                    {
                        commonDataGridView.Columns[1].HeaderText = "Ім'я      ";
                        commonDataGridView.Columns[2].HeaderText = "E-mail";
                        commonDataGridView.Columns[0].HeaderText = "Прізвище       ";
                        commonDataGridView.Columns[3].HeaderText = "Кількість куплених ноутбуків";

                        VisibleThings($"ТОП-5 клієнтів (з {period.startDate} до {period.endDate.Replace(" 23:59:59", "")})");

                    }
                }
                else
                {
                    commonLabel.Text = "";
                }
            }
            catch (Exception)
            {
                commonLabel.Text = "Статистика недоступна. Клієнтів ще немає у базі.";
            }

        }

        private void periodTop10LaptopsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisibleThings("Вибір періоду...");
            commonDataGridView.Visible = false;

            commonDataGridView.DataSource = DatabaseManager.GetDataTable("SELECT MIN(date_), MAX(date_) FROM sales");

            try
            {
                var period = new PeriodForm(
                    Convert.ToDateTime(commonDataGridView.Rows[0].Cells[0].Value),
                    Convert.ToDateTime(commonDataGridView.Rows[0].Cells[1].Value));
                var result = period.ShowDialog();

                if (result == DialogResult.OK)
                {
                    commonDataGridView.DataSource = DatabaseManager.GetDataTable("SELECT TOP 10 Laptops.Laptop_id, Laptops.Model, Laptops.Producer," +
                   " Laptops.Processor, Laptops.Ram, Laptops.Color, Laptops.Hard_disk_cap, Laptops.Size," +
                   " Laptops.Wt, Laptops.Video_card, Laptops.Features, Displays.Resolution, Displays.Matte," +
                   " Displays.Technology, SUM(Checks.Num_laptops) as quantity " +
                   "FROM Laptops JOIN Checks ON Laptops.Laptop_id = Checks.Laptop_id JOIN Displays " +
                   "ON Displays.Display_id = Laptops.Display_id JOIN Sales ON Sales.Sale_id = Checks.Sale_id" +
                    $" WHERE Sales.Date_ >= '{period.startDate}' AND Sales.Date_ <= '{period.endDate}'" +
                   "GROUP BY Laptops.Laptop_id, Laptops.Model, Laptops.Producer," +
                   " Laptops.Processor, Laptops.Ram, Laptops.Color, Laptops.Hard_disk_cap, Laptops.Size," +
                   " Laptops.Wt, Laptops.Video_card, Laptops.Features, Displays.Resolution, Displays.Matte," +
                   " Displays.Technology ORDER BY quantity DESC");

                    if (commonDataGridView.RowCount < 1)
                    {
                        commonLabel.Text = "Статистика у цей період недоступна. " +
                            $"\nЖодних продаж не було здійснено з {period.startDate} до {period.endDate.Replace(" 23:59:59", "")}.";
                    }
                    else
                    {
                        commonDataGridView.Columns[0].HeaderText = "№";
                        commonDataGridView.Columns[1].HeaderText = "Модель";
                        commonDataGridView.Columns[2].HeaderText = "Виробник";
                        commonDataGridView.Columns[3].HeaderText = "Процесор";
                        commonDataGridView.Columns[4].HeaderText = "ОЗП";
                        commonDataGridView.Columns[5].HeaderText = "Колір";
                        commonDataGridView.Columns[6].HeaderText = "Об'єм жорсткого диску";
                        commonDataGridView.Columns[7].HeaderText = "Розмір екрану";
                        commonDataGridView.Columns[8].HeaderText = "Вага";
                        commonDataGridView.Columns[9].HeaderText = "Відеокарта";
                        commonDataGridView.Columns[10].HeaderText = "Особливості";
                        commonDataGridView.Columns[11].HeaderText = "Роздільна здатність екрану";
                        commonDataGridView.Columns[12].HeaderText = "Матовий екран";
                        commonDataGridView.Columns[13].HeaderText = "Технологія екрану";
                        commonDataGridView.Columns[14].HeaderText = "Кількість проданих";

                        VisibleThings($"ТОП-10 ноутбуків (з {period.startDate} до {period.endDate.Replace(" 23:59:59", "")})");

                    }
                }
                else
                {
                    commonLabel.Text = "";
                }
            }
            catch (Exception)
            {
                commonLabel.Text = $"Статистика недоступна. Немає ноутбуків, що були продані.";
            }
        }

    }
}
