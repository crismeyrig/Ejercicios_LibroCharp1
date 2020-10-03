using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

   namespace Ejercicios_LibroCharp1.Ejercap3cap8
{
    public class Ejer3cap_8
    {
        public static void Ejercicio()
        {
             string Hora;
             string Fecha;

            DateTime Hoy = DateTime.Now;
            Hora= Hoy.ToString("hh:mm:ss tt");
            Fecha = Hoy.ToString("dd/MMMM/yyyy");
        }
              
             
    }
}