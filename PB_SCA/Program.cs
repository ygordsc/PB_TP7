using PB_SCA.Models;

namespace PB_SCA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Disciplina d1 = new Disciplina("Java", 527);

            Professor p1 = new Professor("LP", 4321);

            Turma t1 = new Turma(987, p1);
            t1.addAluno(new Aluno("Ygor", 1234));
            t1.addAluno(new Aluno("João", 5678));
            t1.addAluno(new Aluno("Ana", 9012));
            t1.addAluno(new Aluno("Joaquim", 3456));
            t1.addAluno(new Aluno("Maria", 7890));
            t1.addAluno(new Aluno("Lucas", 2345));
            t1.addAluno(new Aluno("Pedro", 0123));
            t1.addAluno(new Aluno("Julia", 4567));
            t1.addAluno(new Aluno("Marcos", 6789));
            t1.addAluno(new Aluno("Beatriz", 8901));

            t1.abrirTurma(d1);
            Console.WriteLine(t1.gerarPauta());

            t1.addAluno(new Aluno("José", 098));
            
        }
    }
}
