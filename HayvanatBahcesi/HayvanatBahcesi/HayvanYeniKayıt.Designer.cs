﻿namespace HayvanatBahcesi
{
    partial class HayvanYeniKayıt
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
            this.GelisTarihi = new System.Windows.Forms.DateTimePicker();
            this.Yas = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Tür = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Sinif = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.KaydetButonu = new System.Windows.Forms.Button();
            this.IptalButonu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Yas)).BeginInit();
            this.SuspendLayout();
            // 
            // GelisTarihi
            // 
            this.GelisTarihi.CustomFormat = "dd.MM.yyy";
            this.GelisTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GelisTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.GelisTarihi.Location = new System.Drawing.Point(228, 292);
            this.GelisTarihi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GelisTarihi.Name = "GelisTarihi";
            this.GelisTarihi.Size = new System.Drawing.Size(160, 30);
            this.GelisTarihi.TabIndex = 59;
            // 
            // Yas
            // 
            this.Yas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Yas.Location = new System.Drawing.Point(228, 232);
            this.Yas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Yas.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.Yas.Name = "Yas";
            this.Yas.Size = new System.Drawing.Size(160, 30);
            this.Yas.TabIndex = 58;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(103, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 25);
            this.label6.TabIndex = 57;
            this.label6.Text = "Yaş:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(102, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 25);
            this.label5.TabIndex = 56;
            this.label5.Text = "Geliş Tarihi:";
            // 
            // Tür
            // 
            this.Tür.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Tür.Location = new System.Drawing.Point(228, 182);
            this.Tür.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Tür.Name = "Tür";
            this.Tür.Size = new System.Drawing.Size(160, 30);
            this.Tür.TabIndex = 55;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(102, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 25);
            this.label3.TabIndex = 54;
            this.label3.Text = "Tür: ";
            // 
            // Sinif
            // 
            this.Sinif.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Sinif.Location = new System.Drawing.Point(228, 127);
            this.Sinif.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Sinif.Name = "Sinif";
            this.Sinif.Size = new System.Drawing.Size(160, 30);
            this.Sinif.TabIndex = 53;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(102, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 25);
            this.label2.TabIndex = 52;
            this.label2.Text = "Sınıf: ";
            // 
            // KaydetButonu
            // 
            this.KaydetButonu.Location = new System.Drawing.Point(108, 409);
            this.KaydetButonu.Name = "KaydetButonu";
            this.KaydetButonu.Size = new System.Drawing.Size(142, 56);
            this.KaydetButonu.TabIndex = 61;
            this.KaydetButonu.Text = "KAYDET";
            this.KaydetButonu.UseVisualStyleBackColor = true;
            this.KaydetButonu.Click += new System.EventHandler(this.KaydetButonu_Click_1);
            // 
            // IptalButonu
            // 
            this.IptalButonu.Location = new System.Drawing.Point(256, 409);
            this.IptalButonu.Name = "IptalButonu";
            this.IptalButonu.Size = new System.Drawing.Size(153, 56);
            this.IptalButonu.TabIndex = 62;
            this.IptalButonu.Text = "İPTAL";
            this.IptalButonu.UseVisualStyleBackColor = true;
            this.IptalButonu.Click += new System.EventHandler(this.IptalButonu_Click);
            // 
            // HayvanYeniKayıt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 538);
            this.Controls.Add(this.IptalButonu);
            this.Controls.Add(this.KaydetButonu);
            this.Controls.Add(this.GelisTarihi);
            this.Controls.Add(this.Yas);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Tür);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Sinif);
            this.Controls.Add(this.label2);
            this.Name = "HayvanYeniKayıt";
            this.Text = "HayvanYeniKayıt";
            this.Load += new System.EventHandler(this.HayvanYeniKayıt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Yas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker GelisTarihi;
        private System.Windows.Forms.NumericUpDown Yas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Tür;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Sinif;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button KaydetButonu;
        private System.Windows.Forms.Button IptalButonu;
    }
}