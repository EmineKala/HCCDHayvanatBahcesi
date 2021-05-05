namespace HayvanatBahcesi
{
    partial class HayvanMenüYeniKayit
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
            this.IptalButonu = new System.Windows.Forms.Button();
            this.KaydetButonu = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.NumericUpDown();
            this.Gün = new System.Windows.Forms.DateTimePicker();
            this.MenüKodu = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenüKodu)).BeginInit();
            this.SuspendLayout();
            // 
            // IptalButonu
            // 
            this.IptalButonu.Location = new System.Drawing.Point(273, 297);
            this.IptalButonu.Name = "IptalButonu";
            this.IptalButonu.Size = new System.Drawing.Size(153, 56);
            this.IptalButonu.TabIndex = 72;
            this.IptalButonu.Text = "İPTAL";
            this.IptalButonu.UseVisualStyleBackColor = true;
            // 
            // KaydetButonu
            // 
            this.KaydetButonu.Location = new System.Drawing.Point(133, 297);
            this.KaydetButonu.Name = "KaydetButonu";
            this.KaydetButonu.Size = new System.Drawing.Size(142, 56);
            this.KaydetButonu.TabIndex = 71;
            this.KaydetButonu.Text = "KAYDET";
            this.KaydetButonu.UseVisualStyleBackColor = true;
            this.KaydetButonu.Click += new System.EventHandler(this.KaydetButonu_Click);
            // 
            // ID
            // 
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ID.Location = new System.Drawing.Point(246, 90);
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
            this.ID.TabIndex = 84;
            this.ID.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // Gün
            // 
            this.Gün.CustomFormat = "dd.MM.yyyy hh:mm";
            this.Gün.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Gün.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Gün.Location = new System.Drawing.Point(246, 194);
            this.Gün.Name = "Gün";
            this.Gün.Size = new System.Drawing.Size(200, 30);
            this.Gün.TabIndex = 83;
            this.Gün.Value = new System.DateTime(2020, 5, 31, 0, 0, 0, 0);
            // 
            // MenüKodu
            // 
            this.MenüKodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MenüKodu.Location = new System.Drawing.Point(246, 144);
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
            this.MenüKodu.TabIndex = 82;
            this.MenüKodu.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(91, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 25);
            this.label6.TabIndex = 81;
            this.label6.Text = "Yemek Zamanı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(91, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 25);
            this.label3.TabIndex = 80;
            this.label3.Text = "Menü Kodu: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(91, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 25);
            this.label2.TabIndex = 79;
            this.label2.Text = "Hayvan ID: ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // HayvanMenüYeniKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 479);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.Gün);
            this.Controls.Add(this.MenüKodu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IptalButonu);
            this.Controls.Add(this.KaydetButonu);
            this.Name = "HayvanMenüYeniKayit";
            this.Text = "HayvanMenüYeniKayit";
            ((System.ComponentModel.ISupportInitialize)(this.ID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenüKodu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button IptalButonu;
        private System.Windows.Forms.Button KaydetButonu;
        private System.Windows.Forms.NumericUpDown ID;
        private System.Windows.Forms.DateTimePicker Gün;
        private System.Windows.Forms.NumericUpDown MenüKodu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}