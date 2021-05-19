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
    public partial class frmMusteri : Form
    {
        public frmMusteri()
        {
            InitializeComponent();
        }
        MTakipContext db = new MTakipContext();
        private int secID;
        private Musteri secMusteri;
        List<Musteri> mlist = new List<Musteri>();

        private void frmMusteri_Load(object sender, EventArgs e)
        {
            Goster();
        }

        private void Goster()
        {
            if (mlist == null)
            {
                mlist = db.Musteriler.ToList();    //select * from Categories
            }
            else
            {
                mlist = db.Musteriler.Where(x => x.MusteriAd.Contains(txtBoxAra.Text)).ToList();
                //select*from Categories where CategoryName like '%ara%'

            }

            dataGridView2.DataSource = mlist;
        }
        private void Temizle()
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }

            }
        }
        private void dataGridView2_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            secID = (int)dataGridView2.CurrentRow.Cells[0].Value;
            secMusteri = db.Set<Musteri>().Find(secID);
            txtBoxAd.Text = secMusteri.MusteriAd;
            txtBoxSoyad.Text = secMusteri.Soyad;
            txtBoxAdres.Text = secMusteri.Adres;
            txtBoxTel.Text = secMusteri.Telefon.ToString();
            txtBoxEMail.Text = secMusteri.EMail;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Musteri musteri = new Musteri();
            musteri.MusteriAd = txtBoxAd.Text;
            musteri.Soyad = txtBoxSoyad.Text;
            musteri.Adres = txtBoxAdres.Text;
            musteri.Telefon = Convert.ToInt64(txtBoxTel.Text);
            musteri.EMail = txtBoxEMail.Text;
            db.Set<Musteri>().Add(musteri);
            db.SaveChanges();
            Goster();
            Temizle();
        }



        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            secMusteri.MusteriAd = txtBoxAd.Text;
            secMusteri.Soyad = txtBoxSoyad.Text;
            secMusteri.Adres = txtBoxAdres.Text;
            secMusteri.Telefon = Convert.ToInt64(txtBoxTel.Text);
            secMusteri.EMail = txtBoxEMail.Text;
            db.Entry(secMusteri).State = EntityState.Modified;
            db.SaveChanges();
            Goster();
            Temizle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            db.Set<Musteri>().Remove(secMusteri);
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
