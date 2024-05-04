using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaca2
{
    public class Average
    {
        List<double> CalculateAverages(List<double[]> doubles)
        {
            List<double> Averages = new List<double>(); 
            
            foreach (double[] array in doubles)
            {

                Averages.Add(CalculateArrayAverage(array));
            }
            return Averages;
        }

        public double CalculateArrayAverage(double[] doubles)
        {
            double sum = 0;
            for(int i = 0;i < doubles.Length; i++)
            {
                sum += doubles[i];
            }
            return sum/doubles.Length;

        }
    }
}
