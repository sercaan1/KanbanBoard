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
    public partial class FormNot : Form
    {
        private readonly Not _not;
        KategoriYoneticisi _ky;

        public FormNot(Not not, KategoriYoneticisi ky)
        {
            _ky = ky;
            _not = not;
            InitializeComponent();

            // Shows the headers of categories
            foreach (Kategori item in _ky.KategorileriGetir())
            {
                cmbKategori.Items.Add(item);
                txtNot.MaxLength = 140;
            }
            cmbKategori.SelectedIndex = 0;
        }

        // Shows the props of the chosen category on the preview
        private void cmbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKategori.SelectedIndex < 0)
            {
                return;
            }
            else
            {
                Kategori selected = (Kategori)cmbKategori.SelectedItem;
                lblKategori.Text = cmbKategori.SelectedItem.ToString();
                lblTarih.Text = DateTime.Now.ToShortDateString();
                gbxNot.BackColor = selected.Colour;
            }
        }

        // Shows the remaining characters while texting. If there is no remaining character fontcolor of the label will be red.
        private void txtNot_TextChanged(object sender, EventArgs e)
        {
            txtPreview.Text = txtNot.Text;
            if (txtNot.MaxLength - txtNot.Text.Length == 0)
            {
                lblRemain.ForeColor = Color.Red;
            }
            lblRemain.Text = "Remaining characters: " + (txtNot.MaxLength - txtNot.Text.Length).ToString();
        }

        // Create a note and close the form
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtNot.Text.Trim() == "")
            {
                MessageBox.Show("Description of the note can not be null!");
                return;
            }
            if (cmbKategori.SelectedIndex < 0)
            {
                MessageBox.Show("You have to choose a category");
                return;
            }
            _not.Icerik = txtNot.Text;
            _not.Kategori = (Kategori)cmbKategori.SelectedItem;
            _not.CreationTime = DateTime.Now;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
