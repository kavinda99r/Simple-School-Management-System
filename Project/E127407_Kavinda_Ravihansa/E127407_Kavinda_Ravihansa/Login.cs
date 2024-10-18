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
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-U53D910;Initial Catalog=Student;Integrated Security=True");

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Login " + " WHERE username=@User COLLATE SQL_Latin1_General_CP1_CS_AS AND password=@Password COLLATE SQL_Latin1_General_CP1_CS_AS";

            SqlCommand cmnd = new SqlCommand(query, con);

            con.Open();
            cmnd.Parameters.AddWithValue("@User", txtun.Text);
            cmnd.Parameters.AddWithValue("@Password", txtpw.Text);
            SqlDataReader reader = cmnd.ExecuteReader();

            if (reader.Read())
            {
                frmhome home = new frmhome();
                home.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Login credentials, please check Username and Password and try again","Invalid login Details",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            con.Close();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            DialogResult res_exit = MessageBox.Show("Are you sure, Do you really want to Exit...?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res_exit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtpw.Clear();
            txtun.Clear();
        }
    }
}
