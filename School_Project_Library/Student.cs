using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    [Serializable]
    public class Student : Person
    {
        public List<Section> Sections { get; set; }


        public Student() : base()
        {
            Sections = new List<Section>();
        }
        public Student(string name, DateTime dOB) : base(name, dOB) { }


        public string PrintTranscript()
        {
            string info = "";
            foreach (Section section in Sections)
            {
                int myIndex = findMyIndex(section);
                info += String.Format("{0} {1}\n", section.Course.CourseCode, section.Enrolments[myIndex].FinalGrade);
            }
            return info;
        }

        private int findMyIndex(Section section)
        {
            int myIndex = 0;
            for(int i = 0; i < section.Enrolments.Count; i++)
            {
                if (section.Enrolments[i].Student.RegistrationNo == RegistrationNo)
                {
                    myIndex = i;
                    break;
                }
            }
            return myIndex;
        }
    }
}
