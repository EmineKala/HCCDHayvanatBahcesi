namespace HayvanatBahcesi
{
    partial class HayvanBakici
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HayvanBakici));
            this.ID = new System.Windows.Forms.NumericUpDown();
            this.BakiciSicilNo = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.SilButonu = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.GüncelleButonu = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.KaydetButonu = new System.Windows.Forms.Button();
            this.Gorev = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Satir = new System.Windows.Forms.Label();
            this.SatirSayisi = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.ID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BakiciSicilNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SatirSayisi)).BeginInit();
            this.SuspendLayout();
            // 
            // ID
            // 
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ID.Location = new System.Drawing.Point(967, 112);
            this.ID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ID.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.ID.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(160, 30);
            this.ID.TabIndex = 91;
            this.ID.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // BakiciSicilNo
            // 
            this.BakiciSicilNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BakiciSicilNo.Location = new System.Drawing.Point(967, 163);
            this.BakiciSicilNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BakiciSicilNo.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.BakiciSicilNo.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.BakiciSicilNo.Name = "BakiciSicilNo";
            this.BakiciSicilNo.Size = new System.Drawing.Size(160, 30);
            this.BakiciSicilNo.TabIndex = 89;
            this.BakiciSicilNo.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(820, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 25);
            this.label6.TabIndex = 88;
            this.label6.Text = "Görev:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(820, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 25);
            this.label3.TabIndex = 87;
            this.label3.Text = "Bakıcı Sicil No: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(820, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 25);
            this.label2.TabIndex = 86;
            this.label2.Text = "Hayvan ID: ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(957, 550);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 85;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(870, 440);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(60, 65);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 84;
            this.pictureBox4.TabStop = false;
            // 
            // SilButonu
            // 
            this.SilButonu.Location = new System.Drawing.Point(936, 440);
            this.SilButonu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SilButonu.Name = "SilButonu";
            this.SilButonu.Size = new System.Drawing.Size(191, 65);
            this.SilButonu.TabIndex = 83;
            this.SilButonu.Text = "Sil";
            this.SilButonu.UseVisualStyleBackColor = true;
            this.SilButonu.Click += new System.EventHandler(this.SilButonu_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(870, 371);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(60, 65);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 82;
            this.pictureBox3.TabStop = false;
            // 
            // GüncelleButonu
            // 
            this.GüncelleButonu.Location = new System.Drawing.Point(936, 371);
            this.GüncelleButonu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GüncelleButonu.Name = "GüncelleButonu";
            this.GüncelleButonu.Size = new System.Drawing.Size(191, 65);
            this.GüncelleButonu.TabIndex = 81;
            this.GüncelleButonu.Text = "Güncelle";
            this.GüncelleButonu.UseVisualStyleBackColor = true;
            this.GüncelleButonu.Click += new System.EventHandler(this.GüncelleButonu_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(870, 302);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 65);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 80;
            this.pictureBox2.TabStop = false;
            // 
            // KaydetButonu
            // 
            this.KaydetButonu.Location = new System.Drawing.Point(936, 302);
            this.KaydetButonu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.KaydetButonu.Name = "KaydetButonu";
            this.KaydetButonu.Size = new System.Drawing.Size(191, 65);
            this.KaydetButonu.TabIndex = 79;
            this.KaydetButonu.Text = "Yeni Kayıt";
            this.KaydetButonu.UseVisualStyleBackColor = true;
            this.KaydetButonu.Click += new System.EventHandler(this.KaydetButonu_Click);
            // 
            // Gorev
            // 
            this.Gorev.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Gorev.Location = new System.Drawing.Point(967, 206);
            this.Gorev.Name = "Gorev";
            this.Gorev.Size = new System.Drawing.Size(160, 30);
            this.Gorev.TabIndex = 92;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(813, 737);
            this.dataGridView1.TabIndex = 93;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Satir
            // 
            this.Satir.AutoSize = true;
            this.Satir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Satir.Location = new System.Drawing.Point(820, 65);
            this.Satir.Name = "Satir";
            this.Satir.Size = new System.Drawing.Size(116, 25);
            this.Satir.TabIndex = 94;
            this.Satir.Text = "Satır Sayısı:";
            // 
            // SatirSayisi
            // 
            this.SatirSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.SatirSayisi.Location = new System.Drawing.Point(967, 65);
            this.SatirSayisi.Name = "SatirSayisi";
            this.SatirSayisi.Size = new System.Drawing.Size(160, 30);
            this.SatirSayisi.TabIndex = 95;
            // 
            // HayvanBakici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 737);
            this.Controls.Add(this.SatirSayisi);
            this.Controls.Add(this.Satir);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Gorev);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.BakiciSicilNo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.SilButonu);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.GüncelleButonu);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.KaydetButonu);
            this.Name = "HayvanBakici";
            this.Text = "HayvanBakici";
            ((System.ComponentModel.ISupportInitialize)(this.ID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BakiciSicilNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SatirSayisi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown ID;
        private System.Windows.Forms.NumericUpDown BakiciSicilNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button SilButonu;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button GüncelleButonu;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button KaydetButonu;
        private System.Windows.Forms.TextBox Gorev;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label Satir;
        private System.Windows.Forms.NumericUpDown SatirSayisi;
    }
}