using System;
using System.Collections.Generic;
using System.Text;

namespace Diseño_Guiado_por_el_Dominio
{
    class Profesor:Asalariado
    {
        string asignatura;

        public Profesor(string nombre, string apellido, int edad, string asignatura)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;

            this.asignatura = asignatura;
        }
        public Profesor(int salario, string fechaPagoSalario, string nombre, string apellido, int edad, string asignatura)
            : base(salario, fechaPagoSalario, nombre, apellido, edad)
        {
            this.asignatura = asignatura;
        }
        public override void MostrarSalario()
        {
            Console.WriteLine($"Salario del Profesor {this.nombre} {this.apellido}");
            Console.WriteLine($"Monto Salario: {this.salario}");
            Console.WriteLine($"Fecha de paga: {this.fechaPagoSalario}");
        }

    }
}
