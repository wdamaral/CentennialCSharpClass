namespace Assignment4
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.grpSchoolIcons = new System.Windows.Forms.GroupBox();
            this.btnAddSection = new System.Windows.Forms.Button();
            this.btnAddTeacher = new System.Windows.Forms.Button();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLoadSchool = new System.Windows.Forms.Button();
            this.btnSaveSchool = new System.Windows.Forms.Button();
            this.grpCourses = new System.Windows.Forms.GroupBox();
            this.lstCourses = new System.Windows.Forms.ListView();
            this.Code = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Sections = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Evaluations = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpSections = new System.Windows.Forms.GroupBox();
            this.lstSections = new System.Windows.Forms.ListView();
            this.secId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.secName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.secSemester = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.secNoEnrolments = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.secFaculty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpStudents = new System.Windows.Forms.GroupBox();
            this.lstStudents = new System.Windows.Forms.ListView();
            this.stdRegNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stdName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stdDOB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stdPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.grpSchoolIcons.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpCourses.SuspendLayout();
            this.grpSections.SuspendLayout();
            this.grpStudents.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpSchoolIcons
            // 
            this.grpSchoolIcons.Controls.Add(this.btnAddSection);
            this.grpSchoolIcons.Controls.Add(this.btnAddTeacher);
            this.grpSchoolIcons.Controls.Add(this.btnAddStudent);
            this.grpSchoolIcons.Controls.Add(this.btnAddCourse);
            this.grpSchoolIcons.Location = new System.Drawing.Point(12, 93);
            this.grpSchoolIcons.Name = "grpSchoolIcons";
            this.grpSchoolIcons.Size = new System.Drawing.Size(1795, 305);
            this.grpSchoolIcons.TabIndex = 4;
            this.grpSchoolIcons.TabStop = false;
            this.grpSchoolIcons.Text = "School Register";
            // 
            // btnAddSection
            // 
            this.btnAddSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSection.Image = global::Assignment4.Properties.Resources.section_128;
            this.btnAddSection.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddSection.Location = new System.Drawing.Point(541, 78);
            this.btnAddSection.Name = "btnAddSection";
            this.btnAddSection.Size = new System.Drawing.Size(200, 183);
            this.btnAddSection.TabIndex = 2;
            this.btnAddSection.Text = "Add Section";
            this.btnAddSection.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnAddSection.UseVisualStyleBackColor = true;
            this.btnAddSection.Click += new System.EventHandler(this.btnAddSection_Click);
            // 
            // btnAddTeacher
            // 
            this.btnAddTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTeacher.Image = global::Assignment4.Properties.Resources.teacher_128;
            this.btnAddTeacher.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddTeacher.Location = new System.Drawing.Point(1049, 78);
            this.btnAddTeacher.Name = "btnAddTeacher";
            this.btnAddTeacher.Size = new System.Drawing.Size(200, 183);
            this.btnAddTeacher.TabIndex = 3;
            this.btnAddTeacher.Text = "Add Teacher";
            this.btnAddTeacher.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddTeacher.UseVisualStyleBackColor = true;
            this.btnAddTeacher.Click += new System.EventHandler(this.btnAddTeacher_Click);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStudent.Image = global::Assignment4.Properties.Resources.student_128;
            this.btnAddStudent.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddStudent.Location = new System.Drawing.Point(1557, 78);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(200, 183);
            this.btnAddStudent.TabIndex = 4;
            this.btnAddStudent.Text = "Add Student";
            this.btnAddStudent.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddStudent.UseVisualStyleBackColor = false;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCourse.Image = global::Assignment4.Properties.Resources.course_128;
            this.btnAddCourse.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddCourse.Location = new System.Drawing.Point(33, 78);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(200, 183);
            this.btnAddCourse.TabIndex = 1;
            this.btnAddCourse.Text = "Add Course";
            this.btnAddCourse.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddCourse.UseVisualStyleBackColor = true;
            this.btnAddCourse.Click += new System.EventHandler(this.btnAddCourse_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLoadSchool);
            this.groupBox1.Controls.Add(this.btnSaveSchool);
            this.groupBox1.Location = new System.Drawing.Point(1538, 435);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 512);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "School Control";
            // 
            // btnLoadSchool
            // 
            this.btnLoadSchool.Image = global::Assignment4.Properties.Resources.load_128;
            this.btnLoadSchool.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLoadSchool.Location = new System.Drawing.Point(33, 275);
            this.btnLoadSchool.Name = "btnLoadSchool";
            this.btnLoadSchool.Size = new System.Drawing.Size(200, 183);
            this.btnLoadSchool.TabIndex = 6;
            this.btnLoadSchool.Text = "Load School";
            this.btnLoadSchool.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLoadSchool.UseVisualStyleBackColor = true;
            this.btnLoadSchool.Click += new System.EventHandler(this.btnLoadSchool_Click);
            // 
            // btnSaveSchool
            // 
            this.btnSaveSchool.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveSchool.Image")));
            this.btnSaveSchool.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSaveSchool.Location = new System.Drawing.Point(33, 65);
            this.btnSaveSchool.Name = "btnSaveSchool";
            this.btnSaveSchool.Size = new System.Drawing.Size(200, 183);
            this.btnSaveSchool.TabIndex = 5;
            this.btnSaveSchool.Text = "Save School";
            this.btnSaveSchool.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSaveSchool.UseVisualStyleBackColor = true;
            this.btnSaveSchool.Click += new System.EventHandler(this.btnSaveSchool_Click);
            // 
            // grpCourses
            // 
            this.grpCourses.Controls.Add(this.lstCourses);
            this.grpCourses.Location = new System.Drawing.Point(12, 435);
            this.grpCourses.Name = "grpCourses";
            this.grpCourses.Size = new System.Drawing.Size(1496, 512);
            this.grpCourses.TabIndex = 99;
            this.grpCourses.TabStop = false;
            this.grpCourses.Text = "Courses";
            // 
            // lstCourses
            // 
            this.lstCourses.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Code,
            this.Description,
            this.Sections,
            this.Evaluations});
            this.lstCourses.FullRowSelect = true;
            this.lstCourses.GridLines = true;
            this.lstCourses.Location = new System.Drawing.Point(33, 60);
            this.lstCourses.MultiSelect = false;
            this.lstCourses.Name = "lstCourses";
            this.lstCourses.Size = new System.Drawing.Size(1439, 415);
            this.lstCourses.TabIndex = 0;
            this.lstCourses.UseCompatibleStateImageBehavior = false;
            this.lstCourses.View = System.Windows.Forms.View.Details;
            this.lstCourses.SelectedIndexChanged += new System.EventHandler(this.lstCourses_SelectedIndexChanged);
            this.lstCourses.DoubleClick += new System.EventHandler(this.lstCourses_DoubleClick);
            // 
            // Code
            // 
            this.Code.Text = "Code";
            this.Code.Width = 142;
            // 
            // Description
            // 
            this.Description.Text = "Description";
            this.Description.Width = 689;
            // 
            // Sections
            // 
            this.Sections.Text = "# Sections";
            this.Sections.Width = 169;
            // 
            // Evaluations
            // 
            this.Evaluations.Text = "# Evaluations";
            this.Evaluations.Width = 185;
            // 
            // grpSections
            // 
            this.grpSections.Controls.Add(this.lstSections);
            this.grpSections.Location = new System.Drawing.Point(12, 953);
            this.grpSections.Name = "grpSections";
            this.grpSections.Size = new System.Drawing.Size(943, 490);
            this.grpSections.TabIndex = 7;
            this.grpSections.TabStop = false;
            this.grpSections.Text = "Sections";
            // 
            // lstSections
            // 
            this.lstSections.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.secId,
            this.secName,
            this.secSemester,
            this.secNoEnrolments,
            this.secFaculty});
            this.lstSections.FullRowSelect = true;
            this.lstSections.GridLines = true;
            this.lstSections.Location = new System.Drawing.Point(33, 58);
            this.lstSections.MultiSelect = false;
            this.lstSections.Name = "lstSections";
            this.lstSections.Size = new System.Drawing.Size(887, 397);
            this.lstSections.TabIndex = 0;
            this.lstSections.UseCompatibleStateImageBehavior = false;
            this.lstSections.View = System.Windows.Forms.View.Details;
            this.lstSections.SelectedIndexChanged += new System.EventHandler(this.lstSections_SelectedIndexChanged);
            // 
            // secId
            // 
            this.secId.Text = "ID";
            this.secId.Width = 117;
            // 
            // secName
            // 
            this.secName.Text = "Name";
            this.secName.Width = 260;
            // 
            // secSemester
            // 
            this.secSemester.Text = "Semester";
            this.secSemester.Width = 193;
            // 
            // secNoEnrolments
            // 
            this.secNoEnrolments.Text = "# Enrolments";
            this.secNoEnrolments.Width = 201;
            // 
            // secFaculty
            // 
            this.secFaculty.Text = "Teacher";
            // 
            // grpStudents
            // 
            this.grpStudents.Controls.Add(this.lstStudents);
            this.grpStudents.Location = new System.Drawing.Point(975, 953);
            this.grpStudents.Name = "grpStudents";
            this.grpStudents.Size = new System.Drawing.Size(832, 490);
            this.grpStudents.TabIndex = 8;
            this.grpStudents.TabStop = false;
            this.grpStudents.Text = "Students";
            // 
            // lstStudents
            // 
            this.lstStudents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.stdRegNo,
            this.stdName,
            this.stdDOB,
            this.stdPhone});
            this.lstStudents.FullRowSelect = true;
            this.lstStudents.Location = new System.Drawing.Point(36, 58);
            this.lstStudents.MultiSelect = false;
            this.lstStudents.Name = "lstStudents";
            this.lstStudents.Size = new System.Drawing.Size(767, 377);
            this.lstStudents.TabIndex = 99;
            this.lstStudents.UseCompatibleStateImageBehavior = false;
            this.lstStudents.View = System.Windows.Forms.View.Details;
            // 
            // stdRegNo
            // 
            this.stdRegNo.Text = "Registration No";
            // 
            // stdName
            // 
            this.stdName.Text = "Name";
            // 
            // stdDOB
            // 
            this.stdDOB.Text = "Date of Birth";
            // 
            // stdPhone
            // 
            this.stdPhone.Text = "Telephone";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(403, 32);
            this.label1.TabIndex = 100;
            this.label1.Text = "Wagner D\'Amaral - 300932673";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(240F, 240F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1829, 1469);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpStudents);
            this.Controls.Add(this.grpSections);
            this.Controls.Add(this.grpCourses);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpSchoolIcons);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "School Administration";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.grpSchoolIcons.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.grpCourses.ResumeLayout(false);
            this.grpSections.ResumeLayout(false);
            this.grpStudents.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddCourse;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnAddTeacher;
        private System.Windows.Forms.GroupBox grpSchoolIcons;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSaveSchool;
        private System.Windows.Forms.Button btnLoadSchool;
        private System.Windows.Forms.GroupBox grpCourses;
        private System.Windows.Forms.ListView lstCourses;
        private System.Windows.Forms.GroupBox grpSections;
        private System.Windows.Forms.ListView lstSections;
        private System.Windows.Forms.GroupBox grpStudents;
        private System.Windows.Forms.ListView lstStudents;
        private System.Windows.Forms.ColumnHeader Code;
        private System.Windows.Forms.ColumnHeader Description;
        private System.Windows.Forms.ColumnHeader Sections;
        private System.Windows.Forms.ColumnHeader Evaluations;
        private System.Windows.Forms.ColumnHeader secId;
        private System.Windows.Forms.ColumnHeader secName;
        private System.Windows.Forms.ColumnHeader secSemester;
        private System.Windows.Forms.ColumnHeader secNoEnrolments;
        private System.Windows.Forms.ColumnHeader stdRegNo;
        private System.Windows.Forms.ColumnHeader stdName;
        private System.Windows.Forms.ColumnHeader stdDOB;
        private System.Windows.Forms.ColumnHeader stdPhone;
        private System.Windows.Forms.ColumnHeader secFaculty;
        public System.Windows.Forms.Button btnAddSection;
        private System.Windows.Forms.Label label1;
    }
}

