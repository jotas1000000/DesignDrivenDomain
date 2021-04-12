using System;
using System.Collections.Generic;
using System.Text;

namespace Diseño_Guiado_por_el_Dominio
{
    class Director:Asalariado
    {
  
        public Director(string nombre, string apellido, int edad)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
        }
        public Director(int salario, string fechaPagoSalario, string nombre, string apellido, int edad)
            :base(salario, fechaPagoSalario, nombre, apellido, edad)
        {

        }
        public void AdminstrarColegio()
        {
            Console.WriteLine("Administrando Colegio...");
        }

        public override void MostrarSalario()
        {
            Console.WriteLine($"Salario del Director {this.nombre} {this.apellido}");
            Console.WriteLine($"Monto Salario: {this.salario}");
            Console.WriteLine($"Fecha: {this.fechaPagoSalario}");
        }
    }
}
