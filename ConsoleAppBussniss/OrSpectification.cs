using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppBussniss
{
    public class OrSpectification<T> : CompositeSpecification<T>
    {
        private ISpecification<T> one;
        private ISpecification<T> other;
        
        public OrSpectification(ISpecification<T> one,ISpecification<T> other)
        {
            this.one = one;
            this.other = other;
        }

        public override bool IsStatisfiedBy(T candidate)
        {
            return one.IsStatisfiedBy(candidate) || other.IsStatisfiedBy(candidate);
        }
    }
}
