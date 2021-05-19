using MusteriTakipApp.DTO;
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
    public partial class frmUrun : Form
    {
        public frmUrun()
        {
            InitializeComponent();
        }
        MTakipContext db = new MTakipContext();
        int secId;
        Urun secUrun;
        List<Urun> ulist = new List<Urun>();

        private void frmUrun_Load(object sender, EventArgs e)
        {
            Goster();
            ComboDoldur();
          
        }

        private void Goster()
        {
                var ulist = db.Set<Urun>().Select(x => new UrunDTO
                {
                    UrunId = x.UrunId,
                    UrunAd = x.UrunAd,
                    KategoriAd = x.Kategori.KategoriAd,
                    TedarikciAd = x.Tedarikci.TedarikciAd
                }).ToList();
            dataGridView2.DataSource = ulist;
        }

        private void ComboDoldur()
        {
            //var clist = db.Set<Categories>().Select(x=> new CategoriesDTO
            var klist = db.Set<Kategori>().Select(x => new
            {
                KategoriId = x.KategoriId,
                KategoriAd = x.KategoriAd
            }).ToList();
            comboBoxKategori.DataSource = klist;
            comboBoxKategori.DisplayMember = "KategoriAd";
            comboBoxKategori.ValueMember = "KategoriId";

            var tlist = db.Set<Tedarikci>().Select(x => new TedarikciDTO
            {
                TedarikciId = x.TedarikciId,
                TedarikciAd = x.TedarikciAd
            }).ToList();
            comboBoxTed.DataSource = tlist;
            comboBoxTed.DisplayMember = "TedarikciAd";
            comboBoxTed.ValueMember = "TedarikciId";
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
            secId = (int)dataGridView2.CurrentRow.Cells[0].Value;
            secUrun = db.Set<Urun>().Find(secId);
            txtBoxAd.Text = secUrun.UrunAd;
            comboBoxKategori.SelectedValue = secUrun.KategoriId;
            comboBoxTed.SelectedValue = secUrun.TedarikciId;
            txtBoxBarkod.Text = secUrun.BarkodNo.ToString();
            richTxtBoxAciklama.Text = secUrun.Aciklama;
            txtBoxBirimFiyat.Text = secUrun.BirimFiyat.ToString();
            txtBoxMiktar.Text = secUrun.Miktar.ToString();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Urun yUrun = new Urun();
            yUrun.UrunAd = txtBoxAd.Text;
            yUrun.Aciklama = richTxtBoxAciklama.Text;
            yUrun.BarkodNo = Convert.ToInt64(txtBoxBarkod.Text);
            yUrun.BirimFiyat = Convert.ToDecimal(txtBoxBirimFiyat.Text);
            yUrun.TedarikciId = (int)comboBoxTed.SelectedValue;
            yUrun.KategoriId = (int)comboBoxKategori.SelectedValue;
            yUrun.Miktar = Convert.ToInt32(txtBoxMiktar.Text);
            db.Set<Urun>().Add(yUrun);
            db.SaveChanges();
            Goster();
            Temizle();
        }



        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            secUrun.UrunAd = txtBoxAd.Text;
            secUrun.Aciklama = richTxtBoxAciklama.Text;
            secUrun.BarkodNo = Convert.ToInt64(txtBoxBarkod.Text);
            secUrun.BirimFiyat = Convert.ToDecimal(txtBoxBirimFiyat.Text);
            secUrun.KategoriId = (int)comboBoxKategori.SelectedValue;
            secUrun.TedarikciId = (int)comboBoxTed.SelectedValue;
            secUrun.Miktar = Convert.ToInt32(txtBoxMiktar.Text);
            db.Entry(secUrun).State = EntityState.Modified;
            db.SaveChanges();
            Goster();
            Temizle();
        }

        private void btnSıl_Click(object sender, EventArgs e)
        {
            db.Set<Urun>().Remove(secUrun);
            db.SaveChanges();
            Goster();
            Temizle();
        }

        private void txtBoxAra_TextChanged(object sender, EventArgs e)
        {
           ulist=  db.Urunler.Where(x => x.UrunAd.Contains(txtBoxAra.Text)).ToList();
            dataGridView2.DataSource = ulist;
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }
    }
}
