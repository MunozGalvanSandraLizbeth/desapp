// Calcular la distancia entre dos puntos, dadas las coodenadas del punto A y el punto B

double d = 0, ax, ay, bx, by;

Console.Clear();
Console.WriteLine("Dame el valor de ax: "); ax = double.Parse(Console.ReadLine());
Console.WriteLine("Dame el valor de bx: "); bx = double.Parse(Console.ReadLine());
Console.WriteLine("Dame el valor de ay: "); ay = double.Parse(Console.ReadLine());
Console.WriteLine("Dame el valor de by: "); by = double.Parse(Console.ReadLine());

d = Math.Sqrt(((ax - bx) * (ax - bx)) + ((ay - by) * (ay - by)));

Console.WriteLine($"La distancia entre ax = {ax:f2}, ay = {ay:f2} y bx = {bx:f2}, by = {by:f2} es: {d:f2} \n");
