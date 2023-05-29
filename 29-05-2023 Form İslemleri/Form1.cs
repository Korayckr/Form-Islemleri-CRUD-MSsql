using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _29_05_2023_Form_İslemleri
{
    public partial class Form1 : Form
    {




        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        public Form1()
        {
            InitializeComponent();
            passTxB.PasswordChar = '*';
        }

        private void girisBtn_Click(object sender, EventArgs e)
        {


            {
                string sorgu = "SELECT * FROM GirisBilgiler where username=@user AND pasword=@pass";
                con = new SqlConnection("data source = KORAYPC\\SQLEXPRESS; Initial Catalog=ldbLogin; Integrated Security=True");
                cmd = new SqlCommand(sorgu, con);
                cmd.Parameters.AddWithValue("@user", usernameTxB.Text);
                cmd.Parameters.AddWithValue("@pass", passTxB.Text);
                con.Open();

                dr = cmd.ExecuteReader();
                
                if (dr.Read())
                {
                    MessageBox.Show("Tebrikler Başarılı Bir Şekilde Giriş Yaptınız");

                    
                    
                    Form3 form3 = new Form3();
                    form3.veri = usernameTxB.Text;

                    form3.ShowDialog();


                    this.Hide();
                }
                else
                {

                    MessageBox.Show("Kullanıcı Adınızı ve Şifrenizi Kontrol Ediniz");

                }
                con.Close();
            }

            





        }

        private void usernameTxB_TextChanged(object sender, EventArgs e)
        {

        }

    }
}