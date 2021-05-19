
namespace MusteriTakipApp
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnSatis = new FontAwesome.Sharp.IconButton();
            this.btnTedarikci = new FontAwesome.Sharp.IconButton();
            this.btnMusteri = new FontAwesome.Sharp.IconButton();
            this.btnUrun = new FontAwesome.Sharp.IconButton();
            this.btnKategori = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnKucult = new FontAwesome.Sharp.IconButton();
            this.btnBuyut = new FontAwesome.Sharp.IconButton();
            this.btnCıkıs = new FontAwesome.Sharp.IconButton();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelMenu.Controls.Add(this.btnSatis);
            this.panelMenu.Controls.Add(this.btnTedarikci);
            this.panelMenu.Controls.Add(this.btnMusteri);
            this.panelMenu.Controls.Add(this.btnUrun);
            this.panelMenu.Controls.Add(this.btnKategori);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 711);
            this.panelMenu.TabIndex = 0;
            // 
            // btnSatis
            // 
            this.btnSatis.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSatis.FlatAppearance.BorderSize = 0;
            this.btnSatis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSatis.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSatis.IconChar = FontAwesome.Sharp.IconChar.Cube;
            this.btnSatis.IconColor = System.Drawing.Color.Gainsboro;
            this.btnSatis.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSatis.IconSize = 32;
            this.btnSatis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSatis.Location = new System.Drawing.Point(0, 367);
            this.btnSatis.Name = "btnSatis";
            this.btnSatis.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnSatis.Size = new System.Drawing.Size(220, 60);
            this.btnSatis.TabIndex = 5;
            this.btnSatis.Text = "Satış";
            this.btnSatis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSatis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSatis.UseVisualStyleBackColor = true;
            this.btnSatis.Click += new System.EventHandler(this.btnSatis_Click);
            // 
            // btnTedarikci
            // 
            this.btnTedarikci.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTedarikci.FlatAppearance.BorderSize = 0;
            this.btnTedarikci.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTedarikci.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnTedarikci.IconChar = FontAwesome.Sharp.IconChar.TruckMoving;
            this.btnTedarikci.IconColor = System.Drawing.Color.Gainsboro;
            this.btnTedarikci.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTedarikci.IconSize = 32;
            this.btnTedarikci.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTedarikci.Location = new System.Drawing.Point(0, 307);
            this.btnTedarikci.Name = "btnTedarikci";
            this.btnTedarikci.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnTedarikci.Size = new System.Drawing.Size(220, 60);
            this.btnTedarikci.TabIndex = 4;
            this.btnTedarikci.Text = "Tedarikçi";
            this.btnTedarikci.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTedarikci.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTedarikci.UseVisualStyleBackColor = true;
            this.btnTedarikci.Click += new System.EventHandler(this.btnTedarikci_Click);
            // 
            // btnMusteri
            // 
            this.btnMusteri.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMusteri.FlatAppearance.BorderSize = 0;
            this.btnMusteri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMusteri.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMusteri.IconChar = FontAwesome.Sharp.IconChar.User;
            this.btnMusteri.IconColor = System.Drawing.Color.Gainsboro;
            this.btnMusteri.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMusteri.IconSize = 32;
            this.btnMusteri.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMusteri.Location = new System.Drawing.Point(0, 247);
            this.btnMusteri.Name = "btnMusteri";
            this.btnMusteri.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnMusteri.Size = new System.Drawing.Size(220, 60);
            this.btnMusteri.TabIndex = 3;
            this.btnMusteri.Text = "Müşteri";
            this.btnMusteri.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMusteri.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMusteri.UseVisualStyleBackColor = true;
            this.btnMusteri.Click += new System.EventHandler(this.btnMusteri_Click);
            // 
            // btnUrun
            // 
            this.btnUrun.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUrun.FlatAppearance.BorderSize = 0;
            this.btnUrun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUrun.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnUrun.IconChar = FontAwesome.Sharp.IconChar.Tag;
            this.btnUrun.IconColor = System.Drawing.Color.Gainsboro;
            this.btnUrun.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUrun.IconSize = 32;
            this.btnUrun.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUrun.Location = new System.Drawing.Point(0, 187);
            this.btnUrun.Name = "btnUrun";
            this.btnUrun.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnUrun.Size = new System.Drawing.Size(220, 60);
            this.btnUrun.TabIndex = 2;
            this.btnUrun.Text = "Ürün";
            this.btnUrun.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUrun.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUrun.UseVisualStyleBackColor = true;
            this.btnUrun.Click += new System.EventHandler(this.btnUrun_Click);
            // 
            // btnKategori
            // 
            this.btnKategori.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKategori.FlatAppearance.BorderSize = 0;
            this.btnKategori.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKategori.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnKategori.IconChar = FontAwesome.Sharp.IconChar.Cubes;
            this.btnKategori.IconColor = System.Drawing.Color.Gainsboro;
            this.btnKategori.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnKategori.IconSize = 32;
            this.btnKategori.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKategori.Location = new System.Drawing.Point(0, 127);
            this.btnKategori.Name = "btnKategori";
            this.btnKategori.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnKategori.Size = new System.Drawing.Size(220, 60);
            this.btnKategori.TabIndex = 1;
            this.btnKategori.Text = "Kategori";
            this.btnKategori.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKategori.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKategori.UseVisualStyleBackColor = true;
            this.btnKategori.Click += new System.EventHandler(this.btnKategori_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.panel1.Size = new System.Drawing.Size(220, 127);
            this.panel1.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.Image = global::MusteriTakipApp.Properties.Resources._1;
            this.btnHome.Location = new System.Drawing.Point(41, 25);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(131, 80);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click_1);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelTitleBar.Controls.Add(this.btnKucult);
            this.panelTitleBar.Controls.Add(this.btnBuyut);
            this.panelTitleBar.Controls.Add(this.btnCıkıs);
            this.panelTitleBar.Controls.Add(this.lblTitleChildForm);
            this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1030, 75);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // btnKucult
            // 
            this.btnKucult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKucult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKucult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.btnKucult.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnKucult.IconColor = System.Drawing.Color.Gainsboro;
            this.btnKucult.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnKucult.IconSize = 25;
            this.btnKucult.Location = new System.Drawing.Point(909, 12);
            this.btnKucult.Name = "btnKucult";
            this.btnKucult.Size = new System.Drawing.Size(33, 29);
            this.btnKucult.TabIndex = 7;
            this.btnKucult.UseVisualStyleBackColor = true;
            this.btnKucult.Click += new System.EventHandler(this.btnKucult_Click);
            // 
            // btnBuyut
            // 
            this.btnBuyut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuyut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuyut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.btnBuyut.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btnBuyut.IconColor = System.Drawing.Color.Gainsboro;
            this.btnBuyut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuyut.IconSize = 25;
            this.btnBuyut.Location = new System.Drawing.Point(948, 12);
            this.btnBuyut.Name = "btnBuyut";
            this.btnBuyut.Size = new System.Drawing.Size(33, 29);
            this.btnBuyut.TabIndex = 6;
            this.btnBuyut.UseVisualStyleBackColor = true;
            this.btnBuyut.Click += new System.EventHandler(this.btnBuyut_Click);
            // 
            // btnCıkıs
            // 
            this.btnCıkıs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCıkıs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCıkıs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.btnCıkıs.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.btnCıkıs.IconColor = System.Drawing.Color.Red;
            this.btnCıkıs.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCıkıs.IconSize = 25;
            this.btnCıkıs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCıkıs.Location = new System.Drawing.Point(987, 12);
            this.btnCıkıs.Name = "btnCıkıs";
            this.btnCıkıs.Size = new System.Drawing.Size(33, 29);
            this.btnCıkıs.TabIndex = 5;
            this.btnCıkıs.UseVisualStyleBackColor = true;
            this.btnCıkıs.Click += new System.EventHandler(this.btnCıkıs_Click);
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitleChildForm.Location = new System.Drawing.Point(59, 41);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(45, 17);
            this.lblTitleChildForm.TabIndex = 1;
            this.lblTitleChildForm.Text = "Home";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(21, 36);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(32, 32);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(220, 75);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(1030, 9);
            this.panelShadow.TabIndex = 2;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panelDesktop.Controls.Add(this.label2);
            this.panelDesktop.Controls.Add(this.label1);
            this.panelDesktop.Controls.Add(this.pictureBox1);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(220, 84);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1030, 627);
            this.panelDesktop.TabIndex = 3;
            this.panelDesktop.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDesktop_Paint);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(375, 386);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "label1";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(375, 418);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 36);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::MusteriTakipApp.Properties.Resources._1;
            this.pictureBox1.Location = new System.Drawing.Point(331, 145);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(368, 194);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "1.PNG");
            this.ımageList1.Images.SetKeyName(1, "1PNG.PNG");
            this.ımageList1.Images.SetKeyName(2, "2.PNG");
            this.ımageList1.Images.SetKeyName(3, "3.PNG");
            this.ımageList1.Images.SetKeyName(4, "4.PNG");
            this.ımageList1.Images.SetKeyName(5, "5.PNG");
            this.ımageList1.Images.SetKeyName(6, "6.PNG");
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 711);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnSatis;
        private FontAwesome.Sharp.IconButton btnTedarikci;
        private FontAwesome.Sharp.IconButton btnMusteri;
        private FontAwesome.Sharp.IconButton btnUrun;
        private FontAwesome.Sharp.IconButton btnKategori;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lblTitleChildForm;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panelDesktop;
        private FontAwesome.Sharp.IconButton btnKucult;
        private FontAwesome.Sharp.IconButton btnBuyut;
        protected FontAwesome.Sharp.IconButton btnCıkıs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}

