using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

        //Crear el diseño de una clase para llevar el inventario de una tienda
        public class Ejercicio1Cap10
        {
            private int ID { get; set; }
            private string nombre { get; set; }
            private double precio { get; set; }
            private double costo { get; set; }
            private double cantidad { get; set; }


            public Ejercicio1Cap10()
            {
                ID = 0;
                precio = 0;
                costo = 0;
                cantidad = 0;
            }


            public Ejercicio1Cap10(int id, string nombre, double costo, double precio, double cantidad)
            {
                this.ID = id;
                this.nombre = nombre;
                this.costo = costo;
                this.precio = precio;
                this.cantidad = cantidad;
            }
        }
    
