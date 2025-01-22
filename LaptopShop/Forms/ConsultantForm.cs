using System;
using System.Windows.Forms;

namespace LaptopShop.Forms
{
    public partial class ConsultantForm : Form
    {
        Form currentChildForm;
        public ConsultantForm()
        {
            InitializeComponent();
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;

            childForm.TopLevel = false;
            panelForm.Controls.Add(childForm);
            childForm.Show();
        }

        private void LaptopsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new LaptopsForm());
        }

        private void ConsultantForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void clientsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ClientsForm());
        }

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SalesForm());
        }
    }
}
