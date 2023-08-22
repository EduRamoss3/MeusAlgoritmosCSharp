using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Path.Entities;

namespace Path
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Eduardo\source\asd.txt";
            try
            {
                using (StreamReader streamReader = File.OpenText(path))
                {
                    List<Funcionario>  list = new List<Funcionario>();
                    while(!streamReader.EndOfStream)
                    {
                        list.Add(new Funcionario(streamReader.ReadLine()));
                    }
                    list.Sort();
                    foreach(Funcionario func in list)
                    {
                        Console.WriteLine(func.ToString());
                    }
                }

            }
            catch (IOException E )
            {
                Console.WriteLine(E.Message);
         
            }
            Console.ReadKey();
        }
    }
}
