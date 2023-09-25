
Tienda mitienda = new Tienda {Nombre = "Ferreteria las Lomas", Domicilio = "Av. Luis Moya 345", Propietario = "Sandra Munoz"};

// Agregar clientes a la tienda
mitienda.AgregarCliente(new Cliente {Nombre = "Felipe Calderon", RFC = "CACF560909Y34", Domicilio = "Las Lomas 123", Correo = "calderon345@gmail.com"} );
mitienda.AgregarCliente(new Cliente {Nombre = "Enrique Peña", RFC = "PEEN750807C34", Domicilio = "5 de Mayo 321", Correo = "pena564@gmail.com"} );
mitienda.AgregarCliente(new Cliente {Nombre = "Andres Lopez", RFC = "LOOA450302F56", Domicilio = "Palacio Nacional 213", Correo = "amlo2312@gmail.com" });
mitienda.AgregarCliente(new Cliente {Nombre = "Xocjitl Gelatinas", RFC = "GEPX800504P23", Domicilio = "Danone 231", Correo = "xochitl764@gmail.com", });

//Agregar ventas a los clientes
mitienda.Clientes[0].AgregarVenta(new Venta {Articulo = "Martillo", Cantidad = 10, Precio = 60.5} );
mitienda.Clientes[0].AgregarVenta(new Venta {Articulo = "Pala", Cantidad = 2, Precio = 170.55} );
mitienda.Clientes[1].AgregarVenta(new Venta {Articulo = "Clavo", Cantidad = 2.5, Precio = 60.34} );
mitienda.Clientes[1].AgregarVenta(new Venta {Articulo = "Cinta de aislar", Cantidad = 5, Precio = 7.34} );
mitienda.Clientes[1].AgregarVenta(new Venta {Articulo = "Pinzas", Cantidad = 1, Precio = 650.33} );
mitienda.Clientes[2].AgregarVenta(new Venta {Articulo = "Thiner", Cantidad = 5, Precio = 65.00} );

// Reporte
Console.Clear();
Console.WriteLine("Reporte de ventas en Tienda\n");
Console.WriteLine(mitienda.ToString());
Console.WriteLine($"\nTotal de clientes: {mitienda.Clientes.Count()}");
Console.WriteLine($"Total de Ventas: {mitienda.TotalVentas()}");

Console.WriteLine("\n>> Datos generales de los clientes:\n");
foreach(Cliente cliente in mitienda.Clientes) {
    Console.WriteLine(cliente.ToString());
}

Console.WriteLine(">> Ventas de los clientes:\n");
foreach(Cliente cliente in mitienda.Clientes) {
    Console.WriteLine($"\n> {cliente.Nombre} - {cliente.RFC} - ({cliente.Ventas.Count()})\n");
    foreach(Venta venta in cliente.Ventas)
        Console.WriteLine(venta.ToString());
    Console.WriteLine($"\n- Subtotal : {cliente.SubTotal(),36:c2}\n");
}
Console.WriteLine($"\n\n- Total: {mitienda.Total(),40:c2}\n");
