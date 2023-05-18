using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_TMPS
{
    // Factory Method pentru crearea operației de scădere
    public class SubtractionFactory : OperationFactory
    {
        public override IOperation CreateOperation()
        {
            return new Subtraction();
        }
    }
}
