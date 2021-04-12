using System;
using System.Collections.Generic;
using System.Text;

namespace Diseño_Guiado_por_el_Dominio
{
    class Estudiante:Usuario
    {
        public Estudiante(string nombre, string apellido, int edad)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
        }

        public void MostrarEstudiante()
        {
            Console.WriteLine("***** Estudiante *****");
            Console.WriteLine($"nombre y apellido: {this.nombre} {this.apellido}");
            Console.WriteLine($"edad: {this.edad}");
        }
    }
}
