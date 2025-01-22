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

namespace LaptopShop.Forms
{
    public partial class ViewDisplaysForm : Form
    {
        public ViewDisplaysForm()
        {
            InitializeComponent();
        }

        private void ViewDisplaysForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'laptopShopDataSet.displays' table. You can move, or remove it, as needed.
            this.displaysTableAdapter.Fill(this.laptopShopDataSet.displays);

        }

        private void editButton_Click(object sender, EventArgs e)
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
            displaysTableAdapter.Fill(laptopShopDataSet.displays);
            laptopShopDataSet.AcceptChanges();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            //edt.label1.Text = "Додавання робітника";
        }
    }
}
