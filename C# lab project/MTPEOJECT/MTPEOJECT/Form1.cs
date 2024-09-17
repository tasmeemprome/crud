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
namespace MTPEOJECT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=LAPTOP-L8JGFSH4;Initial Catalog=MTPEOJECT;Integrated Security=True;TrustServerCertificate=True";
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();
            string FirstName = tbFirstName.Text;
            string LastName = tbLastName.Text;
            string Query = "INSERT INTO PROJECT(FirstName, LastName)VALUES('"+ FirstName + "','"+ LastName + "')";
            SqlCommand cmd = new SqlCommand(Query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Data has been saved");
        }
    }
}
