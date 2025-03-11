using System;

namespace BusquedaNombreApp
{
    class Program
    {
        static void Main(string[] args)
        {
            BuscadorNombres buscador = new BuscadorNombres();
            buscador.IngresarNombres();
            buscador.BuscarNombre();
        }
    }

    class BuscadorNombres
    {
        private string[] nombres = new string[5];

        public void IngresarNombres()
        {
            Console.WriteLine("Ingrese 5 nombres:");
            for (int i = 0; i < nombres.Length; i++)
            {
                Console.Write($"Nombre {i + 1}: ");
                nombres[i] = Console.ReadLine() ?? string.Empty;
            }
        }

        public void BuscarNombre()
        {
            Console.Write("Ingrese un nombre a buscar: ");
            string nombreABuscar = Console.ReadLine() ?? string.Empty;

            bool encontrado = false;
            for (int i = 0; i < nombres.Length; i++)
            {
                if (nombres[i].Equals(nombreABuscar, StringComparison.OrdinalIgnoreCase))
                {
                    // Mostrar la posición en el arreglo (sin sumar 1)
                    Console.WriteLine(
                        $"El nombre '{nombreABuscar}' se encuentra en la posición {i}."
                    );
                    encontrado = true;
                    break;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine($"El nombre '{nombreABuscar}' no se encuentra en el arreglo.");
            }
        }
    }
}
