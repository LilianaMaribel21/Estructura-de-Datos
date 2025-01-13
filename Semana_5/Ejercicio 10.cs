// Ejercicio 10: Encontrar el menor y mayor de una lista de precios

using System; 
using System.Linq; 

class Program
{
    static void Main()
    {
        // Crea un arreglo de precios
        double[] precios = { 20, 78, 46, 12, 90, 65, 19 };

        // Encuentra el menor precio usando LINQ
        double menor = precios.Min();
        // Encuentra el mayor precio usando LINQ
        double mayor = precios.Max();

        Console.WriteLine($"El menor precio es: {menor}"); 
        Console.WriteLine($"El mayor precio es: {mayor}"); 
    }
}
