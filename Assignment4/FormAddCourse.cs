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
    public partial class FormAddCourse : Form
    {
        CourseManager courseManager;
        FormMain formMain;
        public FormAddCourse(CourseManager courseManager, FormMain formMain)
        {
            this.courseManager = courseManager;
            this.formMain = formMain;
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtCourseCode.ResetText();
            txtDescription.ResetText();
            txtName.ResetText();
            txtNoEvaluations.ResetText();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtCourseCode.Text != "" || txtName.Text != "")
            {
                Course course = new Course();
                try
                {
                    course.CourseCode = txtCourseCode.Text;
                    course.Name = txtName.Text;
                    course.NoOfEvaluations = (int)txtNoEvaluations.Value;
                    course.Description = txtDescription.Text;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error!");
                }
                
                courseManager.AddCourse(course);
                formMain.AddCourseToList(course);
                btnReset.PerformClick();
                formMain.btnAddSection.Enabled = true;

            }
            else
            {
                MessageBox.Show("Course code and name cannot be blank.", "Fail!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
