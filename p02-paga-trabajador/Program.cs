// Calcula la paga de un trabajador, considerando las horas extra

// Declaración de variables
string nombre;
int horas, hextra=0; // Valores numéricas enteras
float paga, pagaextra=0, pagabruta, paganeta, impuesto, tasa; // Valores numéricas punto flotante

Console.Clear(); // Limpia consola
Console.WriteLine("Calculando la paga de un trabajador \n");
Console.Write("Nombre ? ") ; nombre = Console.ReadLine(); // Te pide que ingreses un valor tipo string y la almacena en variable
Console.Write("Horas trabajadas ? ") ; horas = int.Parse(Console.ReadLine()); // Te pide que ingreses un valor tipo int y la almacena en variable
Console.Write("Paga por hora ? ") ; paga = float.Parse(Console.ReadLine()); // Te pide que ingreses un valor tipo float y la almacena en variable

tasa = 0.03f; // Asigna valor a variable

if(horas > 40) { // Si las horas son mayores a 40 horas
hextra = horas - 40; // Se le restan 40 a las horas y las almacena en variable hextra
pagaextra = 2 * paga * hextra; // Dos veces la paga por las horas extras, y se almacena en variable pagaextra
pagabruta = 40 * paga + (2 * paga * hextra); // 40 horas por la paga + horas extras y se almacena en variable pagabruta
} else // Sino

pagabruta = horas * paga; // La pagabruta será el valor de horas por la paga

impuesto = pagabruta * tasa; // El impuesto será la pagabruta por la tasa
paganeta = pagabruta - impuesto; // Y l paga neta será la pagabruta menos los impuestos

// Imprime textos
Console.WriteLine($"Resumen de pagos del trabajador {nombre}:\n");
Console.WriteLine($"Horas trabajadas {horas} de las cuales {hextra} son extra, se asume una tasa de impuesto de {tasa:p2}"); //p2 convierte a porcentaje
Console.WriteLine($"Paga bruta: {pagabruta,12:c2}"); //c2 convierte a pesos
Console.WriteLine($"Impuessto: {impuesto,12:c2}");
Console.WriteLine($"Paga neta: {paganeta,12:c2}");
