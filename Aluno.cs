using System;
namespace ExercicioClasses3
{
    class Aluno
    {
        public float Nota1;
        public float Nota2;
        public float Nota3;
        public string Nome;
        

        public float NotaFinal()
        {
            return Nota1 + Nota2 + Nota3;
        }

        public override string ToString()
        {
            return NotaFinal().ToString();
        }
        

    }
}
