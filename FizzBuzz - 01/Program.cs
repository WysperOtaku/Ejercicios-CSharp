using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codember01
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 0; i <= 100; i++){

                if(i % 3 == 0 && i % 5 == 0){
                    Console.WriteLine("fizzbuzz");
                }
                else if (i % 3 == 0){
                    Console.WriteLine("fizz");
                }
                else if(i % 5 == 0){
                    Console.WriteLine("buzz");
                }
                else {
                    Console.WriteLine(i);
                }
            }

            Console.ReadLine();

        }
    }
}