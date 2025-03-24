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
    public partial class user : Form
    {
        SqlConnection connection = new SqlConnection("Data Source = RıDVAN\\SQLEXPRESS; Initial Catalog = SchoolLibrary; Integrated Security = True");
        public user()
        {
            InitializeComponent();
            groupBox1.Visible=false;
            groupBox2.Visible=false;
        }

        private void sourceBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
        }

        void Status(string isbn)
        {
            try
            {
                bool status = false;
                using (SqlConnection connection = new SqlConnection("Data Source = RıDVAN\\SQLEXPRESS; Initial Catalog = SchoolLibrary; Integrated Security = True"))
                {
                    string Command = "Update Books set status=@status where isbn=@isbn";
                    using (SqlCommand sqlCommand = new SqlCommand(Command, connection))
                    {
                        connection.Open();
                        sqlCommand.Parameters.AddWithValue("@isbn",isbn);
                        sqlCommand.Parameters.AddWithValue("@status", status);
                        sqlCommand.ExecuteNonQuery();
                        
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        void ControlBook(string isbn)
        {
            string date;
            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source = RıDVAN\\SQLEXPRESS; Initial Catalog = SchoolLibrary; Integrated Security = True"))
                {
                    string Command = "select b.return_date from Books a left join BorrowedBooks b on a.book_id=b.book_id where a.isbn=@isbn";
                    using (SqlCommand sqlCommand = new SqlCommand(Command, connection))
                    {
                        connection.Open();
                        sqlCommand.Parameters.AddWithValue("@isbn",isbn);
                        sqlCommand.ExecuteNonQuery();

                        SqlDataReader reader = sqlCommand.ExecuteReader();
                        if (reader.Read())
                        {
                            date = reader["return_date"].ToString();
                            if (date==null)
                            {
                                MessageBox.Show("Kitap Başka Kişide");
                            }
                        }
                    }
                }
               

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        bool StatusCheck(string isbn)
        {
            bool statusbool=true;
            try
            {
                string status;
                using (SqlConnection connection = new SqlConnection(
                           "Data Source = RıDVAN\\SQLEXPRESS; Initial Catalog = SchoolLibrary; Integrated Security = True"))
                {
                    string Command = "select status from Books where @isbn=isbn";
                    using (SqlCommand sqlCommand = new SqlCommand(Command, connection))
                    {
                        connection.Open();
                        sqlCommand.Parameters.AddWithValue("@isbn", isbn);
                        sqlCommand.ExecuteNonQuery();
                        SqlDataReader drReader = sqlCommand.ExecuteReader();
                        if (drReader.Read())
                        {
                            status = drReader["status"].ToString();
                            if (status == "False")
                            {
                                MessageBox.Show("Kitap Başkasonda");
                                statusbool=false;
                            }
                        }


                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            return statusbool;
        }

        void Book(int student_id,int book_id,DateTime borrow_date)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source = RıDVAN\\SQLEXPRESS; Initial Catalog = SchoolLibrary; Integrated Security = True"))
                {
                    string command = "insert into BorrowedBooks(student_id,book_id,borrow_date) Values(@student_id,@book_id,@borrow_date) ";
                    connection.Open();
                    using (SqlCommand sqlCommand=new SqlCommand(command,connection))
                    {
                        sqlCommand.Parameters.AddWithValue("@student_id", student_id);
                        sqlCommand.Parameters.AddWithValue("@book_id", book_id);
                        sqlCommand.Parameters.AddWithValue("@borrow_date", borrow_date);
                        sqlCommand.ExecuteNonQuery();

                    }
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        private int book_Id;
        void BookId(string isbn)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source = RıDVAN\\SQLEXPRESS; Initial Catalog = SchoolLibrary; Integrated Security = True"))
                {
                    string command = "select book_id from Books where isbn=@isbn ";
                    using (SqlCommand sqlCommand = new SqlCommand(command, connection))
                    {
                        connection.Open();
                        sqlCommand.Parameters.AddWithValue("@isbn", isbn);
                        sqlCommand.ExecuteNonQuery();
                        SqlDataReader reader = sqlCommand.ExecuteReader();
                        if (reader.Read())
                        {
                            book_Id =int.Parse(reader["book_id"].ToString()) ;
                        }

                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        int id;
        private void BookGive(int book_id,int student_id,DateTime borrow_date)
        {
            try
            {
                string command ="insert into BorrowedBooks(student_id,book_id,borrow_date) Values(@student_id,@book_id,@borrow_date)";
                using (SqlConnection connection = new SqlConnection("Data Source = RıDVAN\\SQLEXPRESS; Initial Catalog = SchoolLibrary; Integrated Security = True"))
                {
                    using (SqlCommand sqlCommand=new SqlCommand(command,connection))
                    {
                        connection.Open();
                        sqlCommand.Parameters.AddWithValue("@book_id", book_id);
                        sqlCommand.Parameters.AddWithValue("@student_id", student_id);
                        sqlCommand.Parameters.AddWithValue("@borrow_date", borrow_date);
                        sqlCommand.ExecuteNonQuery();
                    }
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message+"Hata BookGive");
            }
        }
        private void studentid(int student_number)
        {
            try
            {
                string command = "select student_id from Students where student_number=@student_number";
                using (SqlConnection connection = new SqlConnection("Data Source = RıDVAN\\SQLEXPRESS; Initial Catalog = SchoolLibrary; Integrated Security = True"))
                {
                    connection.Open ();
                    using (SqlCommand sqlCommand=new SqlCommand(command,connection))
                    {
                        SqlDataReader dataReader = sqlCommand.ExecuteReader();

                        if (dataReader.Read()) 
                        {
                            id = int.Parse(dataReader["student_id"].ToString());                        
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + "Hata student_id");
            }
        }

        private void btnControl_Click(object sender, EventArgs e)
        {
            string isbn = txtControl.Text;
            ControlBook(isbn);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string isbn = textBox1.Text;
            int studentId = int.Parse(txtIdstudent.Text);
            StatusCheck(isbn);
            BookId(isbn);
            Status(isbn);
            Book(studentId,book_Id,DateTime.Now);

        }

        private void kitapVerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = true;
            groupBox3.Visible = false;
        }

        private void kitapİadeEtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible= true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int student_id = int.Parse(textBox2.Text);
            studentid(student_id);
            string isbn = textBox3.Text;
            BookId(isbn);

            BookGive(id,book_Id,DateTime.Now);
        }
    }
}
