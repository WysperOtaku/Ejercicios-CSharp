using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int queTriar;
            Console.WriteLine("Exercici a provar? ");
            queTriar = Convert.ToInt32(Console.ReadLine());
            switch (queTriar)
            {

                case 1:

                    int repeticiones = 0;
                    string letra;

                    Console.WriteLine("Que letra quieres repetir? ");
                    letra = Console.ReadLine();
                    Console.WriteLine("Cuantas veces? ");
                    repeticiones = Convert.ToInt32(Console.ReadLine());

                    for (int i = 0; i < repeticiones; i++)
                    {
                        Console.Write(letra);
                    }
                    Console.ReadLine();

                    break;

                case 2:

                    int XX = 18;
                    int multilicador = 1;
                    int valorMultiplicacion = 0;

                    while (valorMultiplicacion < 725)
                    {
                        valorMultiplicacion = XX * multilicador;
                        if (valorMultiplicacion > 725)
                        {
                            break;
                        }
                        Console.WriteLine(valorMultiplicacion);
                        multilicador++;
                    }
                    Console.ReadLine();

                    break;

                case 3:

                    int resultadoSuma = 0;
                    int numero;
                    int sumador = 0;
                    int numeroEnterSuma = 18;

                    Console.WriteLine("Introduce un numero");
                    numero = Convert.ToInt32(Console.ReadLine());


                    for (int i = 18; i <= numero; i++)
                    {

                        resultadoSuma = resultadoSuma + (numeroEnterSuma + sumador);
                        sumador++;

                    }

                    Console.WriteLine("El resultado final es: " + resultadoSuma);
                    Console.ReadLine();

                    break;

                case 4:

                    int numeroDemanat;
                    int numeroImparells;
                    int numeroParells;
                    int resultatParells = 0;
                    int resultatImparells = 0;

                    Console.WriteLine("Introduce un numero");
                    numeroDemanat = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Espera uns instants...");
                    Console.WriteLine("Aqui estan els resultats: ");

                    if (numeroDemanat % 2 == 0)
                    {
                        numeroParells = numeroDemanat / 2;
                        numeroImparells = numeroDemanat / 2;
                    }
                    else
                    {
                        numeroParells = (numeroDemanat / 2);
                        numeroImparells = (numeroDemanat / 2) + 1;
                    }

                    for (int i = 1; i <= numeroDemanat; i++)
                    {

                        if (i % 2 == 0)
                        {
                            resultatParells = resultatParells + i;
                        }
                        else
                        {
                            resultatImparells = resultatImparells + i;
                        }

                    }


                    Console.WriteLine("Numero de nombres parells: " + numeroParells);
                    Console.WriteLine("Numero de nombres Imparells: " + numeroImparells);
                    Console.WriteLine("Suma de numeros parells: " + resultatParells);
                    Console.WriteLine("Suma de numero imparells: " + resultatImparells);

                    Console.ReadLine();

                    break;

                case 5:

                    Random rand = new Random();
                    int randName;
                    int player1;
                    int player2;
                    string[] nombres = { "Pedro Picapiedra", "Álex Marqués", "Jordi Hurtado", "Jordi Wild", "DiGref", "Me encanta el Vegetia", "Wysper", "Eric Mejillas", "Mateo Guarrindono", "Panturex" };

                    Console.WriteLine("Bienvenido al piedra papel o tijeras mas mejor piedra papel o tijeras");
                    Console.WriteLine("Dime, que vas a seleccionar?");
                    Console.WriteLine("1. Piedra");
                    Console.WriteLine("2. Papel");
                    Console.WriteLine("3. Tijeras");

                    player1 = Convert.ToInt32(Console.ReadLine());
                    if (player1 > 3 || player1 < 1)
                    {
                        Console.WriteLine("Acaso estas intentando hacer trampas? Fuera de aqui!");
                        break;
                    }

                    player2 = rand.Next(1, 3);
                    randName = rand.Next(0, nombres.Length);
                    Console.WriteLine("Hoy te enfrentaras contra....");
                    Console.WriteLine(nombres[randName]);

                    Console.WriteLine("Veamos quien resulta ser el ganador de este trepidante duelo...");

                    if (player1 == player2)
                    {
                        Console.WriteLine("TREMENDO EMPATE!!");
                    }
                    else if (player1 == 1 && player2 == 2)
                    {
                        Console.WriteLine("No me lo puedo creer " + nombres[randName] + " se acaba de hacer con la victoria, le han sacado el papel");
                    }
                    else if (player1 == 1 && player2 == 3)
                    {
                        Console.WriteLine("Intrepido victorioso te llamaban! Esas tijeras no han podido contigo");
                    }
                    else if (player1 == 2 && player2 == 1)
                    {
                        Console.WriteLine("Victoria muy interesante. Como podria una simple piedra contra tu papel? ");
                    }
                    else if (player1 == 2 && player2 == 3)
                    {
                        Console.WriteLine("Como es posible, te ha ganado " + nombres[randName] + " era obvio que esas tijeras acabarian contigo");
                    }
                    else if (player1 == 3 && player2 == 1)
                    {
                        Console.WriteLine("Es acaso esta tu mejor jugada? Tremenda derrota, esa piedra ha podido contigo, te ha ganado " + nombres[randName]);
                    }
                    else if (player1 == 3 && player2 == 2)
                    {
                        Console.WriteLine("SI!, has ganado a " + nombres[randName] + " como ha podido pensar que te ganaria con un papel...");
                    }
                    Console.WriteLine("Esto ha sido el piedra papel o tijeras de las leyendas, si quieres salir del programa pulsa enter:");
                    Console.ReadLine();

                    break;

                case 6:
                    
                    int saldo = 1000;
                    int intercambio;
                    int seleccion;

                    Inicio();

                    void Inicio(){

                        Console.WriteLine("*****Cajero Intrepido*****");
                        Console.WriteLine("**************************");
                        Console.WriteLine("*Selecciona una operación*");
                        Console.WriteLine("**************************");
                        Console.WriteLine("* 1.Sacar Efectivo *******");
                        Console.WriteLine("**************************");
                        Console.WriteLine("* 2.Depositar efectivo ***");
                        Console.WriteLine("**************************");
                        Console.WriteLine("* 3.Comprovar saldo ******");
                        Console.WriteLine("**************************");
                        Console.WriteLine("* 0.Salir ****************");
                        Console.WriteLine("**************************");

                        seleccion = Convert.ToInt32(Console.ReadLine());
                        switch (seleccion){

                            case 1:

                                Sacar();

                                break;

                            case 2:

                                Depositar();

                                break;

                            case 3:

                                Checking();

                                break;

                            case 0:

                                break;

                        }
                    }

                        void Sacar (){

                            Console.WriteLine("**************************");
                            Console.WriteLine("* .Cuanto quieres sacar? *");
                            Console.WriteLine("**************************");

                            intercambio = Convert.ToInt32(Console.ReadLine());
                            saldo = saldo - intercambio;
                            Console.WriteLine("* .Enter para volver *****");
                            Console.Read();
                            Console.Clear();
                            Inicio();

                        }

                        void Depositar (){

                            Console.WriteLine("**************************");
                            Console.WriteLine("*.Cuanto quieres depositar");
                            Console.WriteLine("**************************");

                            intercambio = Convert.ToInt32(Console.ReadLine());
                            saldo = saldo + intercambio;
                            Console.WriteLine("* .Enter para volver *****");
                            Console.Read();
                            Console.Clear();
                            Inicio();

                        }

                        void Checking (){
                            
                            Console.WriteLine("**************************");
                            Console.WriteLine("* .Tu saldo es: **********");
                            Console.WriteLine("* ." + saldo + " *********");
                            Console.WriteLine("**************************");
                            
                            Console.WriteLine("* .Enter para volver *****");
                            Console.Read();
                            Console.Clear();
                            Inicio();

                        }

                    

                    break;

                    case 7:

                        int edad;
                        int ingresos;
                        bool refAlq = false;
                        int infrac;
                        string respuesta;

                        Console.WriteLine("Bienvenido al programa de gestion de alquileres");
                        Console.WriteLine("Cuantos años tienes?");
                        edad = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Nombra tus ingresos");
                        ingresos = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Referencia de alquiler anterior positiva? S/N");
                        respuesta = Console.ReadLine();
                        
                        if (respuesta == "S" || respuesta == "s"){
                            
                            refAlq = true;

                        }
                        else if (respuesta == "N" || respuesta == "n"){

                            refAlq = false;

                        }
                        else {
                            Console.WriteLine("Introduce S o N, vuelve a intentarlo");
                        }

                        Console.WriteLine("Introduce numero de infracciones en los ultimos 5 meses");
                        infrac = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Procederemos a afirmarle si puede acceder al alquiler");

                        if ((edad > 21 && edad < 65) && (ingresos >= 2500) && (refAlq == true) && (infrac <= 1)){
                            
                            Console.WriteLine("Puedes acceder al alquiler del apartamento");

                        }

                        break;

            }

        }
    }
}