// Calcular el subtotal de las ventas de un usuario

int cantidad = 0;
double tventas = 0, tiva = 0, precio = 0, subtotal, iva;
string resp = "s";

while(resp == "s") {
    Console.WriteLine("¿Desea agregar un articulo? s/n"); resp = Console.ReadLine();

    if (resp != "s")
    break;

    Console.WriteLine("Ingrese la cantidad del artículo que desea llevar: "); cantidad = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese la precio del artículo: "); precio = int.Parse(Console.ReadLine());

    subtotal = cantidad * precio;

    if (subtotal > 1200) {
        tventas += subtotal;
    }
    else {
        iva = subtotal * 0.16;
        tventas += subtotal + iva;
        tiva += iva;
    }
}

Console.WriteLine("\nResumen del subtotal de ventas:\n");
Console.WriteLine($"El subtotal de ventas es: {tventas}");
Console.WriteLine($"Y hay un total de IVA: {tiva}");