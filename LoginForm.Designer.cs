namespace proje_kutuphane
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cikis = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_kullaniciAdi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.btn_giris = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_kayit = new System.Windows.Forms.Button();
            this.sifreGoster = new System.Windows.Forms.CheckBox();
            this.btn_sifremiUnuttum = new System.Windows.Forms.Button();
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
            this.panel1.TabIndex = 0;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(112, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hoşgeldiniz!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(109, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(9, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Kullanıcı Adı";
            // 
            // txt_kullaniciAdi
            // 
            this.txt_kullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_kullaniciAdi.Location = new System.Drawing.Point(12, 206);
            this.txt_kullaniciAdi.Multiline = true;
            this.txt_kullaniciAdi.Name = "txt_kullaniciAdi";
            this.txt_kullaniciAdi.Size = new System.Drawing.Size(296, 30);
            this.txt_kullaniciAdi.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(9, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Şifre";
            // 
            // txt_sifre
            // 
            this.txt_sifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_sifre.Location = new System.Drawing.Point(12, 269);
            this.txt_sifre.Multiline = true;
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.PasswordChar = '*';
            this.txt_sifre.Size = new System.Drawing.Size(296, 30);
            this.txt_sifre.TabIndex = 1;
            // 
            // btn_giris
            // 
            this.btn_giris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(87)))));
            this.btn_giris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_giris.FlatAppearance.BorderSize = 0;
            this.btn_giris.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen;
            this.btn_giris.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.btn_giris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_giris.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_giris.ForeColor = System.Drawing.Color.White;
            this.btn_giris.Location = new System.Drawing.Point(12, 331);
            this.btn_giris.Name = "btn_giris";
            this.btn_giris.Size = new System.Drawing.Size(296, 40);
            this.btn_giris.TabIndex = 3;
            this.btn_giris.Text = "GİRİŞ YAP";
            this.btn_giris.UseVisualStyleBackColor = false;
            this.btn_giris.Click += new System.EventHandler(this.btn_giris_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(96, 454);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Hesabın yok mu?";
            // 
            // btn_kayit
            // 
            this.btn_kayit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(87)))));
            this.btn_kayit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_kayit.FlatAppearance.BorderSize = 0;
            this.btn_kayit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen;
            this.btn_kayit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.btn_kayit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kayit.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kayit.ForeColor = System.Drawing.Color.White;
            this.btn_kayit.Location = new System.Drawing.Point(12, 482);
            this.btn_kayit.Name = "btn_kayit";
            this.btn_kayit.Size = new System.Drawing.Size(296, 31);
            this.btn_kayit.TabIndex = 5;
            this.btn_kayit.Text = "KAYIT OL";
            this.btn_kayit.UseVisualStyleBackColor = false;
            this.btn_kayit.Click += new System.EventHandler(this.btn_kayit_Click);
            // 
            // sifreGoster
            // 
            this.sifreGoster.AutoSize = true;
            this.sifreGoster.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifreGoster.Location = new System.Drawing.Point(205, 305);
            this.sifreGoster.Name = "sifreGoster";
            this.sifreGoster.Size = new System.Drawing.Size(103, 20);
            this.sifreGoster.TabIndex = 2;
            this.sifreGoster.Text = "Şifreyi Göster";
            this.sifreGoster.UseVisualStyleBackColor = true;
            this.sifreGoster.CheckedChanged += new System.EventHandler(this.sifreGoster_CheckedChanged);
            // 
            // btn_sifremiUnuttum
            // 
            this.btn_sifremiUnuttum.BackColor = System.Drawing.Color.White;
            this.btn_sifremiUnuttum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sifremiUnuttum.FlatAppearance.BorderSize = 0;
            this.btn_sifremiUnuttum.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_sifremiUnuttum.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_sifremiUnuttum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sifremiUnuttum.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sifremiUnuttum.ForeColor = System.Drawing.Color.Black;
            this.btn_sifremiUnuttum.Location = new System.Drawing.Point(99, 377);
            this.btn_sifremiUnuttum.Name = "btn_sifremiUnuttum";
            this.btn_sifremiUnuttum.Size = new System.Drawing.Size(118, 27);
            this.btn_sifremiUnuttum.TabIndex = 4;
            this.btn_sifremiUnuttum.Text = "Şifremi Unuttum";
            this.btn_sifremiUnuttum.UseVisualStyleBackColor = false;
            this.btn_sifremiUnuttum.Click += new System.EventHandler(this.btn_sifremiUnuttum_Click);
            // 
            // LoginForm
            // 
            this.AcceptButton = this.btn_giris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(320, 525);
            this.Controls.Add(this.sifreGoster);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_kayit);
            this.Controls.Add(this.btn_sifremiUnuttum);
            this.Controls.Add(this.btn_giris);
            this.Controls.Add(this.txt_sifre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_kullaniciAdi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label cikis;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_kullaniciAdi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.Button btn_giris;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_kayit;
        private System.Windows.Forms.CheckBox sifreGoster;
        private System.Windows.Forms.Button btn_sifremiUnuttum;
    }
}