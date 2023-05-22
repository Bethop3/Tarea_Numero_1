using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1.Objetos
{
    internal class Productos
    {
        public int Descuento(int Precio)
        {
            if (Precio >= 5000) 
            {
                int des = (Precio / 100) * 10;
                Console.WriteLine("\n Solo Aplica el descuento: \n");
                return des;
            }
            
            return 0;
        }
        public string Intereses(int Precio)
        {
            return Precio >= 8000 ? "Aplica" : "No aplica";
        }
        public string Interes (int Precio)
        {
            return Precio >= 10000 ? "Aplica" : "No Aplica";
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
                string Condicion1 = this.Interes(Articulo);
                switch (Condicion)
                {
                    case "Aplica":
                        switch (Condicion1)
                        {
                            case "Aplica":

                                break;

                            case "No Aplica":

                                break;
                        }
                        break;

                    case "No aplica": 
                        Console.WriteLine("El precio es de "+(Articulo+descuento));
                        break;
                }

            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
