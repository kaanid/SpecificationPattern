using ConsoleAppBussniss2;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace ConsoleApp33Specification
{
    public class NameUserExpressionSpecification : CompositeSpecification<User>
    {
        public override Expression<Func<User, bool>> ToExpression()
        {
            return (m) => !string.IsNullOrWhiteSpace(m.Name);
        }
    }
    public class AgeUserExpressionSpecification : CompositeSpecification<User>
    {
        public override Expression<Func<User, bool>> ToExpression()
        {
            return (m) => m.Age > 18;
        }
    }


    public class SexUserExpressionSpecification : CompositeSpecification<User>
    {
        public override Expression<Func<User, bool>> ToExpression()
        {
            return m => m.Sex == Sex.Female;
        }
    }

    public class InfoUserExpressionSpecification : CompositeSpecification<User>
    {
        public override Expression<Func<User, bool>> ToExpression()
        {
            return m => m.Info != null && m.Info.Length > 6;
        }
    }

}
