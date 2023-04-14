using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treino
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> B = new List<string> { "ANTA", "BOLI" };

            B.Add ("A");
            B.Add("Bos");
            B.Add("Nova");
            B.Add("OBBelisco");
            B.Add("Obres");
            B.Insert(3, "Out");
            B.Add("Out1");
            Console.WriteLine("------------------------------------------");
            foreach (string P in B)
            {
                Console.WriteLine(P);
            }
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("List count:"+B.Count());
            Console.WriteLine("------------------------------------------");

            //Achar a primeira ou ultima posição que combine com um predicado(expressao simples)    
            Console.WriteLine("Achar a primeira ou ultima posição que combine com um predicado(expressao simples)");

            string N = B.Find(Teste);
            Console.WriteLine("First A: " + N);

            string N2 = B.Find(h => h[0] == 'B');
            Console.WriteLine("First B: " + N2);

            string N3 = B.FindLast(p => p[0] == 'A');
            Console.WriteLine("Last A: "+N3);
            Console.WriteLine("------------------------------------------");

            //Achar o primeiro Index
            Console.WriteLine("Achar o primeiro Index");

            int pos1 = B.FindIndex(x => x[0] == 'A');
            Console.WriteLine("First index: " + pos1);
            int po2 = B.FindLastIndex(Indexx);
            Console.WriteLine("Last index: " + po2);
            Console.WriteLine("------------------------------------------");

            Console.WriteLine("------------------------------------------");
           // Achar a qual posição do primeiro index contém a primeira letra como B:
            Console.WriteLine("Achar a qual posição do primeiro index contém a primeira letra como B:");
            string ou = B.Find(x => x[0] == 'B');
            int ou1 = B.FindIndex(x => x[0] == 'B');
            Console.WriteLine("Index nome: " + ou +" Posição: "+ ou1);

            Console.WriteLine("------------------------------------------");
            // Achar todos que começam com a letra B:
            Console.WriteLine("Achar todos que começam com a letra B:");
            List<string> list2 = B.FindAll(x => x[0] == 'B');

            foreach(string obj in list2)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("------------------------------------------");
            //Achar todos que tenham tamanho  de 5 letras:
            Console.WriteLine("Achar todos que tenham tamanho  de 5 letras:");
            List<string> list3 = B.FindAll(x => x.Length == 5);
            foreach(string obj in list3)
            {
                Console.WriteLine("Objeto com tamanho 5: "+obj);
            }
            Console.WriteLine("------------------------------------------");

            //Remover 2 elementos a partir da posição 3:
            Console.WriteLine("Remover 2 elementos a partir da posição 3:");
            B.RemoveRange(3, 2);
            foreach(string obj in B)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("------------------------------------------");
            B.RemoveAt(0);
            B.Remove("Obres");
        }
        public static bool Teste(string N)
        {
            return N[0] == 'A';
        }
        public static bool Indexx(string O)
        {
            return O[0] == 'O';
        }
    }
}
