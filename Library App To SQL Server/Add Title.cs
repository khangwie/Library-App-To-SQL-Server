using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_App_To_SQL_Server
{
    public partial class Add_Title : Form
    {
        public Add_Title()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string TitleID = txtID.Text;
            string titleName = txtName.Text;
            string titleType = txtTitleType.Text;
            string pubid = txtPubID.Text;
            string price = txtPrice.Text;
            string pubDate = txtPubDate.Text;

            string connectionString = "Data Source=your_server;Initial Catalog=your_database;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string insertQuery = "INSERT INTO titles (title_id, title, type, pub_id, price, pubdate) " +
                                         "VALUES (@titleID, @titleName, @titleType, @pubid, @price, @pubDate)";

                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@titleID", TitleID);
                        command.Parameters.AddWithValue("@titleName", titleName);
                        command.Parameters.AddWithValue("@titleType", titleType);
                        command.Parameters.AddWithValue("@pubid", pubid);
                        command.Parameters.AddWithValue("@price", price);
                        command.Parameters.AddWithValue("@pubDate", pubDate);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Information inserted!");
                        }
                        else
                        {
                            MessageBox.Show("Insertion failed.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

            }
        }
    }
}

