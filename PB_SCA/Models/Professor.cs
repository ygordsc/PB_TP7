using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PB_SCA.Models
{
    internal class Professor
    {
        public string NomeProfessor { get; set; }
        public int MatriculaProfessor { get; set; }

        public Professor(string n, int m) 
        {
            NomeProfessor = n;
            MatriculaProfessor = m;
        }
    }
}
