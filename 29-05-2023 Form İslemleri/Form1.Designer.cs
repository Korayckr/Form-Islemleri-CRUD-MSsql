namespace _29_05_2023_Form_İslemleri
{
    partial class Form1
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
            this.usernameTxB = new System.Windows.Forms.TextBox();
            this.passTxB = new System.Windows.Forms.TextBox();
            this.girisBtn = new System.Windows.Forms.Button();
            this.kayitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(80, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(80, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // usernameTxB
            // 
            this.usernameTxB.Location = new System.Drawing.Point(175, 87);
            this.usernameTxB.Name = "usernameTxB";
            this.usernameTxB.Size = new System.Drawing.Size(100, 22);
            this.usernameTxB.TabIndex = 2;
            this.usernameTxB.TextChanged += new System.EventHandler(this.usernameTxB_TextChanged);
            // 
            // passTxB
            // 
            this.passTxB.Location = new System.Drawing.Point(175, 132);
            this.passTxB.Name = "passTxB";
            this.passTxB.Size = new System.Drawing.Size(100, 22);
            this.passTxB.TabIndex = 3;
            // 
            // girisBtn
            // 
            this.girisBtn.BackColor = System.Drawing.Color.CadetBlue;
            this.girisBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.girisBtn.Location = new System.Drawing.Point(175, 195);
            this.girisBtn.Name = "girisBtn";
            this.girisBtn.Size = new System.Drawing.Size(86, 49);
            this.girisBtn.TabIndex = 4;
            this.girisBtn.Text = "Giriş";
            this.girisBtn.UseVisualStyleBackColor = false;
            this.girisBtn.Click += new System.EventHandler(this.girisBtn_Click);
            // 
            // kayitBtn
            // 
            this.kayitBtn.BackColor = System.Drawing.Color.CadetBlue;
            this.kayitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kayitBtn.Location = new System.Drawing.Point(175, 250);
            this.kayitBtn.Name = "kayitBtn";
            this.kayitBtn.Size = new System.Drawing.Size(86, 45);
            this.kayitBtn.TabIndex = 5;
            this.kayitBtn.Text = "Kayıt Ol";
            this.kayitBtn.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.kayitBtn);
            this.Controls.Add(this.girisBtn);
            this.Controls.Add(this.passTxB);
            this.Controls.Add(this.usernameTxB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox usernameTxB;
        private System.Windows.Forms.TextBox passTxB;
        private System.Windows.Forms.Button girisBtn;
        private System.Windows.Forms.Button kayitBtn;
    }
}

