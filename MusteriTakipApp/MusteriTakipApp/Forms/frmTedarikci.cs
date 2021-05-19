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
    public partial class frmTedarikci : Form
    {
        public frmTedarikci()
        {
            InitializeComponent();
        }
        MTakipContext db = new MTakipContext();
        int secID;
        Tedarikci secTedarikci;
        List<Tedarikci> tlist = new List<Tedarikci>();

        private void frmTedarikci_Load(object sender, EventArgs e)
        {
            Goster();
            this.dataGridView1.Columns["Urunler"].Visible = false;
        }

        private void Goster()
        {
            if (tlist == null)
            {
                tlist = db.Tedarikciler.ToList();    //select * from Categories
            }
            else
            {
                tlist = db.Tedarikciler.Where(x => x.TedarikciAd.Contains(txtBoxAra.Text)).ToList();
                //select*from Categories where CategoryName like '%ara%'

            }

            dataGridView1.DataSource = tlist;
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

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            secID = (int)dataGridView1.CurrentRow.Cells[0].Value;
            secTedarikci = db.Set<Tedarikci>().Find(secID);
            txtBoxAd.Text = secTedarikci.TedarikciAd;
            richTxtBoxAcıklama.Text = secTedarikci.Aciklama;
            txtBoxEMail.Text = secTedarikci.EMail;
            txtBoxTel.Text = secTedarikci.Telefon.ToString();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Tedarikci yTed = new Tedarikci();
            yTed.TedarikciAd = txtBoxAd.Text;
            yTed.Aciklama = richTxtBoxAcıklama.Text;
            yTed.Telefon = Convert.ToInt64(txtBoxTel.Text);
            yTed.EMail = txtBoxEMail.Text;
            db.Set<Tedarikci>().Add(yTed);
            db.SaveChanges();
            Goster();
            Temizle();
        }

       

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            secTedarikci.TedarikciAd = txtBoxAd.Text;
            secTedarikci.Aciklama = richTxtBoxAcıklama.Text;
            secTedarikci.Telefon = Convert.ToInt64(txtBoxTel.Text);
            secTedarikci.EMail = txtBoxEMail.Text;
            db.Entry(secTedarikci).State = EntityState.Modified;
            db.SaveChanges();
            Goster();
            Temizle();
        }

        private void btnSıl_Click(object sender, EventArgs e)
        {
            db.Set<Tedarikci>().Remove(secTedarikci);
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
