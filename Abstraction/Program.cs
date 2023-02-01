using System;
using System.Runtime.CompilerServices;

namespace Abstraction
{
    class Program
    {
        static void  Main(string[] args)

        {

            

            Console.Write("Your first number : ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Your second number : ");
            int number2 = Convert.ToInt32(Console.ReadLine());


            //------------------------------
            Addition addition = new Addition();
            int resultOfAddition = addition.Operator(number1,number2);


            addition.Call(number1,number2,resultOfAddition);

           
            //-------------------------------

            Substraction substraction = new Substraction();  
            int resultOfSubstraction  = substraction.Operator(number1, number2);


            substraction.Call(number1, number2, resultOfSubstraction);


            //-------------------------------
            Multiplication multiplication = new Multiplication();
            int resultOfMultiplaction = multiplication.Operator(number1, number2);



            multiplication.Call(number1, number2, resultOfMultiplaction);



            //--------------------------------
            Division division = new Division();
            int resultOfDivision = division.Operator(number1, number2);



            division.Call(number1, number2, resultOfDivision);



        }

    }
}