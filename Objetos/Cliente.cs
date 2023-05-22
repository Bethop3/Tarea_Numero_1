﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1.Objetos
{
    internal class Cliente
    {
        public string Nombre { get; set; }
        public long Telefono { get; set;}
        public string Correo { get; set; } 
        
        public static void Imprimir(Cliente cliente)
        {
            Console.Clear();
            Console.WriteLine("Nombre del cliente: ");
            Console.WriteLine(cliente.Nombre);
            Console.WriteLine("Telefono del cliente:");
            Console.WriteLine(cliente.Telefono);
            Console.WriteLine("Correo del cliente: ");
            Console.WriteLine(cliente.Correo);
            Console.WriteLine("\n");
        }
        public static Cliente Registro()
        {
            Cliente cliente = new Cliente();
            bool a = true;
            while (a)
            {
                try
                {
                    Console.WriteLine("Ingrese su Nombre:");
                    cliente.Nombre = Console.ReadLine();
                    Console.WriteLine("Ingrese su telefono:");
                    cliente.Telefono = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese su correo:");
                    cliente.Correo = Console.ReadLine();
                    a = false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        
            return cliente;
        }
    }
}
