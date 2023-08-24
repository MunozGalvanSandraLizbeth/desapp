// Programa que manda saludos en la pantalla

// Declaración de variables tipo string
string persona = "Sandra"; 
string amigo = "Paloma"; 

// Escribe el valor de variable persona
Console.WriteLine(persona);

// Sustituye el valor de persona por otro
persona = "Sandy";

//Imprime texto y llama variables
Console.WriteLine("Hola" + persona); // + concatena
Console.WriteLine($"Hola {persona} bienvenida a c#"); //$ sirve para indicar que habrá una cadena de intermedio
Console.WriteLine($"\nTú eres {persona} y tu amiga es {amigo}\n"); // \n salto de línea
Console.WriteLine("Nombres con mayúsculas: ");
Console.WriteLine($"{persona.ToUpper()} {amigo.ToUpper()}"); //.ToUpper convierte cadenas a todas sus letras en mayúsculas
