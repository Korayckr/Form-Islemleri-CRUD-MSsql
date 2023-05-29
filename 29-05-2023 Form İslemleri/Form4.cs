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
    public partial class Form4 : Form
    {

        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        public Form4()
        {
            InitializeComponent();
        }

        private void silBtn_Click(object sender, EventArgs e)
        {
            
                string sorgu = "SELECT * FROM GirisBilgiler where username=@user AND pasword=@pass";
                con = new SqlConnection("data source = KORAYPC\\SQLEXPRESS; Initial Catalog=ldbLogin; Integrated Security=True");
                cmd = new SqlCommand(sorgu, con);
                {
                    con.Open();

                    
           
                    int userid = Convert.ToInt32(kullaniciIdTxB.Text);


                string checkQuery = "SELECT COUNT(*) FROM Kullanicilar WHERE id = @id";
                using (SqlCommand checkCommand = new SqlCommand(checkQuery, con))
                {
                    checkCommand.Parameters.AddWithValue("@id", userid);
                    int existingUserCount = (int)checkCommand.ExecuteScalar();
                    if (existingUserCount == 0)
                    {
                        MessageBox.Show("Bu ID'ye sahip bir kullanıcı bulunmamaktadır!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; 
                    }
                }

                string query = "DELETE FROM Kullanicilar WHERE id = @id";

                    
                    using (SqlCommand command = new SqlCommand(query, con))
                    {
                    // parametre ekle ve değerleri gir
                    command.Parameters.AddWithValue("@id", userid);



                        
                        command.ExecuteNonQuery();
                    }
                }

            MessageBox.Show("Kullanıcı Silindi!!!");
        }

        private void anaSyfBtn_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();

            form3.Show();
            this.Hide();
        }
    }
}
