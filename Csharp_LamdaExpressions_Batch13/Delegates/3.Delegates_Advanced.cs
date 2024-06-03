using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAdvanced
{
    class Program
    {
        delegate int SquareDelegate(int x);
        delegate void PrintMessageDelegatge(int x);
        delegate bool IsValidDelegate(int x);

        //SQuare is the method(Named)
        static int Square(int x)
        {
            return x * x;
        }
        static void PrintValue(int value)
        {
            Console.WriteLine(value);
        }
        static bool isCurrectValue(int value)
        {
            if (value == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void Main()
        {
            //Rule : Delegate the your referece method signature(parametrs,and return type) -- just cross-check and confirm
            SquareDelegate squareDelegate = Square;
            int result1 = squareDelegate(10);
            Console.WriteLine(result1);

            PrintMessageDelegatge printMessageDelegatge = PrintValue;
            printMessageDelegatge(10);

            IsValidDelegate isValidDelegate = isCurrectValue;
            bool result2 = isValidDelegate(1);
            Console.WriteLine(result2);

            //SquareDelegate squareDelegate = Square;//Adddress

            //Anonomous Method No address(By using delegate key word we can create anonomous)
            SquareDelegate squareDelegate1 = delegate (int y)
            {
                return y * y;
            };
            int result3 = squareDelegate1(10);
            Console.WriteLine(result3);


            //Lambda | Arrow is nothing but the way of your showing the delegate method in simple manner called lambda
            SquareDelegate squareDelegate3 = (int y) =>
            {
                return y * y;
            };
            int result4 = squareDelegate3(10);
            Console.WriteLine(result3);
            
            PrintMessageDelegatge printMessageDelegatge1 = delegate (int y)
            {
                Console.WriteLine(y);
            };
            //Lambda
            PrintMessageDelegatge printMessageDelegatge2 = (int y) =>
            {
                Console.WriteLine(y);
            };

            IsValidDelegate isValidDelegate1 = delegate (int y)
            {
                if (y == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            };
            bool result6 = isValidDelegate1(10);
            Console.WriteLine(result6);

            IsValidDelegate isValidDelegate2 = (int abc) =>
            {
                if (abc == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            };
            bool result7 = isValidDelegate2(10);
            Console.WriteLine(result7);



            Console.ReadLine();


        }
    }
}
