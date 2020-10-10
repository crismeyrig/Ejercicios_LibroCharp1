using System;
using Ejercicios_LibroCharp1.Tarea3;
//using Ejercicios_LibroCharp1.Tarea5;


namespace Ejercicios_LibroCharp1
{
    class Program
    {
        static void Main(string[] args)
        {
             int menu = 0;
            Ejercicios123Cap6 ejercicios123Cap6 = new Ejercicios123Cap6();
            Ejercicio4Cap6 ejercicio4Cap6 = new Ejercicio4Cap6();
            Ejercicio1Cap7 ejercicio1Cap7 = new Ejercicio1Cap7();
            Ejer3cap8 ejer3Cap8 = new Ejer3cap8();
            Ejer5cap8 ejer5Cap8 = new Ejer5cap8();
            Ejercicio134Cap9 ejercicio134Cap9 = new Ejercicio134Cap9();
            Ejercicio1Cap10 ejercicio1Cap10 = new Ejercicio1Cap10();
            Ejercicio2Cap10 ejercicio2Cap10 = new Ejercicio2Cap10();
            Ejercicio3Cap10 ejercicio3Cap10 = new Ejercicio3Cap10();

            while(menu != 9)
            {
            Console.WriteLine("1-Ejercicio 1,2,3 cap 6");
            Console.WriteLine("2-Ejercicio 4 cap 6");
            Console.WriteLine("3-Ejercicio 1 cap 7");
            Console.WriteLine("4-Ejercicio 3 cap 8");
            Console.WriteLine("5-Ejercicio 1,3,4 cap 9");
            Console.WriteLine("6-Ejercicio 5 cap 8");
            Console.WriteLine("7-Ejercicio 1 cap 10");
            Console.WriteLine("8-Ejercicio 2 cap 10");
            Console.WriteLine("9-Ejercicio 3 cap 10");
            
            
            Console.WriteLine("15-Salir");
            Console.WriteLine("Elija una opción: ");
            
            menu = Convert.ToInt32(Console.ReadLine());
          
            switch(menu)
            {
            case 1:
             ejercicios123Cap6.calificación();

            break;

            case 2:
             ejercicio4Cap6.EscuelaFunciones();

            break;

            case 3:
             ejercicio1Cap7.arraylist();

            break;
            

             case 4:

             ejer3Cap8.EjercicioDia();

            break;

            case 5 :
          
              Console.WriteLine("Creando una estructura");

            break;
            
            case 6:
        
             ejer5Cap8.Ordenar();

            break;

             case 7:
           
             Console.WriteLine("Creando clases");

             break;

             case 8:
              Console.WriteLine("Creando clases");

            break;

            case 9:
     
             Console.WriteLine("Creando clases");

            break;
                
        
             default: 
             Console.WriteLine("Error, no existe:");
            break;

            }
        }
    }
    
    }
}
