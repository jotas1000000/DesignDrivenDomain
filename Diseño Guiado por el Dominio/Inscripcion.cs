using System;
using System.Collections.Generic;
using System.Text;

namespace Diseño_Guiado_por_el_Dominio
{
    class Inscripcion
    {
        Estudiante elEstudiante;
        Curso elCurso;

        public Inscripcion() { }
        public Inscripcion(Estudiante elEstudiante, Curso elCurso)
        {
            this.elEstudiante = elEstudiante;
            this.elCurso = elCurso;
        }

        public void MostrarInscripcion()
        {
            Console.WriteLine("*** Inscripcion ***");
            Console.WriteLine($"Estudiante: {elEstudiante.nombre} {elEstudiante.apellido}");
            Console.WriteLine($"Curso: {elCurso.Grado} de {elCurso.Nivel} Paralelo {elCurso.Paralelo}");
            Console.WriteLine("*******************");
        }
    }
}
