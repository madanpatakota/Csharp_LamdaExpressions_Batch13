using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuiltinDelegateBasicsNameSpace
{

    //do't think only methods are members

    //every thing if you write in side the class i.e. member (Access Speficiers)
    internal class Program
    {
        // delegate int delResult(int y);

        delegate string delResult(string y);

        public static string GetEmployeeID(string EmployeeID)
        {
            return EmployeeID;
        }

        public static void Main()
        {

            string EmployeeID = GetEmployeeID("TCS123345");
            Console.WriteLine("EmployeeID is", EmployeeID);

            delResult del1 = delegate (string y)
                                    {
                                        return "INfosis4321";
                                    };

            //delegate string delResult(string y);//My own delegate
            delResult del = (string y) =>
            {
                return "INfosis4321";
            };

            Func<string,string> funcDel = (string y) =>
            {
                return "INfosis4321";
            };
            funcDel("EmployeeID");


            //Func will accept the input(any) parameters and return the type(any)
            Func<string,string, string> funcDel1 = (string y , string z) =>
            {
                Console.WriteLine("Hello world");
                Console.WriteLine("Hello world");
                Console.WriteLine("Hello world");
                Console.WriteLine("Hello world");
                Console.WriteLine("Hello world");

                return "";
            };

            funcDel1("1", "2");


            Func<int,int> funcDel4 = (int k) =>
            {
                return 1;
            };
            funcDel4(1);


            Func<int, string> funcDel5 = (int k) =>
            {
                return "";
            };

            Func<int> funcDel9 = () =>
            {
                return 1;
            };


            //Last parameter is the return type 
            Func<int, int, int, int, string, double> funcDel6 = (int x, int y, int z, int k, string s) =>
            {
                return 10.09;
            };



            //Csharp delegate










        }

    }
}
