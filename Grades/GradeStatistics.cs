﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class GradeStatistics
    {
        public GradeStatistics() // default constructor
        {
            HighestGrade = 0;
            LowestGrade = float.MaxValue;
        }

        public float Averagegrade;
        public float HighestGrade;
        public float LowestGrade;

    }
}
