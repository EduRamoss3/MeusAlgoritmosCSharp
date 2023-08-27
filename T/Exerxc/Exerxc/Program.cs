using Exerxc.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerxc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Courses> courses = new List<Courses>();
            
            Courses A = new Courses();
            Courses B = new Courses();
            Courses C = new Courses();

            Console.WriteLine("How many students for course A?");

            int Anumber = int.Parse(Console.ReadLine());
            for (int i = 0; i < Anumber; i++)
            {
                int Id = int.Parse(Console.ReadLine());
                User user = new User(Id);
                A._User.Add(user);
            }

            courses.Add(A);

            Console.WriteLine("How many students for course B?");
            int Bnumber = int.Parse(Console.ReadLine());
            for (int i = 0; i < Bnumber; i++)
            {
                int Id = int.Parse(Console.ReadLine());
                User user = new User(Id);
                B._User.Add(user);
            }
            courses.Add(B);


            Console.WriteLine("How many students for course C?");
            int Cnumber = int.Parse(Console.ReadLine());
            for (int i = 0; i < Cnumber; i++)
            {
                int Id = int.Parse(Console.ReadLine());
                User user = new User(Id);
                C._User.Add(user);
            }

            courses.Add(C);
            HashSet<User> all = new HashSet<User>(A._User);
            all.UnionWith(B._User);
            all.UnionWith(C._User);

            Console.Write("Total students: " + all.Count);
            Console.ReadKey();
        }
    }
}
