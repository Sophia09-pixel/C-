using System;
using System.Collections.Generic;
using System.Text;

namespace Resolvendo2
{
    class Estudante
    {
        private string email;

        public string Name { get; set; }
        public string Email { get; set; }

        public Estudante(string name, string email)
        {
            Name = name;
            Email = email;
        }

        public override string ToString()
        {
            return Name + ", " + Email;
        }

    }

}
