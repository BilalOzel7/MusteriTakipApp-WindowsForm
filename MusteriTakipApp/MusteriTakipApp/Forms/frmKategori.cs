using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusteriTakipApp.Forms
{
    public partial class frmKategori : Form
    {
        public frmKategori()
        {
            InitializeComponent();
        }
        MTakipContext db = new MTakipContext();
        int secID;
        Kategori secKategori;
        List<Kategori> klist = new List<Kategori>();

        private void frmKategori_Load(object sender, EventArgs e)
        {
            Goster();
            this.dataGridView1.Columns["Urunler"].Visible = false;
        }

        private void Goster()
        {
            if (klist == null)
            {
                klist = db.Kategorilers.ToList();    //select * from Categories
            }
            else
            {
                klist = db.Kategorilers.Where(x => x.KategoriAd.Contains(txtBoxAra.Text)).ToList();
                //select*from Categories where CategoryName like '%ara%'

            }

            dataGridView1.DataSource = klist;
        }
        private void Temizle()
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
                else if (item is RichTextBox)
                {
                    item.Text = "";
                }
            }
        }
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            secID = (int)dataGridView1.CurrentRow.Cells[0].Value;
            secKategori = db.Set<Kategori>().Find(secID);
            txtBoxAd.Text = secKategori.KategoriAd;
            richTextBoxAciklama.Text = secKategori.Aciklama;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Kategori yKat = new Kategori();
            yKat.KategoriAd = txtBoxAd.Text;
            yKat.Aciklama = richTextBoxAciklama.Text;
            db.Set<Kategori>().Add(yKat);
            db.SaveChanges();
            Goster();
            Temizle();
        }



        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            secKategori.KategoriAd = txtBoxAd.Text;
            secKategori.Aciklama = richTextBoxAciklama.Text;
            db.Entry(secKategori).State = EntityState.Modified;
            db.SaveChanges();
            Goster();
            Temizle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            db.Set<Kategori>().Remove(secKategori);
            db.SaveChanges();
            Goster();
            Temizle();
        }

        private void txtBoxAra_TextChanged(object sender, EventArgs e)
        {
            Goster();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }
    }
}
