using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;


/*
* Normal method to filter numbers based on a condition
* Predicate: Represents a delegate that defines a method that takes one input parameter and returns a Boolean value.
*/

class PredicateDelegateClass
{
    delegate bool IsValidDelegate(int x);
    static void Main()
    {
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
        //bool result7 = isValidDelegate2(10);
        //Predicate<int> isValidDelegate3 = (int abc) => abc == 1;
        Predicate<int> isValidDelegate4 = (int abc) =>
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

        //1st step..
        //Predicate<string> obj = (<input parameters>) =>
        //{

        //}

        //2ndstep
        //Predicate<string> obj = (string courseName) =>
        //{

        //}

        //3rdstetp : keep in mind return type should be bool
        //Predicate<string> obj = (string courseName) =>
        //{
        //    return true;
        //};


        //bool


        bool isTrue = 1 == 1; //true

        bool isTrue1 = 1 == 2; //false


        Predicate<string> predicate = (string courseName) =>
        {
            if (courseName == "Csharp")
            {
                return true;
            }
            else { 
                return false; 
            }
        };




       bool resultType =  predicate("Csharp");
       Console.WriteLine(resultType);


        bool isTrue2 = 1 == 1; //true
        Predicate<string> predicate1 = (string courseName) => courseName == "Csharp";

        bool resultType1 = predicate("Csharp");
        Console.WriteLine(resultType1);


        Predicate<int> result_2 = (number) => number % 2 == 0;
        bool isEven = result_2(13);  //false

        Console.WriteLine(isEven);

        //int k;

        //k = 1;

        List<int> items = new List<int>();

        //Box

        //Box.add mangoes ---> Mango

        // items = 10;

        //items is box here this box should be accept int value

        items.Add(13); // true
        items.Add(1);
        items.Add(10);

        int isEven1 =  items.Find((item) => item % 2 > 0);


        Console.ReadLine();





    }

}

