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
    public partial class Edit_Title : Form
    {
        public Edit_Title()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Titlename = txtNewTitleName.Text;
            string Titletype = txtNewTitleType.Text;
            string Titleprice = txtNewTitlePrice.Text;

            string oid = txtID.Text;
            string oname = txtTitleName.Text;

            if (string.IsNullOrWhiteSpace(Titlename) || string.IsNullOrWhiteSpace(Titletype) ||
                string.IsNullOrWhiteSpace(Titleprice) || string.IsNullOrWhiteSpace(oid) || string.IsNullOrWhiteSpace(oname))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            try
            {
                string connectionString = "Data Source=YourServer;Initial Catalog=YourDatabase;Integrated Security=True";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string editQuery = "UPDATE titles SET title = @Titlename, type = @Titletype, price = @Titleprice WHERE title_id = @oid AND title = @oname";

                    using (SqlCommand command = new SqlCommand(editQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Titlename", Titlename);
                        command.Parameters.AddWithValue("@Titletype", Titletype);
                        command.Parameters.AddWithValue("@Titleprice", Titleprice);
                        command.Parameters.AddWithValue("@oid", oid);
                        command.Parameters.AddWithValue("@oname", oname);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Title has been edited!");
                        }
                        else
                        {
                            MessageBox.Show("No records were updated. Please check your input.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}
