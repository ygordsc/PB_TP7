using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PB_SCA.Models
{
    internal class Aluno
    {
        public string NomeAluno { get; set; }
        public int MatriculaAluno { get; set; }

        public Aluno(string n, int m)
        {
            NomeAluno = n;
            MatriculaAluno = m;
        }
    }
}
