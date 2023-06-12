using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoVersionII
{
    internal class Program
    {
        static string[] proveedores = { "Apple", "Bershka", "CocaCola", "Datsun", "Eucerin" };
        static string[] ciudades = { "Alajuela", "Bagaces", "Cartago", "Desamparados", "Esparza" };
        static int[] articulos = { 2, 75, 12, 2, 42 };

        static void Main(string[] args)
        {
            char opcion;

            do
            {
                // Mostrar el menú de opciones
                Console.WriteLine("Seleccione una opción:");
                Console.WriteLine("1) Informar datos de un proveedor.");
                Console.WriteLine("2) Actualizar ciudad de un proveedor.");
                Console.WriteLine("3) Actualizar número de artículos de un proveedor.");
                Console.WriteLine("4) Incorporar un nuevo proveedor.");
                Console.WriteLine("5) Dar de baja a un proveedor.");
                Console.WriteLine("6) Salir.");

                // Leer la opción seleccionada por el usuario
                opcion = char.ToLower(Console.ReadKey().KeyChar);
                Console.WriteLine();

                switch (opcion)
                {
                    case '1':
                        InformarDatosProveedor();
                        break;

                    case '2':
                        ActualizarCiudadProveedor();
                        break;

                    case '3':
                        ActualizarNumeroArticulosProveedor();
                        break;

                    case '4':
                        IncorporarNuevoProveedor();
                        break;

                    case '5':
                        DarDeBajaProveedor();
                        break;

                    case '6':
                        Console.WriteLine("Gracias por utilizar el programa.");
                        break;

                    default:
                        Console.WriteLine("Opción inválida. Por favor, seleccione una opción válida.");
                        break;
                }

                Console.WriteLine();
            }
            while (opcion != '6');
        }

        static void InformarDatosProveedor()
        {
            // Solicitar el nombre del proveedor al usuario
            Console.WriteLine("Ingrese el nombre del proveedor:");
            string proveedor = Console.ReadLine();

            // Buscar el proveedor en el arreglo // método Array.IndexOf estático de la clase Array en C# que se
            // utiliza para buscar el índice de la primera aparición de un elemento en un arreglo.
            int indice = Array.IndexOf(proveedores, proveedor);
            if (indice != -1)
            {
                // Mostrar los datos del proveedor encontrado
                Console.WriteLine("Proveedor: " + proveedores[indice]);
                Console.WriteLine("Ciudad: " + ciudades[indice]);
                Console.WriteLine("Número de artículos: " + articulos[indice]);
            }
            else
            {
                Console.WriteLine("El proveedor ingresado no existe.");
            }
        }

        static void ActualizarCiudadProveedor()
        {
            // Solicitar el nombre del proveedor al usuario
            Console.WriteLine("Ingrese el nombre del proveedor:");
            string proveedor = Console.ReadLine();

            // Buscar el proveedor en el arreglo
            int indice = Array.IndexOf(proveedores, proveedor);
            //se evalúa como verdadera si el valor de indice no es igual a -1.
            if (indice != -1)
            {
                // Solicitar la nueva ciudad al usuario
                Console.WriteLine("Ingrese la nueva ciudad del proveedor:");
                string nuevaCiudad = Console.ReadLine();

                // Actualizar la ciudad del proveedor
                ciudades[indice] = nuevaCiudad;
                Console.WriteLine("Ciudad actualizada exitosamente.");
            }
            else
            {
                Console.WriteLine("El proveedor ingresado no existe.");
            }
        }

        static void ActualizarNumeroArticulosProveedor()
        {
            // Solicitar el nombre del proveedor al usuario
            Console.WriteLine("Ingrese el nombre del proveedor:");
            string proveedor = Console.ReadLine();

            // Buscar el proveedor en el arreglo
            int indice = Array.IndexOf(proveedores, proveedor);
            if (indice != -1)
            {
                // Solicitar la cantidad de artículos a aumentar o disminuir
                Console.WriteLine("Ingrese la cantidad de artículos (positiva para aumentar, negativa para disminuir):");
                int cantidad = int.Parse(Console.ReadLine());

                // Actualizar el número de artículos del proveedor
                articulos[indice] += cantidad;
                Console.WriteLine("Número de artículos actualizado exitosamente.");
            }
            else
            {
                Console.WriteLine("El proveedor ingresado no existe.");
            }
        }

        static void IncorporarNuevoProveedor()
        {
            // Solicitar el nombre del nuevo proveedor al usuario
            Console.WriteLine("Ingrese el nombre del nuevo proveedor:");
            string nuevoProveedor = Console.ReadLine();

            // Solicitar la ciudad del nuevo proveedor al usuario
            Console.WriteLine("Ingrese la ciudad del nuevo proveedor:");
            string nuevaCiudad = Console.ReadLine();

            // Solicitar el número de artículos del nuevo proveedor al usuario
            Console.WriteLine("Ingrese el número de artículos del nuevo proveedor:");
            int nuevosArticulos = int.Parse(Console.ReadLine());

            // Buscar la posición donde se debe insertar el nuevo proveedor en orden alfabético
            // Array.BinarySearch es un método estático de la clase Array en C# que se utiliza
            // para buscar un elemento en un arreglo unidimensional ordenado.
            int indice = Array.BinarySearch(proveedores, nuevoProveedor);
            if (indice < 0)
            {
                indice = ~indice;

                // Aumentar el tamaño de los arreglos para incluir el nuevo proveedor
                // Array.Resize es un método estático de la clase Array en C# que se
                // utiliza para cambiar el tamaño de un arreglo unidimensional.
                Array.Resize(ref proveedores, proveedores.Length + 1);
                Array.Resize(ref ciudades, ciudades.Length + 1);
                Array.Resize(ref articulos, articulos.Length + 1);

                // Desplazar los elementos para abrir espacio al nuevo proveedor
                //Array.Copy es un método estático de la clase Array en C# que se
                //utiliza para copiar elementos de un arreglo a otro arreglo.
                Array.Copy(proveedores, indice, proveedores, indice + 1, proveedores.Length - indice - 1);
                Array.Copy(ciudades, indice, ciudades, indice + 1, ciudades.Length - indice - 1);
                Array.Copy(articulos, indice, articulos, indice + 1, articulos.Length - indice - 1);

                // Insertar el nuevo proveedor en la posición correcta
                proveedores[indice] = nuevoProveedor;
                ciudades[indice] = nuevaCiudad;
                articulos[indice] = nuevosArticulos;

                Console.WriteLine("Proveedor incorporado exitosamente.");
            }
            else
            {
                Console.WriteLine("El proveedor ingresado ya existe.");
            }
        }

        static void DarDeBajaProveedor()
        {
            // Solicitar el nombre del proveedor a dar de baja al usuario
            Console.WriteLine("Ingrese el nombre del proveedor a dar de baja:");
            string proveedor = Console.ReadLine();

            // Buscar el proveedor en el arreglo
            int indice = Array.IndexOf(proveedores, proveedor);
            if (indice != -1)
            {
                // Desplazar los elementos para eliminar al proveedor
                Array.Copy(proveedores, indice + 1, proveedores, indice, proveedores.Length - indice - 1);
                Array.Copy(ciudades, indice + 1, ciudades, indice, ciudades.Length - indice - 1);
                Array.Copy(articulos, indice + 1, articulos, indice, articulos.Length - indice - 1);

                // Reducir el tamaño de los arreglos
                Array.Resize(ref proveedores, proveedores.Length - 1);
                Array.Resize(ref ciudades, ciudades.Length - 1);
                Array.Resize(ref articulos, articulos.Length - 1);

                Console.WriteLine("Proveedor dado de baja exitosamente.");
            }
            else
            {
                Console.WriteLine("El proveedor ingresado no existe.");
            }
        }
    }
}