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
    public partial class FormKategoriler : Form
    {
        KategoriYoneticisi _ky;
        public FormKategoriler(KategoriYoneticisi ky)
        {
            _ky = ky;
            InitializeComponent();
            BringComboBoxItems();
        }

        // Shows the all categories headers and display their colors.
        private void BringComboBoxItems()
        {
            foreach (var item in _ky.KategorileriGetir())
            {
                cmbKategoriler.Items.Add(item);
            }
            cmbKategoriler.SelectedIndex = 0;
            pbxRenk.BackColor = ((Kategori)cmbKategoriler.SelectedItem).Colour;
        }

        private void cmbKategoriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            pbxRenk.BackColor = ((Kategori)cmbKategoriler.SelectedItem).Colour;
        }

        // Open a new form to create a category.
        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormKategori frm = new FormKategori(_ky);
            frm.ShowDialog();
            BringComboBoxItems();
        }

        // Open a new form to edit the chosen category.
        private void btnEdit_Click(object sender, EventArgs e)
        {
            Kategori kategori = (Kategori)cmbKategoriler.SelectedItem;
            FormEditCategory frm = new FormEditCategory(kategori);
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                BringComboBoxItems();
            }
        }

        // Deletes the chosen category.
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to delete the category?", "Delete category", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Yes)
            {
                Kategori kategori = (Kategori)cmbKategoriler.SelectedItem;
                _ky.KategoriCikar(kategori);
            }
        }
    }
}
