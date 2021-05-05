namespace HayvanatBahcesi
{
    partial class MenüYeniKayit
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
            this.Ad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.IptalButonu = new System.Windows.Forms.Button();
            this.KaydetButonu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Ad
            // 
            this.Ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Ad.Location = new System.Drawing.Point(241, 149);
            this.Ad.Name = "Ad";
            this.Ad.Size = new System.Drawing.Size(180, 30);
            this.Ad.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(107, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 25);
            this.label2.TabIndex = 46;
            this.label2.Text = "Ad: ";
            // 
            // IptalButonu
            // 
            this.IptalButonu.Location = new System.Drawing.Point(268, 317);
            this.IptalButonu.Name = "IptalButonu";
            this.IptalButonu.Size = new System.Drawing.Size(153, 56);
            this.IptalButonu.TabIndex = 68;
            this.IptalButonu.Text = "İPTAL";
            this.IptalButonu.UseVisualStyleBackColor = true;
            this.IptalButonu.Click += new System.EventHandler(this.IptalButonu_Click);
            // 
            // KaydetButonu
            // 
            this.KaydetButonu.Location = new System.Drawing.Point(128, 317);
            this.KaydetButonu.Name = "KaydetButonu";
            this.KaydetButonu.Size = new System.Drawing.Size(142, 56);
            this.KaydetButonu.TabIndex = 67;
            this.KaydetButonu.Text = "KAYDET";
            this.KaydetButonu.UseVisualStyleBackColor = true;
            this.KaydetButonu.Click += new System.EventHandler(this.KaydetButonu_Click);
            // 
            // MenüYeniKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 467);
            this.Controls.Add(this.IptalButonu);
            this.Controls.Add(this.KaydetButonu);
            this.Controls.Add(this.Ad);
            this.Controls.Add(this.label2);
            this.Name = "MenüYeniKayit";
            this.Text = "MenüYeniKayit";
         
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Ad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button IptalButonu;
        private System.Windows.Forms.Button KaydetButonu;
    }
}