namespace proje_kutuphane
{
    partial class UyeKitaplar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UyeKitaplar));
            this.btn_cikis = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_kitaplar = new System.Windows.Forms.Button();
            this.btn_anasayfa = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_listeYenile = new System.Windows.Forms.Button();
            this.btn_listeArama = new System.Windows.Forms.Button();
            this.txt_arama = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cikis = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.btn_cikis.TabIndex = 2;
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
            this.panel2.Controls.Add(this.btn_anasayfa);
            this.panel2.Controls.Add(this.btn_cikis);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 565);
            this.panel2.TabIndex = 1;
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
            this.btn_kitaplar.Location = new System.Drawing.Point(8, 182);
            this.btn_kitaplar.Name = "btn_kitaplar";
            this.btn_kitaplar.Size = new System.Drawing.Size(200, 45);
            this.btn_kitaplar.TabIndex = 1;
            this.btn_kitaplar.Text = "KİTAPLAR";
            this.btn_kitaplar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_kitaplar.UseVisualStyleBackColor = true;
            this.btn_kitaplar.Click += new System.EventHandler(this.btn_kitaplar_Click);
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
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Controls.Add(this.btn_listeYenile);
            this.panel4.Controls.Add(this.btn_listeArama);
            this.panel4.Controls.Add(this.txt_arama);
            this.panel4.Location = new System.Drawing.Point(219, 35);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1131, 565);
            this.panel4.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1130, 487);
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
            this.panel1.TabIndex = 61;
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
            // UyeKitaplar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 600);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UyeKitaplar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UyeKitaplar";
            this.Load += new System.EventHandler(this.UyeKitaplar_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_cikis;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_kitaplar;
        private System.Windows.Forms.Button btn_anasayfa;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_listeYenile;
        private System.Windows.Forms.Button btn_listeArama;
        private System.Windows.Forms.TextBox txt_arama;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label cikis;
    }
}