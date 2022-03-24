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
    public partial class FormProjeListesi : Form
    {
        private ProjeYoneticisi _py;
        private KategoriYoneticisi _ky;
        public FormProjeListesi(ProjeYoneticisi py, KategoriYoneticisi ky)
        {
            _py = py;
            _ky = ky;
            InitializeComponent();
            dgvProjeler.DataSource = _py.ProjeleriGetir();
            dgvProjeler.Columns[0].Visible = false;
            dgvProjeler.Columns[1].HeaderText = "Project Name";
            dgvProjeler.Columns[2].HeaderText = "Creation Time";
            dgvProjeler.Columns[3].HeaderText = "Update Time";
        }

        // Opens the chosen project.
        private void dgvProjeler_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProjeler.SelectedRows.Count < 1)
            {
                return;
            }
            Proje secilenProje = (Proje)dgvProjeler.SelectedRows[0].DataBoundItem;
            FormProje2 frm = new FormProje2(_py, secilenProje, _ky);
            frm.MdiParent = this.MdiParent;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        // Can delete the project by right click.
        private void dgvProjeler_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int position = dgvProjeler.HitTest(e.X, e.Y).RowIndex;
                if (position >= 0)
                {
                    contextMenuStrip1.Show(dgvProjeler, e.X, e.Y);
                    dgvProjeler.Rows[position].Selected = true;
                }
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _py.ProjeCikar((Proje)dgvProjeler.SelectedRows[0].DataBoundItem);
        }
    }
}
