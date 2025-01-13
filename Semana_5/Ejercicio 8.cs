// Ejercicio 8: Verificar si una palabra es un palíndromo.

using System; 
using System.Linq; 

class Program
{
    static void Main()
    {
        Console.Write("Introduce una palabra: "); 
        string palabra = Console.ReadLine(); 
        string inversa = new string(palabra.Reverse().ToArray());

        // Compara la palabra original con su inversa, ignorando mayúsculas y minúsculas
        if (palabra.Equals(inversa, StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("La palabra es un palíndromo."); 
        }
        else
        {
            Console.WriteLine("La palabra no es un palíndromo."); 
        }
    }
}