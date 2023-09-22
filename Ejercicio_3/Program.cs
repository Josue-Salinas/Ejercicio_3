using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el número de notas: ");
            int nro_notas = int.Parse(Console.ReadLine());
            float suma_notas = 0f;
            for (int i = 1; i <= nro_notas; i++)
            {
                Console.Write("Ingrese la nota " + i + ":");
                float nota = float.Parse(Console.ReadLine());
                suma_notas += nota;
            }
            float promedio = suma_notas / nro_notas;
            Console.WriteLine("El promedio es " + promedio);
            Console.ReadKey();
        }
    }
}
