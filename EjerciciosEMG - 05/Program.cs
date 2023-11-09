using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_3
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
                    Random numerosAleatorios20 = new Random();
                    List<int> numeros20 = new List<int>();
                    for (int contador = 0; contador < 20; contador++)
                    {
                        numeros20.Add(numerosAleatorios20.Next(0, 2001));
                    }
                    Console.WriteLine("20 Numeros aleatorios del 0 al 2000 i el mas pequeño");
                    Console.WriteLine("Els nombres aleatoris son: " + string.Join("-", numeros20));
                    Console.WriteLine("I el nombre mes petit es: " + numeros20.Min());
                    Console.ReadLine();
                    break;

                case 2:
                    double mediaNumeros500 = 0;
                    int numeros500Pares = 0;
                    int numeros500Multiplos11 = 0;
                    int numeroLimite = 1001;
                    Random numerosAleatorios500 = new Random();
                    int[] numeros500 = new int[numeroLimite];
                    for (int contador = 0; contador < numeroLimite; contador++)
                    {
                        numeros500[contador] = numerosAleatorios500.Next(0, numeroLimite);

                        mediaNumeros500 = mediaNumeros500 + numeros500[contador];

                        if(numeros500[contador] % 2 == 0)
                        {
                            numeros500Pares++;
                        }

                        if(numeros500[contador] % 11 == 0)
                        {
                            numeros500Multiplos11++;
                        }
                    }
                    if (numeroLimite > 0)
                    {
                        mediaNumeros500 = mediaNumeros500 / numeroLimite;
                    }
                    Console.WriteLine(numeros500Pares);
                    Console.WriteLine(numeros500Multiplos11);
                    Console.WriteLine(mediaNumeros500);
                    Console.ReadLine();
                    break;

                case 3:
                    Console.WriteLine("Introdueix una frase per comptar les vocals. (escriu 'end' per sortir)");
                    string texto = Convert.ToString(Console.ReadLine());
                    int contadorVocales = 0;
                    if (texto == Convert.ToString("end"))
                    {
                        Console.WriteLine("Sortint del programa.");
                    }
                    else
                    {
                        string vocales = "aeiouAEIOU";
                        for(int posicionTexto = 0; posicionTexto < texto.Length; posicionTexto++)
                        {
                            if(vocales.Contains(texto[posicionTexto]))
                            {
                                contadorVocales++;
                            }
                        }
                    }
                    Console.WriteLine("El nombre total de vocals es " + contadorVocales + ".");
                    Console.ReadLine();
                    break;

                case 4:
                    int dineroBanco = 1000;
                    int eleccionBanco = 0;
                    while(eleccionBanco != 4);
                    {
                        Console.WriteLine("Que operacio vols fer? (1 ingresar, 2 retirar, 3 comprovar calers, 4 sortir)");
                        eleccionBanco = Convert.ToInt32(Console.ReadLine());
                        switch (eleccionBanco)
                        {
                            case 1:
                                dineroBanco = Ingresar(dineroBanco);
                                break;

                            case 2:
                                dineroBanco = Retirar(dineroBanco);
                                break;

                            case 3:
                                ComprobarDinero(dineroBanco);
                                break;

                            case 4:
                                Console.WriteLine("Sortint de la teva compte del caixer.");
                                break;

                            default:
                                Console.WriteLine("Ho sento aquesta opcio no esta a la terminal, escull una altre opcio.");
                                break;
                        }
                    }
                    break;
            }

            int Ingresar(int dineroBanco)
            {
                Console.WriteLine("Quants calers vols ingresar a la teva compte?");
                int dineroIngreso = Convert.ToInt32(Console.ReadLine());
                dineroBanco = dineroBanco + dineroIngreso;
                Console.WriteLine("Ara tens " + dineroBanco + " euros al banc.");
                return dineroBanco;
            }

            int Retirar(int dineroBanco)
            {
                Console.WriteLine("Quants calers vols retirar de la teva compte?");
                int dineroRetirar = Convert.ToInt32(Console.ReadLine());
                if (dineroRetirar <= dineroBanco)
                {
                    dineroBanco = dineroBanco - dineroRetirar;
                    Console.WriteLine("Ara tens " + dineroBanco + " euros al banc.");
                }
                else
                {
                    Console.WriteLine("No pots retirar " + dineroRetirar + " euros perque nomes tens " + dineroBanco + " euros.");
                }
                return dineroBanco;
            }

            void ComprobarDinero(int dineroBanco)
            {
                Console.WriteLine("Els calers de la teva compte ara mateix son " + dineroBanco + " euros.");
            }
            
        }
    }
}
