using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1Day4Lab5
{
    class Program
    {
        int userInt;
        static void Main(string[] args)
        {
            //Prompt user for 1 to 10 int
            Console.WriteLine("Numbers one to ten, pwease");
            var UserInput = Console.ReadLine();         

            //Use a for loop
            int.TryParse(UserInput, out int UserInt);

            //Display the factorial of the number
            Console.WriteLine(FactorialSet(UserInt));

            //Prompt for continue (y/n)
            Console.WriteLine("Contin uWu ? yiss or noooooo pwease");

            Console.ReadLine();
            //long type (Parse.Long)
        }
        static long FactorialSet(int UserInt)
        
        {
            long PrevProduct = 1;
            
            for (int i = 1; i <= UserInt; ++i)
            {
                PrevProduct = i * (PrevProduct);
                
            }
            return PrevProduct;


        }
    }
}
