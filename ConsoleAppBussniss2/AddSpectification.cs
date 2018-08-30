using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace ConsoleAppBussniss2
{
    public class AddSpectification<T> : CompositeSpecification<T>
    {
        private ISpecification<T> one;
        private ISpecification<T> other;
        
        public AddSpectification(ISpecification<T> one,ISpecification<T> other)
        {
            this.one = one;
            this.other = other;
        }

        public override Expression<Func<T, bool>> ToExpression()
        {
            var leftEx = one.ToExpression();
            var rightEx = other.ToExpression();

            var paramExpr = Expression.Parameter(typeof(T));
            BinaryExpression andEx = Expression.AndAlso(leftEx.Body, rightEx.Body);
            andEx = (BinaryExpression)(new ParameterReplacer(paramExpr).Visit(andEx));

            //return Expression.Lambda<Func<T, bool>>(andEx, leftEx.Parameters.Single());
            return Expression.Lambda<Func<T, bool>>(andEx, paramExpr);
        }
    }
}
