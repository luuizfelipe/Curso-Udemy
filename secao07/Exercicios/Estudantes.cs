﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace secao07.Exercicios
{
    internal class Estudantes
    {
        public string Name { get; set; }
        public string Email { get; set; } 


        public Estudantes(string name, string email)
        {
            Name = name;
            Email = email;
        }

        public override string ToString()
        {
            return Name + " " + Email;
        }
    }
}
