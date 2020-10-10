using System;
using System.Collections.Generic;
using System.Text;


    class Ejercicio2Cap10
    {
        //Crear una clase para llevar la información de los estudiantes de una escuela
        class Estudiante
        {
            private int id { get; set; }
            private string nombre { get; set; }
            private string apellidos { get; set; }
            private string matricula { get; set; }
            private string cedula { get; set; }
            private string direccion { get; set; }
            private string carrera { get; set; }
            private string tetlefono { get; set; }


            public Estudiante()
            {
                id = 0;
            }


            public Estudiante(int id, string nombre, string apellidos, string matricula, string cedula, string direccion, string carrera, string telefono)
            {
                this.id = id;
                this.nombre = nombre;
                this.apellidos = apellidos;
                this.matricula = matricula;
                this.cedula = cedula;
                this.direccion = direccion;
                this.carrera = carrera;
                this.tetlefono = tetlefono;


            }
        }
    }
