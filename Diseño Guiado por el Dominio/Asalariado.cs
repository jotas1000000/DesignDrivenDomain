using System;
using System.Collections.Generic;
using System.Text;

namespace Diseño_Guiado_por_el_Dominio
{
    public class Asalariado:Usuario
    {
        public int salario;
        public string fechaPagoSalario;



        public Asalariado() { }

        public Asalariado(int salario, string fechaPagoSalario)
        {
            this.salario = salario;
            this.fechaPagoSalario = fechaPagoSalario;
        }

        public Asalariado(int salario, string fechaPagoSalario, string nombre, string apellido, int edad)
        {
            this.salario = salario;
            this.fechaPagoSalario = fechaPagoSalario;

            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
        }

        public virtual void MostrarSalario()
        {
            Console.WriteLine($"Monto Salario: {this.salario}");
            Console.WriteLine($"Fecha: {this.fechaPagoSalario}");
        }
    }
}
