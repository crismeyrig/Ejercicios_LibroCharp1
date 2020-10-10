using System;
using System.Collections.Generic;
using System.Text;


namespace Ejercicios_LibroCharp1.Tarea5
{
    class Ejercicio1Cap12
    {

        public static int Factorial(int numero)
        {
            int resul = 1;

            for (int i = numero; i > 1; i--)
                resul *= i;
            return resul;
        }
        public static void factor()
        {
            Inicializar();
        }
        static void Inicializar()
        {
            int numero;
            Console.WriteLine("Ingrese un numero: ");
            numero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("El factorial es {0}", Factorial(numero));
        }
    }

}