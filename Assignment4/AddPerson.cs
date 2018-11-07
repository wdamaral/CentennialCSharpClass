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
    public partial class FormAddPerson : Form
    {
        string personType;
        FormMain formMain;
        CourseManager courseManager;
        //Section section;
        int idCourse;
        int idSection;
        public FormAddPerson(CourseManager courseManager, FormMain formMain, string personType)
        {
            this.courseManager = courseManager;
            this.formMain = formMain;
            this.personType = personType;
            InitializeComponent();
        }

        private void AddPerson_Load(object sender, EventArgs e)
        {
            if (personType == "teacher")
            {
                grpAddPerson.Text = "Add Teacher";
                this.Text = "Add Teacher";
                grpRegistered.Text = "Teachers registered";
                
                foreach (Teacher teacher in formMain.teachers)
                {
                    AddPersonToList(teacher);
                }
            }
            else
            {
                grpAddPerson.Text = "Add Student";
                this.Text = "Add Student";

                grpRegistered.Text = "Students registered";
                foreach (Student student in formMain.students)
                {
                    AddPersonToList(student);
                }
            }


            foreach (Course course in courseManager.Courses)
            {
                for (int i = 0; i < course.Sections.Count; i++)
                {
                    AddCourseSectionToList(course, i);
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtCity.ResetText();
            txtName.ResetText();
            txtPhone.ResetText();
            txtProvince.ResetText();
            dtpDOB.ResetText();
            txtAddress.ResetText();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "")
            {
                txtPhone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                Address address = new Address()
                {
                    StreetAddress = txtAddress.Text,
                    City = txtCity.Text,
                    ProvinceOrTerritory = txtProvince.Text
                };
                if (personType == "teacher")
                {
                    Teacher teacher = new Teacher(txtName.Text, dtpDOB.Value)
                    {
                        Address = address,
                        TelephoneNumber = double.Parse(txtPhone.Text)
                    };

                    if (lstCourseSec.SelectedItems.Count > 0)
                    {
                        courseManager.Courses[idCourse].Sections[idSection].Faculty = teacher;
                    }
                    formMain.teachers.Add(teacher);
                    AddPersonToList(teacher);
                    lstCourseSec.Items.Clear();
                    foreach (Course course in courseManager.Courses)
                    {
                        for (int i = 0; i < course.Sections.Count; i++)
                        {
                            AddCourseSectionToList(course, i);
                        }
                    }

                }
                else
                {
                    Student student = new Student()
                    {
                        Address = address,
                        Name = txtName.Text,
                        DOB = dtpDOB.Value,
                        TelephoneNumber = double.Parse(txtPhone.Text)
                    };
                    if (lstCourseSec.SelectedItems.Count > 0)
                    {
                        courseManager.Courses[idCourse].Sections[idSection].AddStudent(student);
                    }
                    formMain.students.Add(student);
                    AddPersonToList(student);
                }
                MessageBox.Show("A new " + personType + " was registered.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnReset.PerformClick();
            }
            else
            {
                MessageBox.Show("Name cannot be blank.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void AddPersonToList(Person person)
        {
            lstPersons.Items.Add(
                    new ListViewItem(
                        new string[] {
                            person.RegistrationNo.ToString(),
                            person.Name,
                            person.DOB.ToString("MM-dd-yyyy"),
                            person.TelephoneNumber.ToString("(###)###-####"),
                            person.Address.StreetAddress,
                            person.Address.City,
                            person.Address.ProvinceOrTerritory
                        }));
        }

        private void AddCourseSectionToList(Course course, int id)
        {
            string[] info = null;

            if (course.Sections[id].Faculty != null)
            {
                info = new string[] {
                            course.CourseCode,
                            course.Name,
                            course.Sections[id].SectionId,
                            course.Sections[id].Name,
                            course.Sections[id].Faculty.Name
                        };
            }
            else
            {
                info = new string[] {
                            course.CourseCode,
                            course.Name,
                            course.Sections[id].SectionId,
                            course.Sections[id].Name
                        };
            }
            lstCourseSec.Items.Add(
                    new ListViewItem(
                            info
                        ));
        }

        private void lstCourseSec_SelectedIndexChanged(object sender, EventArgs e)
        {
            findCourse(out idCourse, out idSection);
        }
        private void findCourse(out int idCourse, out int idSection)
        {
            //int i = 0;
            //int j = 0;
            int numSection = -1, numCourse = -1;
            if (lstCourseSec.SelectedItems.Count > 0)
            {
                numCourse = courseManager.Courses.FindIndex(x => lstCourseSec.SelectedItems[0].Text == x.CourseCode);
                numSection = courseManager.Courses[numCourse].Sections.FindIndex(x => lstCourseSec.SelectedItems[0].SubItems[2].Text == x.SectionId);
            }
            idCourse = numCourse;
            idSection = numSection;
            //    foreach (Course course in courseManager.Courses)
            //    {
            //        if (lstCourseSec.SelectedItems[0].Text == course.CourseCode)
            //        {
            //            foreach (Section sec in course.Sections)
            //            {
            //                if (lstCourseSec.SelectedItems[0].SubItems[2].Text == sec.SectionId)
            //                {
            //                    this.section = sec;
            //                    numCourse = i;
            //                    numSection = j;
            //                }
            //                j++;
            //            }
            //        }
            //        i++;
            //    }
            //}
            //idSection = numSection;
            //idCourse = numCourse;
        }

        private void lstPersons_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstPersons.SelectedItems.Count > 0 && personType == "teacher")
            {
                Teacher teacher = formMain.teachers.FindLast(x => lstPersons.SelectedItems[0].Text == x.RegistrationNo.ToString());
                lblTeacher.Text = teacher.SectionsInfo();
            }
            else
            {
                lblTeacher.Text = null;
            }
        }
    }
}
