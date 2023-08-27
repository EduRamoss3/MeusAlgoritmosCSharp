using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Eduardo\source\asd.txt";
            try
            {
                Dictionary<string, int> keyValues = new Dictionary<string, int>();
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] lines = sr.ReadLine().Split(',');
                        string Name = lines[0];
                        int Value = int.Parse(lines[1]);
                        if (keyValues.ContainsKey(Name))
                        {
                            keyValues[Name] += Value;    
                        }
                        else
                        {
                            keyValues.Add(Name, Value);
                        }
                    }
                }

                foreach (var item in keyValues)
                {
                    Console.WriteLine(item.Key + ": " + item.Value);
                }
                Console.ReadKey();

            }
            catch(IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
