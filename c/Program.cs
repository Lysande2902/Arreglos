using System;

namespace BurbujaApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Burbuja ordenador = new Burbuja();
            ordenador.IngresarNumeros();
            ordenador.Ordenar();
            ordenador.MostrarArregloOrdenado();
        }
    }

    class Burbuja
    {
        private int[] numeros;
        private int cantidad;

        public void IngresarNumeros()
        {
            Console.Write("Ingrese la cantidad de números a ordenar: ");
            cantidad = int.Parse(Console.ReadLine() ?? "0");
            numeros = new int[cantidad];

            Console.WriteLine("Ingrese los números:");
            for (int i = 0; i < cantidad; i++)
            {
                Console.Write($"Número {i + 1}: ");
                numeros[i] = int.Parse(Console.ReadLine() ?? "0");
            }
        }

        public void Ordenar()
        {
            for (int i = 0; i < cantidad - 1; i++) //Recorre el arreglo
            {
                for (int j = 0; j < cantidad - 1 - i; j++)
                {
                    if (numeros[j] > numeros[j + 1]) //Si el numero actual es mayor al siguiente se intercambian
                    {
                        int temp = numeros[j]; //Guarda el numero de manera temporal
                        numeros[j] = numeros[j + 1]; //Intercambia al numero
                        numeros[j + 1] = temp; //Guarda el numero temporal
                    }
                }
            }
        }

        public void MostrarArregloOrdenado() //Muestra el arreglo ordenado
        {
            Console.WriteLine("Arreglo ordenado:"); //Muestra el arreglo ordenado
            foreach (var numero in numeros)
            {
                Console.Write(numero + " ");
            }
            Console.WriteLine();
        }
    }
}
