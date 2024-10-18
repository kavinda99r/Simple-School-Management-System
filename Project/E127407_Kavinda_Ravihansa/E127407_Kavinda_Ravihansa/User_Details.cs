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

namespace E127407_Kavinda_Ravihansa
{
    public partial class frmUsers : Form
    {
        public frmUsers()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-U53D910;Initial Catalog=Student;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            string unm=txtUser.Text;
            con.Open();
            SqlCommand cmnd = new SqlCommand();
            cmnd.Connection = con;
            string query = "SELECT * FROM Login WHERE username COLLATE SQL_Latin1_General_CP1_CS_AS = '" + unm + "'";
            cmnd.CommandText = query;

            SqlDataReader reader = cmnd.ExecuteReader();
            while (reader.Read())
            {
                txtPass.Text = reader[1].ToString();
            }
            con.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUser.Clear();
            txtPass.Clear();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
