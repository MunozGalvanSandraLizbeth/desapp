public class InicializadorBD {
    
    public static void Inicializar(ContextoDatos contexto) {

        if(contexto.Empleados.Any()) {
            return;
        }

        var empleados = new Empleado[] {
            new Empleado {Nombre="Juan de la Fuente",RFC="CAFU771123PCI",Edad=45,Genero="Hombre",Correo="jfuente@hotmail.com",Salario=3200.25},
            new Empleado {Nombre="Santiago Jimenez",RFC="SAGI711202",Edad=52,Genero="Hombre",Correo="sanji13@uaz.edu.mx",Salario=3200.25},
            new Empleado {Nombre="Lucia Rodriguez",RFC="LURO771124",Edad=46,Genero="Mujer",Correo="lucyrod@gmail.com",Salario=13210.75},
            new Empleado {Nombre="Roberto Arellano",RFC="ROAR561234",Edad=67,Genero="Hombre",Correo="robertoa@yahoo.com",Salario=9600.00},
            new Empleado {Nombre="Ana Montoya",RFC="ANMO661202",Edad=30,Genero="Mujer",Correo="amontoya@gmail.com",Salario=4765.33},
            new Empleado {Nombre="Erick Mojica",RFC="MOBE011220L76",Edad=21,Genero="Hombre",Correo="mobaer@gmail.com",Salario=7500.50}
        };
        contexto.Empleados.AddRange(empleados);
        contexto.SaveChanges();
    }
}