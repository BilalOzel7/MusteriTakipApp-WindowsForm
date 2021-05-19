
namespace MusteriTakipApp.Forms
{
    partial class frmSatis
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBoxMusteri = new System.Windows.Forms.ComboBox();
            this.comboBoxUrun = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxTarih = new System.Windows.Forms.TextBox();
            this.txtBoxFiyat = new System.Windows.Forms.TextBox();
            this.richTextBoxAciklama = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxFatura = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBoxAra = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(37, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(629, 319);
            this.dataGridView1.TabIndex = 24;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // comboBoxMusteri
            // 
            this.comboBoxMusteri.FormattingEnabled = true;
            this.comboBoxMusteri.Location = new System.Drawing.Point(806, 148);
            this.comboBoxMusteri.Name = "comboBoxMusteri";
            this.comboBoxMusteri.Size = new System.Drawing.Size(169, 24);
            this.comboBoxMusteri.TabIndex = 67;
            // 
            // comboBoxUrun
            // 
            this.comboBoxUrun.FormattingEnabled = true;
            this.comboBoxUrun.Location = new System.Drawing.Point(805, 118);
            this.comboBoxUrun.Name = "comboBoxUrun";
            this.comboBoxUrun.Size = new System.Drawing.Size(169, 24);
            this.comboBoxUrun.TabIndex = 68;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Gainsboro;
            this.label7.Location = new System.Drawing.Point(712, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 17);
            this.label7.TabIndex = 65;
            this.label7.Text = "Tarih";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(713, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 17);
            this.label5.TabIndex = 66;
            this.label5.Text = "Fiyat";
            // 
            // txtBoxTarih
            // 
            this.txtBoxTarih.Location = new System.Drawing.Point(804, 209);
            this.txtBoxTarih.Name = "txtBoxTarih";
            this.txtBoxTarih.Size = new System.Drawing.Size(170, 22);
            this.txtBoxTarih.TabIndex = 63;
            // 
            // txtBoxFiyat
            // 
            this.txtBoxFiyat.Location = new System.Drawing.Point(805, 178);
            this.txtBoxFiyat.Name = "txtBoxFiyat";
            this.txtBoxFiyat.Size = new System.Drawing.Size(170, 22);
            this.txtBoxFiyat.TabIndex = 64;
            // 
            // richTextBoxAciklama
            // 
            this.richTextBoxAciklama.Location = new System.Drawing.Point(804, 242);
            this.richTextBoxAciklama.Name = "richTextBoxAciklama";
            this.richTextBoxAciklama.Size = new System.Drawing.Size(170, 96);
            this.richTextBoxAciklama.TabIndex = 62;
            this.richTextBoxAciklama.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(712, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 58;
            this.label4.Text = "Açıklama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(713, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 59;
            this.label3.Text = "Müşteri ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(713, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 60;
            this.label2.Text = "Ürün ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(713, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 61;
            this.label1.Text = "Fatura No";
            // 
            // txtBoxFatura
            // 
            this.txtBoxFatura.Location = new System.Drawing.Point(805, 85);
            this.txtBoxFatura.Name = "txtBoxFatura";
            this.txtBoxFatura.Size = new System.Drawing.Size(170, 22);
            this.txtBoxFatura.TabIndex = 57;
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.ForestGreen;
            this.btnEkle.Location = new System.Drawing.Point(846, 411);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(87, 41);
            this.btnEkle.TabIndex = 54;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnGuncelle.Location = new System.Drawing.Point(846, 526);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(87, 41);
            this.btnGuncelle.TabIndex = 55;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Red;
            this.btnSil.Location = new System.Drawing.Point(846, 470);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(87, 41);
            this.btnSil.TabIndex = 56;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Gainsboro;
            this.label8.Location = new System.Drawing.Point(541, 446);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 17);
            this.label8.TabIndex = 69;
            this.label8.Text = "Ciro";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnTemizle.Location = new System.Drawing.Point(846, 582);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(87, 41);
            this.btnTemizle.TabIndex = 70;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(210, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 17);
            this.label6.TabIndex = 72;
            this.label6.Text = "Arama";
            // 
            // txtBoxAra
            // 
            this.txtBoxAra.Location = new System.Drawing.Point(289, 38);
            this.txtBoxAra.Name = "txtBoxAra";
            this.txtBoxAra.Size = new System.Drawing.Size(161, 22);
            this.txtBoxAra.TabIndex = 71;
            this.txtBoxAra.TextChanged += new System.EventHandler(this.txtBoxAra_TextChanged);
            // 
            // frmSatis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1015, 657);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBoxAra);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBoxMusteri);
            this.Controls.Add(this.comboBoxUrun);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBoxTarih);
            this.Controls.Add(this.txtBoxFiyat);
            this.Controls.Add(this.richTextBoxAciklama);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxFatura);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmSatis";
            this.Text = "Satis";
            this.Load += new System.EventHandler(this.frmSatis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBoxMusteri;
        private System.Windows.Forms.ComboBox comboBoxUrun;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxTarih;
        private System.Windows.Forms.TextBox txtBoxFiyat;
        private System.Windows.Forms.RichTextBox richTextBoxAciklama;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxFatura;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBoxAra;
    }
}