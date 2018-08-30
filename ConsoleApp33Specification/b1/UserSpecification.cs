using ConsoleAppBussniss;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp33Specification
{
    public class NameUserSpecification : CompositeSpecification<User>
    {
        public override bool IsStatisfiedBy(User candidate)
        {
            return !string.IsNullOrWhiteSpace(candidate.Name);
        }
    }

    public class AgeUserSpecification : CompositeSpecification<User>
    {
        public override bool IsStatisfiedBy(User candidate)
        {
            return candidate.Age > 18;
        }
    }


    public class SexUserSpecification : CompositeSpecification<User>
    {
        public override bool IsStatisfiedBy(User candidate)
        {
            return candidate.Sex == Sex.Female;
        }
    }

    public class InfoUserSpecification : CompositeSpecification<User>
    {
        public override bool IsStatisfiedBy(User candidate)
        {
            return (candidate.Info?.Length??0) > 6;
        }
    }
}
