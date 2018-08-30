using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppBussniss
{
    public interface ISpecification<T>
    {
        bool IsStatisfiedBy(T candidate);

        ISpecification<T> Add(ISpecification<T> other);
        ISpecification<T> Or(ISpecification<T> other);
        ISpecification<T> Not();
    }
}
