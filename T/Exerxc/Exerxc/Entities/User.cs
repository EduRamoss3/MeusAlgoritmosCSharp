using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Exerxc.Entities
{
    internal class User
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public User(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public User(int id)
        {
            Id = id;
            
        }
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            if(!(obj is User)) return false;
            User other = obj as User;
            return Id.Equals(other.Id);
        }
        public override string ToString()
        {
            return  "|Id|" + Id;
        }

    }
}
