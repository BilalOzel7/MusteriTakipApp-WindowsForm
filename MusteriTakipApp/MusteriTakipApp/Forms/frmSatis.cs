using MusteriTakipApp.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusteriTakipApp.Forms
{
    public partial class frmSatis : Form
    {
        public frmSatis()
        {
            InitializeComponent();
        }
        MTakipContext db = new MTakipContext();
        int secID;
        Satis secSatis;
        List<Satis> slist = new List<Satis>();

        private void frmSatis_Load(object sender, EventArgs e)
        {
            Goster();
            ComboDoldur();
        }

        private void ComboDoldur()
        {
            var ulist = db.Set<Urun>().Select(x => new UrunDTO
            {
                UrunId = x.UrunId,
                UrunAd = x.UrunAd
            }).ToList();
            comboBoxUrun.DataSource = ulist;
            comboBoxUrun.DisplayMember = "UrunAd";
            comboBoxUrun.ValueMember = "UrunId";

            var mlist = db.Set<Musteri>().Select(x => new MusteriDTO
            {
                MusteriId = x.MusteriId,
                MusteriAd = x.MusteriAd
            }).ToList();
            comboBoxMusteri.DataSource = mlist;
            comboBoxMusteri.DisplayMember = "MusteriAd";
            comboBoxMusteri.ValueMember = "MusteriId";
        }

        private void Goster()
        {
            var slist = db.Set<Satis>().Select(x => new SatisDTO
            {
                SatisId = x.SatisId,
                FaturaNo = x.FaturaNo,
                UrunAd = x.Urun.UrunAd,
                MusteriAd = x.Musteri.MusteriAd,
                Tarih = x.Tarih,
                Fiyat = x.Fiyat
            }).ToList();
            dataGridView1.DataSource = slist;
        }
        private void Temizle()
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
                if (item is ComboBox)
                {
                    item.Text = "";
                }
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            secID = (int)dataGridView1.CurrentRow.Cells[0].Value;
            secSatis = db.Set<Satis>().Find(secID);
            txtBoxFiyat.Text = secSatis.Fiyat.ToString();
            comboBoxMusteri.SelectedValue = secSatis.MusteriId;
            comboBoxUrun.SelectedValue = secSatis.UrunId;
            txtBoxTarih.Text = secSatis.Tarih.ToString();
            txtBoxFatura.Text = secSatis.FaturaNo.ToString();
            richTextBoxAciklama.Text = secSatis.Aciklama;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Satis ySatis = new Satis();
            ySatis.Aciklama = richTextBoxAciklama.Text;
            ySatis.Fiyat = Convert.ToDecimal(txtBoxFiyat.Text);
            ySatis.MusteriId = (int)comboBoxMusteri.SelectedValue;
            ySatis.UrunId = (int)comboBoxUrun.SelectedValue;
            ySatis.Tarih = Convert.ToDateTime(txtBoxTarih.Text);
            ySatis.FaturaNo = Convert.ToInt32(txtBoxFatura.Text);
            db.Set<Satis>().Add(ySatis);
            db.SaveChanges();
            Goster();
            Temizle();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            secSatis.Aciklama = richTextBoxAciklama.Text;
            secSatis.Fiyat = Convert.ToDecimal(txtBoxFiyat.Text);
            secSatis.MusteriId = (int)comboBoxMusteri.SelectedValue;
            secSatis.UrunId = (int)comboBoxUrun.SelectedValue;
            secSatis.Tarih = Convert.ToDateTime(txtBoxTarih.Text);
            secSatis.FaturaNo = Convert.ToInt32(txtBoxFatura.Text);
            db.SaveChanges();
            Goster();
            Temizle();
        }



        private void btnSil_Click(object sender, EventArgs e)
        {
            db.Set<Satis>().Remove(secSatis);
            db.SaveChanges();
            Goster();
            Temizle();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            decimal Toplam = 0;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                Toplam += Convert.ToDecimal(dataGridView1.Rows[i].Cells[5].Value);
                label8.Text = Toplam.ToString();
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void txtBoxAra_TextChanged(object sender, EventArgs e)
        {
            slist = db.Satislars.Where(x => x.FaturaNo.ToString().Contains(txtBoxAra.Text)).ToList();
            dataGridView1.DataSource = slist;
        }
    }
}
