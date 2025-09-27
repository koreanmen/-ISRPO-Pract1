using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Media;

namespace _ISRPO_Pract1
{
    internal class Calcul
    {
        static public double Calc(double[,] matrix,out double totalSum)
        {
            totalSum = 0;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                bool hasZero = false;
                double columnSum = 0;

                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    columnSum += matrix[i, j];
                    if (matrix[i, j] == 0)
                        hasZero = true;
                }

                if (hasZero)
                {
                    totalSum += columnSum;
                }
            }
            return totalSum;
        }
    }
}
