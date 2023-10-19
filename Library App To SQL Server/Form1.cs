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
    public partial class Form1 : Form
    {


        static SqlConnection connectionString = new SqlConnection(@"Data Source=DESKTOP-DGL558B;Initial Catalog=pubs;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public static DataTable dataAdapterSelect(string sqlQuery)
        {
            // This method will convert any Select string to a query.
            SqlDataAdapter DataAdapter = new SqlDataAdapter(sqlQuery, connectionString);
            DataTable dt = new DataTable();

            return dt;
        }
        // This method will convert any string that would manipulate the data to a query.
        public static void sqlCommandQueryReader(string sqlQuery)
        {
            SqlCommand myCommand = new SqlCommand(sqlQuery, connectionString);
            myCommand.Connection.Open();
            SqlDataReader dr;
            dr = myCommand.ExecuteReader();
            while (dr.Read())
            {

                Console.WriteLine(dr[0]);
                Console.WriteLine(dr[1]);
            }
            myCommand.Connection.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string sqlQuery = "SELECT title_id,title,type,pub_name,price,ytd_sales FROM titles inner join publishers ON titles.pub_id = publishers.pub_id";

            // Define columns programmatically
            dataGridView1.Columns.Add("title_id", "Title ID");
            dataGridView1.Columns.Add("pub_name", "Publisher Name");
            dataGridView1.Columns.Add("price", "Price");
            dataGridView1.Columns.Add("ytd_sales", "YTD Sales");
            dataGridView1.Columns.Add("title", "Title");
            dataGridView1.Columns.Add("type", "Type");

            DataTable dt = dataAdapterSelect(sqlQuery);

            foreach (DataRow dr in dt.Rows)

            {

                dataGridView1.Rows.Add(dr["title_id"], dr["pub_name"], dr["price"], dr["ytd_sales"], dr["title"], dr["type"]);

            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Add_Title add_Title = new Add_Title();
            add_Title.Show();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Delete_Title delete_Title = new Delete_Title();
            delete_Title.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Edit_Title edit_Title = new Edit_Title();
            edit_Title.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            string sqlQuery = "SELECT title_id,title,type,pub_name,price,ytd_sales FROM titles inner join publishers ON titles.pub_id = publishers.pub_id";

            DataTable dt = dataAdapterSelect(sqlQuery);

            foreach (DataRow dr in dt.Rows)
            {
                dataGridView1.Rows.Add(dr["title_id"], dr["pub_name"], dr["price"], dr["ytd_sales"], dr["title"], dr["type"]);
            }

            string sqlQuery2 = "select * from authors order by au_fname asc";
            DataTable dt2 = dataAdapterSelect(sqlQuery2);

            foreach (DataRow dr in dt2.Rows)
            {
                dataGridView2.Rows.Add(dr["au_id"], dr["au_fname"], dr["phone"], dr["address"], dr["city"]);
            }
            // This query will only display the count of the books that the author wrote on the DataGridView.
            string sqlQuery3 = "SELECT authors.au_fname,count(titleauthor.title_id) as authorcount FROM authors, titleauthor WHERE authors.au_id = titleauthor.au_id GROUP BY authors.au_fname";
            DataTable dt3 = dataAdapterSelect(sqlQuery3);

            foreach (DataRow dr in dt3.Rows)
            {
                dataGridView2.Rows.Add(dr["authorcount"]);
            }


        }

        private void Publishers_Click(object sender, EventArgs e)
        {

        }

        private void checkpub_Click(object sender, EventArgs e)
        {
            string PubID = txtPubID.Text;
            string sqlQuery00 = "select * from  publishers where publishers.pub_id='" + PubID + "'";
            DataTable dt00 = dataAdapterSelect(sqlQuery00);

            if (dt00.Rows.Count > 0)
            {
                foreach (DataRow dr in dt00.Rows)
                {
                    dataGridView3.Rows.Clear();
                    dataGridView3.Rows.Add(dr["pub_id"], dr["pub_name"], dr["city"], dr["state"], dr["country"]);
                }
            }
            else
            {
                MessageBox.Show("This Id is does not exist!");
            }

            string q5 = " select * from stores left outer join discounts on stores.stor_id = discounts.stor_id ";
            DataTable q55 =dataAdapterSelect(q5);

            foreach (DataRow dr in q55.Rows)
            {
                dataGridView4.Rows.Add(dr["stor_name"], dr["discount"]);
            }

            string sqlQuery = "SELECT title_id,title,type,pub_name,price,ytd_sales FROM titles inner join publishers ON titles.pub_id = publishers.pub_id";
            DataTable dt = new DataTable();

            dt = dataAdapterSelect(sqlQuery);
            foreach (DataRow dr in dt.Rows)
            {
                dataGridView1.Rows.Add(dr["title_id"], dr["pub_name"], dr["price"], dr["ytd_sales"], dr["title"], dr["type"]);
            }
            // This query will display all the information about the authors on the DataGridView.
            string sqlQuery2 = "select * from authors order by au_fname asc";
            DataTable dt2 = dataAdapterSelect(sqlQuery2);

            foreach (DataRow dr in dt2.Rows)
            {
                dataGridView3.Rows.Add(dr["au_id"], dr["au_fname"], dr["phone"], dr["address"], dr["city"]);
            }
            // This query will only display the count of the books that the author wrote on the DataGridView.
            string sqlQuery3 = "SELECT authors.au_fname,count(titleauthor.title_id) as authorcount FROM authors, titleauthor WHERE authors.au_id = titleauthor.au_id GROUP BY authors.au_fname";
            DataTable dt3 = dataAdapterSelect(sqlQuery3);

            foreach (DataRow dr in dt3.Rows)
            {
                dataGridView4.Rows.Add(dr["authorcount"]);
            }
            string q5 = " select * from stores left outer join discounts on stores.stor_id = discounts.stor_id ";
            DataTable q55 = dataAdapterSelect(q5);

            foreach (DataRow dr in q55.Rows)
            {
                dataGridView4.Rows.Add(dr["stor_name"], dr["discount"]);
            }



        }

    }

}
    

