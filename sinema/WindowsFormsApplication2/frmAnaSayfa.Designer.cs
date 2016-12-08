namespace WindowsFormsApplication2
{
    partial class frmAnaSayfa
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
            this.btnYoneticiGirisi = new System.Windows.Forms.Button();
            this.btnUyeGirisi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnYoneticiGirisi
            // 
            this.btnYoneticiGirisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYoneticiGirisi.Location = new System.Drawing.Point(511, 88);
            this.btnYoneticiGirisi.Name = "btnYoneticiGirisi";
            this.btnYoneticiGirisi.Size = new System.Drawing.Size(106, 272);
            this.btnYoneticiGirisi.TabIndex = 4;
            this.btnYoneticiGirisi.Text = "YÖNETİCİ GİRİŞİ";
            this.btnYoneticiGirisi.UseVisualStyleBackColor = true;
            this.btnYoneticiGirisi.Click += new System.EventHandler(this.btnYoneticiGirisi_Click);
            // 
            // btnUyeGirisi
            // 
            this.btnUyeGirisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUyeGirisi.Location = new System.Drawing.Point(356, 88);
            this.btnUyeGirisi.Name = "btnUyeGirisi";
            this.btnUyeGirisi.Size = new System.Drawing.Size(106, 272);
            this.btnUyeGirisi.TabIndex = 3;
            this.btnUyeGirisi.Text = "ÜYE GİRİŞİ";
            this.btnUyeGirisi.UseVisualStyleBackColor = true;
            this.btnUyeGirisi.Click += new System.EventHandler(this.btnUyeGirisi_Click);
            // 
            // frmAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 514);
            this.Controls.Add(this.btnYoneticiGirisi);
            this.Controls.Add(this.btnUyeGirisi);
            this.Name = "frmAnaSayfa";
            this.Text = "frmAnaSayfa";
            this.Load += new System.EventHandler(this.frmAnaSayfa_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnYoneticiGirisi;
        private System.Windows.Forms.Button btnUyeGirisi;
    }
}