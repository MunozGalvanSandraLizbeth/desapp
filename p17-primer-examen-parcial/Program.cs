// Crear la academia
Academia miacademia = new Academia
{
    Nombre = "Academia Fit Salud",
    Propietario = "Sandra Munoz",
    Domicilio = "Av. Garcia Salinas #432"
};

// Agregar jugadores a la academia
miacademia.AgregarJugador(new Jugador { Nombre = "Raquel Galvan", AñoNac = 2007, Sexo = 'M', Becado = true });
miacademia.AgregarJugador(new Jugador { Nombre = "Erick Mojica", AñoNac = 2008, Sexo = 'H', Becado = false });
miacademia.AgregarJugador(new Jugador { Nombre = "Sandra Muñoz", AñoNac = 2006, Sexo = 'M', Becado = false });
miacademia.AgregarJugador(new Jugador { Nombre = "Leonardo Escobedo", AñoNac = 2009, Sexo = 'H', Becado = true });
miacademia.AgregarJugador(new Jugador { Nombre = "Claudia Martinez", AñoNac = 2006, Sexo = 'H', Becado = true });
miacademia.AgregarJugador(new Jugador { Nombre = "Francisco Barrientos", AñoNac = 2010, Sexo = 'H', Becado = true });
miacademia.AgregarJugador(new Jugador { Nombre = "Pablo Morsa", AñoNac = 2012, Sexo = 'H', Becado = true });
miacademia.AgregarJugador(new Jugador { Nombre = "Estela Perez", AñoNac = 2014, Sexo = 'M', Becado = false });

// Agregar categorías a los jugadores
miacademia.AgregarCategoria(new Categoria { Nombre = "Juvenil1", RangoInicial = 2006, RangoFinal = 2008, Costo = 170.5 });
miacademia.AgregarCategoria(new Categoria { Nombre = "Poderosos", RangoInicial = 2009, RangoFinal = 2012, Costo = 140.5 });
miacademia.AgregarCategoria(new Categoria { Nombre = "Juvenil2", RangoInicial = 2013, RangoFinal = 2015, Costo = 99.9 });

// Asignar jugadores a categorías
miacademia.AsignarJugadoresACategorias();

// Generar el reporte
Console.WriteLine("REPORTE DEL CLUB DEPORTIVO\n");
Console.WriteLine($"Nombre: {miacademia.Nombre}");
Console.WriteLine($"Propietario: {miacademia.Propietario}");
Console.WriteLine($"Domicilio: {miacademia.Domicilio}");
Console.WriteLine($"Total de Categorias: {miacademia.Categorias.Count}");
Console.WriteLine($"Total de Hombres: {miacademia.Jugadores.Count(j => j.Sexo == 'H')}");
Console.WriteLine($"Total de Mujeres: {miacademia.Jugadores.Count(j => j.Sexo == 'M')}");

Console.WriteLine("\n>> Datos generales de las Categorias");
foreach (var categoria in miacademia.Categorias)
{
    Console.WriteLine(categoria.ToString());
}

Console.WriteLine("\n>> Jugadores por Categoria:");
foreach (var categoria in miacademia.Categorias)
{
    Console.WriteLine($"> {categoria.Nombre} - {categoria.RangoInicial}-{categoria.RangoFinal}");

    foreach (var jugador in miacademia.Jugadores)
    {
        if (jugador.Categorias.Any(c => c.Nombre == categoria.Nombre))
        {
            Console.WriteLine(jugador.ToString());
        }
    }

    var subtotal = miacademia.Jugadores
        .Where(j => j.Categorias.Any(c => c.Nombre == categoria.Nombre) && !j.Becado)
        .Sum(j => categoria.Costo);

    Console.WriteLine($"- Subtotal : ${subtotal:F2}\n");
}

var totalIngresos = miacademia.Jugadores
    .Where(j => !j.Becado)
    .Sum(j => j.Categorias.Sum(c => c.Costo));

Console.WriteLine($">> Total : ${totalIngresos:F2}\n");

