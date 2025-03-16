using System;
using System.Collections.Generic;

namespace CatalogoRevistas
{
    class Program
    {
        static void Main(string[] args)
        {
            // Información de la estudiante
            // UNIVERSIDAD ESTATAL AMAZÓNICA
            // CARRERA: TECNOLOGÍAS DE LA INFORMACIÓN
            // ALUMNA: ROSA ELENA CONDE PAUCAR

            // 1. Crear catálogo de revistas usando una List
            List<string> catalogoRevistas = new List<string>();

            // 2. Ingresar 10 títulos al catálogo
            catalogoRevistas.Add("National Geographic");
            catalogoRevistas.Add("Time Magazine");
            catalogoRevistas.Add("Scientific American");
            catalogoRevistas.Add("The Economist");
            catalogoRevistas.Add("Nature");
            catalogoRevistas.Add("Popular Science");
            catalogoRevistas.Add("Wired");
            catalogoRevistas.Add("Discover");
            catalogoRevistas.Add("New Scientist");
            catalogoRevistas.Add("Technology Review");

            bool continuar = true;

            while (continuar)
            {
                // 3. Mostrar menú
                Console.WriteLine("\n=== CATÁLOGO DE REVISTAS ===");
                Console.WriteLine("1. Buscar un título");
                Console.WriteLine("2. Salir");
                Console.Write("Seleccione una opción: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        // 4. Buscar un título
                        Console.Write("Ingrese el título a buscar: ");
                        string tituloBuscado = Console.ReadLine();

                        // Búsqueda iterativa
                        bool encontrado = false;
                        foreach (string titulo in catalogoRevistas)
                        {
                            if (titulo.ToLower() == tituloBuscado.ToLower())
                            {
                                encontrado = true;
                                break;
                            }
                        }

                        // 5. Mostrar resultado
                        if (encontrado)
                        {
                            Console.WriteLine("Resultado: encontrado");
                        }
                        else
                        {
                            Console.WriteLine("Resultado: no encontrado");
                        }
                        break;

                    case "2":
                        continuar = false;
                        Console.WriteLine("Saliendo del programa...");
                        break;

                    default:
                        Console.WriteLine("Opción no válida. Por favor, intente de nuevo.");
                        break;
                }
            }
        }
    }
}
