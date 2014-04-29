namespace Friends
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.grpIdentity = new System.Windows.Forms.GroupBox();
            this.lbState = new System.Windows.Forms.Label();
            this.lbZip = new System.Windows.Forms.Label();
            this.lbStreet = new System.Windows.Forms.Label();
            this.cbStateAbbrevs = new System.Windows.Forms.ComboBox();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lbCity = new System.Windows.Forms.Label();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lbLastName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstBoxFriends = new System.Windows.Forms.ListBox();
            this.radbtnOn = new System.Windows.Forms.RadioButton();
            this.radbtnOff = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.grpIdentity.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpIdentity
            // 
            this.grpIdentity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.grpIdentity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.grpIdentity.Controls.Add(this.lbState);
            this.grpIdentity.Controls.Add(this.lbZip);
            this.grpIdentity.Controls.Add(this.lbStreet);
            this.grpIdentity.Controls.Add(this.cbStateAbbrevs);
            this.grpIdentity.Controls.Add(this.txtZip);
            this.grpIdentity.Controls.Add(this.txtCity);
            this.grpIdentity.Controls.Add(this.lbCity);
            this.grpIdentity.Controls.Add(this.txtStreet);
            this.grpIdentity.Controls.Add(this.txtLastName);
            this.grpIdentity.Controls.Add(this.lbLastName);
            this.grpIdentity.Controls.Add(this.txtFirstName);
            this.grpIdentity.Controls.Add(this.lblFirstName);
            this.grpIdentity.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpIdentity.ForeColor = System.Drawing.Color.White;
            this.grpIdentity.Location = new System.Drawing.Point(216, 45);
            this.grpIdentity.Name = "grpIdentity";
            this.grpIdentity.Size = new System.Drawing.Size(446, 259);
            this.grpIdentity.TabIndex = 0;
            this.grpIdentity.TabStop = false;
            this.grpIdentity.Text = "Identity";
            // 
            // lbState
            // 
            this.lbState.AutoSize = true;
            this.lbState.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbState.Location = new System.Drawing.Point(6, 201);
            this.lbState.Name = "lbState";
            this.lbState.Size = new System.Drawing.Size(56, 25);
            this.lbState.TabIndex = 15;
            this.lbState.Text = "State:";
            // 
            // lbZip
            // 
            this.lbZip.AutoSize = true;
            this.lbZip.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbZip.Location = new System.Drawing.Point(231, 201);
            this.lbZip.Name = "lbZip";
            this.lbZip.Size = new System.Drawing.Size(88, 25);
            this.lbZip.TabIndex = 14;
            this.lbZip.Text = "Zip Code:";
            // 
            // lbStreet
            // 
            this.lbStreet.AutoSize = true;
            this.lbStreet.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbStreet.Location = new System.Drawing.Point(6, 116);
            this.lbStreet.Name = "lbStreet";
            this.lbStreet.Size = new System.Drawing.Size(62, 25);
            this.lbStreet.TabIndex = 13;
            this.lbStreet.Text = "Street:";
            // 
            // cbStateAbbrevs
            // 
            this.cbStateAbbrevs.FormattingEnabled = true;
            this.cbStateAbbrevs.Location = new System.Drawing.Point(122, 198);
            this.cbStateAbbrevs.Name = "cbStateAbbrevs";
            this.cbStateAbbrevs.Size = new System.Drawing.Size(67, 36);
            this.cbStateAbbrevs.TabIndex = 12;
            // 
            // txtZip
            // 
            this.txtZip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtZip.Location = new System.Drawing.Point(319, 198);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(102, 34);
            this.txtZip.TabIndex = 11;
            // 
            // txtCity
            // 
            this.txtCity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCity.Location = new System.Drawing.Point(122, 156);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(299, 34);
            this.txtCity.TabIndex = 9;
            // 
            // lbCity
            // 
            this.lbCity.AutoSize = true;
            this.lbCity.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbCity.Location = new System.Drawing.Point(6, 159);
            this.lbCity.Name = "lbCity";
            this.lbCity.Size = new System.Drawing.Size(46, 25);
            this.lbCity.TabIndex = 7;
            this.lbCity.Text = "City:";
            // 
            // txtStreet
            // 
            this.txtStreet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStreet.Location = new System.Drawing.Point(122, 113);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(299, 34);
            this.txtStreet.TabIndex = 3;
            // 
            // txtLastName
            // 
            this.txtLastName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLastName.Location = new System.Drawing.Point(122, 71);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(299, 34);
            this.txtLastName.TabIndex = 2;
            // 
            // lbLastName
            // 
            this.lbLastName.AutoSize = true;
            this.lbLastName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbLastName.Location = new System.Drawing.Point(6, 74);
            this.lbLastName.Name = "lbLastName";
            this.lbLastName.Size = new System.Drawing.Size(99, 25);
            this.lbLastName.TabIndex = 2;
            this.lbLastName.Text = "Last Name:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFirstName.Location = new System.Drawing.Point(122, 28);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(299, 34);
            this.txtFirstName.TabIndex = 1;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFirstName.Location = new System.Drawing.Point(6, 35);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(101, 25);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name:";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(560, 310);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(102, 33);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(558, 530);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(104, 33);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox1.Controls.Add(this.lstBoxFriends);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(216, 361);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(446, 163);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Friends:";
            // 
            // lstBoxFriends
            // 
            this.lstBoxFriends.FormattingEnabled = true;
            this.lstBoxFriends.ItemHeight = 28;
            this.lstBoxFriends.Location = new System.Drawing.Point(27, 33);
            this.lstBoxFriends.Name = "lstBoxFriends";
            this.lstBoxFriends.Size = new System.Drawing.Size(399, 116);
            this.lstBoxFriends.TabIndex = 0;
            this.lstBoxFriends.SelectedIndexChanged += new System.EventHandler(this.lstBoxFriends_SelectedIndexChanged);
            // 
            // radbtnOn
            // 
            this.radbtnOn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radbtnOn.AutoSize = true;
            this.radbtnOn.BackColor = System.Drawing.Color.Transparent;
            this.radbtnOn.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radbtnOn.Location = new System.Drawing.Point(632, 12);
            this.radbtnOn.Name = "radbtnOn";
            this.radbtnOn.Size = new System.Drawing.Size(56, 25);
            this.radbtnOn.TabIndex = 13;
            this.radbtnOn.TabStop = true;
            this.radbtnOn.Text = "On";
            this.radbtnOn.UseVisualStyleBackColor = false;
            this.radbtnOn.CheckedChanged += new System.EventHandler(this.radbtnOn_CheckedChanged);
            // 
            // radbtnOff
            // 
            this.radbtnOff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radbtnOff.AutoSize = true;
            this.radbtnOff.BackColor = System.Drawing.Color.Transparent;
            this.radbtnOff.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radbtnOff.Location = new System.Drawing.Point(694, 12);
            this.radbtnOff.Name = "radbtnOff";
            this.radbtnOff.Size = new System.Drawing.Size(57, 25);
            this.radbtnOff.TabIndex = 14;
            this.radbtnOff.TabStop = true;
            this.radbtnOff.Text = "Off";
            this.radbtnOff.UseVisualStyleBackColor = false;
            this.radbtnOff.CheckedChanged += new System.EventHandler(this.radbtnOff_CheckedChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(572, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 21);
            this.label4.TabIndex = 15;
            this.label4.Text = "Music:";
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(777, 567);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.radbtnOff);
            this.Controls.Add(this.radbtnOn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.grpIdentity);
            this.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1390, 754);
            this.Name = "frmMain";
            this.Text = "Friends Address Book";
            this.grpIdentity.ResumeLayout(false);
            this.grpIdentity.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpIdentity;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lbLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lbCity;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstBoxFriends;
        private System.Windows.Forms.RadioButton radbtnOn;
        private System.Windows.Forms.RadioButton radbtnOff;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbStateAbbrevs;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lbState;
        private System.Windows.Forms.Label lbZip;
        private System.Windows.Forms.Label lbStreet;
    }
}

