using System;
using System.Collections.Generic;
using System.Text;

namespace Module_3_Task_2
{
    public class ClassA
    {
        public ClassA()
        {
            PowHandler = Pow;
        }

        public Action<bool> ShowHandler { get; set; }

        public Func<int, int, int> PowHandler { get; }

        public int Pow(int a, int b)
        {
            return a * b;
        }
    }
}
