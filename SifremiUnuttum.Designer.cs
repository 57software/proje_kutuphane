namespace proje_kutuphane
{
    partial class SifremiUnuttum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SifremiUnuttum));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cikis = new System.Windows.Forms.Label();
            this.sifreGoster = new System.Windows.Forms.CheckBox();
            this.btn_girisYap = new System.Windows.Forms.Button();
            this.btn_sifreDegistir = new System.Windows.Forms.Button();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_kullaniciAdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_eposta = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(87)))));
            this.panel1.Controls.Add(this.cikis);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 35);
            this.panel1.TabIndex = 6;
            // 
            // cikis
            // 
            this.cikis.AutoSize = true;
            this.cikis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cikis.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cikis.ForeColor = System.Drawing.Color.White;
            this.cikis.Location = new System.Drawing.Point(289, 2);
            this.cikis.Name = "cikis";
            this.cikis.Size = new System.Drawing.Size(29, 31);
            this.cikis.TabIndex = 0;
            this.cikis.Text = "X";
            this.cikis.Click += new System.EventHandler(this.cikis_Click);
            // 
            // sifreGoster
            // 
            this.sifreGoster.AutoSize = true;
            this.sifreGoster.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifreGoster.Location = new System.Drawing.Point(205, 376);
            this.sifreGoster.Name = "sifreGoster";
            this.sifreGoster.Size = new System.Drawing.Size(103, 20);
            this.sifreGoster.TabIndex = 3;
            this.sifreGoster.Text = "Şifreyi Göster";
            this.sifreGoster.UseVisualStyleBackColor = true;
            this.sifreGoster.CheckedChanged += new System.EventHandler(this.sifreGoster_CheckedChanged);
            // 
            // btn_girisYap
            // 
            this.btn_girisYap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(87)))));
            this.btn_girisYap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_girisYap.FlatAppearance.BorderSize = 0;
            this.btn_girisYap.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen;
            this.btn_girisYap.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.btn_girisYap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_girisYap.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_girisYap.ForeColor = System.Drawing.Color.White;
            this.btn_girisYap.Location = new System.Drawing.Point(12, 482);
            this.btn_girisYap.Name = "btn_girisYap";
            this.btn_girisYap.Size = new System.Drawing.Size(296, 31);
            this.btn_girisYap.TabIndex = 5;
            this.btn_girisYap.Text = "GİRİŞ YAP";
            this.btn_girisYap.UseVisualStyleBackColor = false;
            this.btn_girisYap.Click += new System.EventHandler(this.btn_girisYap_Click);
            // 
            // btn_sifreDegistir
            // 
            this.btn_sifreDegistir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(87)))));
            this.btn_sifreDegistir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sifreDegistir.FlatAppearance.BorderSize = 0;
            this.btn_sifreDegistir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen;
            this.btn_sifreDegistir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.btn_sifreDegistir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sifreDegistir.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sifreDegistir.ForeColor = System.Drawing.Color.White;
            this.btn_sifreDegistir.Location = new System.Drawing.Point(12, 411);
            this.btn_sifreDegistir.Name = "btn_sifreDegistir";
            this.btn_sifreDegistir.Size = new System.Drawing.Size(296, 40);
            this.btn_sifreDegistir.TabIndex = 4;
            this.btn_sifreDegistir.Text = "ŞİFREYİ DEĞİŞTİR";
            this.btn_sifreDegistir.UseVisualStyleBackColor = false;
            this.btn_sifreDegistir.Click += new System.EventHandler(this.btn_sifreDegistir_Click);
            // 
            // txt_sifre
            // 
            this.txt_sifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_sifre.Location = new System.Drawing.Point(12, 340);
            this.txt_sifre.Multiline = true;
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.PasswordChar = '*';
            this.txt_sifre.Size = new System.Drawing.Size(296, 30);
            this.txt_sifre.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(9, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 18);
            this.label4.TabIndex = 14;
            this.label4.Text = "Yeni Şifre";
            // 
            // txt_kullaniciAdi
            // 
            this.txt_kullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_kullaniciAdi.Location = new System.Drawing.Point(12, 278);
            this.txt_kullaniciAdi.Multiline = true;
            this.txt_kullaniciAdi.Name = "txt_kullaniciAdi";
            this.txt_kullaniciAdi.Size = new System.Drawing.Size(296, 30);
            this.txt_kullaniciAdi.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(9, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 15;
            this.label3.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(107, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "Şifreni Değiştir";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(109, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(9, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "Eposta";
            // 
            // txt_eposta
            // 
            this.txt_eposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_eposta.Location = new System.Drawing.Point(12, 215);
            this.txt_eposta.Multiline = true;
            this.txt_eposta.Name = "txt_eposta";
            this.txt_eposta.Size = new System.Drawing.Size(296, 30);
            this.txt_eposta.TabIndex = 0;
            // 
            // SifremiUnuttum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(320, 525);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sifreGoster);
            this.Controls.Add(this.btn_girisYap);
            this.Controls.Add(this.btn_sifreDegistir);
            this.Controls.Add(this.txt_sifre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_eposta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_kullaniciAdi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SifremiUnuttum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SifremiUnuttum";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label cikis;
        private System.Windows.Forms.CheckBox sifreGoster;
        private System.Windows.Forms.Button btn_girisYap;
        private System.Windows.Forms.Button btn_sifreDegistir;
        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_kullaniciAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_eposta;
    }
}