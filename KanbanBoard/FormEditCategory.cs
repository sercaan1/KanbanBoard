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
    public partial class FormEditCategory : Form
    {
        private Kategori _kategori;
        public FormEditCategory(Kategori kategori)
        {
            _kategori = kategori;
            InitializeComponent();
            BringTheCategory();
        }

        // Brings the name and the color of the chosen category.
        private void BringTheCategory()
        {
            txtAd.Text = _kategori.Baslik;
            pboRenk.BackColor = _kategori.Colour;
        }

        // Close the form
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Edit category
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtAd.Text.Trim() == "")
            {
                MessageBox.Show("Header of the category can not be null");
                return;
            }
            _kategori.Colour = pboRenk.BackColor;
            _kategori.Baslik = txtAd.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        // Shows the color of the category with colordialog
        private void pboRenk_Click(object sender, EventArgs e)
        {
            cdiRenk.ShowDialog();
            pboRenk.BackColor = cdiRenk.Color;
        }
    }
}
