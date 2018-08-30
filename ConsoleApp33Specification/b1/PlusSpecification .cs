using ConsoleAppBussniss;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp33Specification
{
    public class PlusSpecification : CompositeSpecification<int>
    {
        public override bool IsStatisfiedBy(int candidate)
        {
            return candidate > 0;
        }
    }
}
