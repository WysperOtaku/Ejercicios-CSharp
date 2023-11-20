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
            bool minus;
            bool nums;
            bool simbol;
            string respuesta;

            string contraseña;

            Input();
            Mayus();
            Nums();
            Simbols();

            contraseña = GenerarContraseña(passwdLength,mayus,minus,nums,simbol);
            Console.WriteLine(contraseña);



            void Input (){

            Console.WriteLine("Introduce una longitud de contraseña entre 8 y 16 caràcteres");
            passwdLength = Convert.ToInt32(Console.ReadLine());
            
            if (passwdLength < 8 && passwdLength > 16){

              Console.WriteLine("Valor especificado incorrecto");

              Input();

            }
         }


            void Mayus (){

            Console.WriteLine("Quieres que la contraseña contenga mayusculas? S/n");
            respuesta = Console.ReadLine();
            
            if (respuesta.ToLower() == "s"){

              mayus = true;
              minus = true;

            }
            else if (respuesta.ToLower() == "n"){
                
              mayus = false;
              minus = true;

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

            
            static string GenerarContraseña(int longitud, bool incluirLetrasMayusculas, bool incluirLetrasMinusculas, bool incluirNumeros, bool incluirCaracteresEspeciales)
              {
                    const string letrasMayusculas = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                    const string letrasMinusculas = "abcdefghijklmnopqrstuvwxyz";
                    const string numeros = "0123456789";
                    const string caracteresEspeciales = "!@#$%^&*()-=_+[]{}|;:'\",.<>/?";

                    StringBuilder caracteresPermitidos = new StringBuilder();

                    if (incluirLetrasMayusculas)
                        caracteresPermitidos.Append(letrasMayusculas);
                    if (incluirLetrasMinusculas)
                        caracteresPermitidos.Append(letrasMinusculas);
                    if (incluirNumeros)
                        caracteresPermitidos.Append(numeros);
                    if (incluirCaracteresEspeciales)
                        caracteresPermitidos.Append(caracteresEspeciales);

                    Random random = new Random();
                    StringBuilder contraseñaGenerada = new StringBuilder();

                    for (int i = 0; i < longitud; i++)
                    {
                        int indiceCaracter = random.Next(0, caracteresPermitidos.Length);
                        contraseñaGenerada.Append(caracteresPermitidos[indiceCaracter]);
                    }

                    return contraseñaGenerada.ToString();
              }

        }

    }

}
