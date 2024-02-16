using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10; int b = 12;

            if(a == b)
            {
                //
            }
            else
            {
                //
            }

            switch (a)
            {
                case 0:
                    break; 
                case 1:
                    break;
                default: 
                    break;
            }

            // ciclos
            //for, while, do while
            //++ -- += -=
            //*= /=
            for (int i = 1; i < a; i++)
            {
                Console.WriteLine(i);
            }

            //vectores
            //int, float, char, bool

            int[] numeros = new int[10];
            numeros[0] = 10;
            numeros[5] = 7;

            int j = numeros[5];

            //funciones
            Console.WriteLine(saludar("ana"));
            sumar(2, ref b);

            Console.ReadKey();
        }

        static int sumar(int a, ref int z)
        {
            return a + z;
        }

        static string saludar(string nombre)
        {
            return "hola " + nombre;
        }
    }
}
