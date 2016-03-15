using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public class GradeStatistics
    {
        public GradeStatistics() // default constructor
        {
            HighestGrade = 0;
            LowestGrade = float.MaxValue;
        }

        public float Averagegrade;
        public float HighestGrade;
        public float LowestGrade;

        public string Description
        {
            get
            {
                string result;
                switch (LetterGrade)
                {
                    case "A":
                        result = "Excellent";
                        break;
                    case "B":
                        result = "Above average";
                        break;
                    case "C":
                        result = "Average";
                        break;
                    case "D":
                        result = "Bellow average";
                        break;
                    default:
                        result = "Fail";
                        break;
                        
                }

                return result;
            }
        }

        public string LetterGrade
        {
            get
            {
                string result;
                if (Averagegrade >= 90)
                {
                    result = "A";
                }
                else if (Averagegrade >= 80)
                {
                    result = "B";
                }
                else if (Averagegrade >= 70)
                {
                    result = "C";
                }
                else if (Averagegrade >= 60)
                {
                    result = "D";
                }
                else
                {
                    result = "F";
                }

                return result;
            }
        }
    }
}
