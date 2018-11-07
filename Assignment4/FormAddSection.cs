using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Assignment1;

namespace Assignment4
{
    public partial class FormAddSection : Form
    {
        CourseManager courseManager;
        FormMain formMain;
        Course course;
        Teacher teacher;
        public FormAddSection(CourseManager courseManager, FormMain formMain)
        {
            this.courseManager = courseManager;
            this.formMain = formMain;
            InitializeComponent();
        }

        public FormAddSection(CourseManager courseManager, FormMain formMain, Course course):this(courseManager, formMain)
        {
            this.course = course;
            txtCourse.Text = course.CourseCode;
            txtCourseName.Text = course.Name;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtSectionId.ResetText();
            txtName.ResetText();
            //txtNoEvaluations.ResetText();
            cmbSemester.ResetText();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (lstTeachers.SelectedItems.Count <= 0 && lstTeachers.Items.Count > 0)
            {
                DialogResult result = MessageBox.Show("A teacher is not selected. Continue?", "Teacher", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    SaveForm();
                }
            }
            else
            {
                SaveForm();
            }
            
        }

        private void SaveForm()
        {
            int courseIndex = 0;
            if (txtSectionId.Text != "" || txtName.Text != "")
            {
                if (course == null)
                {
                    MessageBox.Show("Please, select a course.", "Error!");
                }
                else
                {
                    courseIndex = findCourse(course);
                    Section section = new Section();
                    try
                    {
                        section.SectionId = txtSectionId.Text;
                        section.Name = txtName.Text;
                        //section.MaxNumberOfStudents = txtMaxStudents;
                        section.Semester = (SemesterPeriod)Enum.Parse(typeof(SemesterPeriod), cmbSemester.Text);
                        if (teacher != null)
                        {
                            section.Faculty = teacher;
                        }
                        courseManager.Courses[courseIndex].AddSection(section);
                        btnReset.PerformClick();
                        MessageBox.Show("Section added.", "Success!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Section ID and name cannot be blank.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormAddSection_Load(object sender, EventArgs e)
        {
            foreach (SemesterPeriod item in Enum.GetValues(typeof(SemesterPeriod)))
            {
                cmbSemester.Items.Add(item);
            }

            foreach (Teacher teacher in formMain.teachers)
            {
                AddTeacherToList(teacher);
            }

            if (course != null)
            {
                grpCourse.Visible = true;
                txtCourseNameSel.Visible = false;
                cmbCourse.Visible = false;
                lblCourse.Visible = false;
            }
            else
            {
                grpCourse.Visible = false;
                cmbCourse.Visible = true;
                txtCourseNameSel.Visible = true;
                lblCourse.Visible = true;
                foreach (Course item in courseManager.Courses)
                {
                    cmbCourse.Items.Add(item.CourseCode);
                }
            }

            
        }

        private void cmbCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            foreach (Course course in courseManager.Courses)
            {
                if (cmbCourse.Text == course.CourseCode)
                {
                    txtCourseNameSel.Text = course.Name;
                    this.course = course;
                }
            }
        }

        private int findCourse(Course course)
        {
            //int i = 0;
            //for (i = 0; i < courseManager.Courses.Count; i++)
            //{
            //    if (course.CourseCode == courseManager.Courses[i].CourseCode)
            //    {
            //        return i;
            //    }
            //}

            return courseManager.Courses.FindIndex(x => course.CourseCode == x.CourseCode);
        }

        public void AddTeacherToList(Teacher teacher)
        {
            lstTeachers.Items.Add(
                    new ListViewItem(
                        new string[] {
                            teacher.RegistrationNo.ToString(),
                            teacher.Name
                        }));
        }

        private void lstTeachers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstTeachers.SelectedItems.Count > 0)
            {

                foreach (Teacher teacher in formMain.teachers)
                {
                    if (long.Parse(lstTeachers.SelectedItems[0].Text) == teacher.RegistrationNo)
                    {
                        this.teacher = teacher;
                    }
                }
            }
        }
    }
}
