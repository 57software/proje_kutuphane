namespace proje_kutuphane
{
    partial class YonetimPaneli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YonetimPaneli));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cikis = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_kitaplar = new System.Windows.Forms.Button();
            this.btn_cikis = new System.Windows.Forms.Button();
            this.btn_emanetAl = new System.Windows.Forms.Button();
            this.btn_yayinEvleri = new System.Windows.Forms.Button();
            this.btn_anasayfa = new System.Windows.Forms.Button();
            this.btn_uyeler = new System.Windows.Forms.Button();
            this.btn_yonetimPaneli = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
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
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(387, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kütüphane Yönetim Sistemi | Yönetim Paneli";
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
            this.panel2.Controls.Add(this.btn_kitaplar);
            this.panel2.Controls.Add(this.btn_cikis);
            this.panel2.Controls.Add(this.btn_emanetAl);
            this.panel2.Controls.Add(this.btn_yayinEvleri);
            this.panel2.Controls.Add(this.btn_anasayfa);
            this.panel2.Controls.Add(this.btn_uyeler);
            this.panel2.Controls.Add(this.btn_yonetimPaneli);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(0, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 565);
            this.panel2.TabIndex = 0;
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
            // btn_emanetAl
            // 
            this.btn_emanetAl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_emanetAl.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_emanetAl.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_emanetAl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_emanetAl.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_emanetAl.ForeColor = System.Drawing.Color.White;
            this.btn_emanetAl.Image = ((System.Drawing.Image)(resources.GetObject("btn_emanetAl.Image")));
            this.btn_emanetAl.Location = new System.Drawing.Point(8, 429);
            this.btn_emanetAl.Name = "btn_emanetAl";
            this.btn_emanetAl.Size = new System.Drawing.Size(200, 45);
            this.btn_emanetAl.TabIndex = 5;
            this.btn_emanetAl.Text = "KÜTÜPHANE";
            this.btn_emanetAl.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_emanetAl.UseVisualStyleBackColor = true;
            this.btn_emanetAl.Click += new System.EventHandler(this.btn_emanetAl_Click);
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
            // label2
            // 
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(626, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(374, 55);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kütüphane Yönetim Sistemine Hoşgeldiniz\r\nYönetici olarak giriş yaptınız.\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(753, 92);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(120, 120);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // YonetimPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1350, 600);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "YonetimPaneli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YonetimPaneli";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label cikis;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_cikis;
        private System.Windows.Forms.Button btn_emanetAl;
        private System.Windows.Forms.Button btn_yayinEvleri;
        private System.Windows.Forms.Button btn_anasayfa;
        private System.Windows.Forms.Button btn_uyeler;
        private System.Windows.Forms.Button btn_yonetimPaneli;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_kitaplar;
    }
}