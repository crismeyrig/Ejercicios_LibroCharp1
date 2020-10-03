using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class Ejer3cap9
    {
        public void Estructura()
        {

        
       enum Neumaticos { Carretera = 1, TodoTerreno, Competicion, Invierno };
        private bool dEdad;

        public struct Tienda
        {
            public string Pruductos;
        }
        public struct Dueno
        {
            public string NombreDueno;
            public int edadDueno;
        }
         public struct Mascota
        {
            public string EspecieMacosta;
            public string NombreMacosta;
            public int edadMascota;
        }
        public void MascotaDueño()
        {
          
            Dueno d = new Dueno();
            Mascota m = new Mascota(); 

            // string dNombre;
       

            d.NombreDueno = dNombre;
            d.edadDueno = Convert.ToInt32(dEdad);
           
            m.EspecieMacosta = mEspecie;
            m.NombreMacosta = mNombre;
            m.edadMascota = Convert.ToInt32(mEdad);
        }
             
    }
}