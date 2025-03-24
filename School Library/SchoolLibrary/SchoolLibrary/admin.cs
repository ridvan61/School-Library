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
    public partial class admin : Form
    {
        SqlConnection connection = new SqlConnection("Data Source = RıDVAN\\SQLEXPRESS; Initial Catalog = SchoolLibrary; Integrated Security = True");

        public admin()
        {
            InitializeComponent();
            groupBox1.Visible=false;
            groupBox2.Visible=false;
            groupBox3.Visible=false;
            groupBox4.Visible = false;
        }

        private int Id;
        private string password;

        void AddUser(string password)
        {
            string command = "insert into Users(password) Values(@password)";
            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source = RıDVAN\\SQLEXPRESS; Initial Catalog = SchoolLibrary; Integrated Security = True")) ;
                {
                    connection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand(command, connection))
                    {
                        sqlCommand.Parameters.AddWithValue("@password", password);
                        sqlCommand.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Kayıt İşleminiz Tamamlandı");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "HATA adduser");
                throw;
            }
        }

        void DeleteUser(int Id)
        {
            try
            {
                string command = "delete from Users where @Id=user_id";
                using (SqlConnection connection = new SqlConnection("Data Source = RıDVAN\\SQLEXPRESS; Initial Catalog = SchoolLibrary; Integrated Security = True")) ;
                {
                    connection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand(command, connection))
                    {
                        sqlCommand.Parameters.AddWithValue("@Id", Id);
                        sqlCommand.ExecuteNonQuery();

                    }
                }
                MessageBox.Show("Silme İşleminiz Başarılı");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "HATA deleteuser");
                throw;
            }
        }

        void NewPassword(int Id,string password)
        {
            try
            {
                string command = "update Users set password=@password where user_id=@Id";

                using (SqlConnection connection = new SqlConnection("Data Source = RıDVAN\\SQLEXPRESS; Initial Catalog = SchoolLibrary; Integrated Security = True"))
                {
                    connection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand(command, connection))
                    {
                        sqlCommand.Parameters.AddWithValue("@Id", Id);
                        sqlCommand.Parameters.AddWithValue("@password", password);
                        sqlCommand.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Şifre Değişme İşleminiz Başarılı");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        void AddBook(string title,string author, string isbn,bool status)
        {
            try
            {
                string command = "insert into Books(title,author,isbn,status) Values(@title,@author,@isbn,@status)";
                using (SqlConnection connection = new SqlConnection("Data Source = RıDVAN\\SQLEXPRESS; Initial Catalog = SchoolLibrary; Integrated Security = True"))
                {
                    using (SqlCommand sqlcommand=new SqlCommand(command,connection))
                    {
                        connection.Open();
                        sqlcommand.Parameters.AddWithValue("@title", title);
                        sqlcommand.Parameters.AddWithValue("@author", author);
                        sqlcommand.Parameters.AddWithValue("@isbn", isbn);
                        sqlcommand.Parameters.AddWithValue("@status", status);
                        sqlcommand.ExecuteNonQuery();
                    }
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message+"Hata AddBook");
            }
        }
        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Visible=true;
            groupBox2.Visible = false;
            groupBox3.Visible= false;
            groupBox4.Visible=false;
        }

        private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox2.Visible=true;
            groupBox1.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
        }

        private void txtboxId_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtboxPassword_TextChanged(object sender, EventArgs e)
        {
            password=txtboxPassword.Text;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Id = int.Parse(txtboxId.Text);
                DeleteUser(Id);
                ClearTextBox();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                AddUser(password);
                ClearTextBox();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }

        private void btnChanged_Click(object sender, EventArgs e)
        {
            try
            {
                int  Id=int.Parse(txtPasswordId.Text);
                string oldpassword=txtold.Text;
                string newpassword=txtnew.Text;
                if (textBox1.Text==txtnew.Text)
                {
                    NewPassword(Id,newpassword);
                    ClearTextBox();
                }
                else
                {
                    MessageBox.Show("Lütfen yeni şifreyi tekrar giriniz");
                    txtnew.Clear();
                    textBox1.Clear();
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) &&! char.IsControl(e.KeyChar);
        }

        private void passwordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = true;
            groupBox4.Visible = false;

        }

        private void addBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = true;
        }

        private void btnBookCreate_Click(object sender, EventArgs e)
        {
            string author=txtWriter.Text;
            string title=txtName.Text;
            string isbn;
            Random random = new Random();
            isbn="978"+random.Next(100000000,999999999).ToString();
            AddBook(title,author,isbn,true);
            MessageBox.Show($"Kitabınız Oluştu {isbn} isbn numarası ile işlemlerinizi gerçekleştirebilirsiniz");
            ClearTextBox();
        }

        void ClearTextBox()
        {
            txtWriter.Clear();
            txtName.Clear();
            textBox1.Clear();
            txtboxId.Clear();
            txtboxPassword.Clear();
            txtnew.Clear();
            txtold.Clear();
            txtPasswordId.Clear();
            
        }
    }
}
