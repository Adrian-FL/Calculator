using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPropriuCalculator
{
    class Program
    {
        static void Main(string[] args)
        
        {
            Console.WriteLine("Calculator");

          
           

            char selectedOption = ' ';

            Console.WriteLine("\n\nChose an option:\n");
            Console.WriteLine("1: Add");
            Console.WriteLine("2: Substract");
            Console.WriteLine("3: Multiply");
            Console.WriteLine("4: Devide");
            Console.WriteLine("\n0: Dislike");

            selectedOption = Console.ReadKey().KeyChar;
            


            if (selectedOption == '0')
            {
                Console.WriteLine("Epic choice ....allegedly");
                Console.ReadKey(true);
                Environment.Exit(0);
            }
            else
            {
                int numero1 = 0;
                int numero2 = 0;

                Console.Write("Type the first number: ");

                try
                {
                    numero1 = int.Parse(Console.ReadLine());
                }
                catch (Exception excep)
                {
                 Console.WriteLine("The number is incorect! Hit space to continue!");
                 Console.ReadKey(true);
                 return;
                }

                  Console.Write("Type the second number: ");

                  try
                  {
                   numero2 = int.Parse(Console.ReadLine());

                  }
                   catch (Exception excep)
                  {
                   Console.WriteLine("The number is incorect! Hit space to continue!");
                   Console.ReadKey(true);
                   return;
                  }

//  result

             int result = 0;

             switch (selectedOption)
             {
              case '1':
              result = numero1 + numero2;
              break;
              case '2':
              result = numero1 - numero2;
              break;
               case '3':
              result = numero1 * numero2;
              break;
              case '4':
              result = numero1 / numero2;
              break;
             }

             Console.WriteLine("The result is: " + result);
             Console.WriteLine("Smash the dislike button !!! ");
             Console.ReadKey(true);
            }
        }
    }
}
