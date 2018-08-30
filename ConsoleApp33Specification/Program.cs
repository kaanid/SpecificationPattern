using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp33Specification
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var items = Enumerable.Range(-5, 10);

            var oddSpeck = new OddSpecification();

            var plusSpeck = new PlusSpecification();

            var or = oddSpeck.Or(plusSpeck);

            foreach(var i in items)
            {
                Console.WriteLine($"{i} {or.IsStatisfiedBy(i)}");
            }

            var userList = new List<User> {
                new User{  },
                new User{ Age=2 },
                new User{ Name="acc",Sex=Sex.Female,Age=8,Info="Beautiful MM" },
                new User{ Name="bdd",Sex=Sex.Female,Age=20,Info="Beautiful MM" }
            };

            var s1 = new NameUserSpecification();
            var s2 = new AgeUserSpecification();
            var s3 = new SexUserSpecification();
            var s4 = new InfoUserSpecification();

            var op = s1.Add(s2).Add(s3).Add(s4).Not();
            foreach(var m in userList)
            {
                Console.WriteLine($" name:{m.Name} flag:{op.IsStatisfiedBy(m)}");
            }

            Console.WriteLine("...............................");

            var s21 = new NameUserExpressionSpecification();
            var s22 = new AgeUserExpressionSpecification();
            var s23 = new SexUserExpressionSpecification();
            var s24 = new InfoUserExpressionSpecification();

            var op2 = s21.Add(s22).Add(s23).Add(s24).Not();
            foreach (var m in userList)
            {
                Console.WriteLine($" name:{m.Name} flag:{op2.IsStatisfiedBy(m)} ");
            }

        }
    }
}
