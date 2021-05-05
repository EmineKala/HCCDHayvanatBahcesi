﻿namespace HayvanatBahcesi
{
    partial class YiyecekGuncelle
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
            this.MenuKodu = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.Miktar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Ad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MenuKodu)).BeginInit();
            this.SuspendLayout();
            // 
            // IptalButonu
            // 
            this.IptalButonu.Location = new System.Drawing.Point(267, 359);
            this.IptalButonu.Name = "IptalButonu";
            this.IptalButonu.Size = new System.Drawing.Size(153, 56);
            this.IptalButonu.TabIndex = 74;
            this.IptalButonu.Text = "İPTAL";
            this.IptalButonu.UseVisualStyleBackColor = true;
            this.IptalButonu.Click += new System.EventHandler(this.IptalButonu_Click);
            // 
            // KaydetButonu
            // 
            this.KaydetButonu.Location = new System.Drawing.Point(127, 359);
            this.KaydetButonu.Name = "KaydetButonu";
            this.KaydetButonu.Size = new System.Drawing.Size(142, 56);
            this.KaydetButonu.TabIndex = 73;
            this.KaydetButonu.Text = "KAYDET";
            this.KaydetButonu.UseVisualStyleBackColor = true;
            this.KaydetButonu.Click += new System.EventHandler(this.KaydetButonu_Click);
            // 
            // MenuKodu
            // 
            this.MenuKodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MenuKodu.Location = new System.Drawing.Point(260, 201);
            this.MenuKodu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MenuKodu.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.MenuKodu.Minimum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.MenuKodu.Name = "MenuKodu";
            this.MenuKodu.Size = new System.Drawing.Size(160, 30);
            this.MenuKodu.TabIndex = 72;
            this.MenuKodu.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(100, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 25);
            this.label4.TabIndex = 71;
            this.label4.Text = "Menü Kodu: ";
            // 
            // Miktar
            // 
            this.Miktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Miktar.Location = new System.Drawing.Point(260, 132);
            this.Miktar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Miktar.Name = "Miktar";
            this.Miktar.Size = new System.Drawing.Size(160, 30);
            this.Miktar.TabIndex = 70;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(100, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 25);
            this.label3.TabIndex = 69;
            this.label3.Text = "Miktar: ";
            // 
            // Ad
            // 
            this.Ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Ad.Location = new System.Drawing.Point(260, 69);
            this.Ad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Ad.Name = "Ad";
            this.Ad.Size = new System.Drawing.Size(160, 30);
            this.Ad.TabIndex = 68;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(100, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 25);
            this.label2.TabIndex = 67;
            this.label2.Text = "Ad: ";
            // 
            // YiyecekGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 485);
            this.Controls.Add(this.IptalButonu);
            this.Controls.Add(this.KaydetButonu);
            this.Controls.Add(this.MenuKodu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Miktar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Ad);
            this.Controls.Add(this.label2);
            this.Name = "YiyecekGuncelle";
            this.Text = "YiyecekGuncelle";
            ((System.ComponentModel.ISupportInitialize)(this.MenuKodu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button IptalButonu;
        private System.Windows.Forms.Button KaydetButonu;
        private System.Windows.Forms.NumericUpDown MenuKodu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Miktar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Ad;
        private System.Windows.Forms.Label label2;
    }
}