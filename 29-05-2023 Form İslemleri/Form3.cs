using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _29_05_2023_Form_İslemleri
{
    public partial class Form3 : Form
    {
        public string veri;

        public Form3()
        {
            InitializeComponent();
            
        }

        public Form3(string veri)
        {
            this.veri = veri;
            
        }

        private void kullaniciEkBtn_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            form2.Show();
            this.Hide();

        }

        private void kullaniciSilBtn_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();

            form4.Show();
            this.Hide();

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            veriLbl.Text = veri;
        }
    }
}
