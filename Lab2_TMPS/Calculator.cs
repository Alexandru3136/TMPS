using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_TMPS
{
    // Clasa Singleton pentru Calculator
    public class Calculator
    {
        private static Calculator _instance;

        private Calculator() { }

        public static Calculator Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Calculator();
                }
                return _instance;
            }
        }

        public double ExecuteOperation(IOperation operation, double a, double b)
        {
            return operation.Calculate(a, b);
        }
    }
}
