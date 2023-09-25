// Crear una instancia de la tienda
        Tienda miTienda = new Tienda("Mi Tienda", "Juan Pérez", "Calle Principal 123");

        // Crear clientes
        Cliente cliente1 = new Cliente("Rosa Mijarez", "MICR980403V12", "Calle constitución #23", "RosaMija321@gmail.com");
        Cliente cliente2 = new Cliente("Pedro Picapiedra", "PIGP210607", "Cueva central #76", "Picapiedra543@hotmail.com");
        Cliente cliente3 = new Cliente("Erick Mojica", "MOBE011220T54", "5 de mayo #123", "Mobef5643@gmail.com");
        Cliente cliente4 = new Cliente("Paloma Escobedo", "ESMN020517P32", "Azucena #1", "NidiaPaloma2@hotmail.com");

        // Crear ventas para los clientes
        Venta venta1 = new Venta("Producto A", 3, 10.0);
        Venta venta2 = new Venta("Producto B", 2, 15.0);
        Venta venta3 = new Venta("Producto C", 5, 20.0);
        Venta venta4 = new Venta("Producto D", 1, 12.0);

        // Asociar las ventas a los clientes
        cliente1.AgregarVenta(venta1);
        cliente2.AgregarVenta(venta2);
        cliente3.AgregarVenta(venta3);
        cliente4.AgregarVenta(venta4);

        // Agregar los clientes a la tienda
        miTienda.AgregarCliente(cliente1);
        miTienda.AgregarCliente(cliente2);
        miTienda.AgregarCliente(cliente3);
        miTienda.AgregarCliente(cliente4);

        // Imprimir el reporte
        miTienda.ImprimirReporte();
