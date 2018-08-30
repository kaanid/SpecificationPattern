using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppBussniss
{
    public class NotSpectification<T> : CompositeSpecification<T>
    {
        private ISpecification<T> one;
        
        public NotSpectification(ISpecification<T> one)
        {
            this.one = one;
        }

        public override bool IsStatisfiedBy(T candidate)
        {
            return !one.IsStatisfiedBy(candidate);
        }
    }
}
