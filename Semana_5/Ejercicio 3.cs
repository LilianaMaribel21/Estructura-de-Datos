// Ejercicio 3: Notas de asignaturas

using System; 
using System.Collections.Generic; 

class Program
{
    static void Main()
    {
        // Crea una lista con las asignaturas
        List<string> asignaturas = new List<string>
        {
            "Matematicas",
            "Fisica",
            "Quimica",
            "Historia",
            "Lengua"
        };

        // Crea un diccionario para almacenar las notas de cada asignatura
        Dictionary<string, double> notas = new Dictionary<string, double>();

        // Itera sobre cada asignatura de la lista
        foreach (string asignatura in asignaturas)
        {
            Console.Write($"Introduce la nota de {asignatura}: "); 
            double nota = Convert.ToDouble(Console.ReadLine()); 
            notas[asignatura] = nota; 
        }

        // Itera sobre el diccionario para mostrar los resultados
        foreach (var item in notas)
        {
            Console.WriteLine($"En {item.Key} has sacado {item.Value}"); 
        }
    }
}