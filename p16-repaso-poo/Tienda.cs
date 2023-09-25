public class Tienda
{
    // Propiedades de la tienda
    public string Nombre { get; set; }
    public string Propietario { get; set; }
    public string Domicilio { get; set; }
    public List<Cliente> Clientes { get; set; } = new List<Cliente>();

    // Constructor de la tienda
    public Tienda(string nombre, string propietario, string domicilio)
    {
        Nombre = nombre;
        Propietario = propietario;
        Domicilio = domicilio;
    }

    // Método para agregar un cliente a la tienda
    public void AgregarCliente(Cliente cliente)
    {
        Clientes.Add(cliente);
    }

    // Método para imprimir el reporte
    public void ImprimirReporte()
    {
        // Imprime los datos de la tienda
        Console.WriteLine($"Datos de la Tienda:");
        Console.WriteLine($"Nombre: {Nombre}");
        Console.WriteLine($"Propietario: {Propietario}");
        Console.WriteLine($"Domicilio: {Domicilio}");
        Console.WriteLine();

        // Imprime los datos de todos los clientes y sus ventas
        foreach (var cliente in Clientes)
        {
            Console.WriteLine($"Cliente: {cliente.Nombre}");
            Console.WriteLine($"RFC: {cliente.RFC}");
            Console.WriteLine($"Domicilio: {cliente.Domicilio}");
            Console.WriteLine($"Correo: {cliente.Correo}");
            Console.WriteLine("Ventas:");

            double subtotalCliente = 0;

            foreach (var venta in cliente.Ventas)
            {
                Console.WriteLine($"  Artículo: {venta.Articulo}");
                Console.WriteLine($"  Cantidad: {venta.Cantidad}");
                Console.WriteLine($"  Precio unitario: {venta.Precio}");
                double totalVenta = venta.Cantidad * venta.Precio;
                Console.WriteLine($"  Total de venta: {totalVenta}");
                subtotalCliente += totalVenta;
            }

            Console.WriteLine($"Subtotal del cliente: {subtotalCliente}");
            Console.WriteLine();
        }

        // Calcula y muestra el total de ventas de la tienda
        double totalTienda = Clientes.SelectMany(c => c.Ventas).Sum(v => v.Cantidad * v.Precio);
        Console.WriteLine($"Total de ventas de la tienda: {totalTienda}");
    }
}