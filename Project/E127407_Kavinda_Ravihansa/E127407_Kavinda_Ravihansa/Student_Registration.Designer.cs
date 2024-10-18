namespace E127407_Kavinda_Ravihansa
{
    partial class frmreg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmreg));
            this.groupreg = new System.Windows.Forms.GroupBox();
            this.comboreg = new System.Windows.Forms.ComboBox();
            this.lblreg = new System.Windows.Forms.Label();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnreg = new System.Windows.Forms.Button();
            this.groupparent = new System.Windows.Forms.GroupBox();
            this.txtcontact = new System.Windows.Forms.TextBox();
            this.txtnic = new System.Windows.Forms.TextBox();
            this.txtparent = new System.Windows.Forms.TextBox();
            this.lblcontact = new System.Windows.Forms.Label();
            this.lblnic = new System.Windows.Forms.Label();
            this.lblparent = new System.Windows.Forms.Label();
            this.groupcontact = new System.Windows.Forms.GroupBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.txtmobile = new System.Windows.Forms.TextBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.lblhome = new System.Windows.Forms.Label();
            this.lblmobile = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.lbladdress = new System.Windows.Forms.Label();
            this.groupbasic = new System.Windows.Forms.GroupBox();
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
            this.lnkexit = new System.Windows.Forms.LinkLabel();
            this.lnklogout = new System.Windows.Forms.LinkLabel();
            this.groupreg.SuspendLayout();
            this.groupparent.SuspendLayout();
            this.groupcontact.SuspendLayout();
            this.groupbasic.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupreg
            // 
            this.groupreg.Controls.Add(this.comboreg);
            this.groupreg.Controls.Add(this.lblreg);
            this.groupreg.Controls.Add(this.btndelete);
            this.groupreg.Controls.Add(this.btnclear);
            this.groupreg.Controls.Add(this.btnupdate);
            this.groupreg.Controls.Add(this.btnreg);
            this.groupreg.Controls.Add(this.groupparent);
            this.groupreg.Controls.Add(this.groupcontact);
            this.groupreg.Controls.Add(this.groupbasic);
            this.groupreg.Location = new System.Drawing.Point(12, 52);
            this.groupreg.Name = "groupreg";
            this.groupreg.Size = new System.Drawing.Size(454, 580);
            this.groupreg.TabIndex = 0;
            this.groupreg.TabStop = false;
            this.groupreg.Text = "Student Registration";
            // 
            // comboreg
            // 
            this.comboreg.FormattingEnabled = true;
            this.comboreg.Location = new System.Drawing.Point(131, 27);
            this.comboreg.Name = "comboreg";
            this.comboreg.Size = new System.Drawing.Size(121, 21);
            this.comboreg.TabIndex = 7;
            this.comboreg.SelectedIndexChanged += new System.EventHandler(this.comboreg_SelectedIndexChanged);
            // 
            // lblreg
            // 
            this.lblreg.AutoSize = true;
            this.lblreg.Location = new System.Drawing.Point(39, 30);
            this.lblreg.Name = "lblreg";
            this.lblreg.Size = new System.Drawing.Size(44, 13);
            this.lblreg.TabIndex = 2;
            this.lblreg.Text = "Reg No";
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(359, 536);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(78, 29);
            this.btndelete.TabIndex = 6;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(275, 536);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(78, 29);
            this.btnclear.TabIndex = 5;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(104, 536);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(78, 29);
            this.btnupdate.TabIndex = 4;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnreg
            // 
            this.btnreg.Location = new System.Drawing.Point(20, 536);
            this.btnreg.Name = "btnreg";
            this.btnreg.Size = new System.Drawing.Size(78, 29);
            this.btnreg.TabIndex = 3;
            this.btnreg.Text = "Register";
            this.btnreg.UseVisualStyleBackColor = true;
            this.btnreg.Click += new System.EventHandler(this.btnreg_Click);
            // 
            // groupparent
            // 
            this.groupparent.Controls.Add(this.txtcontact);
            this.groupparent.Controls.Add(this.txtnic);
            this.groupparent.Controls.Add(this.txtparent);
            this.groupparent.Controls.Add(this.lblcontact);
            this.groupparent.Controls.Add(this.lblnic);
            this.groupparent.Controls.Add(this.lblparent);
            this.groupparent.Location = new System.Drawing.Point(20, 392);
            this.groupparent.Name = "groupparent";
            this.groupparent.Size = new System.Drawing.Size(417, 138);
            this.groupparent.TabIndex = 2;
            this.groupparent.TabStop = false;
            this.groupparent.Text = "Parent Details";
            // 
            // txtcontact
            // 
            this.txtcontact.Location = new System.Drawing.Point(111, 96);
            this.txtcontact.Name = "txtcontact";
            this.txtcontact.Size = new System.Drawing.Size(121, 20);
            this.txtcontact.TabIndex = 24;
            // 
            // txtnic
            // 
            this.txtnic.Location = new System.Drawing.Point(111, 63);
            this.txtnic.Name = "txtnic";
            this.txtnic.Size = new System.Drawing.Size(121, 20);
            this.txtnic.TabIndex = 23;
            // 
            // txtparent
            // 
            this.txtparent.Location = new System.Drawing.Point(111, 28);
            this.txtparent.Name = "txtparent";
            this.txtparent.Size = new System.Drawing.Size(297, 20);
            this.txtparent.TabIndex = 20;
            // 
            // lblcontact
            // 
            this.lblcontact.AutoSize = true;
            this.lblcontact.Location = new System.Drawing.Point(19, 99);
            this.lblcontact.Name = "lblcontact";
            this.lblcontact.Size = new System.Drawing.Size(84, 13);
            this.lblcontact.TabIndex = 22;
            this.lblcontact.Text = "Contact Number";
            // 
            // lblnic
            // 
            this.lblnic.AutoSize = true;
            this.lblnic.Location = new System.Drawing.Point(19, 66);
            this.lblnic.Name = "lblnic";
            this.lblnic.Size = new System.Drawing.Size(25, 13);
            this.lblnic.TabIndex = 21;
            this.lblnic.Text = "NIC";
            // 
            // lblparent
            // 
            this.lblparent.AutoSize = true;
            this.lblparent.Location = new System.Drawing.Point(19, 31);
            this.lblparent.Name = "lblparent";
            this.lblparent.Size = new System.Drawing.Size(69, 13);
            this.lblparent.TabIndex = 20;
            this.lblparent.Text = "Parent Name";
            // 
            // groupcontact
            // 
            this.groupcontact.Controls.Add(this.txtemail);
            this.groupcontact.Controls.Add(this.txtphone);
            this.groupcontact.Controls.Add(this.txtmobile);
            this.groupcontact.Controls.Add(this.txtaddress);
            this.groupcontact.Controls.Add(this.lblhome);
            this.groupcontact.Controls.Add(this.lblmobile);
            this.groupcontact.Controls.Add(this.lblemail);
            this.groupcontact.Controls.Add(this.lbladdress);
            this.groupcontact.Location = new System.Drawing.Point(20, 233);
            this.groupcontact.Name = "groupcontact";
            this.groupcontact.Size = new System.Drawing.Size(417, 153);
            this.groupcontact.TabIndex = 1;
            this.groupcontact.TabStop = false;
            this.groupcontact.Text = "Contact Details";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(111, 81);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(297, 20);
            this.txtemail.TabIndex = 16;
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(302, 116);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(106, 20);
            this.txtphone.TabIndex = 19;
            // 
            // txtmobile
            // 
            this.txtmobile.Location = new System.Drawing.Point(111, 116);
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
            // lblhome
            // 
            this.lblhome.AutoSize = true;
            this.lblhome.Location = new System.Drawing.Point(230, 119);
            this.lblhome.Name = "lblhome";
            this.lblhome.Size = new System.Drawing.Size(69, 13);
            this.lblhome.TabIndex = 14;
            this.lblhome.Text = "Home Phone";
            // 
            // lblmobile
            // 
            this.lblmobile.AutoSize = true;
            this.lblmobile.Location = new System.Drawing.Point(19, 119);
            this.lblmobile.Name = "lblmobile";
            this.lblmobile.Size = new System.Drawing.Size(72, 13);
            this.lblmobile.TabIndex = 13;
            this.lblmobile.Text = "Mobile Phone";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(19, 84);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(32, 13);
            this.lblemail.TabIndex = 12;
            this.lblemail.Text = "Email";
            // 
            // lbladdress
            // 
            this.lbladdress.AutoSize = true;
            this.lbladdress.Location = new System.Drawing.Point(19, 32);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(45, 13);
            this.lbladdress.TabIndex = 11;
            this.lbladdress.Text = "Address";
            // 
            // groupbasic
            // 
            this.groupbasic.Controls.Add(this.radiof);
            this.groupbasic.Controls.Add(this.txtlnm);
            this.groupbasic.Controls.Add(this.dob);
            this.groupbasic.Controls.Add(this.radiom);
            this.groupbasic.Controls.Add(this.txtfnm);
            this.groupbasic.Controls.Add(this.lblgender);
            this.groupbasic.Controls.Add(this.lbldob);
            this.groupbasic.Controls.Add(this.lbllnm);
            this.groupbasic.Controls.Add(this.lblfnm);
            this.groupbasic.Location = new System.Drawing.Point(20, 58);
            this.groupbasic.Name = "groupbasic";
            this.groupbasic.Size = new System.Drawing.Size(417, 169);
            this.groupbasic.TabIndex = 0;
            this.groupbasic.TabStop = false;
            this.groupbasic.Text = "Basic Details";
            // 
            // radiof
            // 
            this.radiof.AutoSize = true;
            this.radiof.Location = new System.Drawing.Point(214, 133);
            this.radiof.Name = "radiof";
            this.radiof.Size = new System.Drawing.Size(59, 17);
            this.radiof.TabIndex = 15;
            this.radiof.TabStop = true;
            this.radiof.Text = "Female";
            this.radiof.UseVisualStyleBackColor = true;
            // 
            // txtlnm
            // 
            this.txtlnm.Location = new System.Drawing.Point(111, 63);
            this.txtlnm.Name = "txtlnm";
            this.txtlnm.Size = new System.Drawing.Size(297, 20);
            this.txtlnm.TabIndex = 14;
            // 
            // dob
            // 
            this.dob.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dob.Location = new System.Drawing.Point(111, 98);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(136, 20);
            this.dob.TabIndex = 13;
            // 
            // radiom
            // 
            this.radiom.AutoSize = true;
            this.radiom.Location = new System.Drawing.Point(111, 133);
            this.radiom.Name = "radiom";
            this.radiom.Size = new System.Drawing.Size(48, 17);
            this.radiom.TabIndex = 12;
            this.radiom.TabStop = true;
            this.radiom.Text = "Male";
            this.radiom.UseVisualStyleBackColor = true;
            // 
            // txtfnm
            // 
            this.txtfnm.Location = new System.Drawing.Point(111, 28);
            this.txtfnm.Name = "txtfnm";
            this.txtfnm.Size = new System.Drawing.Size(297, 20);
            this.txtfnm.TabIndex = 11;
            // 
            // lblgender
            // 
            this.lblgender.AutoSize = true;
            this.lblgender.Location = new System.Drawing.Point(19, 135);
            this.lblgender.Name = "lblgender";
            this.lblgender.Size = new System.Drawing.Size(42, 13);
            this.lblgender.TabIndex = 10;
            this.lblgender.Text = "Gender";
            // 
            // lbldob
            // 
            this.lbldob.AutoSize = true;
            this.lbldob.Location = new System.Drawing.Point(19, 104);
            this.lbldob.Name = "lbldob";
            this.lbldob.Size = new System.Drawing.Size(66, 13);
            this.lbldob.TabIndex = 9;
            this.lbldob.Text = "Date of Birth";
            // 
            // lbllnm
            // 
            this.lbllnm.AutoSize = true;
            this.lbllnm.Location = new System.Drawing.Point(19, 66);
            this.lbllnm.Name = "lbllnm";
            this.lbllnm.Size = new System.Drawing.Size(58, 13);
            this.lbllnm.TabIndex = 8;
            this.lbllnm.Text = "Last Name";
            // 
            // lblfnm
            // 
            this.lblfnm.AutoSize = true;
            this.lblfnm.Location = new System.Drawing.Point(19, 31);
            this.lblfnm.Name = "lblfnm";
            this.lblfnm.Size = new System.Drawing.Size(57, 13);
            this.lblfnm.TabIndex = 7;
            this.lblfnm.Text = "First Name";
            // 
            // lblskills
            // 
            this.lblskills.AutoSize = true;
            this.lblskills.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblskills.Location = new System.Drawing.Point(135, 18);
            this.lblskills.Name = "lblskills";
            this.lblskills.Size = new System.Drawing.Size(235, 31);
            this.lblskills.TabIndex = 1;
            this.lblskills.Text = "Skills International";
            // 
            // lnkexit
            // 
            this.lnkexit.AutoSize = true;
            this.lnkexit.Location = new System.Drawing.Point(442, 635);
            this.lnkexit.Name = "lnkexit";
            this.lnkexit.Size = new System.Drawing.Size(24, 13);
            this.lnkexit.TabIndex = 2;
            this.lnkexit.TabStop = true;
            this.lnkexit.Text = "Exit";
            this.lnkexit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkexit_LinkClicked);
            // 
            // lnklogout
            // 
            this.lnklogout.AutoSize = true;
            this.lnklogout.Location = new System.Drawing.Point(9, 9);
            this.lnklogout.Name = "lnklogout";
            this.lnklogout.Size = new System.Drawing.Size(40, 13);
            this.lnklogout.TabIndex = 3;
            this.lnklogout.TabStop = true;
            this.lnklogout.Text = "Logout";
            this.lnklogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklogout_LinkClicked);
            // 
            // frmreg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 654);
            this.Controls.Add(this.lnklogout);
            this.Controls.Add(this.lnkexit);
            this.Controls.Add(this.lblskills);
            this.Controls.Add(this.groupreg);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmreg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Registration - Skills International";
            this.Load += new System.EventHandler(this.frmreg_Load);
            this.groupreg.ResumeLayout(false);
            this.groupreg.PerformLayout();
            this.groupparent.ResumeLayout(false);
            this.groupparent.PerformLayout();
            this.groupcontact.ResumeLayout(false);
            this.groupcontact.PerformLayout();
            this.groupbasic.ResumeLayout(false);
            this.groupbasic.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupreg;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnreg;
        private System.Windows.Forms.GroupBox groupparent;
        private System.Windows.Forms.GroupBox groupcontact;
        private System.Windows.Forms.Label lblreg;
        private System.Windows.Forms.TextBox txtcontact;
        private System.Windows.Forms.TextBox txtnic;
        private System.Windows.Forms.TextBox txtparent;
        private System.Windows.Forms.Label lblcontact;
        private System.Windows.Forms.Label lblnic;
        private System.Windows.Forms.Label lblparent;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.TextBox txtmobile;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.Label lblhome;
        private System.Windows.Forms.Label lblmobile;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lbladdress;
        private System.Windows.Forms.GroupBox groupbasic;
        private System.Windows.Forms.RadioButton radiof;
        private System.Windows.Forms.TextBox txtlnm;
        private System.Windows.Forms.DateTimePicker dob;
        private System.Windows.Forms.RadioButton radiom;
        private System.Windows.Forms.TextBox txtfnm;
        private System.Windows.Forms.Label lblgender;
        private System.Windows.Forms.Label lbldob;
        private System.Windows.Forms.Label lbllnm;
        private System.Windows.Forms.Label lblfnm;
        private System.Windows.Forms.Label lblskills;
        private System.Windows.Forms.LinkLabel lnkexit;
        private System.Windows.Forms.LinkLabel lnklogout;
        private System.Windows.Forms.ComboBox comboreg;
    }
}