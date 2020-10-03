using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

   
    public class Ejer5cap8
    {
        public  void Ordenar()
        {
              string Cadena1 ="Crismeyri";
              string Cadena2="Gael";
              string Ordenado;


            string cadena = Cadena1 + Cadena2; 
            string ordenado = new String(cadena.OrderBy(z => z).ToArray());
            Ordenado = Convert.ToString(ordenado);
        }
             
    }
  