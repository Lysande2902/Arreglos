using System;
using System.IO; //Se agrega la librería para trabajar con archivos

namespace ManejoArchivosApp
{
    class Program
    {
        static void Main(string[] args)
        {
            GestorNombres gestor = new GestorNombres();
            gestor.IngresarNombres();
            gestor.GuardarNombres();
            gestor.MostrarNombres();
        }
    }

    class GestorNombres
    {
        private string[] nombres = new string[5];
        private string archivo = "nombres.txt"; 

        public void IngresarNombres()
        {
            Console.WriteLine("Ingrese 5 nombres:");
            for (int i = 0; i < nombres.Length; i++)
            {
                Console.Write($"Nombre {i + 1}: ");
                nombres[i] = Console.ReadLine() ?? string.Empty;
            }
        }
