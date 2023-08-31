// Dado el radio de un círculo, calcula el volumen de la esfera

double r, v, PI = 3.1416;

Console.Clear();
Console.WriteLine("Dame el valor del radio del circulo: "); r = double.Parse(Console.ReadLine());

v = 1.33 * PI * (r * r * r); // Me di cuenta que poner directamente 4/3 no daba el resultado que se esperaba, por lo que puse 1.33 

Console.WriteLine($"El volumen del circulo es: {v:f2}");
