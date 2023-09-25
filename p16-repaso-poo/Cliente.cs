public class Cliente
{
    // Propiedades del cliente
    public string Nombre { get; set; }
    public string RFC { get; set; }
    public string Domicilio { get; set; }
    public string Correo { get; set; }
    public List<Venta> Ventas { get; set; } = new List<Venta>();

    // Constructor del cliente
    public Cliente(string nombre, string rfc, string domicilio, string correo)
    {
        Nombre = nombre;
        RFC = rfc;
        Domicilio = domicilio;
        Correo = correo;
    }

    // Método para agregar una venta al cliente
    public void AgregarVenta(Venta venta)
    {
        Ventas.Add(venta);
    }
}