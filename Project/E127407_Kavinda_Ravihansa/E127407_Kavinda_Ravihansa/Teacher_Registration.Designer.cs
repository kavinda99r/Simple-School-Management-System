namespace E127407_Kavinda_Ravihansa
{
    partial class frmteacher
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmteacher));
            this.btnreg = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.lnklogout = new System.Windows.Forms.LinkLabel();
            this.lnkexit = new System.Windows.Forms.LinkLabel();
            this.groupBoxRegistration = new System.Windows.Forms.GroupBox();
            this.comboreg = new System.Windows.Forms.ComboBox();
            this.lblreg = new System.Windows.Forms.Label();
            this.groupBoxContact = new System.Windows.Forms.GroupBox();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.txtmobile = new System.Windows.Forms.TextBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.lblphone = new System.Windows.Forms.Label();
            this.lblmobile = new System.Windows.Forms.Label();
            this.lbladdress = new System.Windows.Forms.Label();
            this.groupBoxBasic = new System.Windows.Forms.GroupBox();
            this.txtnic = new System.Windows.Forms.TextBox();
            this.lblnic = new System.Windows.Forms.Label();
            this.radiof = new System.Windows.Forms.RadioButton();
            this.txtlnm = new System.Windows.Forms.TextBox();
            this.dob = new System.Windows.Forms.DateTimePicker();
            this.radiom = new System.Windows.Forms.RadioButton();
            this.txtfnm = new System.Windows.Forms.TextBox();
            this.lblgender = new System.Windows.Forms.Label();
            this.lbldob = new System.Windows.Forms.Label();
            this.lbllnm = new System.Windows.Forms.Label();
            this.lblfnm = new System.Windows.Forms.Label();
            this.lblskills = new System.Windows.Forms.Label();
            this.groupBoxRegistration.SuspendLayout();
            this.groupBoxContact.SuspendLayout();
            this.groupBoxBasic.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnreg
            // 
            this.btnreg.Location = new System.Drawing.Point(20, 536);
            this.btnreg.Name = "btnreg";
            this.btnreg.Size = new System.Drawing.Size(78, 29);
            this.btnreg.TabIndex = 0;
            this.btnreg.Text = "Register";
            this.btnreg.UseVisualStyleBackColor = true;
            this.btnreg.Click += new System.EventHandler(this.btnreg_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(104, 537);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(78, 29);
            this.btnupdate.TabIndex = 1;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(275, 536);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(78, 29);
            this.btnclear.TabIndex = 2;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(359, 537);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(78, 29);
            this.btndelete.TabIndex = 3;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // lnklogout
            // 
            this.lnklogout.AutoSize = true;
            this.lnklogout.Location = new System.Drawing.Point(9, 9);
            this.lnklogout.Name = "lnklogout";
            this.lnklogout.Size = new System.Drawing.Size(40, 13);
            this.lnklogout.TabIndex = 4;
            this.lnklogout.TabStop = true;
            this.lnklogout.Text = "Logout";
            this.lnklogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklogout_LinkClicked);
            // 
            // lnkexit
            // 
            this.lnkexit.AutoSize = true;
            this.lnkexit.Location = new System.Drawing.Point(442, 635);
            this.lnkexit.Name = "lnkexit";
            this.lnkexit.Size = new System.Drawing.Size(24, 13);
            this.lnkexit.TabIndex = 5;
            this.lnkexit.TabStop = true;
            this.lnkexit.Text = "Exit";
            this.lnkexit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkexit_LinkClicked);
            // 
            // groupBoxRegistration
            // 
            this.groupBoxRegistration.Controls.Add(this.comboreg);
            this.groupBoxRegistration.Controls.Add(this.lblreg);
            this.groupBoxRegistration.Controls.Add(this.groupBoxContact);
            this.groupBoxRegistration.Controls.Add(this.btnreg);
            this.groupBoxRegistration.Controls.Add(this.btnupdate);
            this.groupBoxRegistration.Controls.Add(this.groupBoxBasic);
            this.groupBoxRegistration.Controls.Add(this.btnclear);
            this.groupBoxRegistration.Controls.Add(this.btndelete);
            this.groupBoxRegistration.Location = new System.Drawing.Point(12, 52);
            this.groupBoxRegistration.Name = "groupBoxRegistration";
            this.groupBoxRegistration.Size = new System.Drawing.Size(454, 580);
            this.groupBoxRegistration.TabIndex = 6;
            this.groupBoxRegistration.TabStop = false;
            this.groupBoxRegistration.Text = "Teacher Registration";
            // 
            // comboreg
            // 
            this.comboreg.FormattingEnabled = true;
            this.comboreg.Location = new System.Drawing.Point(131, 27);
            this.comboreg.Name = "comboreg";
            this.comboreg.Size = new System.Drawing.Size(121, 21);
            this.comboreg.TabIndex = 8;
            this.comboreg.SelectedIndexChanged += new System.EventHandler(this.comboreg_SelectedIndexChanged);
            // 
            // lblreg
            // 
            this.lblreg.AutoSize = true;
            this.lblreg.Location = new System.Drawing.Point(39, 30);
            this.lblreg.Name = "lblreg";
            this.lblreg.Size = new System.Drawing.Size(44, 13);
            this.lblreg.TabIndex = 1;
            this.lblreg.Text = "Reg No";
            // 
            // groupBoxContact
            // 
            this.groupBoxContact.Controls.Add(this.txtphone);
            this.groupBoxContact.Controls.Add(this.txtmobile);
            this.groupBoxContact.Controls.Add(this.txtaddress);
            this.groupBoxContact.Controls.Add(this.lblphone);
            this.groupBoxContact.Controls.Add(this.lblmobile);
            this.groupBoxContact.Controls.Add(this.lbladdress);
            this.groupBoxContact.Location = new System.Drawing.Point(20, 277);
            this.groupBoxContact.Name = "groupBoxContact";
            this.groupBoxContact.Size = new System.Drawing.Size(417, 141);
            this.groupBoxContact.TabIndex = 7;
            this.groupBoxContact.TabStop = false;
            this.groupBoxContact.Text = "Contact Details";
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(302, 89);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(106, 20);
            this.txtphone.TabIndex = 19;
            // 
            // txtmobile
            // 
            this.txtmobile.Location = new System.Drawing.Point(111, 89);
            this.txtmobile.Name = "txtmobile";
            this.txtmobile.Size = new System.Drawing.Size(106, 20);
            this.txtmobile.TabIndex = 18;
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(111, 29);
            this.txtaddress.Multiline = true;
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(297, 41);
            this.txtaddress.TabIndex = 16;
            // 
            // lblphone
            // 
            this.lblphone.AutoSize = true;
            this.lblphone.Location = new System.Drawing.Point(230, 92);
            this.lblphone.Name = "lblphone";
            this.lblphone.Size = new System.Drawing.Size(69, 13);
            this.lblphone.TabIndex = 15;
            this.lblphone.Text = "Home Phone";
            // 
            // lblmobile
            // 
            this.lblmobile.AutoSize = true;
            this.lblmobile.Location = new System.Drawing.Point(19, 92);
            this.lblmobile.Name = "lblmobile";
            this.lblmobile.Size = new System.Drawing.Size(72, 13);
            this.lblmobile.TabIndex = 14;
            this.lblmobile.Text = "Mobile Phone";
            // 
            // lbladdress
            // 
            this.lbladdress.AutoSize = true;
            this.lbladdress.Location = new System.Drawing.Point(19, 32);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(45, 13);
            this.lbladdress.TabIndex = 12;
            this.lbladdress.Text = "Address";
            // 
            // groupBoxBasic
            // 
            this.groupBoxBasic.Controls.Add(this.txtnic);
            this.groupBoxBasic.Controls.Add(this.lblnic);
            this.groupBoxBasic.Controls.Add(this.radiof);
            this.groupBoxBasic.Controls.Add(this.txtlnm);
            this.groupBoxBasic.Controls.Add(this.dob);
            this.groupBoxBasic.Controls.Add(this.radiom);
            this.groupBoxBasic.Controls.Add(this.txtfnm);
            this.groupBoxBasic.Controls.Add(this.lblgender);
            this.groupBoxBasic.Controls.Add(this.lbldob);
            this.groupBoxBasic.Controls.Add(this.lbllnm);
            this.groupBoxBasic.Controls.Add(this.lblfnm);
            this.groupBoxBasic.Location = new System.Drawing.Point(20, 58);
            this.groupBoxBasic.Name = "groupBoxBasic";
            this.groupBoxBasic.Size = new System.Drawing.Size(417, 213);
            this.groupBoxBasic.TabIndex = 7;
            this.groupBoxBasic.TabStop = false;
            this.groupBoxBasic.Text = "Basic Details";
            // 
            // txtnic
            // 
            this.txtnic.Location = new System.Drawing.Point(111, 101);
            this.txtnic.Name = "txtnic";
            this.txtnic.Size = new System.Drawing.Size(135, 20);
            this.txtnic.TabIndex = 20;
            // 
            // lblnic
            // 
            this.lblnic.AutoSize = true;
            this.lblnic.Location = new System.Drawing.Point(19, 104);
            this.lblnic.Name = "lblnic";
            this.lblnic.Size = new System.Drawing.Size(25, 13);
            this.lblnic.TabIndex = 17;
            this.lblnic.Text = "NIC";
            // 
            // radiof
            // 
            this.radiof.AutoSize = true;
            this.radiof.Location = new System.Drawing.Point(214, 179);
            this.radiof.Name = "radiof";
            this.radiof.Size = new System.Drawing.Size(59, 17);
            this.radiof.TabIndex = 16;
            this.radiof.TabStop = true;
            this.radiof.Text = "Female";
            this.radiof.UseVisualStyleBackColor = true;
            // 
            // txtlnm
            // 
            this.txtlnm.Location = new System.Drawing.Point(111, 63);
            this.txtlnm.Name = "txtlnm";
            this.txtlnm.Size = new System.Drawing.Size(297, 20);
            this.txtlnm.TabIndex = 15;
            // 
            // dob
            // 
            this.dob.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dob.Location = new System.Drawing.Point(111, 140);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(136, 20);
            this.dob.TabIndex = 14;
            // 
            // radiom
            // 
            this.radiom.AutoSize = true;
            this.radiom.Location = new System.Drawing.Point(111, 179);
            this.radiom.Name = "radiom";
            this.radiom.Size = new System.Drawing.Size(48, 17);
            this.radiom.TabIndex = 13;
            this.radiom.TabStop = true;
            this.radiom.Text = "Male";
            this.radiom.UseVisualStyleBackColor = true;
            // 
            // txtfnm
            // 
            this.txtfnm.Location = new System.Drawing.Point(111, 28);
            this.txtfnm.Name = "txtfnm";
            this.txtfnm.Size = new System.Drawing.Size(297, 20);
            this.txtfnm.TabIndex = 12;
            // 
            // lblgender
            // 
            this.lblgender.AutoSize = true;
            this.lblgender.Location = new System.Drawing.Point(19, 181);
            this.lblgender.Name = "lblgender";
            this.lblgender.Size = new System.Drawing.Size(42, 13);
            this.lblgender.TabIndex = 11;
            this.lblgender.Text = "Gender";
            // 
            // lbldob
            // 
            this.lbldob.AutoSize = true;
            this.lbldob.Location = new System.Drawing.Point(19, 146);
            this.lbldob.Name = "lbldob";
            this.lbldob.Size = new System.Drawing.Size(66, 13);
            this.lbldob.TabIndex = 10;
            this.lbldob.Text = "Date of Birth";
            // 
            // lbllnm
            // 
            this.lbllnm.AutoSize = true;
            this.lbllnm.Location = new System.Drawing.Point(19, 66);
            this.lbllnm.Name = "lbllnm";
            this.lbllnm.Size = new System.Drawing.Size(58, 13);
            this.lbllnm.TabIndex = 9;
            this.lbllnm.Text = "Last Name";
            // 
            // lblfnm
            // 
            this.lblfnm.AutoSize = true;
            this.lblfnm.Location = new System.Drawing.Point(19, 31);
            this.lblfnm.Name = "lblfnm";
            this.lblfnm.Size = new System.Drawing.Size(57, 13);
            this.lblfnm.TabIndex = 8;
            this.lblfnm.Text = "First Name";
            // 
            // lblskills
            // 
            this.lblskills.AutoSize = true;
            this.lblskills.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblskills.Location = new System.Drawing.Point(135, 18);
            this.lblskills.Name = "lblskills";
            this.lblskills.Size = new System.Drawing.Size(235, 31);
            this.lblskills.TabIndex = 0;
            this.lblskills.Text = "Skills International";
            // 
            // frmteacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 654);
            this.Controls.Add(this.groupBoxRegistration);
            this.Controls.Add(this.lblskills);
            this.Controls.Add(this.lnkexit);
            this.Controls.Add(this.lnklogout);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmteacher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teacher Registration - Skills International";
            this.Load += new System.EventHandler(this.frmteacher_Load);
            this.groupBoxRegistration.ResumeLayout(false);
            this.groupBoxRegistration.PerformLayout();
            this.groupBoxContact.ResumeLayout(false);
            this.groupBoxContact.PerformLayout();
            this.groupBoxBasic.ResumeLayout(false);
            this.groupBoxBasic.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnreg;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.LinkLabel lnklogout;
        private System.Windows.Forms.LinkLabel lnkexit;
        private System.Windows.Forms.GroupBox groupBoxRegistration;
        private System.Windows.Forms.GroupBox groupBoxBasic;
        private System.Windows.Forms.GroupBox groupBoxContact;
        private System.Windows.Forms.Label lblreg;
        private System.Windows.Forms.Label lbllnm;
        private System.Windows.Forms.Label lblfnm;
        private System.Windows.Forms.Label lblskills;
        private System.Windows.Forms.ComboBox comboreg;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.TextBox txtmobile;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.Label lblphone;
        private System.Windows.Forms.Label lblmobile;
        private System.Windows.Forms.Label lbladdress;
        private System.Windows.Forms.TextBox txtlnm;
        private System.Windows.Forms.DateTimePicker dob;
        private System.Windows.Forms.RadioButton radiom;
        private System.Windows.Forms.TextBox txtfnm;
        private System.Windows.Forms.Label lblgender;
        private System.Windows.Forms.Label lbldob;
        private System.Windows.Forms.RadioButton radiof;
        private System.Windows.Forms.TextBox txtnic;
        private System.Windows.Forms.Label lblnic;
    }
}