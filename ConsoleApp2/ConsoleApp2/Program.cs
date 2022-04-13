using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Birinci reqemi daxil edin");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ikinci reqemi daxil edin");
            int num2 = Convert.ToInt32(Console.ReadLine());
            if (num1 == num2) { Console.WriteLine("her iki rfeqem eynidir"); }
            else if (num1 > num2) { Console.WriteLine(num1); }
            else { Console.WriteLine(num2); }

            
          
              
            {

            }
        }
    }
}
