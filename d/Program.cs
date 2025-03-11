using System;

namespace InversionArregloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            InversorArreglo inversor = new InversorArreglo();
            inversor.IngresarNumeros();
            inversor.MostrarArregloOriginal();
            inversor.InvertirArreglo();
            inversor.MostrarArregloInvertido();
        }
    }

    class InversorArreglo
    {
        private int[] numeros = new int[5]; //Arreglo de 5 elementos

        public void IngresarNumeros()
        {
            Console.WriteLine("Ingrese 5 números enteros:");
            for (int i = 0; i < numeros.Length; i++) //Recorre el arreglo
            {
                Console.Write($"Número {i + 1}: "); //Pide el número
                numeros[i] = int.Parse(Console.ReadLine() ?? "0"); //Guarda el número en el arreglo
            }
        }

        public void MostrarArregloOriginal()
        {
            Console.WriteLine("Arreglo original:"); //Muestra el arreglo original
            for (int i = 0; i < numeros.Length; i++) //Recorre todo el arreglo
            {
                Console.WriteLine(numeros[i]);
            }
        }

        public void InvertirArreglo() //Invierte el arreglo
        {
            int inicio = 0; //Inicio del arreglo
            int fin = numeros.Length - 1; //Fin del arreglo

            while (inicio < fin)
            {
                // Intercambiar los elementos
                int temp = numeros[inicio]; //Guarda el número de manera temporal
                numeros[inicio] = numeros[fin]; //Intercambia el número
                numeros[fin] = temp; //Guarda el número temporal

                inicio++; //inicio++ es igual a inicio = inicio + 1. Esto hace que se mueva al siguiente número
                fin--; //fin-- es igual a fin = fin - 1. Sirve para que mueva el número al anterior
            }
        }

        public void MostrarArregloInvertido()
        {
            Console.WriteLine("Arreglo invertido:");
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine(numeros[i]);
            }
        }
    }
}
