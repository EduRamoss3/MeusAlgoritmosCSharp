using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprovadoReprovado
{
    internal class Aluno
    {
        public string Nome_Aluno;
        public double Nota1;
        public double Nota2;
        public double Nota3;
        public bool Aprovado;

        public void Resultado()
        {
            double SomaNotas;
            SomaNotas = Nota1 + Nota2 + Nota3;
              if(SomaNotas >= 60)
            {
                Aprovado = true;
                Console.WriteLine("O aluno " + Nome_Aluno + "Foi aprovado!! Nota: " + SomaNotas);
            }
            else
            {
              
                Aprovado = false;
                Console.WriteLine("O aluno " + Nome_Aluno + "Foi reprovado :(, Faltaram"+ ( 60 - SomaNotas) + "pontos");
            }
              
        }
    }
}
