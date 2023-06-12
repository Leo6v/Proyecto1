using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear una matriz de 5x5
            int[,] matriz = new int[5, 5];

            // Generara números aleatorios y llenar la matriz
            // Random en C# es parte del espacio de nombres System,
            // y se utiliza para generar números aleatorios.
            // Proporciona diferentes métodos y propiedades para generar
            // números aleatorios de diferentes tipos y rangos.
            Random random = new Random();
            //bucle
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    // Generar un número aleatorio entre 1 y 100
                    //Next() es un método de la clase Random en C#
                    //que se utiliza para generar un número aleatorio.
                    //Este método devuelve un número entero no negativo.
                    int numeroAleatorio = random.Next(1, 100);

                    // Asignar el número aleatorio a la posición correspondiente en la matriz
                    matriz[i, j] = numeroAleatorio;
                }
            }

            // Mostrar la matriz en la consola
            Console.WriteLine("Ejercicio #1:");

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    // Imprimir el valor de la posición actual en la matriz
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }

            // Sumar las esquinas de la matriz por posicion 
            int sumaEsquinas = matriz[0, 0] + matriz[0, 4] + matriz[4, 0] + matriz[4, 4];

            // Mostrar la suma de las esquinas en la consola
            Console.WriteLine("La suma de todas las esquinas es de: " + sumaEsquinas);

            // Esperar a que el usuario presione una tecla para salir
            Console.ReadLine();
        }
    }
}

