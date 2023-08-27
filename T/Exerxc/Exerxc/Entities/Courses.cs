using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerxc.Entities
{
    internal class Courses
    {
        public string NameCourse { get; set; }

        public HashSet<User> _User = new HashSet<User>();
        public override string ToString()
        {
            return "|Curse| " + NameCourse;
        }

    }
}
