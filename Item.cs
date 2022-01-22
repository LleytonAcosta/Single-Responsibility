namespace Single_Responsibility
{
    public class Item
    { // Propiedades 
        public Producto Producto { get; set; }

        public int Cantidad { get; set; }

        //Constructor 
        public Item(Producto producto, int cantidad)
        {
            Producto = producto;
            Cantidad = cantidad;
        }

        // Metodo que se aplica solo la responsabilidad de calcular el subtotal de los productos
        public double Subtotal()
        {
            return Cantidad * Producto.Precio;
        }
    }
}

