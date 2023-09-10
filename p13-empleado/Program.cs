// Cintrol empleados

// Instaciar y reservar  espacio en la memoria para un objeto de una clase determinada
Empleado empleado01 = new Empleado();
empleado01.Nombre = "Juan Carlos";
empleado01.Edad = 22;
empleado01.Sexo = 'H';
empleado01.Casado = false;
empleado01.ImprimirDatos();

// Instaciar, luego reservar  espacio en la memoria para un objeto de una clase determinada
Empleado empleado02 = new Empleado();
empleado02.Nombre = "Maria de Jesus";
empleado02.Edad = 41;
empleado02.Sexo = 'M';
empleado02.Casado = true;
empleado02.ImprimirDatos();

Empleado empleado03 = new Empleado("Claudia Solis", 35, 'M', false);
empleado03.ImprimirDatos();

Empleado empleado04 = new Empleado{Nombre = "Gato con botas", Edad = 75, Sexo = 'H', Casado = true};
empleado04.ImprimirDatos();
