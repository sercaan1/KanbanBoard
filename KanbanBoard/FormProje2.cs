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
    public partial class FormProje2 : Form
    {
        private Proje _proje;
        private ProjeYoneticisi _py;
        public Not not;
        private KategoriYoneticisi _ky;
        GroupBox gbx;
        PictureBox pb;
        public FormProje2(ProjeYoneticisi py, Proje proje, KategoriYoneticisi ky)
        {
            InitializeComponent();
            _py = py;
            _proje = proje;
            _ky = ky;
            this.Text = _proje.Baslik;
            KayitlariGetir();
        }

        // Brings the notes and controls of the project.
        private void KayitlariGetir()
        {
            flpToDo.Controls.Clear();
            flpDone.Controls.Clear();
            flpDoin.Controls.Clear();
            foreach (var item in _proje.notlar)
            {
                gbx = new GroupBox();
                gbx.AllowDrop = true;
                gbx.Tag = item.Id;
                gbx.Name = item.Id.ToString();
                gbx.Width = flpToDo.Width - 10;
                gbx.Height = (flpToDo.Height / 6);
                gbx.BackColor = item.Kategori.Colour;
                gbx.MouseDown += Gbx_MouseDown;
                Label lbl = new Label();
                lbl.Text = item.Kategori.ToString();
                lbl.Left = gbx.Left + 5;
                lbl.Top = gbx.Top + 5;
                TextBox txt = new TextBox();
                txt.Text = item.Icerik;
                txt.Width = gbx.Width - 5;
                txt.Height = gbx.Height - 65;
                txt.Multiline = true;
                txt.Top = lbl.Bottom + 5;
                txt.Left = lbl.Left;
                txt.ReadOnly = true;
                txt.Enabled = false;
                Label lbl1 = new Label();
                lbl1.Text = item.CreationTime.ToShortDateString();
                lbl1.Top = txt.Bottom + 10;
                lbl1.Left = lbl.Left;
                PictureBox pb = new PictureBox();
                pb.Size = new Size(lbl.Height + 10, lbl.Height + 10);
                pb.Top = lbl.Top;
                pb.Left = flpToDo.Left + flpToDo.Width - 100;
                pb.Tag = item.Id;
                pb.Click += Btn_Click;
                pb.Image = Properties.Resources.delete;
                gbx.Controls.Add(lbl);
                gbx.Controls.Add(lbl1);
                gbx.Controls.Add(txt);
                gbx.Controls.Add(pb);
                if (item.NotDurum == EnumNotDurum.ToDo)
                {
                    flpToDo.Controls.Add(gbx);
                }
                else if (item.NotDurum == EnumNotDurum.Doin)
                {
                    flpDoin.Controls.Add(gbx);
                }
                else
                {
                    flpDone.Controls.Add(gbx);
                }
            }
        }

        // Resizes the controls as like panels, label, pictureboxes.
        private void KontrolleriBoyutlandir()
        {
            menuStrip1.AllowMerge = false;
            flpDoin.Width = flpDone.Width = flpToDo.Width = this.ClientSize.Width / 3 - 8;
            flpDoin.Height = flpDone.Height = flpToDo.Height = this.ClientSize.Height - 56;
            flpToDo.Left = 5;
            flpToDo.Top = 51;
            flpDoin.Left = flpToDo.Right + 5;
            flpDoin.Top = 51;
            flpDone.Left = flpDoin.Right + 5;
            flpDone.Top = 51;
            lblToDo.Left = flpToDo.Left + flpToDo.Width / 2 - lblToDo.Width / 2;
            lblDoin.Top = lblDone.Top = lblToDo.Top = pbToDo.Top = pbDoin.Top = pbDone.Top = 22;
            lblDoin.Left = flpDoin.Left + flpDoin.Width / 2 - lblDoin.Width / 2;
            lblDone.Left = flpDone.Left + flpDone.Width / 2 - lblDone.Width / 2;
            pbToDo.Left = flpToDo.Right - pbToDo.Width;
            pbDoin.Left = flpDoin.Right - pbDoin.Width;
            pbDone.Left = flpDone.Right - pbDone.Width;
        }

        // Resize the controls when client size changed
        private void FormProje2_SizeChanged(object sender, EventArgs e)
        {
            KontrolleriBoyutlandir();
            KayitlariGetir();
        }

        // Deletes the open form.
        private void deleteProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _py.ProjeCikar(_proje);
            this.Close();
        }

        // Updates the update time
        private void tsmiSaveProject_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Changes saved!");
            _proje.GuncellemeZamani = DateTime.Now;
        }

        // Open a new form to create a new note
        private void tsmiCreateNote_Click(object sender, EventArgs e)
        {
            not = new Not();
            not.NotDurum = EnumNotDurum.ToDo;
            FormNot frm = new FormNot(not, _ky);
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                _proje.notlar.Add(not);
                GroupBoxGetir(not);
            }
        }

        // Create a groupbox of the new created note.
        private void GroupBoxGetir(Not not)
        {
            gbx = new GroupBox();
            gbx.AllowDrop = true;
            gbx.Tag = not.Id;
            gbx.Name = not.Id.ToString();
            gbx.Width = flpToDo.Width - 10;
            gbx.Height = (flpToDo.Height / 6);
            gbx.BackColor = not.Kategori.Colour;
            gbx.MouseDown += Gbx_MouseDown;
            Label lbl = new Label();
            lbl.Text = not.Kategori.ToString();
            lbl.Left = gbx.Left + 5;
            lbl.Top = gbx.Top + 5;
            TextBox txt = new TextBox();
            txt.Text = not.Icerik;
            txt.Width = gbx.Width - 5;
            txt.Height = gbx.Height - 65;
            txt.Multiline = true;
            txt.Top = lbl.Bottom + 5;
            txt.Left = lbl.Left;
            txt.ReadOnly = true;
            txt.Enabled = false;
            Label lbl1 = new Label();
            lbl1.Text = not.CreationTime.ToShortDateString();
            lbl1.Top = txt.Bottom + 10;
            lbl1.Left = lbl.Left;
            PictureBox pb = new PictureBox();
            pb.Size = new Size(lbl.Height + 10, lbl.Height + 10);
            pb.Top = lbl.Top;
            pb.Left = flpToDo.Left + flpToDo.Width - 100;
            pb.Tag = not.Id;
            pb.Click += Btn_Click;
            pb.Image = Properties.Resources.delete;
            gbx.Controls.Add(lbl);
            gbx.Controls.Add(lbl1);
            gbx.Controls.Add(txt);
            gbx.Controls.Add(pb);
            if (not.NotDurum == EnumNotDurum.ToDo)
            {
                flpToDo.Controls.Add(gbx);
            }
            else if (not.NotDurum == EnumNotDurum.Doin)
            {
                flpDoin.Controls.Add(gbx);
            }
            else
            {
                flpDone.Controls.Add(gbx);
            }
        }

        // Deletes the note when clicked to picture of garbage bin.
        private void Btn_Click(object sender, EventArgs e)
        {
            pb = (PictureBox)sender;
            Not secilenNot = _proje.notlar.FirstOrDefault(x => x.Id == (Guid)pb.Tag);
            _proje.notlar.Remove(secilenNot);
            KayitlariGetir();
        }

        // Events of drag-drop of the groupbox and the panels.
        #region 
        private void Gbx_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                var control = sender as Control;
                this.DoDragDrop(control.Name, DragDropEffects.Move);
            }
            else if (e.Button == MouseButtons.Right)
            {
                GroupBox gbx = (GroupBox)sender;
                contextMenuStrip1.Show(gbx, e.X, e.Y);
                not = _proje.notlar.FirstOrDefault(x => x.Id == (Guid)gbx.Tag);
            }
        }

        private void flpToDo_DragEnter(object sender, DragEventArgs e)
        {
            if (!e.Data.GetDataPresent(typeof(string)))
                return;

            var name = e.Data.GetData(typeof(string)) as string;
            var control = this.Controls.Find(name, true).FirstOrDefault();
            if (control != null)
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        private void flpToDo_DragDrop(object sender, DragEventArgs e)
        {
            if (!e.Data.GetDataPresent(typeof(string)))
                return;

            var name = e.Data.GetData(typeof(string)) as string;
            var control = this.Controls.Find(name, true).FirstOrDefault();
            Not secilenNot = _proje.notlar.FirstOrDefault(x => x.Id == (Guid)gbx.Tag);
            if (control != null)
            {
                control.Parent.Controls.Remove(control);
                var panel = (FlowLayoutPanel)sender;
                panel.Controls.Add(control);
                secilenNot.NotDurum = EnumNotDurum.ToDo;
            }
        }

        private void flpDoin_DragDrop(object sender, DragEventArgs e)
        {
            if (!e.Data.GetDataPresent(typeof(string)))
                return;

            var name = e.Data.GetData(typeof(string)) as string;
            var control = this.Controls.Find(name, true).FirstOrDefault();
            Not secilenNot = _proje.notlar.FirstOrDefault(x => x.Id == (Guid)gbx.Tag);
            if (control != null)
            {
                control.Parent.Controls.Remove(control);
                var panel = (FlowLayoutPanel)sender;
                panel.Controls.Add(control);
                secilenNot.NotDurum = EnumNotDurum.Doin;
            }
        }

        private void flpDone_DragDrop(object sender, DragEventArgs e)
        {
            if (!e.Data.GetDataPresent(typeof(string)))
                return;

            var name = e.Data.GetData(typeof(string)) as string;
            var control = this.Controls.Find(name, true).FirstOrDefault();
            Not secilenNot = _proje.notlar.FirstOrDefault(x => x.Id == (Guid)gbx.Tag);
            if (control != null)
            {
                control.Parent.Controls.Remove(control);
                var panel = (FlowLayoutPanel)sender;
                panel.Controls.Add(control);
                secilenNot.NotDurum = EnumNotDurum.Done;
            }
        }
        #endregion

        // Updates the updatetime.
        private void FormProje2_FormClosing(object sender, FormClosingEventArgs e)
        {
            _proje.GuncellemeZamani = DateTime.Now;
        }

        // Shows the picture boxes where to copy.
        private void tsmiCopy_Click_1(object sender, EventArgs e)
        {
            pbDoin.Show();
            pbToDo.Show();
            pbDone.Show();
        }

        // Adds the note to todo panel which copied
        private void pbToDo_Click_1(object sender, EventArgs e)
        {
            Not not1 = new Not() { CreationTime = DateTime.Now, Icerik = not.Icerik, Kategori = not.Kategori };
            not1.NotDurum = EnumNotDurum.ToDo;
            _proje.notlar.Add(not1);
            GroupBoxGetir(not1);
            KayitlariGetir();
            pbToDo.Hide();
            pbDone.Hide();
            pbDoin.Hide();
        }

        // Adds the note to doing panel which copied
        private void pbDoin_Click_1(object sender, EventArgs e)
        {
            Not not1 = new Not() { CreationTime = DateTime.Now, Icerik = not.Icerik, Kategori = not.Kategori };
            not1.NotDurum = EnumNotDurum.Doin;
            _proje.notlar.Add(not1);
            GroupBoxGetir(not1);
            KayitlariGetir();
            pbToDo.Hide();
            pbDone.Hide();
            pbDoin.Hide();
        }

        // Adds the note to done panel which copied
        private void pbDone_Click_1(object sender, EventArgs e)
        {
            Not not1 = new Not() { CreationTime = DateTime.Now, Icerik = not.Icerik, Kategori = not.Kategori };
            not1.NotDurum = EnumNotDurum.Done;
            _proje.notlar.Add(not1);
            GroupBoxGetir(not1);
            KayitlariGetir();
            pbToDo.Hide();
            pbDone.Hide();
            pbDoin.Hide();
        }
    }
}
