using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/* Delegate : 
 *   Delegate in Csharp is nothing but a functional pointer which contains the function reference.
 *   Usually we use delegates as a function reference parameter while we are calling the method.
 *   
 *   Delegate do't have any implementaion details.
 * */

namespace DelegatesBascisNamespace
{
    class DelegatesBasics
    {
        //delegate double operation(double a, double b);
        public delegate double Operation();

       //I have appoint the Mathoperation and its taking 2 argements
       public delegate double MathOperation(double a , double b);



        public double performOperation(Operation op)
        {
            return op();  //getValue();
        }

        // I am going to call performMathOperation from Main method
        // a --> contains first value
        // b --> contains second value
        public double performMathOperation(double a , double b ,MathOperation mathOp)
        {
            return mathOp(a, b);  //getValue();
        }


    }


    class Program
    {
        public static double getValue()
        {
            return 10.09;
        }

        public static double getValue1()
        {
            return 11.09;
        }

       
        public static double Addition(double fValue , double sValue)
        {
            return fValue + sValue;
        }

        public static double Substration(double fValue, double sValue)
        {
            return fValue - sValue;
        }

        public static double Division(double fValue, double sValue)
        {
            return fValue / sValue;
        }

        public static double Multiply(double fValue, double sValue)
        {
            return fValue * sValue;
        }


        static void Main()
        {

            //Delegates

            //Func , Action , Predicate(RealtimeExamples)

            DelegatesBasics delegatesBasics = new DelegatesBasics();
            delegatesBasics.performOperation(getValue);
            delegatesBasics.performOperation(getValue1);

            //Program.Addition(10.09, 11.90);


            //Delegate and your method signature should be having same pattern
            delegatesBasics.performMathOperation(10.09, 20.89, Addition);

            delegatesBasics.performMathOperation(100.09, 20.89, Substration);

            delegatesBasics.performMathOperation(10.09, 20.89, Division);

            delegatesBasics.performMathOperation(10.09, 20.89, Multiply);


        }


        //public static double add()
        //{
        //    return x + y;
        //}


    }
}
