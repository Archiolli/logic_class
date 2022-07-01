using System;
namespace ExercicioClasses3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Aluno x = new Aluno();

            Console.WriteLine("================================================");
            Console.WriteLine("             Digite o nome do aluno");
            Console.WriteLine("================================================");
            x.Nome = Console.ReadLine();
            Console.Clear();
            Console.Write("Digite  as três notas do aluno (1):  ");
            x.Nota1 = float.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Digite  as três notas do aluno (2):  ");
            x.Nota2 = float.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Digite  as três notas do aluno (3):  ");
            x.Nota3 = float.Parse(Console.ReadLine());
            Console.Clear();

            



        }
    }
}