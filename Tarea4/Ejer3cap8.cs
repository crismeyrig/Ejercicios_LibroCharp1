using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

   
    public class Ejer3cap8
    {
        public  void EjercicioDia()
        {
             string Hora;
             string Fecha;

            DateTime Hoy = DateTime.Now;
            Hora= Hoy.ToString("hh:mm:ss tt");
            Fecha = Hoy.ToString("dd/MMMM/yyyy");
        }
              
             
    }
