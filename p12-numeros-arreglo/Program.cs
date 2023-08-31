// Programa práctica de arreglos

float[] arreglo = { 100, 123, 456, 222, 999, 895, 325, 234, 322, 988 };
float suma, sumadiv;

// Mostrar los elementos del arreglo    
est.MostrarElementos(arreglo);

// Calcular y mostrar la suma de los elementos originales
suma = est.CalcularSuma(arreglo);
Console.WriteLine($"\nLa suma de los elemtos es: {suma}");

// Calcular y mostrar la suma de la mitad de los elementos
sumadiv = est.CalcularSumaDiv(arreglo);
Console.WriteLine($"\nLa suma de los elemtos divididos entre 2 es: {sumadiv}");

// Mostrar el arreglo en orden inverso
est.Inverso(arreglo);