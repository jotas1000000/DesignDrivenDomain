using System;
using System.Collections.Generic;
using System.Text;

namespace Diseño_Guiado_por_el_Dominio
{
    public abstract class Usuario
    {
        public string nombre;
        public string apellido;
        public int edad;

        public virtual void MostrarUsuario()
        {
            //Console.WriteLine("***** Usuario *****");
            Console.WriteLine($"nombre y apellido: {this.nombre} {this.apellido}");
            Console.WriteLine($"edad: {this.edad}");
        }

    }
}
