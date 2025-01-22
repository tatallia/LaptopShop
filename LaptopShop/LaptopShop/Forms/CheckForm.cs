using LaptopShop.LaptopShopDataSetTableAdapters;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace LaptopShop.Forms
{
    public partial class CheckForm : Form
    {
        double startPrice;
        int numOfRows = 0;
        string email;
        int newSaleID;

        public CheckForm()
        {
            InitializeComponent();
            checksTableAdapter.Fill(laptopShopDataSet.checks);

            int screenHeight = Screen.PrimaryScreen.WorkingArea.Height;
            int formHeight = Height;

            int topPosition = (screenHeight - formHeight) / 2;

            Bounds = new Rectangle(Screen.PrimaryScreen.WorkingArea.Width - Width, topPosition, Width, formHeight);
        }

        public void CalculateSum()
        {
            double sum = 0;

            for (int i = 0; i < numOfRows; i++)
            {
                sum += Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value);
            }
            sumTextBox.Text = sum.ToString("0.00");

            sum = 0;

            for (int i = 0; i < numOfRows; i++)
            {
                sum += Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value);
            }
            endSumTextBox.Text = sum.ToString("0.00");
        }

        public void InsertDataInGrid(object id, object model, object producer, object price)
        {
            // Отримуємо новий рядок
            DataGridViewRow row = dataGridView1.Rows[dataGridView1.Rows.Add()];

            // Присвоюємо значення кожній комірці нового рядка
            row.Cells["Column1"].Value = id;
            row.Cells["Column2"].Value = model;
            row.Cells["Column3"].Value = producer;
            row.Cells["Column4"].Value = 1;
            row.Cells["Column5"].Value = price;
            row.Cells["Column6"].Value = price;
            startPrice = Convert.ToDouble(price);
            numOfRows++;
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            email = emailTextBox.Text;
            DataTable dt = (DataTable)DatabaseManager.GetDataTable($"SELECT Surname, First_name, Num_bonuses FROM Clients WHERE Email = '{email}'");

            if (dt.Rows.Count > 0) //dt != null && 
            {
                string surname = dt.Rows[0]["Surname"].ToString();
                string firstName = dt.Rows[0]["First_name"].ToString();

                hintLabel.Text = $"Ім'я клієнта: {surname} {firstName}";
                hintLabel.ForeColor = Color.DarkGreen;

                for (int i = 0; i < numOfRows; i++)
                {
                    dataGridView1.Rows[i].Cells[5].Value = DatabaseManager.GetDiscount(Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value),
                        Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value), Convert.ToInt32(dt.Rows[0]["Num_bonuses"]),
                        email);
                }
                CalculateSum();
            }
            else
            {
                hintLabel.Text = "Клієнта із введеним емейлом не знайдено.";
                hintLabel.ForeColor = Color.DarkRed;
            }
        }

        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == 3) 
            {
                int editedValue = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);

                if (!int.TryParse(e.FormattedValue.ToString(), out editedValue))
                {
                    // Якщо не вдалося перетворити введене значення в число
                    MessageBox.Show("Будь ласка, введіть коректну кількість ноутбуків.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true; 
                    return;
                }

                // Перевірка чи є достатня кількість ноутбуків на складі
                int availableQuantity = DatabaseManager.GetAvailableQuantityLaptops((int)dataGridView1.Rows[e.RowIndex].Cells[0].Value); 
                if (editedValue > availableQuantity)
                {
                    MessageBox.Show("На жаль, на складі немає такої кількості ноутбуків.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true; 
                    return;
                }

                dataGridView1.Rows[e.RowIndex].Cells["Column5"].Value = (startPrice * editedValue).ToString("0.00");
                dataGridView1.Rows[e.RowIndex].Cells["Column6"].Value = (startPrice * editedValue).ToString("0.00");
                CalculateSum();
            }
        }

        private void getCheckButton_Click(object sender, EventArgs e)
        {
            if(dataGridView1.RowCount > 0)
            {
                newSaleID = DatabaseManager.GetNewSaleID(salesTableAdapter, email);

                for (int i = 0; i < numOfRows; i++)
                {
                    checksTableAdapter.InsertQuery(
                       newSaleID,
                       Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value),
                       Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value),
                       Convert.ToDecimal(dataGridView1.Rows[i].Cells[5].Value),
                       Convert.ToDecimal(dataGridView1.Rows[i].Cells[4].Value));
                }

                Word exp = new Word();//створюємо наш обєкт ворду
                exp.loadWord();//завантажуємо ворд, і показуємо на екрані
                exp.setFont(1, 0, 0, 15, 0, "Times New Roman", exp.ACenter);//задаємо шрифт та форматування, яким будемо виводити загоовок
                                                                            //виводимо заголовок і дату формування звіту
                exp.wordapp.Selection.TypeText("Чек");
                exp.wordapp.Selection.TypeParagraph();//вставляємо рядок
                exp.wordapp.Selection.TypeParagraph();
                exp.setFont(0, 0, 0, 11);//змінюємо розмір шрифту, щоб не передавати в функцію вставки таблиці форматування
                dataGridView2.DataSource = DatabaseManager.GetDataTable("SELECT Laptops.Model," +
                    " Laptops.Producer, Checks.Num_laptops, Checks.Sum_without_discount, Checks.Sum_paid, Laptops.Manufacturer_warranty" +
                    $" FROM Checks JOIN Laptops ON Checks.Laptop_id = Laptops.Laptop_id WHERE Checks.Sale_id = '{newSaleID}'");

                dataGridView2.Columns[0].HeaderText = "Модель";
                dataGridView2.Columns[1].HeaderText = "Виробник";
                dataGridView2.Columns[2].HeaderText = "К-ть";
                dataGridView2.Columns[4].HeaderText = "Cума до сплати, грн";
                dataGridView2.Columns[3].HeaderText = "Сума без знижки, грн";
                dataGridView2.Columns[5].HeaderText = "Гарантія виробника,\nроки";
                exp.insertTable(dataGridView2, 1);//вставляємо таблицю

                for (int i = 0; i < numOfRows; i++)
                {
                    int laptopId = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value);
                    int numLaptopsSold = Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);

                    DatabaseManager.SubtractLaptopQuantity(laptopId, numLaptopsSold);
                }

                exp.wordapp.Selection.TypeText($"До сплати:\n {endSumTextBox.Text}");
                exp.wordapp.Selection.TypeParagraph();
                exp.wordapp.Selection.TypeParagraph();
                exp.wordapp.Selection.TypeText($"Дата:\n {DateTime.Now.ToString("yyyy-MM-dd")}");

                exp.wordapp.Selection.Move(5, 1);
                exp.wordapp.Selection.Move(1, 1);

                // Перейти на новую строку и установить выравнивание по центру
                exp.wordapp.Selection.TypeParagraph();
                exp.setFont(0, 1, 0, 11, 0, "Times New Roman", exp.ACenter);
                exp.wordapp.Selection.TypeText($"Гарантія магазину, роки: {DatabaseManager.ShopGuarantee}");

                Application.OpenForms.OfType<ConsultantForm>().FirstOrDefault().WindowState = FormWindowState.Minimized;
                Close();
            }
            else
            {
                MessageBox.Show("Ви не обрали товар.",
                    "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addClientButton_Click(object sender, EventArgs e)
        {
            var edt = new EditClientForm();
            edt.label1.Text = "Додавання нового клієнта";
            edt.ShowDialog();
            clientsTableAdapter.Fill(laptopShopDataSet.clients);
            laptopShopDataSet.AcceptChanges();
        }
    }

}
