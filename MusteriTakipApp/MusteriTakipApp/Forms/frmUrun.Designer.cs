
namespace MusteriTakipApp.Forms
{
    partial class frmUrun
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.comboBoxTed = new System.Windows.Forms.ComboBox();
            this.comboBoxKategori = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.richTxtBoxAciklama = new System.Windows.Forms.RichTextBox();
            this.txtBoxBirimFiyat = new System.Windows.Forms.TextBox();
            this.txtBoxBarkod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxMiktar = new System.Windows.Forms.TextBox();
            this.txtBoxAd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSıl = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBoxAra = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(91, 54);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(557, 211);
            this.dataGridView2.TabIndex = 15;
            this.dataGridView2.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView2_CellMouseClick);
            // 
            // comboBoxTed
            // 
            this.comboBoxTed.FormattingEnabled = true;
            this.comboBoxTed.Location = new System.Drawing.Point(471, 367);
            this.comboBoxTed.Name = "comboBoxTed";
            this.comboBoxTed.Size = new System.Drawing.Size(167, 24);
            this.comboBoxTed.TabIndex = 60;
            // 
            // comboBoxKategori
            // 
            this.comboBoxKategori.FormattingEnabled = true;
            this.comboBoxKategori.Location = new System.Drawing.Point(471, 326);
            this.comboBoxKategori.Name = "comboBoxKategori";
            this.comboBoxKategori.Size = new System.Drawing.Size(167, 24);
            this.comboBoxKategori.TabIndex = 61;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(366, 329);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 17);
            this.label6.TabIndex = 59;
            this.label6.Text = "Kategori";
            // 
            // richTxtBoxAciklama
            // 
            this.richTxtBoxAciklama.Location = new System.Drawing.Point(818, 204);
            this.richTxtBoxAciklama.Name = "richTxtBoxAciklama";
            this.richTxtBoxAciklama.Size = new System.Drawing.Size(167, 125);
            this.richTxtBoxAciklama.TabIndex = 58;
            this.richTxtBoxAciklama.Text = "";
            // 
            // txtBoxBirimFiyat
            // 
            this.txtBoxBirimFiyat.Location = new System.Drawing.Point(818, 130);
            this.txtBoxBirimFiyat.Name = "txtBoxBirimFiyat";
            this.txtBoxBirimFiyat.Size = new System.Drawing.Size(167, 22);
            this.txtBoxBirimFiyat.TabIndex = 56;
            // 
            // txtBoxBarkod
            // 
            this.txtBoxBarkod.Location = new System.Drawing.Point(818, 167);
            this.txtBoxBarkod.Name = "txtBoxBarkod";
            this.txtBoxBarkod.Size = new System.Drawing.Size(167, 22);
            this.txtBoxBarkod.TabIndex = 57;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(713, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 52;
            this.label1.Text = "Birim Fiyat";
            // 
            // txtBoxMiktar
            // 
            this.txtBoxMiktar.Location = new System.Drawing.Point(818, 92);
            this.txtBoxMiktar.Name = "txtBoxMiktar";
            this.txtBoxMiktar.Size = new System.Drawing.Size(167, 22);
            this.txtBoxMiktar.TabIndex = 54;
            // 
            // txtBoxAd
            // 
            this.txtBoxAd.Location = new System.Drawing.Point(818, 54);
            this.txtBoxAd.Name = "txtBoxAd";
            this.txtBoxAd.Size = new System.Drawing.Size(167, 22);
            this.txtBoxAd.TabIndex = 55;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(713, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 17);
            this.label5.TabIndex = 53;
            this.label5.Text = "Barkod No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(713, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 51;
            this.label4.Text = "Açıklama";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Gainsboro;
            this.label8.Location = new System.Drawing.Point(713, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 17);
            this.label8.TabIndex = 48;
            this.label8.Text = "Miktar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(366, 370);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 50;
            this.label3.Text = "Tedarikçi ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(713, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 49;
            this.label2.Text = "ÜrünAdı";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnGuncelle.Location = new System.Drawing.Point(859, 388);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(89, 42);
            this.btnGuncelle.TabIndex = 46;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSıl
            // 
            this.btnSıl.BackColor = System.Drawing.Color.Red;
            this.btnSıl.Location = new System.Drawing.Point(859, 497);
            this.btnSıl.Name = "btnSıl";
            this.btnSıl.Size = new System.Drawing.Size(89, 42);
            this.btnSıl.TabIndex = 47;
            this.btnSıl.Text = "Sil";
            this.btnSıl.UseVisualStyleBackColor = false;
            this.btnSıl.Click += new System.EventHandler(this.btnSıl_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.ForestGreen;
            this.btnEkle.Location = new System.Drawing.Point(859, 441);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(89, 42);
            this.btnEkle.TabIndex = 45;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnTemizle.Location = new System.Drawing.Point(859, 549);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(89, 41);
            this.btnTemizle.TabIndex = 62;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Gainsboro;
            this.label7.Location = new System.Drawing.Point(231, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Arama";
            // 
            // txtBoxAra
            // 
            this.txtBoxAra.Location = new System.Drawing.Point(310, 12);
            this.txtBoxAra.Name = "txtBoxAra";
            this.txtBoxAra.Size = new System.Drawing.Size(161, 22);
            this.txtBoxAra.TabIndex = 10;
            this.txtBoxAra.TextChanged += new System.EventHandler(this.txtBoxAra_TextChanged);
            // 
            // frmUrun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1053, 617);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.comboBoxTed);
            this.Controls.Add(this.comboBoxKategori);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.richTxtBoxAciklama);
            this.Controls.Add(this.txtBoxBirimFiyat);
            this.Controls.Add(this.txtBoxBarkod);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxMiktar);
            this.Controls.Add(this.txtBoxAd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSıl);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.txtBoxAra);
            this.Name = "frmUrun";
            this.Text = "Urun";
            this.Load += new System.EventHandler(this.frmUrun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ComboBox comboBoxTed;
        private System.Windows.Forms.ComboBox comboBoxKategori;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox richTxtBoxAciklama;
        private System.Windows.Forms.TextBox txtBoxBirimFiyat;
        private System.Windows.Forms.TextBox txtBoxBarkod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxMiktar;
        private System.Windows.Forms.TextBox txtBoxAd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSıl;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBoxAra;
    }
}