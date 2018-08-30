using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace ConsoleAppBussniss2
{
    public abstract class CompositeSpecification<T> : ISpecification<T>
    {
        public abstract Expression<Func<T,bool>> ToExpression();
        public ISpecification<T> Add(ISpecification<T> other)
        {
            return new AddSpectification<T>(this, other);
        }

        public bool IsStatisfiedBy(T candidate)
        {
            var expression = ToExpression();
            Func<T, bool> predicate = expression.Compile();
            return predicate(candidate);
        }

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
