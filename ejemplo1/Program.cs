using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variables
            //int floar bool char
            //doublem, decimal, long, short, string datetime
            int a, b, c;
#pragma warning disable CS0168 // La variable está declarada pero nunca se usa
#pragma warning disable CS0168 // La variable está declarada pero nunca se usa
            float d, f;
#pragma warning restore CS0168 // La variable está declarada pero nunca se usa
#pragma warning restore CS0168 // La variable está declarada pero nunca se usa
            Console.WriteLine("Hola Como va?");
            Console.WriteLine("Ingrese un numero");
            a = int.Parse(Console.ReadLine());
            b = 10; c = a + b;
            
            Console.WriteLine("El resultado es: " + c);
            Console.ReadKey();
        }
    }
}
