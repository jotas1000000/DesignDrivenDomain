using System;
using System.Collections.Generic;
using System.Text;

namespace Diseño_Guiado_por_el_Dominio
{
    class Curso
    {
        TypeNivel nivel;
        TypeGrado grado;
        TypeParalelo paralelo;
        List<string> materias;

        public Curso() { 

        }

        public Curso(TypeNivel nivel, TypeGrado grado, TypeParalelo paralelo) 
        {
            this.materias = new List<string>();
            this.nivel = nivel;
            this.grado = grado;
            this.paralelo = paralelo;
            this.materias.Add("matematicas");
            this.materias.Add("lenguaje");
            this.materias.Add("historia");

        }

        public TypeNivel Nivel { get => nivel; set => nivel = value; }
        public TypeGrado Grado { get => grado; set => grado = value; }
        public TypeParalelo Paralelo { get => paralelo; set => paralelo = value; }

    }
}
