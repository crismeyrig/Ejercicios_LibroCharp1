using System;
using Ejercicios_LibroCharp1;

//main
namespace Ejercicios_LibroCharp1.Tarea4
{
    class Program
    {
        static void Main(string[] args)
        {
            int opc=1;
            switch(opc){
             case 1:
             Ejer3cap8 ejer1 =new Ejer3cap8();
             ejer1.EjercicioDia();

            break;

            case 2:
             Ejer3cap9 ejer2 =new Ejer3cap9();
             ejer2.Estructura();

            break;
            
            case 3:
             Ejer5cap8 ejer3 =new Ejer5cap8();
             ejer3.Ordenar();

            break;
                
        
             default: 
             Console.WriteLine("Error, no existe:");
            break;

            }
        }
    }
}
