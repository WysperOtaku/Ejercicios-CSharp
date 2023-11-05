using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<String, String> leet = new Dictionary<String, String>(){

                {"A", "4"},
				{"B", "I3"},
				{"C", "["},
				{"D", ")"},
				{"E", "3"},
				{"F", "|="},
				{"G", "&"},
				{"H", "#"},
				{"I", "1"},
				{"J", ",_|"},
				{"K", ">|"},
				{"L", "1"},
				{"M", @"/\/\"},
				{"N", "^/"},
				{"Ñ", "Na4" },
				{"O", "0"},
				{"P", "|*"},
				{"Q", "(_,)"},
				{"R", "I2"},
				{"S", "5"},
				{"T", "7"},
				{"U", "(_)"},
				{"V", @"\/"},
				{"W", @"\/\/"},
				{"X", "><"},
				{"Y", "j"},
				{"Z", "2"},
                {" ", " "}

            };

            string input = Console.ReadLine();
            string output = "";

            for (int i = 0; i < input.Length; i++){

                foreach (var letra in leet){

                    if(letra.Key == input[i].ToString().ToUpper()){

                        output += letra.Value;

                    }

                }

            }

            Console.WriteLine(output);

            Console.ReadLine();
        }

        }
    
}