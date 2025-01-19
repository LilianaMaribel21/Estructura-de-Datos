// Ejercicio 1: Almacenar y mostrar asignaturas de un curso

using System;
using System.Collections.Generic;

class Program

{
    static void Main()
    {
        // Crea una lista de asignaturas y las inicializa con valores
        List<string> asignaturas = new List<string>
        {
            "Matematicas",
            "Fisica",
            "Quimica",
            "Historia",
            "Lengua"
        };

        // Itera a través de la lista de asignaturas
        foreach (string asignatura in asignaturas)
        {
            Console.WriteLine(asignatura); 
        }
    }
}