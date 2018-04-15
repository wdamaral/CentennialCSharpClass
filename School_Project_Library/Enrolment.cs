using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    [Serializable]
    public class Enrolment
    {
        private Student student;
        private Section section;
        private Grade finalGrade;
        private int noOfEvaluations;
        //private Evaluation[] evaluations;
        private List<Evaluation> evaluations;

        public Enrolment(Section section, Student student, int numberOfCourseEvaluations)
        {
            Section = section;
            Student = student;
            NoOfEvaluations = numberOfCourseEvaluations;
            //Evaluations = new Evaluation[numberOfCourseEvaluations];
            Evaluations = new List<Evaluation>();

            AddDefaultEvaluations();
            
        }

        public Student Student
        {
            get { return student; }
            set { student = value; }
        }

        public Section Section
        {
            get { return section; }
            set { section = value; }
        }

        public Grade FinalGrade
        {
            get { return finalGrade; }
            set { finalGrade = value; }
        }

        public int NoOfEvaluations
        {
            get { return noOfEvaluations; }
            private set { noOfEvaluations = value; }

        }

        //public Evaluation[] Evaluations
        public List<Evaluation> Evaluations
        {
            get { return evaluations; }
            private set { evaluations = value; }
        }

        public void CalculateFinalGrade()
        {
            int[] POSSIBLE_GRADES_CENTENNIAL = { 49, 54, 59, 64, 69, 74, 89, 100 };
            double finalGrade = 0;

            foreach (Evaluation eval in evaluations)
            {
                finalGrade += ((double)eval.Points / (double)eval.MaxPoints) * eval.EvaluationWeight;
            }
            finalGrade *= 100;

            foreach (int grade in POSSIBLE_GRADES_CENTENNIAL)
            {
                if((int)finalGrade <= grade)
                {
                    this.finalGrade = (Grade)grade;
                    break;
                }
            }
        }

        private void AddDefaultEvaluations()
        {
            for (int i = 0; i < NoOfEvaluations; i++)
            {
                //evaluations[i] = new Evaluation();
                evaluations.Add(new Evaluation());
            }
        }

        //public string GetInfo()
        //{
        //    return String.Format("Student: {0}, \nSection: {1} \nFinal Grade: {2}",
        //                        Student.GetInfo(), Section.GetInfo(), FinalGrade);
        //}
    }
}
