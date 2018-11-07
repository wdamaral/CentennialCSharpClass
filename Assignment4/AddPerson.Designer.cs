namespace Assignment4
{
    partial class FormAddPerson
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
            this.grpAddPerson = new System.Windows.Forms.GroupBox();
            this.txtPhone = new System.Windows.Forms.MaskedTextBox();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.grpAddress = new System.Windows.Forms.GroupBox();
            this.txtProvince = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblProvince = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lstPersons = new System.Windows.Forms.ListView();
            this.regNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dob = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.telephone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.city = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.province = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstCourseSec = new System.Windows.Forms.ListView();
            this.course = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.courseName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.secId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.secName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.teacherName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpRegistered = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTeacher = new System.Windows.Forms.Label();
            this.grpAddPerson.SuspendLayout();
            this.grpAddress.SuspendLayout();
            this.grpRegistered.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAddPerson
            // 
            this.grpAddPerson.Controls.Add(this.txtPhone);
            this.grpAddPerson.Controls.Add(this.dtpDOB);
            this.grpAddPerson.Controls.Add(this.txtName);
            this.grpAddPerson.Controls.Add(this.lblDOB);
            this.grpAddPerson.Controls.Add(this.lblPhone);
            this.grpAddPerson.Controls.Add(this.lblName);
            this.grpAddPerson.Location = new System.Drawing.Point(33, 73);
            this.grpAddPerson.Name = "grpAddPerson";
            this.grpAddPerson.Size = new System.Drawing.Size(1274, 315);
            this.grpAddPerson.TabIndex = 0;
            this.grpAddPerson.TabStop = false;
            this.grpAddPerson.Text = "Add Teacher";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(248, 146);
            this.txtPhone.Mask = "(999) 000-0000";
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(251, 38);
            this.txtPhone.TabIndex = 1;
            // 
            // dtpDOB
            // 
            this.dtpDOB.Location = new System.Drawing.Point(248, 228);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(391, 38);
            this.dtpDOB.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(248, 71);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(391, 38);
            this.txtName.TabIndex = 0;
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(52, 228);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(169, 32);
            this.lblDOB.TabIndex = 2;
            this.lblDOB.Text = "Date of birth";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(70, 149);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(151, 32);
            this.lblPhone.TabIndex = 1;
            this.lblPhone.Text = "Telephone";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(131, 71);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(90, 32);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // grpAddress
            // 
            this.grpAddress.Controls.Add(this.txtProvince);
            this.grpAddress.Controls.Add(this.txtCity);
            this.grpAddress.Controls.Add(this.lblProvince);
            this.grpAddress.Controls.Add(this.lblCity);
            this.grpAddress.Controls.Add(this.lblAddress);
            this.grpAddress.Controls.Add(this.txtAddress);
            this.grpAddress.Location = new System.Drawing.Point(33, 431);
            this.grpAddress.Name = "grpAddress";
            this.grpAddress.Size = new System.Drawing.Size(1274, 284);
            this.grpAddress.TabIndex = 1;
            this.grpAddress.TabStop = false;
            this.grpAddress.Text = "Address";
            // 
            // txtProvince
            // 
            this.txtProvince.Location = new System.Drawing.Point(248, 229);
            this.txtProvince.Name = "txtProvince";
            this.txtProvince.Size = new System.Drawing.Size(302, 38);
            this.txtProvince.TabIndex = 5;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(248, 147);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(302, 38);
            this.txtCity.TabIndex = 4;
            // 
            // lblProvince
            // 
            this.lblProvince.AutoSize = true;
            this.lblProvince.Location = new System.Drawing.Point(95, 232);
            this.lblProvince.Name = "lblProvince";
            this.lblProvince.Size = new System.Drawing.Size(126, 32);
            this.lblProvince.TabIndex = 8;
            this.lblProvince.Text = "Province";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(157, 150);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(64, 32);
            this.lblCity.TabIndex = 7;
            this.lblCity.Text = "City";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(102, 63);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(119, 32);
            this.lblAddress.TabIndex = 6;
            this.lblAddress.Text = "Address";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(248, 60);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(660, 38);
            this.txtAddress.TabIndex = 3;
            // 
            // lstPersons
            // 
            this.lstPersons.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.regNumber,
            this.name,
            this.dob,
            this.telephone,
            this.address,
            this.city,
            this.province});
            this.lstPersons.FullRowSelect = true;
            this.lstPersons.GridLines = true;
            this.lstPersons.Location = new System.Drawing.Point(21, 68);
            this.lstPersons.Name = "lstPersons";
            this.lstPersons.Size = new System.Drawing.Size(1219, 253);
            this.lstPersons.TabIndex = 6;
            this.lstPersons.UseCompatibleStateImageBehavior = false;
            this.lstPersons.View = System.Windows.Forms.View.Details;
            this.lstPersons.SelectedIndexChanged += new System.EventHandler(this.lstPersons_SelectedIndexChanged);
            // 
            // regNumber
            // 
            this.regNumber.Text = "Registration No";
            // 
            // name
            // 
            this.name.Text = "Name";
            // 
            // dob
            // 
            this.dob.Text = "Date of birth";
            // 
            // telephone
            // 
            this.telephone.Text = "Phone No";
            // 
            // address
            // 
            this.address.Text = "Address";
            // 
            // city
            // 
            this.city.Text = "City";
            // 
            // province
            // 
            this.province.Text = "Province";
            // 
            // lstCourseSec
            // 
            this.lstCourseSec.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.course,
            this.courseName,
            this.secId,
            this.secName,
            this.teacherName});
            this.lstCourseSec.FullRowSelect = true;
            this.lstCourseSec.GridLines = true;
            this.lstCourseSec.Location = new System.Drawing.Point(21, 74);
            this.lstCourseSec.Name = "lstCourseSec";
            this.lstCourseSec.Size = new System.Drawing.Size(1219, 551);
            this.lstCourseSec.TabIndex = 7;
            this.lstCourseSec.UseCompatibleStateImageBehavior = false;
            this.lstCourseSec.View = System.Windows.Forms.View.Details;
            this.lstCourseSec.SelectedIndexChanged += new System.EventHandler(this.lstCourseSec_SelectedIndexChanged);
            // 
            // course
            // 
            this.course.Text = "Course code";
            // 
            // courseName
            // 
            this.courseName.Text = "Name";
            // 
            // secId
            // 
            this.secId.Text = "Section ID";
            // 
            // secName
            // 
            this.secName.Text = "Section name";
            // 
            // teacherName
            // 
            this.teacherName.Text = "Teacher";
            // 
            // grpRegistered
            // 
            this.grpRegistered.Controls.Add(this.lstPersons);
            this.grpRegistered.Location = new System.Drawing.Point(33, 783);
            this.grpRegistered.Name = "grpRegistered";
            this.grpRegistered.Size = new System.Drawing.Size(1274, 366);
            this.grpRegistered.TabIndex = 10;
            this.grpRegistered.TabStop = false;
            this.grpRegistered.Text = "Teachers registered";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstCourseSec);
            this.groupBox2.Location = new System.Drawing.Point(1323, 73);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1274, 642);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select the section to assign";
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = global::Assignment4.Properties.Resources.save_128;
            this.btnSave.Location = new System.Drawing.Point(2465, 747);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(132, 129);
            this.btnSave.TabIndex = 8;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackgroundImage = global::Assignment4.Properties.Resources.reset_128;
            this.btnReset.Location = new System.Drawing.Point(2465, 919);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(132, 129);
            this.btnReset.TabIndex = 9;
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(403, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "Wagner D\'Amaral - 300932673";
            // 
            // lblTeacher
            // 
            this.lblTeacher.AutoSize = true;
            this.lblTeacher.Location = new System.Drawing.Point(1390, 919);
            this.lblTeacher.Name = "lblTeacher";
            this.lblTeacher.Size = new System.Drawing.Size(0, 32);
            this.lblTeacher.TabIndex = 12;
            // 
            // FormAddPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2630, 1777);
            this.Controls.Add(this.lblTeacher);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpRegistered);
            this.Controls.Add(this.grpAddress);
            this.Controls.Add(this.grpAddPerson);
            this.Name = "FormAddPerson";
            this.Text = "Add Person";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AddPerson_Load);
            this.grpAddPerson.ResumeLayout(false);
            this.grpAddPerson.PerformLayout();
            this.grpAddress.ResumeLayout(false);
            this.grpAddress.PerformLayout();
            this.grpRegistered.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAddPerson;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.GroupBox grpAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtProvince;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblProvince;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.MaskedTextBox txtPhone;
        private System.Windows.Forms.ListView lstPersons;
        private System.Windows.Forms.ColumnHeader regNumber;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader dob;
        private System.Windows.Forms.ColumnHeader telephone;
        private System.Windows.Forms.ColumnHeader address;
        private System.Windows.Forms.ColumnHeader city;
        private System.Windows.Forms.ColumnHeader province;
        private System.Windows.Forms.ListView lstCourseSec;
        private System.Windows.Forms.ColumnHeader course;
        private System.Windows.Forms.ColumnHeader courseName;
        private System.Windows.Forms.ColumnHeader secId;
        private System.Windows.Forms.ColumnHeader secName;
        private System.Windows.Forms.ColumnHeader teacherName;
        private System.Windows.Forms.GroupBox grpRegistered;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTeacher;
    }
}