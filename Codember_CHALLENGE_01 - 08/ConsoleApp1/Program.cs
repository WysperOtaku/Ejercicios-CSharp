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

            string msg;
            msg = Console.ReadLine();

            string[] splited = msg.ToLower().Split(" ");
            Dictionary<string, int> contador = new Dictionary<string, int>();

            foreach (string palabra in splited){

                if (!contador.ContainsKey(palabra)){
                    contador[palabra] = 1;
                }
                else {
                    contador[palabra]++;
                }

            }

            string resultado = string.Join("",contador.Select(kv => kv.Key + kv.Value));

            Console.WriteLine(resultado);
            Console.ReadLine();
        }
    }
}