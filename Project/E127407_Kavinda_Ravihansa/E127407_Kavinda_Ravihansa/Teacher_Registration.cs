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
    public partial class frmteacher : Form
    {
        public frmteacher()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-U53D910;Initial Catalog=Student;Integrated Security=True");

        private void frmteacher_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmnd = new SqlCommand();
                cmnd.Connection = con;
                string query = "SELECT * FROM Registration_Teacher";
                cmnd.CommandText = query;

                SqlDataReader reader = cmnd.ExecuteReader();
                while (reader.Read())
                {
                    comboreg.Items.Add(reader["regNo"]);
                }
                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        private void comboreg_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string quert_search = "SELECT * FROM Registration_Teacher WHERE regNo = '" + int.Parse(comboreg.Text) + "'";
                SqlCommand cmnd = new SqlCommand(quert_search, con);
                SqlDataReader reader = cmnd.ExecuteReader();
                while (reader.Read())
                {
                    txtfnm.Text = reader[1].ToString();
                    txtlnm.Text = reader[2].ToString();
                    txtnic.Text = reader[3].ToString();
                    dob.Text = reader[4].ToString();
                    string gender = reader[5].ToString();
                    if (gender == "Male")
                    {
                        radiom.Checked = true;
                    }
                    else
                    {
                        radiof.Checked = true;
                    }
                    txtaddress.Text = reader[6].ToString();
                    txtmobile.Text = reader[7].ToString();
                    txtphone.Text = reader[8].ToString();
                }
                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error while searching, Please restart the form!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnreg_Click(object sender, EventArgs e)
        {
            try
            {
                string regno = comboreg.Text;
                string fnm = txtfnm.Text;
                string lnm = txtlnm.Text;
                string gender;
                if (radiom.Checked)
                {
                    gender = "Male";
                }
                else
                {
                    gender = "Female";
                }
                string date = dob.Text;
                string address = txtaddress.Text;
                string nic = txtnic.Text;
                int mobile = int.Parse(txtmobile.Text);
                int home = int.Parse(txtphone.Text);

                con.Open();
                string select = "SELECT * FROM Registration_Teacher WHERE regNo = '" + comboreg.Text + "'";
                SqlCommand cmnd1 = new SqlCommand(select, con);
                SqlDataReader reader1 = cmnd1.ExecuteReader();
                if (reader1.Read())
                {
                    con.Close();
                    MessageBox.Show("Registration number already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (txtfnm.Text != "" && txtlnm.Text != "" && txtaddress.Text != "" && txtmobile.Text != "" && txtphone.Text != "" && txtnic.Text != "" && comboreg.Text != "")
                    {
                        con.Close();
                        string query_insert = "INSERT INTO Registration_Teacher(regNo,firstName,lastName,gender,address,nic,dateOfBirth,mobilePhone,homePhone)" + "VALUES('" + regno + "','" + fnm + "','" + lnm + "','" + gender + "','" + address + "','" + nic + "','" + date + "'," + mobile + "," + home + ");";

                        SqlCommand cmnd = new SqlCommand(query_insert, con);
                        con.Open();
                        cmnd.ExecuteNonQuery();
                        MessageBox.Show("Record Added Succesfully", "Register Teacher", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    }
                    else
                    {
                        MessageBox.Show("Please fill all details", "Incomplete Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Incomplete Form, Please Fill all details and try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                string regno = comboreg.Text;
                string fnm = txtfnm.Text;
                string lnm = txtlnm.Text;
                string gender;
                if (radiom.Checked)
                {
                    gender = "Male";
                }
                else
                {
                    gender = "Female";
                }
                string date = dob.Text;
                string address = txtaddress.Text;
                string nic = txtnic.Text;
                int mobile = int.Parse(txtmobile.Text);
                int home = int.Parse(txtphone.Text);

                if (txtfnm.Text != "" && txtlnm.Text != "" && txtaddress.Text != "" && txtmobile.Text != "" && txtphone.Text != "" && txtnic.Text != "" && comboreg.Text != "")
                {
                    string query_update = "UPDATE Registration_Teacher SET firstName = '" + fnm + "',lastName = '" + lnm + "',dateOfBirth = '" + date + "',gender = '" + gender + "',address = '" + address + "',mobilePhone = '" + mobile + "',homePhone = '" + home + "',nic = '" + nic + "' WHERE regNo = '" + regno + "'";
                    SqlCommand cmnd = new SqlCommand(query_update, con);
                    con.Open();
                    cmnd.ExecuteNonQuery();
                    MessageBox.Show("Record Updated succesfully", "Update Teacher", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Please fill all details", "Incomplete Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Please select a registration number or fill all details and try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboreg.Text != "")
                {
                    DialogResult res_exit = MessageBox.Show("Are you sure,Do you really want to Delete this Record...?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (res_exit == DialogResult.Yes)
                    {
                        string query_delete = "DELETE FROM Registration_Teacher WHERE regNo = '" + comboreg.Text + "'";
                        SqlCommand cmnd = new SqlCommand(query_delete, con);
                        con.Open();
                        cmnd.ExecuteNonQuery();
                        MessageBox.Show("Record Deleted succesfully", "Delete Teacher", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        con.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Please select a Registration number", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please select a registration number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtfnm.Clear();
            txtlnm.Clear();
            txtaddress.Clear();
            txtmobile.Clear();
            txtphone.Clear();
            txtnic.Clear();
        }

        private void lnklogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmlogin login = new frmlogin();
            login.Show();
            this.Hide();
        }

        private void lnkexit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult res_exit = MessageBox.Show("Are you sure, Do you really want to Exit...?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res_exit == DialogResult.Yes)
            {
                frmhome home = new frmhome();
                home.Show();
                this.Hide();
            }
        }
    }
}
