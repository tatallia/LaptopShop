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
    public partial class EditLaptopForm : Form
    {
        private readonly int id;
        /// true - якщо запис модифікується, false - якщо створюється нова
        readonly bool edit;

        public EditLaptopForm()
        {
            InitializeComponent();
            edit = false;
            laptopsTableAdapter.Fill(laptopShopDataSet.laptops);
            displaysTableAdapter.Fill(laptopShopDataSet.displays);
        }
        public EditLaptopForm(int id, string model, string producer, string processor, int ram, string color, string hd_cap,
            string size, decimal wt, string video_card, string features, int display, int quarantee,  int amount,
            decimal price) : this()
        {
            edit = true;
            this.id = id;
            textBox_Model.Text = model;
            textBox_Producer.Text = producer;
            textBox_Processor.Text = processor;
            textBox_RAM.Text = ram.ToString();
            textBox_HD_cap.Text = hd_cap;
            textBox_Size.Text = size;
            textBox_Weight.Text = wt.ToString();
            textBox_VideoCard.Text = video_card;
            comboBox_Display.SelectedValue = display;
            textBox_Color.Text = color;
            textBox_Features.Text = features;
            textBox_Guarantee.Text = quarantee.ToString();
            textBox_Amount.Text = amount.ToString();
            textBox_Price.Text = price.ToString();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            var displays = new ViewDisplaysForm();
            displays.Show();
        }

        private void textBox_Price_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Дозвіл вводити лише числа, десятичну кому і Backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true; // Запретить ввод недопустимых символов
            }

            // Перевірка наявності коми
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true; // Заборона більше однієї коми
            }

            if ((sender as TextBox).Text.Contains(","))
            {
                string[] parts = (sender as TextBox).Text.Split(new char[] { ',' });
                if (parts[1].Length >= 2 && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true; // Заборона вводу більше двох знаків післе коми
                }
            }

            if ((e.KeyChar == ',') && ((sender as TextBox).Text.Length == 0))
            {
                e.Handled = true; // Заборона вводу коми, якщо строка пуста
            }

        }

        private void textBox_Amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox_Weight_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox_Price_KeyPress(sender, e);
        }

        private void textBox_RAM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void OK_button_Click(object sender, EventArgs e)
        {
            if (edit)
            {
                laptopsTableAdapter.UpdateQuery(textBox_Model.Text,
                    textBox_Producer.Text,
                    textBox_Processor.Text,
                    Convert.ToInt32(textBox_RAM.Text),
                    textBox_Color.Text,
                    textBox_HD_cap.Text,
                    textBox_Size.Text,
                    (float)Convert.ToDecimal(textBox_Weight.Text),
                    textBox_VideoCard.Text,
                    textBox_Features.Text,
                    Convert.ToInt32(comboBox_Display.SelectedValue),
                    Convert.ToInt32(textBox_Guarantee.Text),
                    Convert.ToInt32(textBox_Amount.Text),
                    Convert.ToDecimal(textBox_Price.Text), id);
            }
            else
            {
                laptopsTableAdapter.InsertQuery(textBox_Model.Text,
                    textBox_Producer.Text,
                    textBox_Processor.Text,
                    Convert.ToInt32(textBox_RAM.Text),
                    textBox_Color.Text,
                    textBox_HD_cap.Text,
                    textBox_Size.Text,
                    Convert.ToSingle(Convert.ToDecimal(textBox_Weight.Text)),
                    textBox_VideoCard.Text,
                    textBox_Features.Text,
                    Convert.ToInt32(comboBox_Display.SelectedValue),
                    Convert.ToInt32(textBox_Guarantee.Text),
                    Convert.ToInt32(textBox_Amount.Text),
                    Convert.ToDecimal(textBox_Price.Text));
            }

            Close();
        }

    }
}
