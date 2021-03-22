using System;
using System.Collections.Generic;
using System.Text;

namespace Module_3_Task_2
{
    public class ClassB
    {
        private int _result;

        public Predicate<int> Calc(Func<int, int, int> function, int a, int b)
        {
            _result = function(a, b);
            Predicate<int> predicate = Result;
            return predicate;
        }

        public bool Result(int number)
        {
            if (_result % number == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
