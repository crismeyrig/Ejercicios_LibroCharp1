using System;
using Ejercicios_LibroCharp1;
//using Ejercicios_LibroCharp1.Tarea5;


namespace Ejercicios_LibroCharp1
{
    class Program
    {
        static void Main(string[] args)
        {
             int menu = 0;
            Ejer3cap8 ejer3Cap8 = new Ejer3cap8();
            Ejer5cap8 ejer5Cap8 = new Ejer5cap8();
            Ejercicio134Cap9 ejercicio134Cap9 = new Ejercicio134Cap9();
            Ejercicio1Cap10 ejercicio1Cap10 = new Ejercicio1Cap10();
            Ejercicio2Cap10 ejercicio2Cap10 = new Ejercicio2Cap10();
            Ejercicio3Cap10 ejercicio3Cap10 = new Ejercicio3Cap10();

            while(menu != 6)
            {
            Console.WriteLine("1-Ejercicio 3 cap 8");
            Console.WriteLine("2-Ejercicio 1,3,4 cap 9");
            Console.WriteLine("3-Ejercicio 5 cap 8");
            Console.WriteLine("4-Ejercicio 1 cap 10");
            Console.WriteLine("5-Ejercicio 2 cap 10");
            Console.WriteLine("6-Ejercicio 3 cap 10");
            
            
            Console.WriteLine("15-Salir");
            Console.WriteLine("Elija una opción: ");
            
            menu = Convert.ToInt32(Console.ReadLine());
          
            switch(menu)
            {
             case 1:
             Ejer3cap8 ejer1 =new Ejer3cap8();
             ejer1.EjercicioDia();

            break;

            case 2:
             Ejercicio134Cap9 ejer2 =new Ejercicio134Cap9();
             ejer2.Ejercicio134Cap9();

            break;
            
            case 3:
             Ejer5cap8 ejer3 =new Ejer5cap8();
             ejer3.Ordenar();

            break;

             case 4:
             Ejercicio1Cap10 ejercicio1Cap10 =new Ejercicio1Cap10();
             ejercicio1Cap10.InventarioTienda();

             break;

             case 5:
             Ejercicio2Cap10 ejercicio2Cap10 =new Ejercicio2Cap10();
             ejercicio2Cap10.Estudiante();

            break;

            case 6:
             Ejercicio3Cap10 ejercicio3Cap10 =new Ejercicio3Cap10();
             ejercicio3Cap10.Poligono();

            break;
                
        
             default: 
             Console.WriteLine("Error, no existe:");
            break;

            }
        }
    }
    
    }
}
