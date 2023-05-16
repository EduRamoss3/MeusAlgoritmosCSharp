using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contratos_de_funcionarios.Entities
{
    internal class Departmente
    {
        public string Name { get; set; }

        public Departmente()
        {

        }
        public Departmente(string name)
        {
            Name = name;
        }
    }
}
