namespace HayvanatBahcesi
{
    partial class HayvanBakiciYeniKayit
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
            this.Gorev = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.NumericUpDown();
            this.BakiciSicilNo = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IptalButonu = new System.Windows.Forms.Button();
            this.KaydetButonu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BakiciSicilNo)).BeginInit();
            this.SuspendLayout();
            // 
            // Gorev
            // 
            this.Gorev.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Gorev.Location = new System.Drawing.Point(295, 239);
            this.Gorev.Name = "Gorev";
            this.Gorev.Size = new System.Drawing.Size(160, 30);
            this.Gorev.TabIndex = 98;
            // 
            // ID
            // 
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ID.Location = new System.Drawing.Point(295, 135);
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
            this.ID.TabIndex = 97;
            this.ID.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // BakiciSicilNo
            // 
            this.BakiciSicilNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BakiciSicilNo.Location = new System.Drawing.Point(295, 191);
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
            this.BakiciSicilNo.TabIndex = 96;
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
            this.label6.Location = new System.Drawing.Point(148, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 25);
            this.label6.TabIndex = 95;
            this.label6.Text = "Görev:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(148, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 25);
            this.label3.TabIndex = 94;
            this.label3.Text = "Bakıcı Sicil No: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(148, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 25);
            this.label2.TabIndex = 93;
            this.label2.Text = "Hayvan ID: ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // IptalButonu
            // 
            this.IptalButonu.Location = new System.Drawing.Point(301, 348);
            this.IptalButonu.Name = "IptalButonu";
            this.IptalButonu.Size = new System.Drawing.Size(153, 56);
            this.IptalButonu.TabIndex = 100;
            this.IptalButonu.Text = "İPTAL";
            this.IptalButonu.UseVisualStyleBackColor = true;
            this.IptalButonu.Click += new System.EventHandler(this.IptalButonu_Click);
            // 
            // KaydetButonu
            // 
            this.KaydetButonu.Location = new System.Drawing.Point(153, 348);
            this.KaydetButonu.Name = "KaydetButonu";
            this.KaydetButonu.Size = new System.Drawing.Size(142, 56);
            this.KaydetButonu.TabIndex = 99;
            this.KaydetButonu.Text = "KAYDET";
            this.KaydetButonu.UseVisualStyleBackColor = true;
            this.KaydetButonu.Click += new System.EventHandler(this.KaydetButonu_Click);
            // 
            // HayvanBakiciYeniKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 505);
            this.Controls.Add(this.IptalButonu);
            this.Controls.Add(this.KaydetButonu);
            this.Controls.Add(this.Gorev);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.BakiciSicilNo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "HayvanBakiciYeniKayit";
            this.Text = "HayvanBakiciYeniKayit";
            ((System.ComponentModel.ISupportInitialize)(this.ID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BakiciSicilNo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Gorev;
        private System.Windows.Forms.NumericUpDown ID;
        private System.Windows.Forms.NumericUpDown BakiciSicilNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button IptalButonu;
        private System.Windows.Forms.Button KaydetButonu;
    }
}