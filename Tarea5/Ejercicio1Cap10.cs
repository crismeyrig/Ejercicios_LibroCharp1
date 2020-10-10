using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Ejercicio1Cap10
    {
        //Crear el diseño de una clase para llevar el inventario de una tienda
        public class InventarioTienda
        {
            private int ID { get; set; }
            private string nombre { get; set; }
            private double precio { get; set; }
            private double costo { get; set; }
            private double cantidad { get; set; }


            public InventarioTienda()
            {
                ID = 0;
                precio = 0;
                costo = 0;
                cantidad = 0;
            }


            public InventarioTienda(int id, string nombre, double costo, double precio, double cantidad)
            {
                this.ID = id;
                this.nombre = nombre;
                this.costo = costo;
                this.precio = precio;
                this.cantidad = cantidad;
            }
        }
    }
