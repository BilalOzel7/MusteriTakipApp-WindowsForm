
namespace MusteriTakipApp.Forms
{
    partial class frmTedarikci
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
            this.txtBoxAra = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.richTxtBoxAcıklama = new System.Windows.Forms.RichTextBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSıl = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtBoxTel = new System.Windows.Forms.TextBox();
            this.txtBoxEMail = new System.Windows.Forms.TextBox();
            this.txtBoxAd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTemizle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBoxAra
            // 
            this.txtBoxAra.Location = new System.Drawing.Point(458, 12);
            this.txtBoxAra.Name = "txtBoxAra";
            this.txtBoxAra.Size = new System.Drawing.Size(167, 22);
            this.txtBoxAra.TabIndex = 27;
            this.txtBoxAra.TextChanged += new System.EventHandler(this.txtBoxAra_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(370, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 17);
            this.label6.TabIndex = 26;
            this.label6.Text = "Arama";
            // 
            // richTxtBoxAcıklama
            // 
            this.richTxtBoxAcıklama.Location = new System.Drawing.Point(305, 386);
            this.richTxtBoxAcıklama.Name = "richTxtBoxAcıklama";
            this.richTxtBoxAcıklama.Size = new System.Drawing.Size(167, 96);
            this.richTxtBoxAcıklama.TabIndex = 25;
            this.richTxtBoxAcıklama.Text = "";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnGuncelle.Location = new System.Drawing.Point(627, 307);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(93, 42);
            this.btnGuncelle.TabIndex = 24;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSıl
            // 
            this.btnSıl.BackColor = System.Drawing.Color.Red;
            this.btnSıl.Location = new System.Drawing.Point(627, 416);
            this.btnSıl.Name = "btnSıl";
            this.btnSıl.Size = new System.Drawing.Size(93, 42);
            this.btnSıl.TabIndex = 23;
            this.btnSıl.Text = "Sil";
            this.btnSıl.UseVisualStyleBackColor = false;
            this.btnSıl.Click += new System.EventHandler(this.btnSıl_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.ForestGreen;
            this.btnEkle.Location = new System.Drawing.Point(627, 360);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(93, 42);
            this.btnEkle.TabIndex = 22;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(111, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(736, 177);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // txtBoxTel
            // 
            this.txtBoxTel.Location = new System.Drawing.Point(305, 355);
            this.txtBoxTel.Name = "txtBoxTel";
            this.txtBoxTel.Size = new System.Drawing.Size(167, 22);
            this.txtBoxTel.TabIndex = 17;
            // 
            // txtBoxEMail
            // 
            this.txtBoxEMail.Location = new System.Drawing.Point(305, 327);
            this.txtBoxEMail.Name = "txtBoxEMail";
            this.txtBoxEMail.Size = new System.Drawing.Size(167, 22);
            this.txtBoxEMail.TabIndex = 18;
            // 
            // txtBoxAd
            // 
            this.txtBoxAd.Location = new System.Drawing.Point(305, 298);
            this.txtBoxAd.Name = "txtBoxAd";
            this.txtBoxAd.Size = new System.Drawing.Size(167, 22);
            this.txtBoxAd.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(217, 330);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "E-Mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(217, 355);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Telefon No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(217, 386);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Açıklama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(217, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Ad";
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnTemizle.Location = new System.Drawing.Point(627, 474);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(93, 41);
            this.btnTemizle.TabIndex = 29;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // frmTedarikci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1022, 551);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.txtBoxAra);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.richTxtBoxAcıklama);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSıl);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtBoxTel);
            this.Controls.Add(this.txtBoxEMail);
            this.Controls.Add(this.txtBoxAd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "frmTedarikci";
            this.Text = "Tedarikci";
            this.Load += new System.EventHandler(this.frmTedarikci_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxAra;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox richTxtBoxAcıklama;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSıl;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtBoxTel;
        private System.Windows.Forms.TextBox txtBoxEMail;
        private System.Windows.Forms.TextBox txtBoxAd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTemizle;
    }
}