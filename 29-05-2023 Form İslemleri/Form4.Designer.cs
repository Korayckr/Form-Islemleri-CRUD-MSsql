namespace _29_05_2023_Form_İslemleri
{
    partial class Form4
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
            this.label2 = new System.Windows.Forms.Label();
            this.kullaniciIdTxB = new System.Windows.Forms.TextBox();
            this.silBtn = new System.Windows.Forms.Button();
            this.anaSyfBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(341, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Sil";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kullanıcı ID:";
            // 
            // kullaniciIdTxB
            // 
            this.kullaniciIdTxB.Location = new System.Drawing.Point(237, 134);
            this.kullaniciIdTxB.Name = "kullaniciIdTxB";
            this.kullaniciIdTxB.Size = new System.Drawing.Size(100, 22);
            this.kullaniciIdTxB.TabIndex = 2;
            // 
            // silBtn
            // 
            this.silBtn.BackColor = System.Drawing.Color.CadetBlue;
            this.silBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.silBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.silBtn.Location = new System.Drawing.Point(224, 176);
            this.silBtn.Name = "silBtn";
            this.silBtn.Size = new System.Drawing.Size(123, 75);
            this.silBtn.TabIndex = 3;
            this.silBtn.Text = "Kullanıcı Sil";
            this.silBtn.UseVisualStyleBackColor = false;
            this.silBtn.Click += new System.EventHandler(this.silBtn_Click);
            // 
            // anaSyfBtn
            // 
            this.anaSyfBtn.BackColor = System.Drawing.Color.CadetBlue;
            this.anaSyfBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.anaSyfBtn.Location = new System.Drawing.Point(633, 392);
            this.anaSyfBtn.Name = "anaSyfBtn";
            this.anaSyfBtn.Size = new System.Drawing.Size(135, 46);
            this.anaSyfBtn.TabIndex = 4;
            this.anaSyfBtn.Text = "Ana Sayfa";
            this.anaSyfBtn.UseVisualStyleBackColor = false;
            this.anaSyfBtn.Click += new System.EventHandler(this.anaSyfBtn_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.anaSyfBtn);
            this.Controls.Add(this.silBtn);
            this.Controls.Add(this.kullaniciIdTxB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox kullaniciIdTxB;
        private System.Windows.Forms.Button silBtn;
        private System.Windows.Forms.Button anaSyfBtn;
    }
}