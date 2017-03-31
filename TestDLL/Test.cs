using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestDLL
{
    public class Test
    {
        public bool PassFailTest(bool result)
        {
            return result;
        }
    }

    public class Test2
    {
        public int Add(int x, int y)
        {
            return x + y;
        }
    }
}
