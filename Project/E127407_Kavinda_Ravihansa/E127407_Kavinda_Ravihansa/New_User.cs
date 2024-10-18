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
    public partial class frmNewUser : Form
    {
        public frmNewUser()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-U53D910;Initial Catalog=Student;Integrated Security=True");

        private void button2_Click(object sender, EventArgs e)
        {
            txtUn.Clear();
            txtPw.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtUn.Text != "" && txtPw.Text != "")
            {
                con.Open();
                SqlCommand cmnd1 = new SqlCommand("Select username from Login where username = @UserName", con);
                cmnd1.Parameters.AddWithValue("username", txtUn.Text);
                SqlDataReader reader1 = cmnd1.ExecuteReader();
                if (reader1.Read())
                {
                    con.Close();
                    MessageBox.Show("Username already exists, please try again","Invalid Registration",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                else
                {
                    con.Close();
                    SqlCommand cmnd = new SqlCommand("Insert into Login(username,password)Values(@UserName,@Password)", con);
                    cmnd.Parameters.AddWithValue("username", txtUn.Text);
                    cmnd.Parameters.AddWithValue("password", txtPw.Text);
                    con.Open();
                    cmnd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Registration Succesful","User Registration",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);

                    txtUn.Clear();
                    txtPw.Clear();
                }
            }
            else
            {
                MessageBox.Show("Please enter username and password", "Incomplete Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void New_User_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmlogin login = new frmlogin();
            login.Show();
            this.Hide();
        }
    }
}
