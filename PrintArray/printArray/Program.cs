using System;

class Program
{
    public static void Main(string[] args)
    {
        int[] array1 = new int[5] { 13, 53, 55, 7, 19 };

        ImprimirArray(array1, 4);

    }


    public static void ImprimirArray(int[] array, int tamanio)
    {
        for (int i = 0; i < tamanio; i++)
        {
            Console.WriteLine("Array posicion: " + i + " Valor: " + array[i]);
        }
    }
    
}