namespace _29_05_2023_Form_İslemleri
{
    partial class Form3
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
            this.kullaniciEkBtn = new System.Windows.Forms.Button();
            this.kullaniciSilBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.veriLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // kullaniciEkBtn
            // 
            this.kullaniciEkBtn.BackColor = System.Drawing.Color.CadetBlue;
            this.kullaniciEkBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.kullaniciEkBtn.Location = new System.Drawing.Point(153, 182);
            this.kullaniciEkBtn.Name = "kullaniciEkBtn";
            this.kullaniciEkBtn.Size = new System.Drawing.Size(172, 85);
            this.kullaniciEkBtn.TabIndex = 0;
            this.kullaniciEkBtn.Text = "Kullanıcı Ekle";
            this.kullaniciEkBtn.UseVisualStyleBackColor = false;
            this.kullaniciEkBtn.Click += new System.EventHandler(this.kullaniciEkBtn_Click);
            // 
            // kullaniciSilBtn
            // 
            this.kullaniciSilBtn.BackColor = System.Drawing.Color.CadetBlue;
            this.kullaniciSilBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullaniciSilBtn.Location = new System.Drawing.Point(472, 182);
            this.kullaniciSilBtn.Name = "kullaniciSilBtn";
            this.kullaniciSilBtn.Size = new System.Drawing.Size(170, 89);
            this.kullaniciSilBtn.TabIndex = 1;
            this.kullaniciSilBtn.Text = "Kullanıcı Sil";
            this.kullaniciSilBtn.UseVisualStyleBackColor = false;
            this.kullaniciSilBtn.Click += new System.EventHandler(this.kullaniciSilBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(51, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hoş Geldiniz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(163, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 25);
            this.label2.TabIndex = 3;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // veriLbl
            // 
            this.veriLbl.AutoSize = true;
            this.veriLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.veriLbl.Location = new System.Drawing.Point(169, 60);
            this.veriLbl.Name = "veriLbl";
            this.veriLbl.Size = new System.Drawing.Size(64, 25);
            this.veriLbl.TabIndex = 4;
            this.veriLbl.Text = "label3";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.veriLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kullaniciSilBtn);
            this.Controls.Add(this.kullaniciEkBtn);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button kullaniciEkBtn;
        private System.Windows.Forms.Button kullaniciSilBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label veriLbl;
    }
}