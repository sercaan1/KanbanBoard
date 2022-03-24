using KanbanBoard_Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KanbanBoard
{
    public partial class FormIsim : Form
    {
        public string baslik;
        private ProjeYoneticisi _py;
        public FormIsim(ProjeYoneticisi py)
        {
            _py = py;
            InitializeComponent();
        }

        // Controls the name of the project is already created or not. If it had not sends the name/header of the project to main form.
        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (txtIsim.Text.Trim() == "")
            {
                MessageBox.Show("Please enter the name of project");
                return;
            }
            foreach (var item in _py.ProjeleriGetir())
            {
                if (item.Baslik == txtIsim.Text)
                {
                    MessageBox.Show("This project is already exist!");
                    return;
                }
            }
            if (true)
            {

            }
            baslik = txtIsim.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        public string BasligiAl()
        {
            return baslik;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
