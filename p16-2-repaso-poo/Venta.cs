public class Venta {
    public string Articulo {get; set;}
    public double Cantidad {get; set;}
    public double Precio {get; set;}
    public double Total {get { return Cantidad * Precio;} }

    public Venta() {}
    public Venta(string articulo, int cantidad, double precio) => (Articulo, Cantidad, Precio) = (articulo, cantidad, precio);

    public override string ToString() => $"{Articulo,-20}{Cantidad,5:f2}{Precio,12:c2}{Total,12:c2}";
}