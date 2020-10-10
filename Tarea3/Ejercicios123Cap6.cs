using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_LibroCharp1.Tarea3 {
public class Ejercicios123Cap6
{
    // Esta es la función principal del programa Aquí inicia la aplicacion
public void calificación()
{
 // Variables necesarias
    int cantidad=0; // Cantidad de alumnos int salones=0; // Cantidad de salones
    int n=0; // Variable de control de ciclo salones
    int m=0; // Variable de control del ciclo alumnos
    string valor= "";
    int salones = 0;

    // Variables para el promedio 
    float suma=0.0f;
    float promedio=0.0f;
    float minima=10.0f;   //Variable para la calificación mínima

    float maxima =0.0f;    //Variable para la calificación  maxima


// Pedimos la cantidad de salones 

Console.WriteLine("Dame la cantidad de salones"); 
valor=Console.ReadLine();
salones = Convert.ToInt32(valor);

// Creamos el arreglo

float[][] calif= new float [salones][];
// Pedimos los alumnos por salon 

for(n=0;n <salones; n++) // Ciclo salones
 {
    Console.WriteLine("Dame la cantidad de alumnos para el salon {0}",n); 
    valor=Console.ReadLine();
    cantidad=Convert.ToInt32(valor);

// Instanciamos el arreglo

 calif[n]=new float[cantidad];
 }
  // Capturamos la información 
for(n=0; n<salones;n++) // Ciclo salones 
{
Console.WriteLine("Salon {0}",n); 
for(m=0;m<calif[n].GetLength(0);m++) // Ciclo alumnos
{
Console.Write("Dame la calificación");
valor=Console.ReadLine(); calif[n][m]=Convert.ToSingle(valor);
} 
}
// Desplegamos la información 
Console.WriteLine("—— Información ——");
for (n = 0; n< salones; n++) // Ciclo salones
{
Console.WriteLine("Salon {0}", n);
for (m = 0; m < calif[n].GetLength(0); m++) // Ciclo alumnos 
{
Console.WriteLine("El alumno {0} tiene {1} ", m, calif[n][m]);

 
}
 
}
 // calculo del promedio
        for ( n= 0; n< salones; n++ ) // Ciclo salones
        {
            suma =0 ;
            for ( m  =  0 ; m  <  calif [ n ].GetLength ( 0 ); m++ ) // Ciclo alumnos
            {
                suma += calif [ n ] [ m ];
            }
            promedio = suma / calif [ n ].GetLength ( 0 );
            Console.WriteLine ($" El promedio del salón { n + 1 } es { promedio } " );

}

 // calculo de la nota minima
        for (n = 0; n< salones; n++) // Ciclo salones
        {
            minima = calif[n][0];
            for (m = 0; m < calif[n].GetLength(0); m++) //Ciclo alumnos
            {
                if (calif[n][m] < minima)
                    minima = calif[n][m];

            }
            Console.WriteLine($"La nota minima del salon {n + 1} es {minima}");
        }

 // calculo de la nota maxima
        for (n = 0; n< salones; n++) // Ciclo salones
        {
            maxima = calif[n][0];
            for (m = 0; m < calif[n].GetLength(0); m++) //Ciclo alumnos
            {
                if(calif[n][m] > maxima)
                    maxima = calif[n][m];
                
            }
            Console.WriteLine($"La nota minima del salon {n+1} es {maxima}");
        }

}
}
}




