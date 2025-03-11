using System;

namespace NumerosApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Numeros numeros = new Numeros(); //Aqui se crea un objeto de la clase Numeros
            numeros.IngresarNumeros(); //Un metodo de la clase Numeros
            numeros.MostrarResultados(); //Otro metodo que es mostrar
        }
    }

    class Numeros //Clase numeros
    {
        private int[] valores = new int[10]; //usamos private para que solo la clase pueda acceder a este arreglo

        public void IngresarNumeros()
        {
            Console.WriteLine("Ingrese 10 números enteros:"); //El usuario debe ingresar 10 números
            for (int i = 0; i < valores.Length; i++) //valores.length es igual a 10
            {
                Console.Write($"Número {i + 1}: "); //Ingresa el número
                valores[i] = int.Parse(Console.ReadLine()); //Se guarda el número en el arreglo
            }
        }

        private int CalcularSuma() //Metodo para calcular la suma
        {
            int suma = 0; //La suma se inicia con 0
            foreach (int valor in valores)
            {
                suma += valor; //Se va sumando cada número
            }
            return suma;
        }

        private double CalcularPromedio() //Metodo para calcular el promedio
        {
            return (double)CalcularSuma() / valores.Length; //La suma entre la cantidad de números
        }

        public void MostrarResultados() //Metodo para mostrar los resultados
        {
            int suma = CalcularSuma();
            double promedio = CalcularPromedio();

            Console.WriteLine($"La suma total es: {suma}");
            Console.WriteLine($"El promedio de los números es: {promedio}");
        }
    }
}
