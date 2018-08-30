using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp33Specification
{
    public class User
    {
        public string Name { set; get; }
        public int Age { set; get; }
        public Sex Sex { set; get; }

        public string Info { set; get; }
    }

    public enum Sex
    {
        Male=0,
        Female=1
    }
}
