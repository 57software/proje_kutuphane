namespace proje_kutuphane
{
    partial class Kitaplar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kitaplar));
            this.btn_cikis = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_kitaplar = new System.Windows.Forms.Button();
            this.btn_kutuphane = new System.Windows.Forms.Button();
            this.btn_yayinEvleri = new System.Windows.Forms.Button();
            this.btn_anasayfa = new System.Windows.Forms.Button();
            this.btn_uyeler = new System.Windows.Forms.Button();
            this.btn_yonetimPaneli = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cikis = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_listeYenile = new System.Windows.Forms.Button();
            this.btn_listeArama = new System.Windows.Forms.Button();
            this.txt_arama = new System.Windows.Forms.TextBox();
            this.btn_kitapListe = new System.Windows.Forms.Button();
            this.btn_kitapEkle = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btn_ekleYenile = new System.Windows.Forms.Button();
            this.btn_ekleAra = new System.Windows.Forms.Button();
            this.txt_ekleAra = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.kategori = new System.Windows.Forms.ComboBox();
            this.yayinEvi = new System.Windows.Forms.ComboBox();
            this.txt_kitapAdet = new System.Windows.Forms.TextBox();
            this.txt_kutuphaneID = new System.Windows.Forms.TextBox();
            this.txt_yazarAd = new System.Windows.Forms.TextBox();
            this.txt_yazarSoyad = new System.Windows.Forms.TextBox();
            this.txt_sayfaSayisi = new System.Windows.Forms.TextBox();
            this.txt_kitapDili = new System.Windows.Forms.TextBox();
            this.txt_kitapAdi = new System.Windows.Forms.TextBox();
            this.txt_ISBN = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_cikis
            // 
            this.btn_cikis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cikis.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_cikis.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_cikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cikis.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_cikis.ForeColor = System.Drawing.Color.White;
            this.btn_cikis.Image = ((System.Drawing.Image)(resources.GetObject("btn_cikis.Image")));
            this.btn_cikis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cikis.Location = new System.Drawing.Point(43, 507);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.Size = new System.Drawing.Size(127, 45);
            this.btn_cikis.TabIndex = 6;
            this.btn_cikis.Text = "ÇIKIŞ YAP";
            this.btn_cikis.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cikis.UseVisualStyleBackColor = true;
            this.btn_cikis.Click += new System.EventHandler(this.btn_cikis_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(87)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btn_kitaplar);
            this.panel2.Controls.Add(this.btn_kutuphane);
            this.panel2.Controls.Add(this.btn_yayinEvleri);
            this.panel2.Controls.Add(this.btn_anasayfa);
            this.panel2.Controls.Add(this.btn_uyeler);
            this.panel2.Controls.Add(this.btn_yonetimPaneli);
            this.panel2.Controls.Add(this.btn_cikis);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 565);
            this.panel2.TabIndex = 3;
            // 
            // btn_kitaplar
            // 
            this.btn_kitaplar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_kitaplar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_kitaplar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_kitaplar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kitaplar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kitaplar.ForeColor = System.Drawing.Color.White;
            this.btn_kitaplar.Image = ((System.Drawing.Image)(resources.GetObject("btn_kitaplar.Image")));
            this.btn_kitaplar.Location = new System.Drawing.Point(8, 327);
            this.btn_kitaplar.Name = "btn_kitaplar";
            this.btn_kitaplar.Size = new System.Drawing.Size(200, 45);
            this.btn_kitaplar.TabIndex = 3;
            this.btn_kitaplar.Text = "KİTAPLAR";
            this.btn_kitaplar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_kitaplar.UseVisualStyleBackColor = true;
            this.btn_kitaplar.Click += new System.EventHandler(this.btn_kitaplar_Click);
            // 
            // btn_kutuphane
            // 
            this.btn_kutuphane.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_kutuphane.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_kutuphane.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_kutuphane.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kutuphane.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kutuphane.ForeColor = System.Drawing.Color.White;
            this.btn_kutuphane.Image = ((System.Drawing.Image)(resources.GetObject("btn_kutuphane.Image")));
            this.btn_kutuphane.Location = new System.Drawing.Point(8, 429);
            this.btn_kutuphane.Name = "btn_kutuphane";
            this.btn_kutuphane.Size = new System.Drawing.Size(200, 45);
            this.btn_kutuphane.TabIndex = 5;
            this.btn_kutuphane.Text = "KÜTÜPHANE";
            this.btn_kutuphane.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_kutuphane.UseVisualStyleBackColor = true;
            this.btn_kutuphane.Click += new System.EventHandler(this.btn_kutuphane_Click);
            // 
            // btn_yayinEvleri
            // 
            this.btn_yayinEvleri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_yayinEvleri.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_yayinEvleri.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_yayinEvleri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_yayinEvleri.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_yayinEvleri.ForeColor = System.Drawing.Color.White;
            this.btn_yayinEvleri.Image = ((System.Drawing.Image)(resources.GetObject("btn_yayinEvleri.Image")));
            this.btn_yayinEvleri.Location = new System.Drawing.Point(8, 378);
            this.btn_yayinEvleri.Name = "btn_yayinEvleri";
            this.btn_yayinEvleri.Size = new System.Drawing.Size(200, 45);
            this.btn_yayinEvleri.TabIndex = 4;
            this.btn_yayinEvleri.Text = "YAYIN EVLERİ";
            this.btn_yayinEvleri.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_yayinEvleri.UseVisualStyleBackColor = true;
            this.btn_yayinEvleri.Click += new System.EventHandler(this.btn_yayinEvleri_Click);
            // 
            // btn_anasayfa
            // 
            this.btn_anasayfa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_anasayfa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_anasayfa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_anasayfa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_anasayfa.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_anasayfa.ForeColor = System.Drawing.Color.White;
            this.btn_anasayfa.Image = ((System.Drawing.Image)(resources.GetObject("btn_anasayfa.Image")));
            this.btn_anasayfa.Location = new System.Drawing.Point(8, 131);
            this.btn_anasayfa.Name = "btn_anasayfa";
            this.btn_anasayfa.Size = new System.Drawing.Size(200, 45);
            this.btn_anasayfa.TabIndex = 0;
            this.btn_anasayfa.Text = "ANASAYFA";
            this.btn_anasayfa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_anasayfa.UseVisualStyleBackColor = true;
            this.btn_anasayfa.Click += new System.EventHandler(this.btn_anasayfa_Click);
            // 
            // btn_uyeler
            // 
            this.btn_uyeler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_uyeler.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_uyeler.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_uyeler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_uyeler.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_uyeler.ForeColor = System.Drawing.Color.White;
            this.btn_uyeler.Image = ((System.Drawing.Image)(resources.GetObject("btn_uyeler.Image")));
            this.btn_uyeler.Location = new System.Drawing.Point(8, 276);
            this.btn_uyeler.Name = "btn_uyeler";
            this.btn_uyeler.Size = new System.Drawing.Size(200, 45);
            this.btn_uyeler.TabIndex = 2;
            this.btn_uyeler.Text = "ÜYELER";
            this.btn_uyeler.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_uyeler.UseVisualStyleBackColor = true;
            this.btn_uyeler.Click += new System.EventHandler(this.btn_uyeler_Click);
            // 
            // btn_yonetimPaneli
            // 
            this.btn_yonetimPaneli.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_yonetimPaneli.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_yonetimPaneli.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_yonetimPaneli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_yonetimPaneli.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_yonetimPaneli.ForeColor = System.Drawing.Color.White;
            this.btn_yonetimPaneli.Image = ((System.Drawing.Image)(resources.GetObject("btn_yonetimPaneli.Image")));
            this.btn_yonetimPaneli.Location = new System.Drawing.Point(8, 206);
            this.btn_yonetimPaneli.Name = "btn_yonetimPaneli";
            this.btn_yonetimPaneli.Size = new System.Drawing.Size(200, 45);
            this.btn_yonetimPaneli.TabIndex = 1;
            this.btn_yonetimPaneli.Text = "YÖNETİM PANELİ";
            this.btn_yonetimPaneli.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_yonetimPaneli.UseVisualStyleBackColor = true;
            this.btn_yonetimPaneli.Click += new System.EventHandler(this.btn_yonetimPaneli_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(48, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kütüphane Yönetim Sistemi | Kitaplar";
            // 
            // cikis
            // 
            this.cikis.AutoSize = true;
            this.cikis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cikis.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cikis.ForeColor = System.Drawing.Color.White;
            this.cikis.Location = new System.Drawing.Point(1321, 1);
            this.cikis.Name = "cikis";
            this.cikis.Size = new System.Drawing.Size(29, 31);
            this.cikis.TabIndex = 1;
            this.cikis.Text = "X";
            this.cikis.Click += new System.EventHandler(this.cikis_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(87)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cikis);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1350, 35);
            this.panel1.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Controls.Add(this.btn_listeYenile);
            this.panel4.Controls.Add(this.btn_listeArama);
            this.panel4.Controls.Add(this.txt_arama);
            this.panel4.Location = new System.Drawing.Point(221, 87);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1128, 512);
            this.panel4.TabIndex = 1;
            this.panel4.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1128, 434);
            this.dataGridView1.TabIndex = 0;
            // 
            // btn_listeYenile
            // 
            this.btn_listeYenile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(87)))));
            this.btn_listeYenile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_listeYenile.FlatAppearance.BorderSize = 0;
            this.btn_listeYenile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen;
            this.btn_listeYenile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.btn_listeYenile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_listeYenile.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_listeYenile.ForeColor = System.Drawing.Color.White;
            this.btn_listeYenile.Location = new System.Drawing.Point(295, 20);
            this.btn_listeYenile.Name = "btn_listeYenile";
            this.btn_listeYenile.Size = new System.Drawing.Size(82, 30);
            this.btn_listeYenile.TabIndex = 2;
            this.btn_listeYenile.Text = "YENİLE";
            this.btn_listeYenile.UseVisualStyleBackColor = false;
            this.btn_listeYenile.Click += new System.EventHandler(this.btn_listeYenile_Click);
            // 
            // btn_listeArama
            // 
            this.btn_listeArama.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(87)))));
            this.btn_listeArama.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_listeArama.FlatAppearance.BorderSize = 0;
            this.btn_listeArama.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen;
            this.btn_listeArama.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.btn_listeArama.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_listeArama.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_listeArama.ForeColor = System.Drawing.Color.White;
            this.btn_listeArama.Location = new System.Drawing.Point(173, 20);
            this.btn_listeArama.Name = "btn_listeArama";
            this.btn_listeArama.Size = new System.Drawing.Size(116, 30);
            this.btn_listeArama.TabIndex = 1;
            this.btn_listeArama.Text = "KİTAP ADI ARA";
            this.btn_listeArama.UseVisualStyleBackColor = false;
            this.btn_listeArama.Click += new System.EventHandler(this.btn_listeArama_Click);
            // 
            // txt_arama
            // 
            this.txt_arama.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_arama.Location = new System.Drawing.Point(18, 20);
            this.txt_arama.Multiline = true;
            this.txt_arama.Name = "txt_arama";
            this.txt_arama.Size = new System.Drawing.Size(149, 30);
            this.txt_arama.TabIndex = 0;
            // 
            // btn_kitapListe
            // 
            this.btn_kitapListe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(87)))));
            this.btn_kitapListe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_kitapListe.FlatAppearance.BorderSize = 0;
            this.btn_kitapListe.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen;
            this.btn_kitapListe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.btn_kitapListe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kitapListe.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kitapListe.ForeColor = System.Drawing.Color.White;
            this.btn_kitapListe.Location = new System.Drawing.Point(805, 41);
            this.btn_kitapListe.Name = "btn_kitapListe";
            this.btn_kitapListe.Size = new System.Drawing.Size(304, 40);
            this.btn_kitapListe.TabIndex = 5;
            this.btn_kitapListe.Text = "Kitap Listesi";
            this.btn_kitapListe.UseVisualStyleBackColor = false;
            this.btn_kitapListe.Click += new System.EventHandler(this.btn_kitapListe_Click);
            // 
            // btn_kitapEkle
            // 
            this.btn_kitapEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(87)))));
            this.btn_kitapEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_kitapEkle.FlatAppearance.BorderSize = 0;
            this.btn_kitapEkle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen;
            this.btn_kitapEkle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.btn_kitapEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kitapEkle.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kitapEkle.ForeColor = System.Drawing.Color.White;
            this.btn_kitapEkle.Location = new System.Drawing.Point(486, 41);
            this.btn_kitapEkle.Name = "btn_kitapEkle";
            this.btn_kitapEkle.Size = new System.Drawing.Size(304, 40);
            this.btn_kitapEkle.TabIndex = 4;
            this.btn_kitapEkle.Text = "EKLE";
            this.btn_kitapEkle.UseVisualStyleBackColor = false;
            this.btn_kitapEkle.Click += new System.EventHandler(this.btn_kitapEkle_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(750, 87);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(95, 110);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 54;
            this.pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.dataGridView2);
            this.panel3.Controls.Add(this.btn_ekleYenile);
            this.panel3.Controls.Add(this.btn_ekleAra);
            this.panel3.Controls.Add(this.txt_ekleAra);
            this.panel3.Location = new System.Drawing.Point(221, 192);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1128, 158);
            this.panel3.TabIndex = 2;
            this.panel3.Visible = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(0, 80);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(1127, 77);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // btn_ekleYenile
            // 
            this.btn_ekleYenile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(87)))));
            this.btn_ekleYenile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ekleYenile.FlatAppearance.BorderSize = 0;
            this.btn_ekleYenile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen;
            this.btn_ekleYenile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.btn_ekleYenile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ekleYenile.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ekleYenile.ForeColor = System.Drawing.Color.White;
            this.btn_ekleYenile.Location = new System.Drawing.Point(295, 20);
            this.btn_ekleYenile.Name = "btn_ekleYenile";
            this.btn_ekleYenile.Size = new System.Drawing.Size(82, 30);
            this.btn_ekleYenile.TabIndex = 2;
            this.btn_ekleYenile.Text = "YENİLE";
            this.btn_ekleYenile.UseVisualStyleBackColor = false;
            this.btn_ekleYenile.Click += new System.EventHandler(this.btn_ekleYenile_Click);
            // 
            // btn_ekleAra
            // 
            this.btn_ekleAra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(87)))));
            this.btn_ekleAra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ekleAra.FlatAppearance.BorderSize = 0;
            this.btn_ekleAra.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen;
            this.btn_ekleAra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.btn_ekleAra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ekleAra.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ekleAra.ForeColor = System.Drawing.Color.White;
            this.btn_ekleAra.Location = new System.Drawing.Point(173, 20);
            this.btn_ekleAra.Name = "btn_ekleAra";
            this.btn_ekleAra.Size = new System.Drawing.Size(116, 30);
            this.btn_ekleAra.TabIndex = 1;
            this.btn_ekleAra.Text = "KİTAP ADI ARA";
            this.btn_ekleAra.UseVisualStyleBackColor = false;
            this.btn_ekleAra.Click += new System.EventHandler(this.btn_ekleAra_Click);
            // 
            // txt_ekleAra
            // 
            this.txt_ekleAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_ekleAra.Location = new System.Drawing.Point(18, 20);
            this.txt_ekleAra.Multiline = true;
            this.txt_ekleAra.Name = "txt_ekleAra";
            this.txt_ekleAra.Size = new System.Drawing.Size(149, 30);
            this.txt_ekleAra.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btn_sil);
            this.panel5.Controls.Add(this.btn_guncelle);
            this.panel5.Controls.Add(this.btn_ekle);
            this.panel5.Controls.Add(this.dateTimePicker1);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.label12);
            this.panel5.Controls.Add(this.label11);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.kategori);
            this.panel5.Controls.Add(this.yayinEvi);
            this.panel5.Controls.Add(this.txt_kitapAdet);
            this.panel5.Controls.Add(this.txt_kutuphaneID);
            this.panel5.Controls.Add(this.txt_yazarAd);
            this.panel5.Controls.Add(this.txt_yazarSoyad);
            this.panel5.Controls.Add(this.txt_sayfaSayisi);
            this.panel5.Controls.Add(this.txt_kitapDili);
            this.panel5.Controls.Add(this.txt_kitapAdi);
            this.panel5.Controls.Add(this.txt_ISBN);
            this.panel5.Location = new System.Drawing.Point(226, 351);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1118, 249);
            this.panel5.TabIndex = 0;
            // 
            // btn_sil
            // 
            this.btn_sil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(87)))));
            this.btn_sil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sil.FlatAppearance.BorderSize = 0;
            this.btn_sil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.btn_sil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.btn_sil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sil.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sil.ForeColor = System.Drawing.Color.White;
            this.btn_sil.Location = new System.Drawing.Point(497, 197);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(149, 40);
            this.btn_sil.TabIndex = 12;
            this.btn_sil.Text = "KİTAP SİL";
            this.btn_sil.UseVisualStyleBackColor = false;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(87)))));
            this.btn_guncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_guncelle.FlatAppearance.BorderSize = 0;
            this.btn_guncelle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen;
            this.btn_guncelle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.btn_guncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guncelle.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_guncelle.ForeColor = System.Drawing.Color.White;
            this.btn_guncelle.Location = new System.Drawing.Point(652, 197);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(304, 40);
            this.btn_guncelle.TabIndex = 13;
            this.btn_guncelle.Text = "KİTAP GÜNCELLE";
            this.btn_guncelle.UseVisualStyleBackColor = false;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // btn_ekle
            // 
            this.btn_ekle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(87)))));
            this.btn_ekle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ekle.FlatAppearance.BorderSize = 0;
            this.btn_ekle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen;
            this.btn_ekle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.btn_ekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ekle.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ekle.ForeColor = System.Drawing.Color.White;
            this.btn_ekle.Location = new System.Drawing.Point(187, 197);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(304, 40);
            this.btn_ekle.TabIndex = 11;
            this.btn_ekle.Text = "KİTAP EKLE";
            this.btn_ekle.UseVisualStyleBackColor = false;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(497, 161);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(149, 30);
            this.dateTimePicker1.TabIndex = 8;
            this.dateTimePicker1.Value = new System.DateTime(2024, 4, 8, 0, 0, 0, 0);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(649, 77);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 18);
            this.label10.TabIndex = 101;
            this.label10.Text = "Yazar Adı";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(649, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 18);
            this.label7.TabIndex = 100;
            this.label7.Text = "Sayfa Sayısı";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(804, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 18);
            this.label9.TabIndex = 99;
            this.label9.Text = "Yazar Soyadı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(804, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 18);
            this.label5.TabIndex = 98;
            this.label5.Text = "Kitap Dili";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(494, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 18);
            this.label6.TabIndex = 97;
            this.label6.Text = "Yayın Tarihi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(339, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 18);
            this.label4.TabIndex = 102;
            this.label4.Text = "Kitap Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(184, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 18);
            this.label2.TabIndex = 96;
            this.label2.Text = "ISBN";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(339, 77);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 18);
            this.label12.TabIndex = 94;
            this.label12.Text = "Kitap Adeti";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(184, 77);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 18);
            this.label11.TabIndex = 95;
            this.label11.Text = "Kütüphane No";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(576, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 18);
            this.label8.TabIndex = 93;
            this.label8.Text = "Kategori";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(339, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 92;
            this.label3.Text = "Yayınevi";
            // 
            // kategori
            // 
            this.kategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kategori.FormattingEnabled = true;
            this.kategori.Location = new System.Drawing.Point(579, 25);
            this.kategori.Name = "kategori";
            this.kategori.Size = new System.Drawing.Size(222, 32);
            this.kategori.TabIndex = 1;
            // 
            // yayinEvi
            // 
            this.yayinEvi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yayinEvi.FormattingEnabled = true;
            this.yayinEvi.Location = new System.Drawing.Point(342, 25);
            this.yayinEvi.Name = "yayinEvi";
            this.yayinEvi.Size = new System.Drawing.Size(222, 32);
            this.yayinEvi.TabIndex = 0;
            // 
            // txt_kitapAdet
            // 
            this.txt_kitapAdet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_kitapAdet.Location = new System.Drawing.Point(342, 98);
            this.txt_kitapAdet.Multiline = true;
            this.txt_kitapAdet.Name = "txt_kitapAdet";
            this.txt_kitapAdet.Size = new System.Drawing.Size(149, 30);
            this.txt_kitapAdet.TabIndex = 3;
            // 
            // txt_kutuphaneID
            // 
            this.txt_kutuphaneID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_kutuphaneID.Location = new System.Drawing.Point(187, 98);
            this.txt_kutuphaneID.Multiline = true;
            this.txt_kutuphaneID.Name = "txt_kutuphaneID";
            this.txt_kutuphaneID.Size = new System.Drawing.Size(149, 30);
            this.txt_kutuphaneID.TabIndex = 2;
            // 
            // txt_yazarAd
            // 
            this.txt_yazarAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_yazarAd.Location = new System.Drawing.Point(652, 98);
            this.txt_yazarAd.Multiline = true;
            this.txt_yazarAd.Name = "txt_yazarAd";
            this.txt_yazarAd.Size = new System.Drawing.Size(149, 30);
            this.txt_yazarAd.TabIndex = 4;
            // 
            // txt_yazarSoyad
            // 
            this.txt_yazarSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_yazarSoyad.Location = new System.Drawing.Point(807, 98);
            this.txt_yazarSoyad.Multiline = true;
            this.txt_yazarSoyad.Name = "txt_yazarSoyad";
            this.txt_yazarSoyad.Size = new System.Drawing.Size(149, 30);
            this.txt_yazarSoyad.TabIndex = 5;
            // 
            // txt_sayfaSayisi
            // 
            this.txt_sayfaSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_sayfaSayisi.Location = new System.Drawing.Point(652, 161);
            this.txt_sayfaSayisi.Multiline = true;
            this.txt_sayfaSayisi.Name = "txt_sayfaSayisi";
            this.txt_sayfaSayisi.Size = new System.Drawing.Size(149, 30);
            this.txt_sayfaSayisi.TabIndex = 9;
            // 
            // txt_kitapDili
            // 
            this.txt_kitapDili.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_kitapDili.Location = new System.Drawing.Point(807, 161);
            this.txt_kitapDili.Multiline = true;
            this.txt_kitapDili.Name = "txt_kitapDili";
            this.txt_kitapDili.Size = new System.Drawing.Size(149, 30);
            this.txt_kitapDili.TabIndex = 10;
            // 
            // txt_kitapAdi
            // 
            this.txt_kitapAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_kitapAdi.Location = new System.Drawing.Point(342, 161);
            this.txt_kitapAdi.Multiline = true;
            this.txt_kitapAdi.Name = "txt_kitapAdi";
            this.txt_kitapAdi.Size = new System.Drawing.Size(149, 30);
            this.txt_kitapAdi.TabIndex = 7;
            // 
            // txt_ISBN
            // 
            this.txt_ISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_ISBN.Location = new System.Drawing.Point(187, 161);
            this.txt_ISBN.Multiline = true;
            this.txt_ISBN.Name = "txt_ISBN";
            this.txt_ISBN.Size = new System.Drawing.Size(149, 30);
            this.txt_ISBN.TabIndex = 6;
            // 
            // Kitaplar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 600);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btn_kitapListe);
            this.Controls.Add(this.btn_kitapEkle);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Kitaplar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitaplar";
            this.Load += new System.EventHandler(this.Kitaplar_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_cikis;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label cikis;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_listeYenile;
        private System.Windows.Forms.Button btn_listeArama;
        private System.Windows.Forms.TextBox txt_arama;
        private System.Windows.Forms.Button btn_kitapListe;
        private System.Windows.Forms.Button btn_kitapEkle;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btn_ekleYenile;
        private System.Windows.Forms.Button btn_ekleAra;
        private System.Windows.Forms.TextBox txt_ekleAra;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox kategori;
        private System.Windows.Forms.ComboBox yayinEvi;
        private System.Windows.Forms.TextBox txt_kitapAdet;
        private System.Windows.Forms.TextBox txt_kutuphaneID;
        private System.Windows.Forms.TextBox txt_yazarAd;
        private System.Windows.Forms.TextBox txt_yazarSoyad;
        private System.Windows.Forms.TextBox txt_sayfaSayisi;
        private System.Windows.Forms.TextBox txt_kitapDili;
        private System.Windows.Forms.TextBox txt_kitapAdi;
        private System.Windows.Forms.TextBox txt_ISBN;
        private System.Windows.Forms.Button btn_kitaplar;
        private System.Windows.Forms.Button btn_kutuphane;
        private System.Windows.Forms.Button btn_yayinEvleri;
        private System.Windows.Forms.Button btn_anasayfa;
        private System.Windows.Forms.Button btn_uyeler;
        private System.Windows.Forms.Button btn_yonetimPaneli;
    }
}