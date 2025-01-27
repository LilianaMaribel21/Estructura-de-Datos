using System;
using System.Collections.Generic;

namespace Utilities
{
    public class Tower
    {
        public Stack<int> Disks { get; private set; }
        public string Name { get; private set; }

        public Tower(string name)
        {
            Disks = new Stack<int>();
            Name = name;
        }

        public void MoveDiskTo(Tower destination)
        {
            int disk = Disks.Pop();
            destination.Disks.Push(disk);
            Console.WriteLine($"Mover disco {disk} de {Name} a {destination.Name}");
        }
    }

    public static class HanoiSolver
    {
        // Resuelve el problema de las Torres de Hanoi de forma recursiva.
        public static void Solve(int n, Tower source, Tower auxiliary, Tower destination)   // "n"Número de discos -"source"Torre de origen - "auxiliary"Torre auxiliar - "destination"Torre de destino.
        {
            if (n == 1)
            {
                source.MoveDiskTo(destination);
                return;
            }

            Solve(n - 1, source, destination, auxiliary);
            source.MoveDiskTo(destination);
            Solve(n - 1, auxiliary, source, destination);
        }
    }
   public static class BalanceChecker
    {
        
        // Comprueba si una expresión matemática se encuentra balanceada en términos de paréntesis, corchetes y llaves.
        // Verdadero si está balanceada, falso si no lo es.
        public static bool IsBalanced(string expression)   // "expression" La expresión matemática que sera verificada.
        {
            Stack<char> stack = new Stack<char>();

            foreach (char c in expression)
            {
                if (c == '(' || c == '{' || c == '[')
                {
                    stack.Push(c);
                }
                else if (c == ')' || c == '}' || c == ']')
                {
                    if (stack.Count == 0) return false;

                    char top = stack.Pop();
                    if ((c == ')' && top != '(') || (c == '}' && top != '{') || (c == ']' && top != '['))
                    {
                        return false;
                    }
                }
            }

            return stack.Count == 0;
        }
    } 
}