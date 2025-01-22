using LaptopShop.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaptopShop
{
    public partial class PeriodForm : Form
    {
        private bool formInitialized = false;
        bool startDateTimeChanged = false;
        bool endDateTimeChanged = false;
        public string startDate;
        public string endDate;

        public PeriodForm()
        {
            InitializeComponent();
        }

        public PeriodForm(DateTime start, DateTime end)
        {
            InitializeComponent();
            dateTimePicker1.MinDate = start;
            dateTimePicker1.MaxDate = end;
            dateTimePicker2.MaxDate = end;
            dateTimePicker2.Enabled = false;
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd MMMM yyyy";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "dd MMMM yyyy";
            formInitialized = true;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (formInitialized)
            {
                dateTimePicker2.Enabled = true;
                dateTimePicker2.MinDate = dateTimePicker1.Value;
                startDateTimeChanged = true;
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.MaxDate = dateTimePicker2.Value;
            endDateTimeChanged = true;
        }

        private void OK_button_Click(object sender, EventArgs e)
        {
            if(startDateTimeChanged && endDateTimeChanged) 
            {
                startDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                endDate = dateTimePicker2.Value.ToString("yyyy-MM-dd") + " 23:59:59";
                this.DialogResult = DialogResult.OK;
                Close();
            } 
            else if(!startDateTimeChanged)
            {
                MessageBox.Show("НЕ було обрано початок періоду.", "Помилка",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("НЕ було обрано кінець періоду.", "Помилка",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
