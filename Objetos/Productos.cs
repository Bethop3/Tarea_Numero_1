using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
             "Aplicar Descuento del 10 %", "Aplicar 6 o 12 meses sin intereses",
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
            
        public void Ingresar()
        {
            Console.WriteLine("Instrucciones: \n");
            Console.WriteLine("Si es mayor o igual a 5000 se le aplicara un descuento del 10%");
            Console.WriteLine("Si es mayor o igual a 8000, se aplicara una opcion de pago a 3 meses sin intereses (Tendra que elegir si quiere el descuento del 10% o pagar a meses sin interese)");
            Console.WriteLine("Si es mayor a 10000, se le aplicara una opcion de pago a 6 o 10 meses sin intereses (Tendra que elegir si quiere el descuento del 10% o pagar a meses sin interese)");
            Console.WriteLine("Ingrese el Precio del articulo a comprar: ");
            try
            {
                int Articulo = int.Parse(Console.ReadLine());
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
                                Console.WriteLine("Ustede eligio descuento.♥");
                                Console.WriteLine("El precio del producto es de " + (Articulo - descuento));
                                Environment.Exit(0);
                            }
                            if (decision == "Aplicar 3 meses sin intereses")
                            {
                                Console.WriteLine("Usted eligio Pagar a meses sin intereses. ♥");
                                Console.WriteLine("El precio del producto es de " +Articulo);
                                Environment.Exit(0);
                            }
                        }
                        if (Articulo >= 10000)
                        {
                            string desicion = this.Opciones2();
                            if (desicion == "Aplicar Descuento del 10 %")
                            {
                                Console.WriteLine("Ustede eligio descuento.♥");
                                Console.WriteLine("El precio del producto es de "+(Articulo - descuento));
                                Environment.Exit(0);
                            }
                            if (desicion == "Aplicar 6 o 12 meses sin intereses")
                            {
                                Console.WriteLine("Usted eligio Pagar a meses sin intereses. ♥");
                                Console.WriteLine("El precio del producto es de " +Articulo);
                                Environment.Exit(0);
                            }
                        }
                        break;
                    case "No aplica":
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
