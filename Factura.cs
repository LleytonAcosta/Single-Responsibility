using System;
using System.Collections.Generic;
using System.Text;
//using System.Threading.Tasks;
namespace Single_Responsibility
{

    public class Factura
    { 
        // Propiedades 
        public int Cedula { get; set; }

        public DateTime Fecha { get; set; }

        public List<Item> Items { get; set; }

        public Cliente Cliente { get; set; }

        // Constructor
        public Factura(int cedula, Cliente cliente)
        {
            Cedula = cedula;
            Cliente = cliente;
            Items = new List<Item>();
            Fecha = DateTime.Today;
        }

        // Calculo unico donde se obtiene el subtotal y se calcula y retorna el total de los productos

        public double Total()
        {
            double total = 0;
            foreach(var item in Items)
            {
                total += item.Subtotal();
            }
            return total;
        }


    }  
}
