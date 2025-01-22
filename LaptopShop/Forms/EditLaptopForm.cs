using System;
using System.Drawing;
using System.Linq;
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
            displayComboBox.ForeColor = Color.Gray;
        }
        public EditLaptopForm(int id, string model, string producer, string processor, int ram, string color, string hd_cap,
            string size, decimal wt, string video_card, string features, int display, int quarantee, int amount,
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
            displayComboBox.SelectedValue = display;
            textBox_Color.Text = color;
            textBox_Features.Text = features;
            textBox_Guarantee.Text = quarantee.ToString();
            textBox_Amount.Text = amount.ToString();
            textBox_Price.Text = price.ToString();
            displayComboBox.ForeColor = Color.Black;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            ConsultantForm consultantForm = Application.OpenForms.OfType<ConsultantForm>().FirstOrDefault();
            consultantForm.Visible = false;
            var displays = new DisplaysForm();
            displays.ShowDialog();
            consultantForm.Visible = true;
            laptopShopDataSet.AcceptChanges();
            displaysTableAdapter.Fill(laptopShopDataSet.displays);
        }

        private void textBox_Price_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Validation.IsValidPrice(e, textBox_Price.Text);
        }

        private void textBox_Amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Validation.IsDigit(e);
        }

        private void textBox_Weight_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Validation.IsValidWight(e, textBox_Weight.Text);
        }

        private void OK_button_Click(object sender, EventArgs e)
        {
            if(displayComboBox.ForeColor == Color.Gray && edit != true)
            {
                MessageBox.Show("Будь ласка, оберіть номер дисплею.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Validation.AreAllTextBoxesFilled(this))
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
                        Convert.ToInt32(displayComboBox.SelectedValue),
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
                        Convert.ToInt32(displayComboBox.SelectedValue),
                        Convert.ToInt32(textBox_Guarantee.Text),
                        Convert.ToInt32(textBox_Amount.Text),
                        Convert.ToDecimal(textBox_Price.Text));
                }

                Close();
            }
        }

        private void textBox_Guarantee_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Validation.IsDigit(e);
        }

        private void displayComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            displayComboBox.ForeColor = Color.Black;
        }
    }
}
