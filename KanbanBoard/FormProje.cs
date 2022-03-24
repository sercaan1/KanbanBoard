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
    public partial class FormProje : Form
    {
        private Not not;
        private Proje yeniProje;
        private ProjeYoneticisi _py;
        private KategoriYoneticisi _ky;
        GroupBox gbx;
        PictureBox pb;
        public FormProje(ProjeYoneticisi py, string baslik, KategoriYoneticisi ky)
        {
            _ky = ky;
            _py = py;
            yeniProje = new Proje();
            yeniProje.Baslik = baslik;
            yeniProje.CreationTime = DateTime.Now;

            InitializeComponent();
        }

        // While opening the form size will change automatically because of the mdicontainer. And also user can change the size of the client.
        private void FormProje_SizeChanged(object sender, EventArgs e)
        {
            KontrolleriBoyutlandir();
        }

        // Resizes the controls on the form as the picture boxes, labels and panels.
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

        // If the project didnt save before adds the project to the list otherwise it only updates the update time of the project.
        private void tsmiSaveProject_Click(object sender, EventArgs e)
        {
            bool varMi = _py.ProjeVarMi(yeniProje);
            if (!varMi)
            {
                _py.ProjeEkle(yeniProje);
            }
            yeniProje.GuncellemeZamani = DateTime.Now;
            MessageBox.Show("Changes saved!");
        }

        // Controls the project is saved or not. If it is not, it will ask to the user if they want to save it.
        private void FormProje_FormClosing(object sender, FormClosingEventArgs e)
        {
            bool varMi = _py.ProjeVarMi(yeniProje);

            if (varMi)
            {
                e.Cancel = false;
            }
            else
            {
                DialogResult dr = MessageBox.Show("Do you want to save changes?", "Closing", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (dr == DialogResult.Yes)
                {
                    if (!varMi)
                    {
                        _py.ProjeEkle(yeniProje);
                    }
                    yeniProje.GuncellemeZamani = DateTime.Now;
                    MessageBox.Show("Changes saved!");
                    e.Cancel = false;
                }
                else if (dr == DialogResult.No)
                {
                    e.Cancel = false;
                }
                else if (dr == DialogResult.Cancel)
                    e.Cancel = true;
            }
        }

        // Open a new form to create a note.
        private void tsmiCreateNote_Click(object sender, EventArgs e)
        {
            not = new Not();
            not.NotDurum = EnumNotDurum.ToDo;
            FormNot frm = new FormNot(not, _ky);
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                yeniProje.notlar.Add(not);
                GroupBoxGetir(not);
            }
        }

        // Creates a groupbox in the controls of the panel which contains the note.
        private void GroupBoxGetir(Not not)
        {
            gbx = new GroupBox();
            gbx.AllowDrop = true;
            gbx.MouseDown += Gbx_MouseDown;
            gbx.Width = flpToDo.Width - 10;
            gbx.Height = (flpToDo.Height / 6);
            gbx.Tag = not.Id;
            gbx.BackColor = not.Kategori.Colour;
            gbx.Name = not.Id.ToString();
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
            pb = new PictureBox();
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

        // Delete method of the picturebox in the groupbox.
        private void Btn_Click(object sender, EventArgs e)
        {
            pb = (PictureBox)sender;
            Not secilenNot = yeniProje.notlar.FirstOrDefault(x => x.Id == (Guid)pb.Tag);
            yeniProje.notlar.Remove(secilenNot);
            NotlariGetir();
        }

        // Brings the notes after created a note and drag-drop events.
        private void NotlariGetir()
        {
            flpToDo.Controls.Clear();
            flpDoin.Controls.Clear();
            flpDone.Controls.Clear();
            foreach (var item in yeniProje.notlar)
            {
                gbx = new GroupBox();
                gbx.AllowDrop = true;
                gbx.MouseDown += Gbx_MouseDown;
                gbx.Width = flpToDo.Width - 10;
                gbx.Height = (flpToDo.Height / 6);
                gbx.Tag = item.Id;
                gbx.BackColor = item.Kategori.Colour;
                gbx.Name = item.Id.ToString();
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
                pb = new PictureBox();
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

        // Drag-drop events of groupbox and panels. Also controls the right click or left click on the groupbox.
        #region DragDropFlps
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
                not = yeniProje.notlar.FirstOrDefault(x => x.Id == (Guid)gbx.Tag);
            }
        }
        private void flpToDo_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
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
            Not secilenNot = yeniProje.notlar.FirstOrDefault(x => x.Id == (Guid)gbx.Tag);
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
            Not secilenNot = yeniProje.notlar.FirstOrDefault(x => x.Id == (Guid)gbx.Tag);
            if (control != null)
            {
                control.Parent.Controls.Remove(control);
                var panel = (FlowLayoutPanel)sender;
                panel.Controls.Add(control);
                secilenNot.NotDurum = EnumNotDurum.Doin;
            }
        }
        private void flpDone_DragDrop_1(object sender, DragEventArgs e)
        {
            if (!e.Data.GetDataPresent(typeof(string)))
                return;

            var name = e.Data.GetData(typeof(string)) as string;
            var control = this.Controls.Find(name, true).FirstOrDefault();
            Not secilenNot = yeniProje.notlar.FirstOrDefault(x => x.Id == (Guid)gbx.Tag);
            if (control != null)
            {
                control.Parent.Controls.Remove(control);
                var panel = (FlowLayoutPanel)sender;
                panel.Controls.Add(control);
                secilenNot.NotDurum = EnumNotDurum.Done;
            }
        }
        #endregion

        // Shows the picture boxes where to copy
        private void tsmiCopy_Click(object sender, EventArgs e)
        {
            pbDoin.Show();
            pbToDo.Show();
            pbDone.Show();
        }

        // Adds the note to todo panel which copied
        private void pbToDo_Click(object sender, EventArgs e)
        {
            Not not1 = new Not() { CreationTime = DateTime.Now, Icerik = not.Icerik, Kategori = not.Kategori};
            not1.NotDurum = EnumNotDurum.ToDo;
            yeniProje.notlar.Add(not1);
            GroupBoxGetir(not1);
            NotlariGetir();
            pbToDo.Hide();
            pbDone.Hide();
            pbDoin.Hide();
        }

        // Adds the note to doing panel which copied
        private void pbDoin_Click(object sender, EventArgs e)
        {
            Not not1 = new Not() { CreationTime = DateTime.Now, Icerik = not.Icerik, Kategori = not.Kategori };
            not1.NotDurum = EnumNotDurum.Doin;
            yeniProje.notlar.Add(not1);
            GroupBoxGetir(not1);
            NotlariGetir();
            pbToDo.Hide();
            pbDone.Hide();
            pbDoin.Hide();
        }

        // Adds the note to done panel which copied
        private void pbDone_Click(object sender, EventArgs e)
        {
            Not not1 = new Not() { CreationTime = DateTime.Now, Icerik = not.Icerik, Kategori = not.Kategori };
            not1.NotDurum = EnumNotDurum.Done;
            yeniProje.notlar.Add(not1);
            GroupBoxGetir(not1);
            NotlariGetir();
            pbToDo.Hide();
            pbDone.Hide();
            pbDoin.Hide();
        }
    }
}
