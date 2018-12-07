using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_polymorfism
{
    class A
    {
        public string Description()
        {
            return "The object is of the type A";
        }
    }

    class B : A
    {
        public new string Description()
        {
            return "The object is of the type B";
        }
    }

    class C : A
    {
        public new string Description()
        {
            return "You just entered the Matrix!";
        }
    }
}
