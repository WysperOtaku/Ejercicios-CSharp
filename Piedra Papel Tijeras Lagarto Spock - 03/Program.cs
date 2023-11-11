using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piedra_Papel_Tijeras_Lagarto_Spook_Github
{
    class Program
    {
        static void Main(string[] args)
        {
            int jugador1;
            int jugador2;
            Random pptls = new Random();
            jugador1 = pptls.Next(0, 5);
            jugador2 = pptls.Next(0, 5);
            Console.WriteLine("Piedra Papel Tijeras Lagarto Spock");
            Console.WriteLine("El resultado de la ronda es: ");
            bool jugar = true;
            while (jugar)
            {
                if (jugador1 == jugador2)
                {
                    Console.WriteLine("El resultado es empate");
                    jugador1 = pptls.Next(0, 5);
                    jugador2 = pptls.Next(0, 5);
                    Console.WriteLine("Quieres volver a jugar? (true = si)(false = no)");
                    jugar = Convert.ToBoolean(Console.ReadLine());
                }
                if (jugador1 != jugador2)
                {
                    if (jugador1 == 0 && jugador2 == 1)
                    {
                        Console.WriteLine("El Jugador 2 gana");
                        jugador1 = pptls.Next(0, 5);
                        jugador2 = pptls.Next(0, 5);
                    }
                    else if (jugador1 == 0 && jugador2 == 2)
                    {
                        Console.WriteLine("El Jugador 1 gana");
                        jugador1 = pptls.Next(0, 5);
                        jugador2 = pptls.Next(0, 5);
                    }
                    else if (jugador1 == 0 && jugador2 == 3)
                    {
                        Console.WriteLine("El Jugador 1 gana");
                        jugador1 = pptls.Next(0, 5);
                        jugador2 = pptls.Next(0, 5);
                    }
                    else if (jugador1 == 0 && jugador2 == 4)
                    {
                        Console.WriteLine("El Jugador 2 gana");
                        jugador1 = pptls.Next(0, 5);
                        jugador2 = pptls.Next(0, 5);
                    }
                    else if (jugador1 == 1 && jugador2 == 0)
                    {
                        Console.WriteLine("El Jugador 1 gana");
                        jugador1 = pptls.Next(0, 5);
                        jugador2 = pptls.Next(0, 5);
                    }
                    else if (jugador1 == 1 && jugador2 == 2)
                    {
                        Console.WriteLine("El Jugador 2 gana");
                        jugador1 = pptls.Next(0, 5);
                        jugador2 = pptls.Next(0, 5);
                    }
                    else if (jugador1 == 1 && jugador2 == 3)
                    {
                        Console.WriteLine("El Jugador 2 gana");
                        jugador1 = pptls.Next(0, 5);
                        jugador2 = pptls.Next(0, 5);
                    }
                    else if (jugador1 == 1 && jugador2 == 4)
                    {
                        Console.WriteLine("El Jugador 1 gana");
                        jugador1 = pptls.Next(0, 5);
                        jugador2 = pptls.Next(0, 5);
                    }
                    else if (jugador1 == 2 && jugador2 == 0)
                    {
                        Console.WriteLine("El Jugador 2 gana");
                        jugador1 = pptls.Next(0, 5);
                        jugador2 = pptls.Next(0, 5);
                    }
                    else if (jugador1 == 2 && jugador2 == 1)
                    {
                        Console.WriteLine("El Jugador 1 gana");
                        jugador1 = pptls.Next(0, 5);
                        jugador2 = pptls.Next(0, 5);
                    }
                    else if (jugador1 == 2 && jugador2 == 3)
                    {
                        Console.WriteLine("El Jugador 1 gana");
                        jugador1 = pptls.Next(0, 5);
                        jugador2 = pptls.Next(0, 5);
                    }
                    else if (jugador1 == 2 && jugador2 == 4)
                    {
                        Console.WriteLine("El Jugador 2 gana");
                        jugador1 = pptls.Next(0, 5);
                        jugador2 = pptls.Next(0, 5);
                    }
                    else if (jugador1 == 3 && jugador2 == 0)
                    {
                        Console.WriteLine("El Jugador 2 gana");
                        jugador1 = pptls.Next(0, 5);
                        jugador2 = pptls.Next(0, 5);
                    }
                    else if (jugador1 == 3 && jugador2 == 1)
                    {
                        Console.WriteLine("El Jugador 1 gana");
                        jugador1 = pptls.Next(0, 5);
                        jugador2 = pptls.Next(0, 5);
                    }
                    else if (jugador1 == 3 && jugador2 == 2)
                    {
                        Console.WriteLine("El Jugador 2 gana");
                        jugador1 = pptls.Next(0, 5);
                        jugador2 = pptls.Next(0, 5);
                    }
                    else if (jugador1 == 3 && jugador2 == 4)
                    {
                        Console.WriteLine("El Jugador 1 gana");
                        jugador1 = pptls.Next(0, 5);
                        jugador2 = pptls.Next(0, 5);
                    }
                    else if (jugador1 == 4 && jugador2 == 0)
                    {
                        Console.WriteLine("El Jugador 1 gana");
                        jugador1 = pptls.Next(0, 5);
                        jugador2 = pptls.Next(0, 5);
                    }
                    else if (jugador1 == 4 && jugador2 == 1)
                    {
                        Console.WriteLine("El Jugador 2 gana");
                        jugador1 = pptls.Next(0, 5);
                        jugador2 = pptls.Next(0, 5);
                    }
                    else if (jugador1 == 4 && jugador2 == 2)
                    {
                        Console.WriteLine("El Jugador 1 gana");
                        jugador1 = pptls.Next(0, 5);
                        jugador2 = pptls.Next(0, 5);
                    }
                    else if (jugador1 == 4 && jugador2 == 3)
                    {
                        Console.WriteLine("El Jugador 2 gana");
                        jugador1 = pptls.Next(0, 5);
                        jugador2 = pptls.Next(0, 5);
                    }
                    Console.WriteLine("Quieres volver a jugar? (true = si)(false = no)");
                    jugar = Convert.ToBoolean(Console.ReadLine());
                }
            }
        }
    }
}
