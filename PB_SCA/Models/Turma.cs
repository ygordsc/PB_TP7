using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PB_SCA.Models;

namespace PB_SCA.Models
{
    internal class Turma
    {
        private const int CapacidadeMaxima = 10;
        private const int CapacidadeMinima = 2;

        private List<Aluno> alunos = new List<Aluno>();
        private bool turmaAberta = false;

        public int CodigoTurma { get; set; }
        public string NomeDisciplinaTurma { get; set; }
        public string NomeProfessor { get; set; }

        public Turma(int c, Professor professor)
        {
            CodigoTurma = c;
            NomeProfessor = professor.NomeProfessor;
            NomeDisciplinaTurma = "";
        }

        public void addAluno(Aluno aluno)
        {
            if (alunos.Count < CapacidadeMaxima)
            {
                alunos.Add(aluno);
                Console.WriteLine("Aluno adicionado\n");
            } 
            else
            {
                Console.WriteLine("Turma cheia\n");
            }
        }

        public bool abrirTurma(Disciplina disciplina)
        {
            if (!turmaAberta && alunos.Count >= CapacidadeMinima)
            {
                turmaAberta = true;
                NomeDisciplinaTurma = disciplina.NomeDisciplina;
                return true;
            }
            else
            {
                return false;
            }
        }

        public string gerarPauta()
        {
            string pauta = $"Código da Turma: {CodigoTurma}\n" +
                       $"Disciplina: {NomeDisciplinaTurma}\n" +
                       $"Professor: {NomeProfessor}\n" +
                       "Alunos Inscritos:\n";

            foreach (var aluno in alunos)
            {
                pauta += $"- {aluno.NomeAluno}\n";
            }

            return pauta;
        }
    }
}
