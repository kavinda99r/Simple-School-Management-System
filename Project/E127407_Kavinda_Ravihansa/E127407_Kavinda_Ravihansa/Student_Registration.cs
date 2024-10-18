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
    public partial class frmreg : Form
    {
        public frmreg()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-U53D910;Initial Catalog=Student;Integrated Security=True");

        private void frmreg_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmnd = new SqlCommand();
                cmnd.Connection = con;
                string query = "SELECT * FROM Registration";
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
                MessageBox.Show("Error","Error",MessageBoxButtons.OK,MessageBoxIcon.Question);
            }
        }

        private void comboreg_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                
                con.Open();
                string quert_search = "SELECT * FROM Registration WHERE regNo = '" + int.Parse(comboreg.Text) + "'";
                SqlCommand cmnd = new SqlCommand(quert_search, con);
                SqlDataReader reader = cmnd.ExecuteReader();
                while (reader.Read())
                {
                    txtfnm.Text = reader[1].ToString();
                    txtlnm.Text = reader[2].ToString();
                    dob.Text = reader[3].ToString();
                    string gender = reader[4].ToString();
                    if (gender == "Male")
                    {
                        radiom.Checked = true;
                    }
                    else
                    {
                        radiof.Checked = true;
                    }
                    txtaddress.Text = reader[5].ToString();
                    txtemail.Text = reader[6].ToString();
                    txtmobile.Text = reader[7].ToString();
                    txtphone.Text = reader[8].ToString();
                    txtparent.Text = reader[9].ToString();
                    txtnic.Text = reader[10].ToString();
                    txtcontact.Text = reader[11].ToString();
                }
                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error while searching, Please restart the form!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
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
                string email = txtemail.Text;
                string parent = txtparent.Text;
                string nic = txtnic.Text;
                int mobile = int.Parse(txtmobile.Text);
                int home = int.Parse(txtphone.Text);
                int contact = int.Parse(txtcontact.Text);

                con.Open();
                string select ="SELECT * FROM Registration WHERE regNo = '" + comboreg.Text + "'";
                SqlCommand cmnd1 = new SqlCommand(select, con);
                SqlDataReader reader1 = cmnd1.ExecuteReader();
                if(reader1.Read())
                {
                    con.Close();
                    MessageBox.Show("Registration number already exists","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                else
                {
                    if(txtfnm.Text !="" && txtlnm.Text !="" && txtaddress.Text !="" && txtemail.Text !="" && txtmobile.Text !="" && txtphone.Text !="" && txtparent.Text !="" && 
                        txtnic.Text !="" && txtcontact.Text !="" && comboreg.Text !="")
                    {
                        con.Close();
                        string query_insert = "INSERT INTO Registration(regNo,firstName,lastName,gender,address,email,parentName,nic,dateOfBirth,mobilePhone,homePhone,contactNo)" + "VALUES('" + regno + "','" + fnm + "','" + lnm + "','" + gender + "','" + address + "','" + email + "','" + parent + "','" + nic + "','" + date + "'," + mobile + "," + home + "," + contact + ");";

                        SqlCommand cmnd = new SqlCommand(query_insert, con);
                        con.Open();
                        cmnd.ExecuteNonQuery();
                        MessageBox.Show("Record Added Succesfully", "Register Student", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        
                    }
                    else
                    {
                        MessageBox.Show("Please fill all details","Incomplete Form",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                }
                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Incomplete Form, Please Fill all details and try again","Incomplete Form",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                string regno = comboreg.Text;
                string fnm = txtfnm.Text.Trim();
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
                string email = txtemail.Text;
                string parent = txtparent.Text;
                string nic = txtnic.Text;
                int mobile = int.Parse(txtmobile.Text);
                int home = int.Parse(txtphone.Text);
                int contact = int.Parse(txtcontact.Text);

                if (txtfnm.Text != "" && txtlnm.Text != "" && txtaddress.Text != "" && txtemail.Text != "" && txtmobile.Text != "" && txtphone.Text != "" && txtparent.Text != "" && txtnic.Text != "" && txtcontact.Text != "" && comboreg.Text != "")
                {
                    string query_update = "UPDATE Registration SET firstName = '" + fnm + "',lastName = '" + lnm + "',dateOfBirth = '" + date + "',gender = '" + gender + "',address = '" + address + "',email = '" + email + "',mobilePhone = '" + mobile + "',homePhone = '" + home + "',parentName = '" + parent + "',nic = '" + nic + "',contactNo = '" + contact + "' WHERE regNo = '" + regno + "'";
                    SqlCommand cmnd = new SqlCommand(query_update, con);
                    con.Open();
                    cmnd.ExecuteNonQuery();
                    MessageBox.Show("Record Updated succesfully", "Update Student", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Please fill all details","Incomplete Form",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                con.Close();
                
            }
            catch (Exception)
            {
                MessageBox.Show("Please select a registration number or fill all details and try again","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                if(comboreg.Text !="")
                {
                    DialogResult res_exit = MessageBox.Show("Are you sure,Do you really want to Delete this Record...?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (res_exit == DialogResult.Yes)
                    {
                        string query_delete = "DELETE FROM Registration WHERE regNo = '" + comboreg.Text + "'";
                        SqlCommand cmnd = new SqlCommand(query_delete, con);
                        con.Open();
                        cmnd.ExecuteNonQuery();
                        MessageBox.Show("Record Deleted succesfully", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        con.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Please select a Registration number","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }

            catch (Exception)
            {
                MessageBox.Show("Please select a registration number","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtfnm.Clear();
            txtlnm.Clear();
            txtaddress.Clear();
            txtemail.Clear();
            txtmobile.Clear();
            txtphone.Clear();
            txtparent.Clear();
            txtnic.Clear();
            txtcontact.Clear();
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
