using System;
namespace Lab2_TMPS
{
    // Interfața pentru operații matematice
    public interface IOperation
    {
        double Calculate(double a, double b);
    }

    // Operația de adunare
    public class Addition : IOperation
    {
        public double Calculate(double a, double b)
        {
            return a + b;
        }
    }
}