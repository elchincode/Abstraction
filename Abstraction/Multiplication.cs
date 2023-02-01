using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public sealed class Multiplication : Calculation

    {
        public override int Operator(int num1, int num2)
        {
            return num1 * num2;
        }
        public override void Call(int num1, int num2, int result)
        {
            Console.WriteLine($" Multiplaction : first number = {num1} | second number = {num2} |  Result = {result} ");



        }
    }
}
