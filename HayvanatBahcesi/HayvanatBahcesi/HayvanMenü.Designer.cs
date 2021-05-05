namespace HayvanatBahcesi
{
    partial class HayvanMenü
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HayvanMenü));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.SilButonu = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.GüncelleButonu = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.KaydetButonu = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MenüKodu = new System.Windows.Forms.NumericUpDown();
            this.Gün = new System.Windows.Forms.DateTimePicker();
            this.ID = new System.Windows.Forms.NumericUpDown();
            this.Satir = new System.Windows.Forms.Label();
            this.SatirSayisi = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenüKodu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SatirSayisi)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-4, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(786, 731);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(921, 533);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(842, 422);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(60, 65);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 45;
            this.pictureBox4.TabStop = false;
            // 
            // SilButonu
            // 
            this.SilButonu.Location = new System.Drawing.Point(921, 422);
            this.SilButonu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SilButonu.Name = "SilButonu";
            this.SilButonu.Size = new System.Drawing.Size(191, 65);
            this.SilButonu.TabIndex = 44;
            this.SilButonu.Text = "Sil";
            this.SilButonu.UseVisualStyleBackColor = true;
            this.SilButonu.Click += new System.EventHandler(this.SilButonu_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(842, 353);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(60, 65);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 43;
            this.pictureBox3.TabStop = false;
            // 
            // GüncelleButonu
            // 
            this.GüncelleButonu.Location = new System.Drawing.Point(921, 353);
            this.GüncelleButonu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GüncelleButonu.Name = "GüncelleButonu";
            this.GüncelleButonu.Size = new System.Drawing.Size(191, 65);
            this.GüncelleButonu.TabIndex = 42;
            this.GüncelleButonu.Text = "Güncelle";
            this.GüncelleButonu.UseVisualStyleBackColor = true;
            this.GüncelleButonu.Click += new System.EventHandler(this.GüncelleButonu_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(842, 284);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 65);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 41;
            this.pictureBox2.TabStop = false;
            // 
            // KaydetButonu
            // 
            this.KaydetButonu.Location = new System.Drawing.Point(921, 284);
            this.KaydetButonu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.KaydetButonu.Name = "KaydetButonu";
            this.KaydetButonu.Size = new System.Drawing.Size(191, 65);
            this.KaydetButonu.TabIndex = 40;
            this.KaydetButonu.Text = "Yeni Kayıt";
            this.KaydetButonu.UseVisualStyleBackColor = true;
            this.KaydetButonu.Click += new System.EventHandler(this.KaydetButonu_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(788, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 25);
            this.label6.TabIndex = 74;
            this.label6.Text = "Yemek Zamanı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(788, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 25);
            this.label3.TabIndex = 72;
            this.label3.Text = "Menü Kodu: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(788, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 25);
            this.label2.TabIndex = 70;
            this.label2.Text = "Hayvan ID: ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MenüKodu
            // 
            this.MenüKodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MenüKodu.Location = new System.Drawing.Point(943, 138);
            this.MenüKodu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MenüKodu.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.MenüKodu.Minimum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.MenüKodu.Name = "MenüKodu";
            this.MenüKodu.Size = new System.Drawing.Size(160, 30);
            this.MenüKodu.TabIndex = 76;
            this.MenüKodu.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            // 
            // Gün
            // 
            this.Gün.CustomFormat = "dd.MM.yyyy hh:mm";
            this.Gün.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Gün.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Gün.Location = new System.Drawing.Point(943, 188);
            this.Gün.Name = "Gün";
            this.Gün.Size = new System.Drawing.Size(212, 30);
            this.Gün.TabIndex = 77;
            this.Gün.Value = new System.DateTime(2020, 6, 2, 13, 55, 4, 0);
            // 
            // ID
            // 
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ID.Location = new System.Drawing.Point(943, 84);
            this.ID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ID.Maximum = new decimal(new int[] {
            999,
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
            this.ID.TabIndex = 78;
            this.ID.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // Satir
            // 
            this.Satir.AutoSize = true;
            this.Satir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Satir.Location = new System.Drawing.Point(788, 41);
            this.Satir.Name = "Satir";
            this.Satir.Size = new System.Drawing.Size(110, 25);
            this.Satir.TabIndex = 79;
            this.Satir.Text = "Satır Sayısı";
            // 
            // SatirSayisi
            // 
            this.SatirSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.SatirSayisi.Location = new System.Drawing.Point(943, 41);
            this.SatirSayisi.Name = "SatirSayisi";
            this.SatirSayisi.Size = new System.Drawing.Size(160, 30);
            this.SatirSayisi.TabIndex = 80;
            // 
            // HayvanMenü
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 733);
            this.Controls.Add(this.SatirSayisi);
            this.Controls.Add(this.Satir);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.Gün);
            this.Controls.Add(this.MenüKodu);
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
            this.Controls.Add(this.dataGridView1);
            this.Name = "HayvanMenü";
            this.Text = "HayvanMenü";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenüKodu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SatirSayisi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button SilButonu;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button GüncelleButonu;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button KaydetButonu;
       
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown MenüKodu;
        private System.Windows.Forms.DateTimePicker Gün;
        private System.Windows.Forms.NumericUpDown ID;
        private System.Windows.Forms.Label Satir;
        private System.Windows.Forms.NumericUpDown SatirSayisi;
    }
}