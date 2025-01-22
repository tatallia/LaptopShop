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

        //private void ClickDeleteEventButton(object sender, EventArgs e)
        //{
        // OpenChildForm(new DeleteEventForm());
        //}
    }
}
