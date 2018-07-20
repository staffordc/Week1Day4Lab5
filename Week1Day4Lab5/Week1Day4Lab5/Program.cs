using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1Day4Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            var Repeat = true;
            while (Repeat)
            {

                //Prompt user for 1 to 10 int
                Console.WriteLine("I can give you Factowiawows!");
                Console.WriteLine("\n Numbers one to ten, pwease");
                int userInt;
                userInt = Validate();
                
                //Display the factorial of the number
                Console.WriteLine(FactorialSet(userInt)); 
      
                Repeat = Retry();
            }
        }
        //Prompt for continue (y/n)
        static bool Retry()
        {
            Console.WriteLine("\n Contin uWu ? yiss or noooooo pwease");
            String Answer = Console.ReadLine().ToUpper();

            if (Answer == "Y" || Answer == "YES" || Answer == "YISS")
            {
                return true;
            }
            else if (Answer == "N" || Answer == "NO" || Answer == "NOOOOOO")
            {
                return false;
            }
            else
            {
                Console.WriteLine("\n I donut no that, pwease input y or n");
                return Retry();
            }
        }

        //long type (Parse.Long)
        static long FactorialSet(long i)
        //Use recursion
        {
            if (i == 1) return i;

            return FactorialSet(i-1) * i; 
            
            
        }

        static int Validate()
        {
            String UserInput = Console.ReadLine();
            if (Int32.TryParse(UserInput, out int result) && result > 0 && result < 10)
            {
                return result;
            }
            else
            {
                Console.WriteLine("\n Nice twy, it's gotta bee inside 1 and 10");
                return Validate();
            }
        }
    }
}
