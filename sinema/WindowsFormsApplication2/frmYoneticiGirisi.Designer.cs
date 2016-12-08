namespace WindowsFormsApplication2
{
    partial class frmYoneticiGirisi
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnSorgulamaekrani = new System.Windows.Forms.Button();
            this.btnBiletSatis = new System.Windows.Forms.Button();
            this.btnFilmEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 79);
            this.button1.TabIndex = 7;
            this.button1.Text = "Film Sil";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSorgulamaekrani
            // 
            this.btnSorgulamaekrani.Location = new System.Drawing.Point(205, 172);
            this.btnSorgulamaekrani.Name = "btnSorgulamaekrani";
            this.btnSorgulamaekrani.Size = new System.Drawing.Size(119, 78);
            this.btnSorgulamaekrani.TabIndex = 6;
            this.btnSorgulamaekrani.Text = "Sorgulama Ekranı";
            this.btnSorgulamaekrani.UseVisualStyleBackColor = true;
            this.btnSorgulamaekrani.Click += new System.EventHandler(this.btnSorgulamaekrani_Click);
            // 
            // btnBiletSatis
            // 
            this.btnBiletSatis.Location = new System.Drawing.Point(205, 41);
            this.btnBiletSatis.Name = "btnBiletSatis";
            this.btnBiletSatis.Size = new System.Drawing.Size(119, 76);
            this.btnBiletSatis.TabIndex = 5;
            this.btnBiletSatis.Text = "Bilet Satış";
            this.btnBiletSatis.UseVisualStyleBackColor = true;
            this.btnBiletSatis.Click += new System.EventHandler(this.btnBiletSatis_Click);
            // 
            // btnFilmEkle
            // 
            this.btnFilmEkle.Location = new System.Drawing.Point(12, 41);
            this.btnFilmEkle.Name = "btnFilmEkle";
            this.btnFilmEkle.Size = new System.Drawing.Size(125, 76);
            this.btnFilmEkle.TabIndex = 4;
            this.btnFilmEkle.Text = "Film Ekle";
            this.btnFilmEkle.UseVisualStyleBackColor = true;
            this.btnFilmEkle.Click += new System.EventHandler(this.btnFilmEkle_Click);
            // 
            // frmYoneticiGirisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 323);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSorgulamaekrani);
            this.Controls.Add(this.btnBiletSatis);
            this.Controls.Add(this.btnFilmEkle);
            this.Name = "frmYoneticiGirisi";
            this.Text = "Yönetici Girişi";
            this.Load += new System.EventHandler(this.frmYoneticiGirisi_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSorgulamaekrani;
        private System.Windows.Forms.Button btnBiletSatis;
        private System.Windows.Forms.Button btnFilmEkle;
    }
}