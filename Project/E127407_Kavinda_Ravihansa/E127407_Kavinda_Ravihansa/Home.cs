using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E127407_Kavinda_Ravihansa
{
    public partial class frmhome : Form
    {
        public frmhome()
        {
            InitializeComponent();
            customizeDesign();
        }

        private void customizeDesign()
        {
            studentSubmenu.Visible = false;
            teacherSubmenu.Visible = false;
        }

        private void hideSubmenu()
        {
            if (studentSubmenu.Visible == true)
                studentSubmenu.Visible = false;

            if (teacherSubmenu.Visible == true)
                teacherSubmenu.Visible = false;
        }

        private void showSubMenu(Panel studentSubmenu)
        {
            if (studentSubmenu.Visible == false)
            {
                hideSubmenu();
                studentSubmenu.Visible = true;
            }
            else
                studentSubmenu.Visible = false;
        }

        private void frmhome_Load(object sender, EventArgs e)
        {

        }

        private void btnstudent_Click(object sender, EventArgs e)
        {
            showSubMenu(studentSubmenu);
        }

        private void btnteacher_Click(object sender, EventArgs e)
        {
            showSubMenu(teacherSubmenu);
        }

        private void btnStudentRegister_Click(object sender, EventArgs e)
        {
            frmreg frmstudentreg = new frmreg();
            frmstudentreg.Show();
            this.Hide();
        }

        private void btnTeacherRegister_Click(object sender, EventArgs e)
        {
            frmteacher frmteacherreg = new frmteacher();
            frmteacherreg.Show();
            this.Hide();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildform.Controls.Add(childForm);
            panelChildform.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnStudentDetails_Click(object sender, EventArgs e)
        {
            openChildForm(new frmStudentDetails());
            hideSubmenu();
        }

        private void btnTeacherDetails_Click(object sender, EventArgs e)
        {
            openChildForm(new frmTeacherDetails());
            hideSubmenu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult res_exit = MessageBox.Show("Are you sure, Do you really want to Exit...?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res_exit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmlogin login = new frmlogin();
            login.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openChildForm(new frmUsers());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmNewUser newuser = new frmNewUser();
            newuser.Show();
            this.Hide();
        }
    }
}
