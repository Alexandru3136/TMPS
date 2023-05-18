using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_TMPS
{
    // Factory Method pentru crearea operațiilor
    public abstract class OperationFactory
    {
        public abstract IOperation CreateOperation();
    }

    // Factory Method pentru crearea operației de adunare
    public class AdditionFactory : OperationFactory
    {
        public override IOperation CreateOperation()
        {
            return new Addition();
        }
    }
}
