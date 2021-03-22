using System;

namespace Module_3_Task_2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var program = new Program();
            var a = new ClassA();
            var b = new ClassB();
            a.ShowHandler = program.Show;
            a.ShowHandler(b.Calc(a.PowHandler, 2, 3).Invoke(2));
        }

        public void Show(bool predicateResult)
        {
            Console.WriteLine(predicateResult);
        }
    }
}
