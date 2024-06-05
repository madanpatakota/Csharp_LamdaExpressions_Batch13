using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ActionDelegateClass
{
    delegate void PrintMessageDelegatge(int x);


    static void PerformTransaction(double amount)
    {
        // Define an Action to display a bank transaction message
        Action<string> displayBankMessage = (message) =>
        {
            Console.WriteLine($"Bank Transaction: {message}");
        };

        // Assume some bank logic here, for simplicity just displaying a message
        displayBankMessage($"Transaction completed. Amount is : {amount}");
    }


    // Normal method to congratulate an employee and display a message
    static void CongratulateEmployee(string employeeName)
    {
        // Define an Action to display an employee congratulatory message
        Action<string> displayEmployeeMessage = message =>
        {
            Console.WriteLine($"Employee Congratulation: {message}");
        };

        // Assume some employee congratulation logic here, for simplicity just displaying a message
        displayEmployeeMessage($"Congratulations, {employeeName}!");
    }







    static void Main()
    {

        CongratulateEmployee("Robert");





        PerformTransaction(5000.98);


        //PrintMessageDelegatge printMessageDelegatge2 = (int y) =>
        //{
        //    Console.WriteLine(y);
        //};


        //(____________) => {  }


        //1st step..
        //Action<int,__________> obj = (<input parameter should be int,__________>) =>
        //{

        //}

        //2ndstep
        //Action<string> obj = (string courseName) =>
        //{

        //}

        //3rdstetp : keep in mind return type should be bool
        //Predicate<string> obj = (string courseName) =>
        //{
        //    return true;
        //};

        //Coder -- (Data)   Plan
        Action<int> printMessageDelegatge3 = (int y) =>
        {
            Console.WriteLine(y);
        };
        printMessageDelegatge3(10);


        Action<int, int> a1 = (int y, int z) =>
        {
            Console.WriteLine(y);
            Console.WriteLine(z);
        };
        a1(10, 20);


        Action<int, int, string> a2 = (int y, int z, string a) =>
        {
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(a);
        };
        a2(10, 20, "30");




        List<int> items = new List<int>();

        //Box

        //Box.add mangoes ---> Mango

        // items = 10;

        //items is box here this box should be accept int value

        items.Add(10); // true
        items.Add(20);
        items.Add(30);

        //Action<int> action = (int item) =>
        //{
        //    item = item + 10;
        //};

        ////action();

        ////list of ints
        //items.ForEach(action);

       var newItems =  items.Select((item) => item + 10);


        //20 ,30 ,40
        foreach (var item in items)
        {
            Console.WriteLine(item);
        }


        Console.ReadLine();





    }
}

