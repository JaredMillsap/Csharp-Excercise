using System;

namespace Csharp_Variables_Excercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string myName = "Jared";

            int myAge = 25;
            char middleInitial = 'W';
            bool trueorF = true;
            double myWeight = 204.005;
            decimal myHeight = 70.1m;

            Console.WriteLine($"Hello, my Name is {myName} {middleInitial}. I am {myAge} years old. I weigh {myWeight} lbs. I am {myHeight} inches tall.");
          
        }
    }
}
