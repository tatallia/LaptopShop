using LaptopShop.LaptopShopDataSetTableAdapters;
using System;
using System.Windows.Forms;

namespace LaptopShop.Forms
{
    public partial class EditDisplayForm : Form
    {

        private readonly int id;
        /// true - якщо запис модифікується, false - якщо створюється новий
        readonly bool edit;

        public EditDisplayForm()
        {
            InitializeComponent();
            edit = false;
            displaysTableAdapter.Fill(laptopShopDataSet.displays);
        }
        public EditDisplayForm(int id, bool matte, string technology, string resolution, string size, string format) : this()
        {
            edit = true;
            this.id = id;
            technologyTextBox.Text = technology;
            resolutionTextBox.Text = resolution;
            sizeTextBox.Text = size;
            formatTextBox.Text = format;
            matteCheckBox.Checked = matte;
        }

        private void OK_button_Click(object sender, EventArgs e)
        {
            if (Validation.AreAllTextBoxesFilled(this))
            {
                if (edit)
                {
                    displaysTableAdapter.UpdateQuery(
                        matteCheckBox.Checked,
                        technologyTextBox.Text,
                        resolutionTextBox.Text,
                        sizeTextBox.Text,
                        formatTextBox.Text,
                        id);
                }
                else
                {
                    displaysTableAdapter.InsertQuery(
                        matteCheckBox.Checked,
                        technologyTextBox.Text,
                        resolutionTextBox.Text,
                        sizeTextBox.Text,
                        formatTextBox.Text);
                }
                Close();
            }
        }
    

        private void EditDisplayForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'laptopShopDataSet.displays' table. You can move, or remove it, as needed.
            this.displaysTableAdapter.Fill(this.laptopShopDataSet.displays);

        }

        private void formatTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = !Validation.IsValidFormat(formatTextBox.Text);
        }
    }
}
