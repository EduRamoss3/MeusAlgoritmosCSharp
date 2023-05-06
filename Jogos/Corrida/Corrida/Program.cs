using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corrida
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] mapa = new string[2, 10];

            MainGame NovoJogo = new MainGame();
            //Entrada do jogo
            Console.SetWindowSize(100, 10);
            Console.Beep(37, 3237);
            NovoJogo.IniciarJogo(mapa);
            NovoJogo.AdicionarCarros(mapa);
            NovoJogo.MostrarJogo(mapa);
            Console.WriteLine("Utilize W- S- A- D- para movimentar seu carro, e em seguida, tecle enter");
            string tecla = Console.ReadLine();
           for(int i = 0;  i < 10; i++)
            {
                tecla = Console.ReadLine();
                NovoJogo.Jogada(mapa, tecla);

            }


            NovoJogo.MostrarJogo(mapa);
            



            Console.ReadKey();
        }
    }
}
