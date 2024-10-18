namespace E127407_Kavinda_Ravihansa
{
    partial class frmlogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmlogin));
            this.grouplogin = new System.Windows.Forms.GroupBox();
            this.lblpw = new System.Windows.Forms.Label();
            this.btnlogin = new System.Windows.Forms.Button();
            this.txtpw = new System.Windows.Forms.TextBox();
            this.btnclear = new System.Windows.Forms.Button();
            this.lblun = new System.Windows.Forms.Label();
            this.txtun = new System.Windows.Forms.TextBox();
            this.pictureskills = new System.Windows.Forms.PictureBox();
            this.lblskills = new System.Windows.Forms.Label();
            this.btnexit = new System.Windows.Forms.Button();
            this.grouplogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureskills)).BeginInit();
            this.SuspendLayout();
            // 
            // grouplogin
            // 
            this.grouplogin.Controls.Add(this.lblpw);
            this.grouplogin.Controls.Add(this.btnlogin);
            this.grouplogin.Controls.Add(this.txtpw);
            this.grouplogin.Controls.Add(this.btnclear);
            this.grouplogin.Controls.Add(this.lblun);
            this.grouplogin.Controls.Add(this.txtun);
            this.grouplogin.ForeColor = System.Drawing.Color.White;
            this.grouplogin.Location = new System.Drawing.Point(80, 187);
            this.grouplogin.Name = "grouplogin";
            this.grouplogin.Size = new System.Drawing.Size(283, 163);
            this.grouplogin.TabIndex = 0;
            this.grouplogin.TabStop = false;
            this.grouplogin.Text = "Login";
            // 
            // lblpw
            // 
            this.lblpw.AutoSize = true;
            this.lblpw.BackColor = System.Drawing.Color.Transparent;
            this.lblpw.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpw.ForeColor = System.Drawing.Color.White;
            this.lblpw.Location = new System.Drawing.Point(15, 78);
            this.lblpw.Name = "lblpw";
            this.lblpw.Size = new System.Drawing.Size(68, 16);
            this.lblpw.TabIndex = 4;
            this.lblpw.Text = "Password";
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(156)))), ((int)(((byte)(252)))));
            this.btnlogin.FlatAppearance.BorderSize = 0;
            this.btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.Location = new System.Drawing.Point(166, 117);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(97, 30);
            this.btnlogin.TabIndex = 2;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // txtpw
            // 
            this.txtpw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtpw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtpw.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpw.ForeColor = System.Drawing.Color.White;
            this.txtpw.Location = new System.Drawing.Point(106, 75);
            this.txtpw.Name = "txtpw";
            this.txtpw.Size = new System.Drawing.Size(157, 22);
            this.txtpw.TabIndex = 1;
            this.txtpw.UseSystemPasswordChar = true;
            // 
            // btnclear
            // 
            this.btnclear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(156)))), ((int)(((byte)(252)))));
            this.btnclear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(156)))), ((int)(((byte)(252)))));
            this.btnclear.Location = new System.Drawing.Point(18, 117);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(97, 30);
            this.btnclear.TabIndex = 3;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // lblun
            // 
            this.lblun.AutoSize = true;
            this.lblun.BackColor = System.Drawing.Color.Transparent;
            this.lblun.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblun.ForeColor = System.Drawing.Color.White;
            this.lblun.Location = new System.Drawing.Point(15, 45);
            this.lblun.Name = "lblun";
            this.lblun.Size = new System.Drawing.Size(71, 16);
            this.lblun.TabIndex = 2;
            this.lblun.Text = "Username";
            // 
            // txtun
            // 
            this.txtun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtun.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtun.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtun.ForeColor = System.Drawing.Color.White;
            this.txtun.Location = new System.Drawing.Point(106, 42);
            this.txtun.Name = "txtun";
            this.txtun.Size = new System.Drawing.Size(157, 22);
            this.txtun.TabIndex = 0;
            // 
            // pictureskills
            // 
            this.pictureskills.BackColor = System.Drawing.Color.Transparent;
            this.pictureskills.Image = ((System.Drawing.Image)(resources.GetObject("pictureskills.Image")));
            this.pictureskills.Location = new System.Drawing.Point(148, 30);
            this.pictureskills.Name = "pictureskills";
            this.pictureskills.Size = new System.Drawing.Size(145, 116);
            this.pictureskills.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureskills.TabIndex = 1;
            this.pictureskills.TabStop = false;
            // 
            // lblskills
            // 
            this.lblskills.AutoSize = true;
            this.lblskills.BackColor = System.Drawing.Color.Transparent;
            this.lblskills.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblskills.ForeColor = System.Drawing.Color.White;
            this.lblskills.Location = new System.Drawing.Point(108, 149);
            this.lblskills.Name = "lblskills";
            this.lblskills.Size = new System.Drawing.Size(235, 31);
            this.lblskills.TabIndex = 1;
            this.lblskills.Text = "Skills International";
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(82)))), ((int)(((byte)(96)))));
            this.btnexit.FlatAppearance.BorderSize = 0;
            this.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.ForeColor = System.Drawing.Color.White;
            this.btnexit.Location = new System.Drawing.Point(12, 364);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(77, 30);
            this.btnexit.TabIndex = 4;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // frmlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(437, 403);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.pictureskills);
            this.Controls.Add(this.grouplogin);
            this.Controls.Add(this.lblskills);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmlogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login - Skills International";
            this.grouplogin.ResumeLayout(false);
            this.grouplogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureskills)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grouplogin;
        private System.Windows.Forms.Label lblpw;
        private System.Windows.Forms.TextBox txtpw;
        private System.Windows.Forms.Label lblun;
        private System.Windows.Forms.TextBox txtun;
        private System.Windows.Forms.PictureBox pictureskills;
        private System.Windows.Forms.Label lblskills;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Button btnexit;
    }
}

