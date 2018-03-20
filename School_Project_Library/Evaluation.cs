using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    [Serializable]
    public class Evaluation
    {
        private EvaluationType typeOfEvaluation;
        private double evaluationWeight;
        private int maxPoints;
        private int points;

        public Evaluation() { }

        public Evaluation(EvaluationType typeOfEvaluation, int maxPoints, double evaluationWeight)
        {
            TypeOfEvaluation = typeOfEvaluation;
            MaxPoints = maxPoints;
            EvaluationWeight = evaluationWeight;
        }

        public EvaluationType TypeOfEvaluation
        {
            get { return typeOfEvaluation; }
            set { typeOfEvaluation = value; }
        }

        public double EvaluationWeight
        {
            get { return evaluationWeight; }
            set
            {
                evaluationWeight = value;
            }
        }

        public int MaxPoints
        {
            get { return maxPoints; }
            set
            {
                maxPoints = value;
            }
        }

        public int Points
        {
            get { return points; }
            set { points = value; }
        }

        public string GetInfo()
        {
            return String.Format("Evaluation: {0}, Weight: {1}, Maximum points: {2}, Points: {3}.",
                                    TypeOfEvaluation, EvaluationWeight, MaxPoints, Points);
        }

        public double CalcWeightAchived(int points, double maxPoints, double weight)
        {
            return ((points / maxPoints * weight) * 100);
        }
        
    }
}
