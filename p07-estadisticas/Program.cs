// Calcula las estadisticas de un arreglo de calificaciones

const int MAX = 100;
int n = 0;
double[] califs = null;

double may = 0, men = 0, prom = 0, var = 0, desv = 0;

Console.Clear();
Console.WriteLine("¿Cuántas calificaciones va a registrar? ");
n = int.Parse(Console.ReadLine());

if(n > MAX){
    Console.WriteLine("El máximo de elementos es: {0}", MAX);
    return 1;
}

califs = new double[n];
for(int i = 0; i < califs.Length; i++){
    Console.WriteLine($"calificación[{i}] = ");
    califs[i] = double.Parse(Console.ReadLine());
}

Console.WriteLine($"Los elementos del arreglo son: {est.Imprime(califs)}");

may = est.Mayor(califs);
men = est.Menor(califs);
prom = est.Promedio(califs); 
var = est.Varianza(califs, prom);
desv = Math.Sqrt(var);

Console.WriteLine("\nResumen de estadisticas:");

Console.WriteLine($"Cantidad de calificaciones: {califs.Length}");
Console.WriteLine($"La calificación mayor es: {may:f2}");
Console.WriteLine($"La calificación menor es: {men:f2}");
Console.WriteLine($"El promedio final es: {prom:f2}");
Console.WriteLine($"La varianza es: {var:f2}");
Console.WriteLine($"La desviación es: {desv:f2}");

return 0;

