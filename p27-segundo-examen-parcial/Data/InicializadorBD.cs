public class InicializadorBD {
    public static void Inicializar(ContextoDatos contexto) {
        if(contexto.Articulos.Any()) {

            return;

        }
        var articulos = new Articulo[] {
            new Articulo {Descripcion="Pintura roja",FechaAlta=DateTime.Parse("26/10/2023"),Cantidad=10,Precio=70.6,UdeMedida="Litro"},
            new Articulo {Descripcion="Clavos",FechaAlta=DateTime.Parse("20/09/2023"),Cantidad=5,Precio=62.5,UdeMedida="Caja"},
            new Articulo {Descripcion="Tornillos",FechaAlta=DateTime.Parse("25/03/2023"),Cantidad=20,Precio=200.5,UdeMedida="Kilo"},
            new Articulo {Descripcion="Cinta métrica",FechaAlta=DateTime.Parse("13/08/2023"),Cantidad=5,Precio=105.3,UdeMedida="Metro"},
            new Articulo {Descripcion="Destornillador",FechaAlta=DateTime.Parse("15/04/2023"),Cantidad=1,Precio=21.0,UdeMedida="Pieza"}
        };
        contexto.Articulos.AddRange(articulos);
        contexto.SaveChanges();
    }
}