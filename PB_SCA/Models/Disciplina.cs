using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PB_SCA.Models
{
    internal class Disciplina
    {
        public string NomeDisciplina { get; set; }
        public int IdDisciplina { get; set; }

        public Disciplina(string n, int i)
        {
            NomeDisciplina = n;
            IdDisciplina = i;    
        }
    }
}
