using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDelegate
{
    public delegate int SimpleDelegate();
    class MultiCastDelegate
    {
        public static int SimpleMethod1()
        {
            Console.WriteLine("Simple Method1 is invoked!!");
            return 1;
        }
        public static int SimpleMethod2()
        {
            Console.WriteLine("Simple Method2 is invoked!!");
            return 2;
        }
        public static int SimpleMethod3()
        {
            Console.WriteLine("Simple Method3 is invoked!!");
            return 3;
        }

        static void Main(string[] args)
        {
           SimpleDelegate sd1 = SimpleMethod1;
           sd1 += SimpleMethod2;
           sd1 += SimpleMethod3;
           //sd1 -= SimpleMethod3;

            //sd4();
            int value = sd1.Invoke();
            
            Console.WriteLine(value);
            Console.ReadKey();
        }
    }
}
