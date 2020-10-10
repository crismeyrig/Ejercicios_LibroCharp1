using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class Ejercicio1Cap7
    {
        public void arraylist()
    {
    int[] nota = new int[15];
    int N, max = nota[0], min = nota[0];
    for(int i = 0; i < 15; i++)
    {
        Console.Write("Dame la nota: ");
        N = int.Parse(Console.ReadLine());
        nota[i] = N;
    }

    Console.Write("\n\nLa nota maxima del salon  es: " + nota.Max());
    Console.Write("\n\nLa nota minima del  salon  es: " + nota.Min());

    Console.ReadKey();
}
}
