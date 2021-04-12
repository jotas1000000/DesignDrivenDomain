using System;
using System.Collections.Generic;
using System.Text;

namespace Diseño_Guiado_por_el_Dominio
{
    class Colegio
    {
        List<Estudiante> losEstudiantes;
        List<Asalariado> losProfes;
        Asalariado elDirector;

        List<Curso> losCursos;
        List<Inscripcion> lasInscripciones;

        public Colegio() {
            this.losEstudiantes = new List<Estudiante>();
            this.losProfes = new List<Asalariado>();
            this.losCursos = new List<Curso>();
            this.lasInscripciones = new List<Inscripcion>();
        }
        public Colegio(List<Estudiante> losEstudiantes, List<Asalariado> losProfes, Asalariado elDirector, List<Curso> losCursos, List<Inscripcion> lasInscripciones)
        {
            this.losEstudiantes = losEstudiantes;
            this.losProfes = losProfes;
            this.elDirector = elDirector;

            this.losCursos = losCursos;
            this.lasInscripciones = lasInscripciones;
        }

        public void RegistrarEstudiante(Estudiante elEstudiante)
        {
            losEstudiantes.Add(elEstudiante);
        }

        public void RegistrarProfesor(Asalariado elProfesor)
        {
            losProfes.Add(elProfesor);
        }

        public void RegistrarDirector(Asalariado elDirector)
        {
            this.elDirector = elDirector;
        }

        public void RegistrarInscripcion(Inscripcion laInscripcion)
        {
            lasInscripciones.Add(laInscripcion);
        }

        public void MostrarEstudiantes()
        {
            foreach (var estudiante in this.losEstudiantes )
            {
                estudiante.MostrarEstudiante();
            }
        }

        public void MostrarProfesoresYSalario()
        {
            foreach (var profe in this.losProfes)
            {
                profe.MostrarSalario();
            }
        }

        public void MostrarDirectorYSalario()
        {
                elDirector.MostrarSalario();
            
        }

        public void MostrarInscripciones()
        {
            foreach (var inscripcion in this.lasInscripciones)
            {
                inscripcion.MostrarInscripcion();
            }
        }

        public void MostrarEstadoDelColegio()
        {
            Console.WriteLine("************************** Los Estudiantes *******************************");
            MostrarEstudiantes();
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("************************** Los Profesores *******************************");
            MostrarProfesoresYSalario();
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("************************** El Director *******************************");
            MostrarDirectorYSalario();
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("************************** Las Inscripciones *******************************");
            MostrarInscripciones();
            Console.WriteLine("**************************************************************************");
        }


    }
}
