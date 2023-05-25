using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Tarea1.Objetos
{
    internal class Productos
    {
        public string Opciones1()
        {

            // Seleccionar cualquier opcion del menu
            var fruit = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                    .Title("\t Seleccione Cualquier opcion: ")
                    .PageSize(10)
                    .MoreChoicesText("[grey](Muevete Con las teclas Arriba y Abajo, dar ENTER para elegir la opcion)[/]")
                    .AddChoices(new[] {
             "Aplicar Descuento del 10 %", "Aplicar 3 meses sin intereses",
                    }));

            // regresar la opcion seleccionada como un string
            return fruit;
        }
        public string Opciones2()
        {

            // Seleccionar cualquier opcion del menu
            var fruit = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                    .Title("\t Seleccione Cualquier opcion: ")
                    .PageSize(10)
                    .MoreChoicesText("[grey](Muevete Con las teclas Arriba y Abajo, dar ENTER para elegir la opcion)[/]")
                    .AddChoices(new[] {
             "Aplicar Descuento del 10 %","Aplicar 3 meses sin intereses", "Aplicar 6 meses sin intereses","Aplicar 12 meses sin intereses",
                    }));

            // regresar la opcion seleccionada como un string
            return fruit;
        }
        public int Descuento(int Precio)
        {
            if (Precio > 5000) 
            {
                int des = (Precio / 100) * 10;
                Console.WriteLine("\n Su descuento es de: "+des+"\n");
                return des;
            }
            
            return 0;
        }
        public string Intereses(int Precio)
        {

            if( Precio >= 8000 && Precio < 10000)
            {
                return "Aplica";
            }
            if ( Precio >= 10000)
            {
                return "Aplica";
            }

            return "No aplica";

        }
        public int IngresarNum()
        {
            int aux = 0;
            bool t = true;
            while (t)
            {
                try
                {
                    int lola;
                    int i;
                    Console.WriteLine("Ingresa Cuantos productos comprara");
                    i= int.Parse(Console.ReadLine());
                    for ( int j = 0; j < i; j++)
                    {
                        Console.WriteLine("Ingresa el producto numero " + (j + 1));
                        lola = int.Parse(Console.ReadLine());
                        aux = aux + lola ;
                    }
                    t = false;
                }
                catch (Exception ex)
                {
                    Console.Clear();

                    Console.WriteLine(ex.Message);
                }
            }
            return aux;
        }
            
        public void Ingresar()
        {
            Console.WriteLine("Instrucciones: \n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" \n Devera ingresar los precios de los productos.\n");
            Console.WriteLine("1. Si es mayor o igual a 5000 se le aplicara un descuento del 10% \n");
            Console.WriteLine("2. Si es mayor o igual a 8000, se aplicara una opcion de pago a 3 meses \n sin intereses (Tendra que elegir si quiere el descuento del 10% o pagar a meses sin interese)\n ");
            Console.WriteLine("3. Si es mayor a 10000, se le aplicara una opcion de pago a 6 o 10 meses \n sin intereses (Tendra que elegir si quiere el descuento del 10% o pagar a meses sin interese)\n ");
            Console.ForegroundColor = ConsoleColor.White;
            try
            {
                int Articulo = this.IngresarNum();
                double descuento = this.Descuento(Articulo);
                string Condicion = this.Intereses(Articulo);
                switch (Condicion)
                {
                    case "Aplica":
                        
                        if (Articulo > 8000 && Articulo < 10000)
                        {
                            string decision = this.Opciones1();
                            if (decision == "Aplicar Descuento del 10 %")
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Ustede eligio descuento.♥");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("El precio del producto es de " + (Articulo - descuento));
                                Environment.Exit(0);
                            }
                            if (decision == "Aplicar 3 meses sin intereses")
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Usted eligio Pagar a meses sin intereses. ♥");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("El precio del producto es de " +Articulo);
                                Environment.Exit(0);
                            }
                        }
                        if (Articulo >= 10000)
                        {
                            string desicion = this.Opciones2();
                            if (desicion == "Aplicar Descuento del 10 %")
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Ustede eligio descuento.♥");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("El precio del producto es de "+(Articulo - descuento));
                                Environment.Exit(0);
                            }
                            if (desicion == "Aplicar 3 meses sin intereses")
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Usted eligio Pagar a 3 meses sin intereses. ♥");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("El precio del producto es de " + Articulo);
                                Environment.Exit(0);
                            }
                            if (desicion == "Aplicar 6 meses sin intereses")
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Usted eligio Pagar a 6 meses sin intereses. ♥");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("El precio del producto es de " +Articulo);
                                Environment.Exit(0);
                            }
                            if (desicion == "Aplicar 12 meses sin intereses")
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Usted eligio Pagar a 12 meses sin intereses. ♥");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("El precio del producto es de " + Articulo);
                                Environment.Exit(0);
                            }
                        }
                        break;
                    case "No aplica":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("El precio es de "+(Articulo-descuento));
                        break;
                }

            }catch (Exception ex)
            {
                Console.Clear();
                Ingresar();
                Console.WriteLine(ex.Message);
            }
        }
    }
}
