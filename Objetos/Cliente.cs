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
        public string Telefono { get; set;}
        public string Correo { get; set; } 
        
        public static void Imprimir(Cliente cliente)
        {
            Console.Clear();
            Console.WriteLine("Nombre del cliente: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(cliente.Nombre);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Telefono del cliente:");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(cliente.Telefono);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Correo del cliente: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(cliente.Correo);
            Console.ForegroundColor = ConsoleColor.White;
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
                    
                    if( cliente.Nombre.Length == 0 )
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Porfavor Ingrese los datos correctamente.");
                        Console.ForegroundColor = ConsoleColor.White;
                        continue;
                    }
                    
                    Console.WriteLine("Ingrese su telefono:");
                    cliente.Telefono = Console.ReadLine();
                    if (cliente.Telefono.Length == 0)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Porfavor Ingrese los datos correctamente.");
                        Console.ForegroundColor = ConsoleColor.White;
                        continue;
                    }
                    Console.WriteLine("Ingrese su correo:");
                    cliente.Correo = Console.ReadLine();
                    if (cliente.Correo.Length == 0)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Porfavor Ingrese los datos correctamente.");
                        Console.ForegroundColor = ConsoleColor.White;
                        continue;
                    }
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
