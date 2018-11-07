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
    public partial class FormMain : Form
    {
        private CourseManager courseManager;
        private Course selectedCourse;
        private Section selectedSection;
        public List<Student> students;
        public List<Teacher> teachers;
        public FormMain()
        {
            InitializeComponent();
            courseManager = new CourseManager();
            students = new List<Student>();
            teachers = new List<Teacher>();
        }

        private void btnLoadSchool_Click(object sender, EventArgs e)
        {
            string fileName = "";

            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Binary files (*.dat)|*.dat";
            fileDialog.ShowDialog();
            fileName = fileDialog.FileName;

            if (fileName != "")
            {
                try
                {

                    courseManager.LoadSchool(fileName);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

                lstCourses.Items.Clear();
                foreach (Course course in courseManager.Courses)
                {
                    AddCourseToList(course);
                    foreach (Section section in course.Sections)
                    {
                        if (section.Faculty != null)
                        {
                            if (!teachers.Exists(x => x == section.Faculty))
                            {
                                teachers.Add(section.Faculty);
                            }
                        }
                        foreach (Enrolment enrol in section.Enrolments)
                        {
                            if (enrol != null)
                            {
                                students.Add(enrol.Student);
                            }
                        }
                    }
                }
                btnAddSection.Enabled = true;
                btnSaveSchool.Enabled = true;
            }
            
        }

        private void lstCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstCourses.SelectedItems.Count > 0)
            {
                lstSections.Items.Clear();

                GetSelectedCourse();

                foreach (Section section in selectedCourse.Sections)
                {
                    AddSectionToList(section);
                }
            }
            
        }

        private void GetSelectedCourse()
        {
            string code = "";

            code = checkSelection(lstCourses);

            selectedCourse = courseManager.Courses.FindLast(x => code == x.CourseCode);
            //selectedCourse = new Course()
            //{
            //    CourseCode = code
            //};
            //foreach (Course course in courseManager.Courses)
            //{
            //    if (selectedCourse.CourseCode == course.CourseCode)
            //    {
            //        selectedCourse = course;
            //    }
            //}
        }

        private void GetSelectedSection()
        {
            string code = "";

            code = checkSelection(lstSections);
            selectedSection = selectedCourse.Sections.FindLast(x => code == x.SectionId);
            //selectedSection = new Section()
            //{
            //    SectionId = code
            //};
            //foreach (Section section in selectedCourse.Sections)
            //{
            //    if (selectedSection.SectionId == section.SectionId)
            //    {
            //        selectedSection = section;
            //    }
            //}
        }

        private void lstSections_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstSections.SelectedItems.Count > 0)
            {
                lstStudents.Items.Clear();

                GetSelectedSection();

                foreach (Enrolment enrolment in selectedSection.Enrolments)
                {
                    AddStudentToList(enrolment);
                }
            }
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            FormAddCourse formAddCourse = new FormAddCourse(courseManager, this);
            formAddCourse.ShowDialog();
        }

        public void AddCourseToList(Course course)
        {
            lstCourses.Items.Add(
                        new ListViewItem(
                            new string[] {
                            course.CourseCode,
                            course.Description,
                            course.NumberOfSections.ToString(),
                            course.NoOfEvaluations.ToString()
                            })
                            );
        }

        public void AddStudentToList(Enrolment enrolment)
        {
            lstStudents.Items.Add(
                    new ListViewItem(
                        new string[] {
                            enrolment.Student.RegistrationNo.ToString(),
                            enrolment.Student.Name,
                            enrolment.Student.DOB.ToString("MM-dd-yyyy"),
                            enrolment.Student.TelephoneNumber.ToString("(###)###-####")
                        }));
        }

        public void AddSectionToList(Section section)
        {
            string[] str = null;
            if (section.Faculty != null)
            {
                 str = new string[] {
                            section.SectionId,
                            section.Name,
                            section.Semester.ToString(),
                            section.NumberOfEnrolments.ToString(),
                            section.Faculty.Name
                        };
            }
            else
            {
                str = new string[] {
                            section.SectionId,
                            section.Name,
                            section.Semester.ToString(),
                            section.NumberOfEnrolments.ToString()
                        };
            }

            lstSections.Items.Add(
                new ListViewItem(
                    str
                    ));

        }

        private void lstCourses_DoubleClick(object sender, EventArgs e)
        {
            string code = checkSelection(lstCourses);
            foreach (Course course in courseManager.Courses)
            {
                if (course.CourseCode == code)
                {
                    FormAddSection formAddSection = new FormAddSection(courseManager, this, course);
                    formAddSection.ShowDialog();
                }
            }
        }

        private string checkSelection(ListView lst)
        {
            string code = "";
            if (lst.SelectedItems.Count > 0)
            {
                code = lst.SelectedItems[0].Text;
            }

            return code;
        }

        private void btnAddSection_Click(object sender, EventArgs e)
        {
            FormAddSection formAddSection = new FormAddSection(courseManager, this);
            formAddSection.ShowDialog();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            btnAddSection.Enabled = false;
            btnSaveSchool.Enabled = false;
        }

        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            FormAddPerson formAddPerson = new FormAddPerson(courseManager, this, "teacher");
            formAddPerson.ShowDialog();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            FormAddPerson formAddPerson = new FormAddPerson(courseManager, this, "student");
            formAddPerson.ShowDialog();
        }

        private void btnSaveSchool_Click(object sender, EventArgs e)
        {
            try
            {

                courseManager.SaveSchoolInfo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }


            MessageBox.Show("School information saved successfully.", "Success!");
        }
    }
}
