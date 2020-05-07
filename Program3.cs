using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {

            
                        int x;
                        for (int i = 1; i <= 10; i++)
                        {
                            for (int j = 1; j <= 10; j++)
                            {
                                x = i * j;
                                Console.Write(x);
                                Console.Write("\t");
                            }
                            Console.WriteLine();
                        }
                        Console.ReadKey();
            
            /*
                        int x;
                        for (int i = 0; i <= 1000; i++)
                            if ((i % 3 == 0) || (i % 11 == 0) || (i % 5 == 0))
                            Console.Write("{0}\t",i);      
                            Console.WriteLine();
                            Console.ReadKey();
           */
           /*
                        for (int j = 0; j <= 10; j++)
                        {
                            for (int i = 0; i < j; i++)
                                Console.Write("*\t",j*i);
                            Console.WriteLine();
                        }
                        Console.ReadKey();
                      
                                   for (int j = 10; j > 0; j--)
                                   {
                                       for (int i = 0; i < j; i++)
                                           Console.Write("*\t", j * i);
                                       Console.WriteLine();
                                       }
                                  Console.ReadKey();
            

          
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10 - i; j++)
                    Console.Write(" ");
                for (int j = 1; j <= i; j++)
                    Console.Write("*");

                Console.WriteLine("");
                
            }
            Console.ReadKey();


            for (int i = 10; i > 0; i--)
            {
                for (int j = 1; j <= 10 - i; j++)
                    Console.Write(" ");
                for (int j = 1; j <= i; j++)
                    Console.Write("*");

                Console.WriteLine("");

            }
            Console.ReadKey();

    */
        }
    }
}
