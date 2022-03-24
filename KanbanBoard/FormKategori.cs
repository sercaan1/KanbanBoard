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
    public partial class FormKategori : Form
    {
        KategoriYoneticisi _ky;
        public FormKategori(KategoriYoneticisi ky)
        {
            _ky = ky;
            InitializeComponent();
        }

        // Shows the color of the category with colordialog.
        private void pboRenk_Click(object sender, EventArgs e)
        {
            cdiRenk.ShowDialog();
            pboRenk.BackColor = cdiRenk.Color;
        }

        // Creates a category
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtAd.Text.Trim() == "")
            {
                MessageBox.Show("Header of the category can not be null!");
                return;
            }
            Kategori kategori = new Kategori();
            kategori.Baslik = txtAd.Text;
            kategori.Colour = pboRenk.BackColor;
            _ky.KategoriEkle(kategori);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
