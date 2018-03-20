using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    [Serializable]
    public class Section
    {
        private string sectionId;
        private string name;
        private int maxNoOfEnrolments;
        private int noOfEnrolments;
        private SemesterPeriod semester;
        private Person faculty;
        private Enrolment[] enrolments;
        private Course course;



        public Section()
        {
            MaxNumberOfStudents = 40;
            this.enrolments = new Enrolment[MaxNumberOfStudents];
        }

        public Section(Course course, int maxNoOfStudents, SemesterPeriod semester)
        {
            MaxNumberOfStudents = maxNoOfStudents;
            Semester = semester;
            Course = course;
            this.enrolments = new Enrolment[MaxNumberOfStudents];
        }

        public Section(Course course, SemesterPeriod semester) : this()
        {
            this.semester = semester;
            this.course = course;
        }
        
        public string SectionId
        {
            get { return sectionId; }
            set { sectionId = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public SemesterPeriod Semester
        {
            get { return semester; }
            set { semester = value; }
        }

        public Person Faculty
        {
            get { return faculty; }
            set { faculty = value; }
        }

        public int MaxNumberOfStudents
        {
            get { return maxNoOfEnrolments; }
            set {
                    try
                    {
                        maxNoOfEnrolments = value;
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                 }
        }

        public int NumberOfEnrolments
        {
            get { return noOfEnrolments; }
        }

        public Course Course
        {
            get { return course; }
            set { course = value; }
        }

        public void AddStudent(Person student)
        {
            Enrolment enrolment;
            try
            {
                enrolment = new Enrolment(this, student, this.course.NoOfEvaluations);
            }
            catch (Exception)
            {
                throw new Exception("Student can only be assigned to the section that is assigned to the course");
            }

            if (MaxNumberOfStudents > noOfEnrolments)
            {
                this.enrolments[this.noOfEnrolments++] = enrolment;
                enrolment.Section = this;
            }
            else
            {
                throw new Exception("Student cannot be added. The section is full.");
            }

        }

        public void DefineEvaluation(int evaluationOrderNo, EvaluationType evaluationType, int maxPoints, double evaluationWeight)
        {
            for (int i = 0; i < noOfEnrolments; i++)
            {
                enrolments[i].Evaluations[evaluationOrderNo - 1].TypeOfEvaluation = evaluationType;
                enrolments[i].Evaluations[evaluationOrderNo - 1].MaxPoints = maxPoints;
                enrolments[i].Evaluations[evaluationOrderNo - 1].EvaluationWeight = evaluationWeight;
            }
        }

        public void AddStudentMark(int evaluationOrderNo, Person student, int points)
        {
            bool registered = false;
            int maxPoints = 0;
            for (int i = 0; i < noOfEnrolments; i++)
            {
                if (enrolments[i].Student.RegistrationNo == student.RegistrationNo)
                {
                    registered = true;
                    maxPoints = enrolments[i].Evaluations[evaluationOrderNo - 1].MaxPoints;

                    if (points > maxPoints)
                    {
                        throw new Exception("Points are more than the max number of points for the evaluation");
                    }
                    else
                    {
                        enrolments[i].Evaluations[evaluationOrderNo - 1].Points = points;
                        break;
                    }
                }
            }
            if (!registered)
            {
                throw new Exception("Student " + student.Name + " is not in the section");
            }
        }

        public string GetInfo()
        {
            string info;

            info = string.Format("Section Id: {0}, Name: {1}, Max no of Students: {2}, Semester: {3},\n",
                                    SectionId, Name, MaxNumberOfStudents, Semester);
            if (Faculty != null)
            {
                info += string.Format("\tFaculty: {0}\n", Faculty.Name);
            }

            info += string.Format("Number of students: {0}", NumberOfEnrolments);

            for (int i = 0; i < NumberOfEnrolments; i++)
            {
                info += string.Format("\n\t{0}",enrolments[i].Student.Name);
            }

            return info;
        }

        public string GetEvaluationsInfo()
        {
            string evalInfo;
            int i = 1;
            evalInfo = string.Format("\t");
            if (this.enrolments[0] != null)
            {
                foreach (Evaluation eval in enrolments[0].Evaluations)
                {
                    evalInfo += string.Format("{0}.{1}[{2}]\t", i, eval.TypeOfEvaluation, eval.MaxPoints);
                    i++;
                }
            }
            else
            {
                Console.WriteLine("No enrollments in the section");
            }
            

            for (i = 0; i < noOfEnrolments; i++)
            {
                evalInfo += string.Format("\n{0}\t", enrolments[i].Student.Name);
                foreach (Evaluation eval in enrolments[i].Evaluations)
                {
                    double weightAchived = eval.CalcWeightAchived(eval.Points, eval.MaxPoints, eval.EvaluationWeight);
                    evalInfo += string.Format("{0}/{1}\t\t", eval.Points, weightAchived);
                }
            }
            //evalInfo = String.Format("\t");
            return evalInfo;
        }

        public string FinalMarksInfo()
        {
            string finalInfo = "";
            for (int i = 0; i < noOfEnrolments; i++)
            {
                
                enrolments[i].CalculateFinalGrade();
                finalInfo += string.Format("{0}\t{1}\n", enrolments[i].Student.Name, enrolments[i].FinalGrade);
            }

            return finalInfo;
        }
    }
}
