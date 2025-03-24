using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolLibrary
{
    public partial class Form1 : Form
    {
         SqlConnection connection = new SqlConnection("Data Source = RıDVAN\\SQLEXPRESS; Initial Catalog = SchoolLibrary; Integrated Security = True");

        public Form1()
        {
            InitializeComponent();
            txtId.Clear();
            txtSifre.Clear();
        }

        private int Id;
        private string password;
        private string role;

        void LoginControl(int Id, string password)
        {
            try
            {
                string command = "SELECT * FROM Users WHERE user_id = @Id AND password = @password"; // SQL sorgusu düzeltildi

                using (SqlCommand sqlCommand = new SqlCommand(command, connection))
                {
                    connection.Open();
                    sqlCommand.Parameters.AddWithValue("@Id", Id); // Parametre adı doğru şekilde yazıldı
                    sqlCommand.Parameters.AddWithValue("@password", password); // Parametre adı doğru şekilde yazıldı

                    SqlDataReader reader = sqlCommand.ExecuteReader(); // ExecuteReader ile veriyi okuyoruz

                    if (reader.Read()) // Eğer veri varsa
                    {
                        string role = reader["role"].ToString(); // Role bilgisi alındı

                        if (role == "admin") // Eğer admin ise admin formu açılır
                        {
                            admin adminForm = new admin();
                            adminForm.Show();
                            this.Hide();
                        }
                        else // Eğer admin değilse sadece giriş ekranı gizlenir
                        {
                            user userfrom = new user();
                            userfrom.Show();
                            this.Hide();
                        }
                    }
                    else // Kullanıcı bulunamazsa
                    {
                        MessageBox.Show("Kullanıcı Bulunamadı");
                    }

                    connection.Close();
                }
            }
            catch (Exception e)
            {
                // Hata mesajını göstermek yerine daha detaylı bilgi almak için:
                MessageBox.Show("Hata: " + e.Message); // Hata mesajını kullanıcıya göstermek
                Console.WriteLine(e); // Hata hakkında daha fazla bilgi yazdırılır
            }
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            try
            {
                Id = int.Parse(txtId.Text);
                password = txtSifre.Text;
                LoginControl(Id,password);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception + "Hata Giriş Button");
                throw;
            }
        }

        private void checkbxSifreGoster_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbxSifreGoster.Checked)
            {
                txtSifre.PasswordChar = '\0';
            }
            else
            {
                txtSifre.PasswordChar = '*';
            }
        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Sadece sayı giriş 
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            
        }
    }
}
