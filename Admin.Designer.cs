namespace proje_kutuphane
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cikis = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_cikis = new System.Windows.Forms.Button();
            this.btn_emanetAl = new System.Windows.Forms.Button();
            this.btn_emanetVer = new System.Windows.Forms.Button();
            this.btn_anasayfa = new System.Windows.Forms.Button();
            this.btn_gostergePaneli = new System.Windows.Forms.Button();
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
            this.panel1.TabIndex = 0;
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
            this.label1.Text = "Kütüphane Yönetim Sistemi | Yönetici Paneli";
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
            this.panel2.Controls.Add(this.btn_cikis);
            this.panel2.Controls.Add(this.btn_emanetAl);
            this.panel2.Controls.Add(this.btn_emanetVer);
            this.panel2.Controls.Add(this.btn_anasayfa);
            this.panel2.Controls.Add(this.btn_gostergePaneli);
            this.panel2.Controls.Add(this.btn_yonetimPaneli);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 565);
            this.panel2.TabIndex = 0;
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
            this.label2.TabIndex = 1;
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
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1350, 600);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label cikis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_yonetimPaneli;
        private System.Windows.Forms.Button btn_emanetAl;
        private System.Windows.Forms.Button btn_emanetVer;
        private System.Windows.Forms.Button btn_anasayfa;
        private System.Windows.Forms.Button btn_gostergePaneli;
        private System.Windows.Forms.Button btn_cikis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}