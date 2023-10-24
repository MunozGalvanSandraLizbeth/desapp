public class InicializadorBD {
    public static void Inicializar(ContextoDatos contexto) {
        if(contexto.Jugadores.Any()) {

            return;

        }
        var jugadores = new Jugador[] {
            new Jugador {Nombre="Sandra Muñoz",FechaNac=DateTime.Parse("27/10/2001"),NoPlayera=10,Posicion="Medio",Apariciones=6,Goles=3},
            new Jugador {Nombre="Erick Mojica",FechaNac=DateTime.Parse("20/12/2001"),NoPlayera=1,Posicion="Portero",Apariciones=10,Goles=7},
            new Jugador {Nombre="Alondra Galvan",FechaNac=DateTime.Parse("11/11/2009"),NoPlayera=14,Posicion="Defensa",Apariciones=7,Goles=0},
            new Jugador {Nombre="Paloma Escobedo",FechaNac=DateTime.Parse("17/05/2007"),NoPlayera=5,Posicion="Lateral",Apariciones=8,Goles=2}
        };
        contexto.Jugadores.AddRange(jugadores);
        contexto.SaveChanges();
    }
}