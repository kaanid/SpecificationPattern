using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace ConsoleAppBussniss2
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

        public override Expression<Func<T, bool>> ToExpression()
        {
            var leftEx = one.ToExpression();
            var rightEx = other.ToExpression();

            var paramEx = Expression.Parameter(typeof(T));
            BinaryExpression orEx = Expression.OrElse(leftEx.Body, rightEx.Body);
            orEx = (BinaryExpression)(new ParameterReplacer(paramEx).Visit(orEx));

            return Expression.Lambda<Func<T, bool>>(orEx, paramEx);
        }

    }
}
