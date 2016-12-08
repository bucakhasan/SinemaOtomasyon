namespace WindowsFormsApplication2
{
    partial class frmParolamiUnuttum
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.btnSifreGonder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "E-Mail";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(22, 53);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(224, 20);
            this.txtMail.TabIndex = 1;
            // 
            // btnSifreGonder
            // 
            this.btnSifreGonder.Location = new System.Drawing.Point(171, 90);
            this.btnSifreGonder.Name = "btnSifreGonder";
            this.btnSifreGonder.Size = new System.Drawing.Size(75, 23);
            this.btnSifreGonder.TabIndex = 2;
            this.btnSifreGonder.Text = "Şifre Gönder";
            this.btnSifreGonder.UseVisualStyleBackColor = true;
            this.btnSifreGonder.Click += new System.EventHandler(this.btnSifreGonder_Click);
            // 
            // frmParolamiUnuttum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(284, 160);
            this.Controls.Add(this.btnSifreGonder);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.label1);
            this.Name = "frmParolamiUnuttum";
            this.Text = "Parolamı Unuttum";
            this.Load += new System.EventHandler(this.frmParolamiUnuttum_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Button btnSifreGonder;
    }
}