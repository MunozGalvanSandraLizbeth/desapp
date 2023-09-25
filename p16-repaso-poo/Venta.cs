public class Venta
{
    // Propiedades de la venta
    public string Articulo { get; set; }
    public int Cantidad { get; set; }
    public double Precio { get; set; }

    // Constructor de la venta
    public Venta(string articulo, int cantidad, double precio)
    {
        Articulo = articulo;
        Cantidad = cantidad;
        Precio = precio;
    }
}