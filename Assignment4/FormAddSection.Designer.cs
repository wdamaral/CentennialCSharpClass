namespace Assignment4
{
    partial class FormAddSection
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lstTeachers = new System.Windows.Forms.ListView();
            this.regNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtCourseNameSel = new System.Windows.Forms.TextBox();
            this.lblCourse = new System.Windows.Forms.Label();
            this.cmbCourse = new System.Windows.Forms.ComboBox();
            this.cmbSemester = new System.Windows.Forms.ComboBox();
            this.lblSemester = new System.Windows.Forms.Label();
            this.lblEvaluations = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblSectionId = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSectionId = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.grpCourse = new System.Windows.Forms.GroupBox();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.txtCourse = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.grpCourse.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lstTeachers);
            this.panel1.Controls.Add(this.txtCourseNameSel);
            this.panel1.Controls.Add(this.lblCourse);
            this.panel1.Controls.Add(this.cmbCourse);
            this.panel1.Controls.Add(this.cmbSemester);
            this.panel1.Controls.Add(this.lblSemester);
            this.panel1.Controls.Add(this.lblEvaluations);
            this.panel1.Controls.Add(this.lblCode);
            this.panel1.Controls.Add(this.lblSectionId);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.txtSectionId);
            this.panel1.Location = new System.Drawing.Point(63, 209);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(903, 584);
            this.panel1.TabIndex = 0;
            // 
            // lstTeachers
            // 
            this.lstTeachers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.regNumber,
            this.name});
            this.lstTeachers.FullRowSelect = true;
            this.lstTeachers.GridLines = true;
            this.lstTeachers.Location = new System.Drawing.Point(171, 285);
            this.lstTeachers.Name = "lstTeachers";
            this.lstTeachers.Size = new System.Drawing.Size(682, 164);
            this.lstTeachers.TabIndex = 6;
            this.lstTeachers.UseCompatibleStateImageBehavior = false;
            this.lstTeachers.View = System.Windows.Forms.View.Details;
            this.lstTeachers.SelectedIndexChanged += new System.EventHandler(this.lstTeachers_SelectedIndexChanged);
            // 
            // regNumber
            // 
            this.regNumber.Text = "Registration No";
            // 
            // name
            // 
            this.name.Text = "Name";
            // 
            // txtCourseNameSel
            // 
            this.txtCourseNameSel.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCourseNameSel.Enabled = false;
            this.txtCourseNameSel.Location = new System.Drawing.Point(531, 51);
            this.txtCourseNameSel.Name = "txtCourseNameSel";
            this.txtCourseNameSel.Size = new System.Drawing.Size(338, 38);
            this.txtCourseNameSel.TabIndex = 3;
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Location = new System.Drawing.Point(42, 57);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(106, 32);
            this.lblCourse.TabIndex = 12;
            this.lblCourse.Text = "Course";
            // 
            // cmbCourse
            // 
            this.cmbCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCourse.FormattingEnabled = true;
            this.cmbCourse.Location = new System.Drawing.Point(171, 54);
            this.cmbCourse.Name = "cmbCourse";
            this.cmbCourse.Size = new System.Drawing.Size(313, 39);
            this.cmbCourse.TabIndex = 2;
            this.cmbCourse.SelectedIndexChanged += new System.EventHandler(this.cmbCourse_SelectedIndexChanged);
            // 
            // cmbSemester
            // 
            this.cmbSemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSemester.FormattingEnabled = true;
            this.cmbSemester.Location = new System.Drawing.Point(171, 477);
            this.cmbSemester.Name = "cmbSemester";
            this.cmbSemester.Size = new System.Drawing.Size(313, 39);
            this.cmbSemester.TabIndex = 7;
            // 
            // lblSemester
            // 
            this.lblSemester.AutoSize = true;
            this.lblSemester.Location = new System.Drawing.Point(12, 480);
            this.lblSemester.Name = "lblSemester";
            this.lblSemester.Size = new System.Drawing.Size(136, 32);
            this.lblSemester.TabIndex = 8;
            this.lblSemester.Text = "Semester";
            // 
            // lblEvaluations
            // 
            this.lblEvaluations.AutoSize = true;
            this.lblEvaluations.Location = new System.Drawing.Point(29, 357);
            this.lblEvaluations.Name = "lblEvaluations";
            this.lblEvaluations.Size = new System.Drawing.Size(119, 32);
            this.lblEvaluations.TabIndex = 5;
            this.lblEvaluations.Text = "Teacher";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(65, 229);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(90, 32);
            this.lblCode.TabIndex = 4;
            this.lblCode.Text = "Name";
            // 
            // lblSectionId
            // 
            this.lblSectionId.AutoSize = true;
            this.lblSectionId.Location = new System.Drawing.Point(10, 146);
            this.lblSectionId.Name = "lblSectionId";
            this.lblSectionId.Size = new System.Drawing.Size(145, 32);
            this.lblSectionId.TabIndex = 3;
            this.lblSectionId.Text = "Section ID";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(171, 226);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(363, 38);
            this.txtName.TabIndex = 5;
            // 
            // txtSectionId
            // 
            this.txtSectionId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSectionId.Location = new System.Drawing.Point(171, 143);
            this.txtSectionId.Name = "txtSectionId";
            this.txtSectionId.Size = new System.Drawing.Size(313, 38);
            this.txtSectionId.TabIndex = 4;
            // 
            // btnReset
            // 
            this.btnReset.BackgroundImage = global::Assignment4.Properties.Resources.reset_128;
            this.btnReset.Location = new System.Drawing.Point(831, 810);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(132, 129);
            this.btnReset.TabIndex = 9;
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = global::Assignment4.Properties.Resources.save_128;
            this.btnSave.Location = new System.Drawing.Point(655, 810);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(132, 129);
            this.btnSave.TabIndex = 8;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // grpCourse
            // 
            this.grpCourse.Controls.Add(this.txtCourseName);
            this.grpCourse.Controls.Add(this.txtCourse);
            this.grpCourse.Location = new System.Drawing.Point(63, 90);
            this.grpCourse.Name = "grpCourse";
            this.grpCourse.Size = new System.Drawing.Size(903, 100);
            this.grpCourse.TabIndex = 3;
            this.grpCourse.TabStop = false;
            this.grpCourse.Text = "Selected course";
            // 
            // txtCourseName
            // 
            this.txtCourseName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCourseName.Enabled = false;
            this.txtCourseName.Location = new System.Drawing.Point(414, 37);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(455, 38);
            this.txtCourseName.TabIndex = 1;
            // 
            // txtCourse
            // 
            this.txtCourse.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCourse.Enabled = false;
            this.txtCourse.Location = new System.Drawing.Point(18, 37);
            this.txtCourse.Name = "txtCourse";
            this.txtCourse.Size = new System.Drawing.Size(370, 38);
            this.txtCourse.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(403, 32);
            this.label1.TabIndex = 10;
            this.label1.Text = "Wagner D\'Amaral - 300932673";
            // 
            // FormAddSection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 973);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpCourse);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panel1);
            this.Name = "FormAddSection";
            this.Text = "Add Section";
            this.Load += new System.EventHandler(this.FormAddSection_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grpCourse.ResumeLayout(false);
            this.grpCourse.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSectionId;
        private System.Windows.Forms.Label lblEvaluations;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblSectionId;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ComboBox cmbSemester;
        private System.Windows.Forms.Label lblSemester;
        private System.Windows.Forms.GroupBox grpCourse;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.TextBox txtCourse;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.ComboBox cmbCourse;
        private System.Windows.Forms.TextBox txtCourseNameSel;
        private System.Windows.Forms.ListView lstTeachers;
        private System.Windows.Forms.ColumnHeader regNumber;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.Label label1;
    }
}