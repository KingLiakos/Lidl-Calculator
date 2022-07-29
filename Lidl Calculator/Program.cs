using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using calculator;


namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int result;

            do
            {
                Console.WriteLine("Welcome to our Calculator :) :)");

                Console.WriteLine("Dose mou ton proton arimtho: ");
                num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Dose mou ton deutero arimtho: ");
                num2 = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("Epelekse tin praksi pou thes na kaneis: ");
                Console.WriteLine("\t + ");
                Console.WriteLine("\t - ");
                Console.WriteLine("\t / ");
                Console.WriteLine("\t * ");


                switch (Console.ReadLine())
                {
                    case "+":
                        result = num1 + num2;
                        Console.WriteLine("The result is " + result);
                        break;
                    case "-":
                        result = num1 - num2;
                        Console.WriteLine("The result is " + result);
                        break;
                    case "/":
                        result = num1 / num2;
                        Console.WriteLine("The result is " + result);
                        break;
                    case "*":
                        result = num1 * num2;
                        Console.WriteLine("The result is " + result);
                        break;
                    default:
                        Console.WriteLine("BEN opws katalavenis");
                        break;

                }
                Console.WriteLine("Theleis na ksanapeksis? (YES or NO ) ");
            }
            while (Console.ReadLine().ToUpper() == "YES");
            Console.WriteLine("Good bye!");
            Console.ReadKey();

        }

    }
}

