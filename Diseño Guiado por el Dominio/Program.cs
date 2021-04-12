using System;

namespace Diseño_Guiado_por_el_Dominio
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Asalariado elDirector;
            Director usuarioDirector = new Director(2500, "Cada 5 del mes", "Roberto", "Gomez", 50);
            elDirector = usuarioDirector;

            Profesor usuarioProfe = new Profesor(2000,"Cada 2 del mes","Pepe", "Alonso",27,"Lenguaje");
            Asalariado elProfe;
            elProfe = usuarioProfe;

            Estudiante elEstudiante = new Estudiante("Roberto", "Bellido", 15);

            Curso elCurso = new Curso(TypeNivel.Primaria, TypeGrado.Sexto, TypeParalelo.B);

            Inscripcion laInscripcion = new Inscripcion(elEstudiante, elCurso);

            //elProfe.MostrarSalario();


            // usuarioDirector.MostrarSalario();
            Colegio elCole = new Colegio();
            elCole.RegistrarDirector(elDirector);
            elCole.RegistrarProfesor(elProfe);
            elCole.RegistrarEstudiante(elEstudiante);
            elCole.RegistrarInscripcion(laInscripcion);

            elCole.MostrarEstadoDelColegio();


        }
    }
}
