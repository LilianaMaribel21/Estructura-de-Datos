// Ejercicio 6: Eliminar asignaturas aprobadas

using System; 
using System.Collections.Generic; 

class Program
{
    static void Main()
    {
        // Lista con las asignaturas iniciales
        List<string> asignaturas = new List<string>
        {
            "Matematicas",
            "Fisica",
            "Quimica",
            "Historia",
            "Lengua"
        };

        // Diccionario para almacenar las notas de las asignaturas
        Dictionary<string, double> notas = new Dictionary<string, double>();

        // Solicita y almacena la nota para cada asignatura
        foreach (string asignatura in asignaturas)
        {
            Console.Write($"Introduce la nota de {asignatura}: "); 
            double nota = Convert.ToDouble(Console.ReadLine()); 
            notas[asignatura] = nota; 
        }

        // Elimina las asignaturas con una nota mayor o igual a 5
        asignaturas.RemoveAll(asignatura => notas[asignatura] >= 5);

        Console.WriteLine("Debes repetir las siguientes asignaturas:");
        // Muestra las asignaturas restantes (reprobadas)
        foreach (string asignatura in asignaturas)
        {
            Console.WriteLine(asignatura); 
        }
    }
}