// Emitir una calificación con letra y un mensaje de acuerdo al promedio

string nombre, letra;
double calif;

Console.Clear();
Console.WriteLine("¿Cómo se llama el/la estudiante? "); nombre = Console.ReadLine();

do{
    Console.WriteLine($"¿Qué calificaión tiene el/la estudiante {nombre}? "); calif = double.Parse(Console.ReadLine());
} while (calif < 0 || calif > 10);

if (calif >= 0 && calif <= 5.9) {
    Console.WriteLine($"La calificación de {nombre} es: {calif}\n");
    Console.WriteLine("Andas mal :( échale más ganas");
}
else if (calif >= 6 && calif <= 7.5) {
    Console.WriteLine($"La calificación de {nombre} es: {calif}\n");
    Console.WriteLine("Mucho mejor :)");
}
else if (calif >= 7.6 && calif <= 8.5) {
    Console.WriteLine($"La calificación de {nombre} es: {calif}\n");
    Console.WriteLine("Muy bien :D");
}
else {
    Console.WriteLine($"La calificación de {nombre} es: {calif}\n");
    Console.WriteLine("¡¡¡Excelente!!! :D");
}