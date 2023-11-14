public class InicializadorBD
{
    public static void Inicializar(ContextoDatos contexto)
    {
        if(contexto.Clientes.Any())
            return;
        var clientes = new List<Cliente> {
            new Cliente { Nombre = "Samira", Apeido = "Clemente", Genero = 'M', FechaCumple = DateTime.Parse("1970-09-11"), Correo = "sacle@gmail.com", Telefono = "4921056987" },
            new Cliente { Nombre = "Leandro", Apeido = "Alvaro", Genero = 'H', FechaCumple = DateTime.Parse("1999-02-01"), Correo = "lealv@gmail.com", Telefono = "4934567895" },
            new Cliente { Nombre = "Angel", Apeido = "Molinero", Genero = 'H', FechaCumple = DateTime.Parse("2001-03-28"), Correo = "angelmol@gmail.com", Telefono = "4331089755" },
            new Cliente { Nombre = "Carolina", Apeido = "Villegas", Genero = 'M', FechaCumple = DateTime.Parse("1989-12-25"), Correo = "carovi@hotmail.com", Telefono = "4944067766" },
            new Cliente { Nombre = "Trinidad", Apeido = "Baez", Genero = 'H', FechaCumple = DateTime.Parse("1990-06-18"), Correo = "triba@hotmail.com", Telefono = "4921001010" },
            new Cliente { Nombre = "Ahmed", Apeido = "Peris", Genero = 'M', FechaCumple = DateTime.Parse("1993-11-20"), Correo = "ahmedpe@gmail.com", Telefono = "4934867422" }
        };
        contexto.Clientes.AddRange(clientes);
        contexto.SaveChanges();

        var habitaciones = new List<Habitacion> {
            new Habitacion { NoHab = 1, Tipo = "Individual", Piso = 1, Costo = 255.80 },
            new Habitacion { NoHab = 11, Tipo = "Doble", Piso = 2, Costo = 355.80 },
            new Habitacion { NoHab = 16, Tipo = "Ejecutiva", Piso = 2, Costo = 755.80 },
            new Habitacion { NoHab = 18, Tipo = "Doble", Piso = 3, Costo = 355.80 },
            new Habitacion { NoHab = 21, Tipo = "Familiar", Piso = 3, Costo = 555.80 },
            new Habitacion { NoHab = 27, Tipo = "Triple", Piso = 4, Costo = 455.80 }
        };
        contexto.Habitaciones.AddRange(habitaciones);
        contexto.SaveChanges();

        var reservas = new List<Reserva>
        {
            new Reserva { ClienteId = clientes.Single(c => c.Apeido == "Clemente").Id, HabitacionId = habitaciones.Single(h => h.NoHab == 1).Id, InicioReserva = DateTime.Parse("2022-10-11"), FinReserva = DateTime.Parse("2022-10-12") },
            new Reserva { ClienteId = clientes.Single(c => c.Apeido == "Molinero").Id, HabitacionId = habitaciones.Single(h => h.NoHab == 16).Id, InicioReserva = DateTime.Parse("2021-05-05"), FinReserva = DateTime.Parse("2021-05-08")},
            new Reserva { ClienteId = clientes.Single(c => c.Apeido == "Baez").Id, HabitacionId = habitaciones.Single(h => h.NoHab == 21).Id, InicioReserva = DateTime.Parse("2023-09-20"), FinReserva = DateTime.Parse("2023-10-01")},
            new Reserva { ClienteId = clientes.Single(c => c.Apeido == "Villegas").Id, HabitacionId = habitaciones.Single(h => h.NoHab == 11).Id, InicioReserva = DateTime.Parse("2020-12-24"), FinReserva = DateTime.Parse("2021-01-02")}
        };
        contexto.Reservas.AddRange(reservas);
        contexto.SaveChanges();
    }
}