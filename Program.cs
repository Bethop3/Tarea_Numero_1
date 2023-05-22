using System;
using Tarea1.Objetos;

namespace Tarea1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hola Bievendio Ingresa los siguientes datos:");
            Cliente cliente = Cliente.Registro();
            Cliente.Imprimir(cliente);
        }
    }
}
