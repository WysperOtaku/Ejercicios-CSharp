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

            int temp;
            int percent;
            int numDias;

            Console.WriteLine("Porfavor introuce tempe,ratura inicial");
            temp = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce probabilidad de lluvia(1-100%, no incluyas el %): ");
            percent = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce cuantos dias quieres predecir: ");
            numDias = Convert.ToInt32(Console.ReadLine());

            Check();
            Clima(temp, percent, numDias);

            static void Clima (int temp_inicial, int percent_lluvia, int num_predict){
                
                int[,] dia = new int [num_predict, 1];
                Random random = new Random();
                int diasLluviosos = 0;
                int temp_max = 0;
                int temp_min = temp_inicial;


                for (int i = 0; i < dia.Length; i++){

                    dia[i, 0] = temp_inicial;

                    Console.WriteLine("Dia " + i);
                    Console.WriteLine("Temperatura: " + temp_inicial);
                    Console.WriteLine("Probabilidad lluvia: " + percent_lluvia);

                    if (percent_lluvia == 100){
                        temp_inicial--;
                        diasLluviosos++;
                    }

                    if (random.Next(1,100) <= 10){
                        
                        if (random.Next(1,2) == 1){

                            temp_inicial = temp_inicial + 2;

                        }else{

                            temp_inicial = temp_inicial -2;

                        }

                    }

                    if (temp_inicial > 25){

                        percent_lluvia = percent_lluvia + 20;

                    }
                    else if (temp_inicial < 5){

                        percent_lluvia = percent_lluvia - 20;

                    }

                    if (percent_lluvia > 100){

                        percent_lluvia = 100;

                    }
                    else if (percent_lluvia < 0){
                        percent_lluvia = 0;
                    }

                    if (temp_max < temp_inicial)
                        temp_max = temp_inicial;
                    
                    if (temp_min > temp_inicial)
                        temp_min = temp_inicial;


                }
            
            Console.WriteLine("Temperatura máxima: " + temp_max + " Temperatura minima: " + temp_min);
            Console.WriteLine("Van a llover " + diasLluviosos + " dias");
                

            }

            void Check(){

                if (percent < 1 || percent > 100){

                    Console.WriteLine("Introduce un valor dentro del rango sin incluir el %");
                    percent = Convert.ToInt32(Console.ReadLine());
                    Check();

                }

            }

        }

    }

}
