using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_TMPS
{
    // Operația de scădere
    public class Subtraction : IOperation
    {
        public double Calculate(double a, double b)
        {
            return a - b;
        }
    }
}
