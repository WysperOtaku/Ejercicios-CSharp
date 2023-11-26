using System.Collections.Generic;
using System.Linq;
using System;

class Program
{
  static double Funcion(double x)
  {
      //Prueba a cambiar la función por otra y verás que el resultado es correcto
      return Math.Pow(x, 2); // Función x^2, aqui podemos poner cualquier funcion que se nos ocurra y que sea integrable.
  }
  static void Main(string[] args)
  {
        double a = 0; // Punto inicial
        double b = 1; // Punto final
        long n = 1000000000; // Numero de trapecios o rectangulos o segmentos de la regla de Simpson

        double result1 = MetodoTrapecios(a, b, n); // Llamada al método
        double result2 = MetodoRectangulos(a, b, n); // Llamada al método
        double result3 = MetodoSimpson(a, b, n); // Llamada al método
        Console.WriteLine($"La integral de la función en el intervalo [{a}, {b}] es {result1}u², resuelto con la regla del trapecio");// Devolvera la integral de la función en el intervalo [a,b]
        Console.WriteLine($"La integral de la función en el intervalo [{a}, {b}] es {result2}u², resuelto con el metodo sumatorio de rectangulos");// Devolvera la integral de la función en el intervalo [a,b]
        Console.WriteLine($"La integral de la función en el intervalo [{a}, {b}] es {result3}u², resuelto con la regla de Simpson");// Devolvera la integral de la función en el intervalo [a,b]
  }


    static double MetodoTrapecios(double a, double b, long n) // Método de los trapecios declarado como static para poder llamarlo desde el Main
    {
      double h = (b - a) / n; // Altura de los trapecios
      double integral = 0.5 * (Funcion(a) + Funcion(b)); // Primera parte de la fórmula (f(a) + f(b)) / 2 suma de los valores de la funcion en los extremos del intervalo

      for (int i = 1; i < n; i++) // Segunda parte de la fórmula
      {
          double x = a + h * i; // Punto intermedio
          integral += Funcion(x); // Sumamos el valor de la funcion en el punto intermedio
      }
      integral *= h; // Multiplicamos por la altura
      return integral; // Devolvemos el resultado
    }

    static double MetodoRectangulos(double a, double b, long n) // Método de los rectangulos declarado como static para poder llamarlo desde el Main
    {
        double h = (b - a) / n; // Altura de los rectangulos
        double integral = 0; // Primera parte de la fórmula 

        for (int i = 0; i < n; i++) // Segunda parte de la fórmula 
        {
            double x = a + h * i; // Punto intermedio
            integral += Funcion(x); // Sumamos el valor de la funcion en el punto intermedio
        }

        integral *= h; // Multiplicamos por la altura
        return integral; // Devolvemos el resultado
    }

    static double MetodoSimpson(double a, double b, long n) // Método de Simpson declarado como static para poder llamarlo desde el Main
    {
        double h = (b - a) / n; // Ancho de cada segmento
        double integral = Funcion(a) + Funcion(b); // Primera parte de la fórmula (f(a) + f(b)) suma de los valores de la funcion en los extremos del intervalo

        for (int i = 1; i < n; i++) // Segunda parte de la fórmula Suma de los valores de la funcion en los puntos intermedios del intervalo
        {
            double x = a + h * i; // Punto intermedio
            integral += Funcion(x) * (i % 2 == 0 ? 2 : 4); // Si i es par se multiplica por 2, si es impar se multiplica por 4
        }

        integral *= h / 3; // Multiplicamos por el ancho y dividimos por 3
        return integral; // Devolvemos el resultado
    }


}