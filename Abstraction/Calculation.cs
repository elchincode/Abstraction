using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public abstract class Calculation
    {
        
       public  abstract int Operator(int num1, int num2);


        public virtual void Call(int num1, int num2, int result )
        {
            Console.WriteLine($" Substraction :       first number = {num1} | second number = {num2} |  Result = {result} ");



        }

    }
}
