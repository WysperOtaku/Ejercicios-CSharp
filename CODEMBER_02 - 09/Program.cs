using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace CODEMBER_02
{
    class Program {

        static void Main(string[] args){

            string input;

            Console.WriteLine("Introduce aqui el codigo a interpretar");
            input = Console.ReadLine();

            Compiler(input);

            static void Compiler (string entrada){

                int salida = 0;
                
                foreach (char caracter in entrada){

                    if (Convert.ToString(caracter) == "#"){

                        salida++;

                    }
                    else if (Convert.ToString(caracter) == "@"){

                        salida--;

                    }
                    else if (Convert.ToString(caracter) == "*"){

                        salida = salida * salida;

                    }
                    else if (Convert.ToString(caracter) == "&"){

                        Console.Write(salida);

                    }

                }

            }

            Console.ReadLine();



        }

    }

}