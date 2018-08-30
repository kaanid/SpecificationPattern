using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace ConsoleAppBussniss
{
    public abstract class CompositeSpecification<T> : ISpecification<T>
    {
        public ISpecification<T> Add(ISpecification<T> other)
        {
            
            return new AddSpectification<T>(this, other);
        }

        public abstract bool IsStatisfiedBy(T candidate);

        public ISpecification<T> Not()
        {
            return new NotSpectification<T>(this);
        }

        public ISpecification<T> Or(ISpecification<T> other)
        {
            return new OrSpectification<T>(this,other);
        }
    }
}
