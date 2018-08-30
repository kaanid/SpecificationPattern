using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace ConsoleAppBussniss2
{
    public class NotSpectification<T> : CompositeSpecification<T>
    {
        private ISpecification<T> one;
        
        public NotSpectification(ISpecification<T> one)
        {
            this.one = one;
        }

        public override Expression<Func<T, bool>> ToExpression()
        {
            var leftEx = one.ToExpression();
            var notEx= Expression.Not(leftEx.Body);

            var paramEx = Expression.Parameter(typeof(T));

            notEx = (UnaryExpression)(new ParameterReplacer(paramEx).Visit(notEx));

            return Expression.Lambda<Func<T, bool>>(notEx, paramEx);
        }
    }
}
