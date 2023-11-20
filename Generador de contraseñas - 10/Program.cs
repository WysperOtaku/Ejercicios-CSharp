using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plantilla{

    class Program 
    {
        static void Main (string[] args){

            int passwdLength;
            bool mayus;
            bool nums;
            bool simbol;
            string respuesta;


            void Input (){

            Console.WriteLine("Introduce una longitud de contraseña entre 8 y 16 caràcteres");
            passwdLength = Convert.ToInt32(Console.ReadLine());
            
            if (passwdLength < 8 && passwdLength > 16){

              Console.WriteLine("Valor especificado incorrecto");

              Input();

            }

            Mayus();

            void Mayus (){

            Console.WriteLine("Quieres que la contraseña contenga mayusculas? S/n");
            respuesta = Console.ReadLine();
            
            if (respuesta.ToLower() == "s"){

              mayus = true;

            }
            else if (respuesta.ToLower() == "n"){
                
              mayus = false;

            }else {

              Console.WriteLine("Introduce S/n");
              Mayus();

            }

            }

            void Nums (){

              Console.WriteLine("Quieres que la contraseña contenga numeros? S/n");
              respuesta = Console.ReadLine();
              
              if (respuesta.ToLower() == "s"){

                nums = true;

              }
              else if (respuesta.ToLower() == "n"){

                nums = false;

              }
              else {

                Console.WriteLine("Introduce S/n");
                Nums();

              }

            }

            void Simbols (){

              Console.WriteLine("Quieres que la contraseña contenga simbolos? S/n");
              respuesta = Console.ReadLine();
              
              if (respuesta.ToLower() == "s"){

                simbol = true;

              }
              else if (respuesta.ToLower() == "n"){

                simbol = false;

              }
              else {

                Console.WriteLine("Introduce S/n");
                Simbols();

              }

            }


            }

        }

    }

}
