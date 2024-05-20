namespace proje_kutuphane
{
    partial class EmanetAl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmanetAl));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_kutuphaneID = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_kullaniciAdi_yenile = new System.Windows.Forms.Button();
            this.txt_kullaniciAdi_ara = new System.Windows.Forms.TextBox();
            this.btn_kullaniciAdi_ara = new System.Windows.Forms.Button();
            this.btn_emanet_al = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cikis = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_emanetAl = new System.Windows.Forms.Button();
            this.btn_emanetVer = new System.Windows.Forms.Button();
            this.btn_anasayfa = new System.Windows.Forms.Button();
            this.btn_gostergePaneli = new System.Windows.Forms.Button();
            this.btn_yonetimPaneli = new System.Windows.Forms.Button();
            this.btn_cikis = new System.Windows.Forms.Button();
            this.txt_kitapID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_emanetID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_teslimTarihi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(499, 325);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(120, 120);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 74;
            this.pictureBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(795, 348);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 18);
            this.label5.TabIndex = 71;
            this.label5.Text = "Kütüphane No";
            // 
            // txt_kutuphaneID
            // 
            this.txt_kutuphaneID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_kutuphaneID.Location = new System.Drawing.Point(797, 369);
            this.txt_kutuphaneID.Multiline = true;
            this.txt_kutuphaneID.Name = "txt_kutuphaneID";
            this.txt_kutuphaneID.Size = new System.Drawing.Size(149, 30);
            this.txt_kutuphaneID.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Controls.Add(this.btn_kullaniciAdi_yenile);
            this.panel3.Controls.Add(this.txt_kullaniciAdi_ara);
            this.panel3.Controls.Add(this.btn_kullaniciAdi_ara);
            this.panel3.Location = new System.Drawing.Point(221, 36);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1128, 227);
            this.panel3.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(14, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(294, 23);
            this.label2.TabIndex = 62;
            this.label2.Text = "Kullanıcının Emanet Aldığı Kitaplar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1128, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btn_kullaniciAdi_yenile
            // 
            this.btn_kullaniciAdi_yenile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(87)))));
            this.btn_kullaniciAdi_yenile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_kullaniciAdi_yenile.FlatAppearance.BorderSize = 0;
            this.btn_kullaniciAdi_yenile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen;
            this.btn_kullaniciAdi_yenile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.btn_kullaniciAdi_yenile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kullaniciAdi_yenile.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kullaniciAdi_yenile.ForeColor = System.Drawing.Color.White;
            this.btn_kullaniciAdi_yenile.Location = new System.Drawing.Point(1041, 28);
            this.btn_kullaniciAdi_yenile.Name = "btn_kullaniciAdi_yenile";
            this.btn_kullaniciAdi_yenile.Size = new System.Drawing.Size(82, 30);
            this.btn_kullaniciAdi_yenile.TabIndex = 2;
            this.btn_kullaniciAdi_yenile.Text = "YENİLE";
            this.btn_kullaniciAdi_yenile.UseVisualStyleBackColor = false;
            this.btn_kullaniciAdi_yenile.Click += new System.EventHandler(this.btn_kullaniciAdi_yenile_Click);
            // 
            // txt_kullaniciAdi_ara
            // 
            this.txt_kullaniciAdi_ara.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_kullaniciAdi_ara.Location = new System.Drawing.Point(738, 28);
            this.txt_kullaniciAdi_ara.Multiline = true;
            this.txt_kullaniciAdi_ara.Name = "txt_kullaniciAdi_ara";
            this.txt_kullaniciAdi_ara.Size = new System.Drawing.Size(149, 30);
            this.txt_kullaniciAdi_ara.TabIndex = 0;
            // 
            // btn_kullaniciAdi_ara
            // 
            this.btn_kullaniciAdi_ara.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(87)))));
            this.btn_kullaniciAdi_ara.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_kullaniciAdi_ara.FlatAppearance.BorderSize = 0;
            this.btn_kullaniciAdi_ara.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen;
            this.btn_kullaniciAdi_ara.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.btn_kullaniciAdi_ara.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kullaniciAdi_ara.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kullaniciAdi_ara.ForeColor = System.Drawing.Color.White;
            this.btn_kullaniciAdi_ara.Location = new System.Drawing.Point(893, 28);
            this.btn_kullaniciAdi_ara.Name = "btn_kullaniciAdi_ara";
            this.btn_kullaniciAdi_ara.Size = new System.Drawing.Size(142, 30);
            this.btn_kullaniciAdi_ara.TabIndex = 1;
            this.btn_kullaniciAdi_ara.Text = "KULLANICI ADI ARA";
            this.btn_kullaniciAdi_ara.UseVisualStyleBackColor = false;
            this.btn_kullaniciAdi_ara.Click += new System.EventHandler(this.btn_kullaniciAdi_ara_Click);
            // 
            // btn_emanet_al
            // 
            this.btn_emanet_al.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(87)))));
            this.btn_emanet_al.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_emanet_al.FlatAppearance.BorderSize = 0;
            this.btn_emanet_al.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen;
            this.btn_emanet_al.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.btn_emanet_al.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_emanet_al.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_emanet_al.ForeColor = System.Drawing.Color.White;
            this.btn_emanet_al.Location = new System.Drawing.Point(642, 420);
            this.btn_emanet_al.Name = "btn_emanet_al";
            this.btn_emanet_al.Size = new System.Drawing.Size(305, 43);
            this.btn_emanet_al.TabIndex = 4;
            this.btn_emanet_al.Text = "EMANET AL";
            this.btn_emanet_al.UseVisualStyleBackColor = false;
            this.btn_emanet_al.Click += new System.EventHandler(this.btn_emanet_al_Click);
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
            this.panel1.TabIndex = 67;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(403, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kütüphane Yönetim Sistemi | Emanet Al Paneli";
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(87)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btn_emanetAl);
            this.panel2.Controls.Add(this.btn_emanetVer);
            this.panel2.Controls.Add(this.btn_anasayfa);
            this.panel2.Controls.Add(this.btn_gostergePaneli);
            this.panel2.Controls.Add(this.btn_yonetimPaneli);
            this.panel2.Controls.Add(this.btn_cikis);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(0, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 565);
            this.panel2.TabIndex = 6;
            // 
            // btn_emanetAl
            // 
            this.btn_emanetAl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_emanetAl.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_emanetAl.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_emanetAl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_emanetAl.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_emanetAl.ForeColor = System.Drawing.Color.White;
            this.btn_emanetAl.Image = ((System.Drawing.Image)(resources.GetObject("btn_emanetAl.Image")));
            this.btn_emanetAl.Location = new System.Drawing.Point(8, 384);
            this.btn_emanetAl.Name = "btn_emanetAl";
            this.btn_emanetAl.Size = new System.Drawing.Size(200, 45);
            this.btn_emanetAl.TabIndex = 4;
            this.btn_emanetAl.Text = "EMANET AL";
            this.btn_emanetAl.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_emanetAl.UseVisualStyleBackColor = true;
            this.btn_emanetAl.Click += new System.EventHandler(this.btn_emanetAl_Click);
            // 
            // btn_emanetVer
            // 
            this.btn_emanetVer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_emanetVer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_emanetVer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_emanetVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_emanetVer.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_emanetVer.ForeColor = System.Drawing.Color.White;
            this.btn_emanetVer.Image = ((System.Drawing.Image)(resources.GetObject("btn_emanetVer.Image")));
            this.btn_emanetVer.Location = new System.Drawing.Point(8, 333);
            this.btn_emanetVer.Name = "btn_emanetVer";
            this.btn_emanetVer.Size = new System.Drawing.Size(200, 45);
            this.btn_emanetVer.TabIndex = 3;
            this.btn_emanetVer.Text = "EMANET VER";
            this.btn_emanetVer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_emanetVer.UseVisualStyleBackColor = true;
            this.btn_emanetVer.Click += new System.EventHandler(this.btn_emanetVer_Click);
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
            // btn_gostergePaneli
            // 
            this.btn_gostergePaneli.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_gostergePaneli.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_gostergePaneli.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_gostergePaneli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_gostergePaneli.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_gostergePaneli.ForeColor = System.Drawing.Color.White;
            this.btn_gostergePaneli.Image = ((System.Drawing.Image)(resources.GetObject("btn_gostergePaneli.Image")));
            this.btn_gostergePaneli.Location = new System.Drawing.Point(8, 257);
            this.btn_gostergePaneli.Name = "btn_gostergePaneli";
            this.btn_gostergePaneli.Size = new System.Drawing.Size(200, 45);
            this.btn_gostergePaneli.TabIndex = 2;
            this.btn_gostergePaneli.Text = "GÖSTERGE PANELİ";
            this.btn_gostergePaneli.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_gostergePaneli.UseVisualStyleBackColor = true;
            this.btn_gostergePaneli.Click += new System.EventHandler(this.btn_gostergePaneli_Click);
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
            this.btn_cikis.TabIndex = 5;
            this.btn_cikis.Text = "ÇIKIŞ YAP";
            this.btn_cikis.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cikis.UseVisualStyleBackColor = true;
            this.btn_cikis.Click += new System.EventHandler(this.btn_cikis_Click);
            // 
            // txt_kitapID
            // 
            this.txt_kitapID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_kitapID.Location = new System.Drawing.Point(643, 308);
            this.txt_kitapID.Multiline = true;
            this.txt_kitapID.Name = "txt_kitapID";
            this.txt_kitapID.Size = new System.Drawing.Size(149, 30);
            this.txt_kitapID.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(641, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 18);
            this.label6.TabIndex = 73;
            this.label6.Text = "Kitap No";
            // 
            // txt_emanetID
            // 
            this.txt_emanetID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_emanetID.Location = new System.Drawing.Point(798, 308);
            this.txt_emanetID.Multiline = true;
            this.txt_emanetID.Name = "txt_emanetID";
            this.txt_emanetID.Size = new System.Drawing.Size(149, 30);
            this.txt_emanetID.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(796, 287);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 18);
            this.label7.TabIndex = 73;
            this.label7.Text = "Emanet No";
            // 
            // txt_teslimTarihi
            // 
            this.txt_teslimTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_teslimTarihi.Location = new System.Drawing.Point(642, 369);
            this.txt_teslimTarihi.Multiline = true;
            this.txt_teslimTarihi.Name = "txt_teslimTarihi";
            this.txt_teslimTarihi.Size = new System.Drawing.Size(149, 30);
            this.txt_teslimTarihi.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(640, 348);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 18);
            this.label8.TabIndex = 73;
            this.label8.Text = "Teslim Tarihi";
            // 
            // EmanetAl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 600);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_teslimTarihi);
            this.Controls.Add(this.txt_emanetID);
            this.Controls.Add(this.txt_kitapID);
            this.Controls.Add(this.txt_kutuphaneID);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btn_emanet_al);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EmanetAl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmanetAl";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_kutuphaneID;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_kullaniciAdi_yenile;
        private System.Windows.Forms.TextBox txt_kullaniciAdi_ara;
        private System.Windows.Forms.Button btn_kullaniciAdi_ara;
        private System.Windows.Forms.Button btn_emanet_al;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label cikis;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_cikis;
        private System.Windows.Forms.Button btn_emanetAl;
        private System.Windows.Forms.Button btn_emanetVer;
        private System.Windows.Forms.Button btn_anasayfa;
        private System.Windows.Forms.Button btn_gostergePaneli;
        private System.Windows.Forms.Button btn_yonetimPaneli;
        private System.Windows.Forms.TextBox txt_kitapID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_emanetID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_teslimTarihi;
        private System.Windows.Forms.Label label8;
    }
}