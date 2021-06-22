using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//It allows you to declare a method inside the body of an already defined method. 
//You are not allowed to use any member access modifiers in the local function
//

/* places where local functions are defined:

Methods
Constructors
Property accessors
Event accessor
Lambda expressions
Finalizers, a.k.a destructors
*/
namespace LocalFunction_csharp
{
    public class Program
    {

        public static void Main()
        {
            //-------------------------------------
            //ex1
            //local function
            void Demo(int x, int y)
            {
                Console.WriteLine(x + y);
                Console.ReadLine();
            }

            //calling local function
            Demo(10, 20);

            //------------------------------------
            //ex2
            //local generic functions

            void Demo2<MyGeneric>(MyGeneric value)
            {
                Console.WriteLine(value);
                Console.ReadLine();
            }
            //calling local generic function
            Demo2<int>(123);
            Demo2<string>("hello");
            //-----------------------------------------
          
        }
    }
}
