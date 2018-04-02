using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    [Serializable]
    public class Course
    {
        public const string SectionIsNotValidMessage = "Section is not valid.";
        public const string SectionAlreadyAssignedMessage = "Section is already assigned";
        private string courseCode;
        private string name;
        private string description;
        private int noOfEvaluations;
        private int numberOfSections;
        private Section[] sections;
        private int maxNumberOfSections;

        public Course()
        {
            maxNumberOfSections = 20;
            this.sections = new Section[this.maxNumberOfSections];
        }

        public Course(string courseCode, string name) : this()
        {
            this.courseCode = courseCode;
            this.name = name;
        }

        public int MaxNumberOfSections
        {
            get { return maxNumberOfSections; }
        }

        public string CourseCode
        {
            get { return courseCode; }
            set { courseCode = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public int NoOfEvaluations
        {
            get { return noOfEvaluations; }
            set {
                try
                {
                    if (numberOfSections == 0)
                    {
                        noOfEvaluations = value;
                    }
                    else
                    {
                        throw new Exception("Section is already assigned. Number of evaluations cannot be changed anymore");
                    }
                } catch(Exception ex)
                {
                    throw ex;
                }
               }
        }

        public int NumberOfSections
        {
            get { return numberOfSections; }
        }

        public Section[] Sections
        {
            get { return sections; }
        }

        public void AddSection(SemesterPeriod semester, string sectionId, string sectionName)
        {
            Section section = new Section()
            {
                Name = sectionName,
                SectionId = sectionId,
                MaxNumberOfStudents = 30
            };
            this.sections[numberOfSections++] = section;
            section.Course = this;
        }

        public void AddSection(Section section)
        {
            if (section.SectionId == null || section.Name == null)
            {
                throw new Exception("Section is not valid.");
            }
            else
            {
                if(section.Course == null)
                {
                    this.sections[numberOfSections++] = section;
                    section.Course = this;
                }
                else
                {
                    throw new Exception("Section is already assigned to " + section.Course.Name + " course");
                }
            }
        }

        public string GetInfo()
        {
            string info;
            info = string.Format("Course Code: {0}, Name: {1}, Description: {2}, No of Evaluations: {3}.\n" +
                                "No of Sections: {4}", 
                                CourseCode, Name, Description, NoOfEvaluations, NumberOfSections);

            for (int i = 0; i < NumberOfSections; i++)
            {
                info += string.Format("\n\t{0}: {1}", Name, sections[i].Name);
            }

            return info;
        }

    }
}
