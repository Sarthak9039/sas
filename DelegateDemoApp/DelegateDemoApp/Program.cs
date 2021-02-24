
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemoApp
{
    delegate int MathsDelegate(int num1, int num2);//declaration
    class Program
    {
        //2 declare method
        static int AddNumbers(int x , int y)
        {
            return x + y;
        }

        static void Main(string[] args)
        {
            //3 create delegate instance which point to a method
          //  MathsDelegate mathDelegateObj = new MathsDelegate(AddNumbers);//addnumber is point to addnumber method
            MathsDelegate mathsDelegate = AddNumbers;

            //4 invoke delegate which internally invoke method
            int result = mathsDelegate(3, 4);
            Console.WriteLine("adition : " + result);

            //anonymous method-2.0-2005
            //merging step2 and step3

            MathsDelegate mathsDelegateObj1 = delegate (int p, int q)
                 {
                     return p - q;
                 };
            result = mathsDelegateObj1(12, 6);
            Console.WriteLine("Substraction : " + result);

            //lambda expression- f/w 3.5-2008
            //(input para) => expresion

            mathsDelegateObj1 = (a, b) => a / b;
            result = mathsDelegateObj1(36, 6);
            Console.WriteLine("Division : " + result);
            Console.ReadLine();
        }
    }
}
