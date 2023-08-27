using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerxc.Entities
{
    internal class Instructor
    {
        public string InstructorName { get; set; }
        public List<Courses> _Courses = new List<Courses>();
        public Instructor()
        {

        }
        public Instructor(string instructorName, List<Courses> courses)
        {
            InstructorName = instructorName;
            _Courses = courses;
        }

        public int TotalStudents(Courses course)  //Total de estudantes em um curso especifico
        {
            int Students = 0;
            if (_Courses.Contains(course))
            {
                Students = course._User.Count();
            }
            return Students;
        }
        public int TotalStAll()
        {

            int Students = 0;
            foreach (Courses course in _Courses) // Total de estudantes em todos os cursos
            {
               if(course._User != null)
                {
                    Students++;
                }
            }
            return Students;
        }
        public string[] SeeUser(Courses course)  // Usuarios em um curso especifico
        {
            string[] users = new string[course._User.Count()];
            for (int i = 0; i < users.Length; i++)
            {
                users[i] = course._User.ToString();
            }
            return users;
        }

    }
}
