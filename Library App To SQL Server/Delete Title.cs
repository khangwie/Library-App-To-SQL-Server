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

namespace Library_App_To_SQL_Server
{
    public partial class Delete_Title : Form
    {
        public Delete_Title()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string titleId = txtTitleID.Text;

            if (string.IsNullOrEmpty(titleId))
            {
                MessageBox.Show("Please enter a title id!");
                return;
            }

            try
            {
                string connectionString = "Data Source=YourServer;Initial Catalog=YourDatabase;Integrated Security=True";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string deleteQuery = "DELETE FROM roysched WHERE title_id=@title_id; " +
                                         "DELETE FROM sales WHERE title_id=@title_id; " +
                                         "DELETE FROM titles WHERE title_id=@title_id;";

                    using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                    {
                        command.Parameters.AddWithValue("@title_id", titleId);
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Title has been deleted!");
                        }
                        else
                        {
                            MessageBox.Show("No records found with the provided title id.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }    }
    }
}
