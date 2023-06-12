using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear una instancia de la clase Random para generar números aleatorios
            Random random = new Random();

            // Crear la matriz de tamaño 5x5
            int[,] matriz = new int[5, 5];

            // Llenar la matriz con números aleatorios
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    // Generar un número aleatorio entre 1 y 100
                    int numeroAleatorio = random.Next(1, 100);

                    // Asignar el número aleatorio a la posición correspondiente en la matriz
                    matriz[i, j] = numeroAleatorio;
                }
            }

            // Mostrar la matriz en la consola
            Console.WriteLine("Matriz generada:");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }

            // Sumar las diagonales de la matriz
            int sumaDiagonal1 = 0;
            int sumaDiagonal2 = 0;
            for (int i = 0; i < 5; i++)
            {
                // Sumar los elementos de la diagonal principal (misma posición en filas y columnas)
                sumaDiagonal1 += matriz[i, i];

                // Sumar los elementos de la diagonal secundaria (posición inversa en filas y columnas)
                sumaDiagonal2 += matriz[i, 4 - i];
            }

            // Mostrar el resultado de la suma de las diagonales
            Console.WriteLine("Suma de la diagonal principal: " + sumaDiagonal1);
            Console.WriteLine("Suma de la diagonal secundaria: " + sumaDiagonal2);

            Console.ReadLine();
        }
    }
}