using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios{

    class Program 
    {
        static void Main (string[] args)
        {

            int queTriar;
            Console.WriteLine("Exercici a provar? ");
            queTriar = Convert.ToInt32(Console.ReadLine());
            switch (queTriar){

                case 1:

                    int[] num = new int[20];
                    Random rand = new Random();
                    int min;

                    for (int i = 0; i < 20; i++){

                        num [i] = rand.Next(1, 3000);

                    }

                    min = num[1];

                    for (int i = 0; i < num.Length; i++){

                        if (num [i] < min){

                            min = num[i];

                        }

                    }
                    Console.WriteLine(min);
                    Console.ReadLine();

                    break;

                case 2:
                    
                    int[] nums = new int[500];
                    Random random = new Random();
                    int sumaTotal = 0;
                    int numPars = 0;
                    int num11 = 0;
                    float mitjana = 0;

                    for (int i = 0; i < nums.Length; i++){

                        nums[i] = random.Next(1, 100);
                        sumaTotal = sumaTotal + nums[i];
                        if (nums[i] % 2 == 0){
                            numPars++;
                        }
                        else if (nums[i] % 11 == 0){
                            num11++;
                        }

                    }

                    mitjana = sumaTotal/nums.Length;

                    Console.WriteLine("Mitjana de la llista: " + mitjana);
                    Console.WriteLine("Numero de parells a la llista: " + numPars);
                    Console.WriteLine("Numero de nombres multiples d'11: " + num11);

                    Console.ReadLine();

                    break;

                case 3:
                    
                    string input;
                    int numVocals = 0;

                    while (true){
                        
                        input = Console.ReadLine().ToLower();
                        
                        if (input == "end"){
                            break;
                        }
                        
                        foreach (char letra in input){

                            if ("aeiou".Contains(letra)){
                                numVocals++;
                            }

                        }
                    }
                    
                    Console.WriteLine("La frase tiene: " + numVocals + " vocales");
                    Console.ReadLine();


                    break;

                case 4:

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
                            Exit();
                            Console.Clear();
                            Inicio();

                        }

                        void Depositar (){

                            Console.WriteLine("**************************");
                            Console.WriteLine("*.Cuanto quieres depositar");
                            Console.WriteLine("**************************");

                            intercambio = Convert.ToInt32(Console.ReadLine());
                            saldo = saldo + intercambio;
                            Exit();
                            Console.Clear();
                            Inicio();

                        }

                        void Checking (){
                            
                            Console.WriteLine("**************************");
                            Console.WriteLine("* .Tu saldo es: **********");
                            Console.WriteLine("* ." + saldo + " *********");
                            Console.WriteLine("**************************");
                            
                            Exit();
                            Console.Clear();
                            Inicio();

                        }

                        void Exit (){

                            Console.WriteLine("* .Enter para volver *****");
                            Console.Read();

                        }

                    break;
            }

            
        }

    }

}
