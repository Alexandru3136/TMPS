using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab2_TMPS;

class Program
{
    static void Main(string[] args)
    {
        // Utilizare Singleton
        Calculator calculator = Calculator.Instance;

        // Utilizare Factory Method
        OperationFactory factory = new AdditionFactory();
        IOperation operation = factory.CreateOperation();

        double result = calculator.ExecuteOperation(operation, 5, 3);
        Console.WriteLine("Addition: 5 + 3 = " + result);

        factory = new SubtractionFactory();
        operation = factory.CreateOperation();

        result = calculator.ExecuteOperation(operation, 5, 3);
        Console.WriteLine("Subtraction: 5 - 3 = " + result);

        Console.ReadLine();
    }
}
