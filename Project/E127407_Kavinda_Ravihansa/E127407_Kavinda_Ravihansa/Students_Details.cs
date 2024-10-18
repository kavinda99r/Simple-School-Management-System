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
    public partial class frmStudentDetails : Form
    {
        string connectionString = @"Data Source=DESKTOP-U53D910;Initial Catalog=Student;Integrated Security=True";
        public frmStudentDetails()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * FROM Registration", sqlCon);
                DataTable dTable = new DataTable();
                sqlData.Fill(dTable);

                dataGridViewStudent.DataSource = dTable;

            }

        }
    }
}
