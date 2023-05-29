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
    public partial class Form2 : Form
    {

        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        public Form2()
        {
            InitializeComponent();
        }

        private void anaSyfBtn_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();

            form3.Show();
            this.Hide();
        }

        private void ekleBtn_Click(object sender, EventArgs e)
        {
            string sorgu = "SELECT * FROM GirisBilgiler where username=@user AND pasword=@pass";
            con = new SqlConnection("data source = KORAYPC\\SQLEXPRESS; Initial Catalog=ldbLogin; Integrated Security=True");
            cmd = new SqlCommand(sorgu, con);
            {
                con.Open();

                
                string ad = isimTxb.Text;
                string soyad= soyadTxB.Text;
                string id = idTxB.Text;

                // aynı id de biri var mı kontrol et
                string checkQuery = "SELECT COUNT(*) FROM Kullanicilar WHERE id = @Data3";
                using (SqlCommand checkCommand = new SqlCommand(checkQuery, con))
                {
                    checkCommand.Parameters.AddWithValue("@Data3", id);
                    int existingUserCount = (int)checkCommand.ExecuteScalar();
                    if (existingUserCount > 0)
                    {
                        MessageBox.Show("Kullanıcı mevcut!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; 
                    }
                }


                
                string query = "INSERT INTO Kullanicilar (ad, soyad, id) VALUES (@Data1, @Data2, @Data3)";

                
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    // parametre ekle ve değerleri gir
                    command.Parameters.AddWithValue("@Data1", ad);
                    command.Parameters.AddWithValue("@Data2", soyad);
                    command.Parameters.AddWithValue("@Data3", id);


                    
                    command.ExecuteNonQuery();

                    
                }
                

            }
            MessageBox.Show("Kullanıcı Kaydedildi!!!");

        }

     
    }
}
