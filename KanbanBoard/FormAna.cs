using KanbanBoard_Library;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KanbanBoard
{
    public partial class FormAna : Form
    {
        ProjeYoneticisi py;
        KategoriYoneticisi ky;
        string baslik = "";
        public FormAna()
        {
            InitializeComponent();
        }

        // Open a new form to take the name of the project. After project had created, create project tab will be unabled.
        private void addProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormIsim frm = new FormIsim(py);
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                baslik = (frm.BasligiAl());
                FormProje frm1 = new FormProje(py, baslik, ky);
                frm1.Text = baslik;
                frm1.MdiParent = this;
                frm1.Dock = DockStyle.Fill;
                tsmiCreateProject.Enabled = false;
                frm1.FormClosing += Frm1_FormClosing;
                frm1.Show();
            }
        }
        private void Frm1_FormClosing(object sender, FormClosingEventArgs e)
        {
            tsmiCreateProject.Enabled = true;
        }

        // While loading the project data is read and loaded with json.
        private void FormAna_Load(object sender, EventArgs e)
        {
            try
            {
                string veriler = File.ReadAllText("veri.json");
                string veriler2 = File.ReadAllText("veri2.json");
                py = JsonConvert.DeserializeObject<ProjeYoneticisi>(veriler);
                ky = JsonConvert.DeserializeObject<KategoriYoneticisi>(veriler2);
            }
            catch (Exception)
            {
                OrnekKategorileriEkle();
            }
        }

        // Instance categories had created for user.
        public void OrnekKategorileriEkle()
        {
            py = new ProjeYoneticisi();
            ky = new KategoriYoneticisi();
            Kategori bug = new Kategori(); bug.Baslik = "Bug"; bug.Colour = Color.Red; ky.KategoriEkle(bug);
            Kategori question = new Kategori(); question.Baslik = "Question"; question.Colour = Color.Blue; ky.KategoriEkle(question);
            Kategori documentary = new Kategori(); documentary.Baslik = "Documentary"; documentary.Colour = Color.Green; ky.KategoriEkle(documentary);
            Kategori invalid = new Kategori(); invalid.Baslik = "Invalid"; invalid.Colour = Color.DeepPink; ky.KategoriEkle(invalid);
        }

        // Open the page of projects of user.
        private void tsmiMyProjects_Click(object sender, EventArgs e)
        {
            FormProjeListesi frm = new FormProjeListesi(py, ky);
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        // Open a new form to create a new category
        private void createCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKategori frm = new FormKategori(ky);
            frm.ShowDialog();
        }

        // Shows the categories of the program on new form
        private void myCategoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKategoriler frm = new FormKategoriler(ky);
            frm.ShowDialog();
        }

        // Writes the datas with json.
        private void FormAna_FormClosing(object sender, FormClosingEventArgs e)
        {
            VerileriYaz();
        }
        private void VerileriYaz()
        {
            string json = JsonConvert.SerializeObject(py);
            File.WriteAllText("veri.json", json);
            string json2 = JsonConvert.SerializeObject(ky);
            File.WriteAllText("veri2.json", json2);
        }
    }
}
