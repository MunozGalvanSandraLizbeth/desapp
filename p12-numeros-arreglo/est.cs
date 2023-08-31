// Bibliote de funciones para un arreglo

public static class est{
    public static void MostrarElementos(float[] arr)
        {
            Console.WriteLine("Elementos del arreglo:");
            foreach (var num in arr)
            {
                Console.Write($"{num} ");
            }
            Console.WriteLine();
        }

    public static float CalcularSuma(float[] arr)
        {
            float suma = 0;
            foreach (var num in arr)
            {
                suma += num;
            }
            return suma;
        }

        public static float CalcularSumaDiv(float[] arr)
        {
            float suma = 0;
            foreach (var num in arr)
            {
                suma += num / 2;
            }
            return suma;
        }
        

        public static void Inverso(float[] arr)
        {
            Console.WriteLine("Arreglo en orden inverso:");
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();
        }
}