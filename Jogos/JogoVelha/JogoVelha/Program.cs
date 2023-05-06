using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace JogoVelha
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string[,] Velha = new string[,]{
            {"-","-","-",},
            {"-","-","-",},
            {"-","-","-",},
                          };
            Console.Title = "\t\t\t\tJogo da Velha";
            MainGame X = new MainGame();
            Player1 player1 = new Player1();
            Player2 player2 = new Player2();
            Console.SetWindowSize(70, 20);
            Console.SetCursorPosition(1, 3);
            

            Console.Beep();
            Console.WriteLine("\t\t\t Jogo da Velha");

            X.MostrarJogo(Velha);
            Console.WriteLine();
            X.NovoJogo(player1, player2, Velha);
            Console.WriteLine(" 1- NOVA PARTIDA , 2 - SAIR");
            int num = int.Parse(Console.ReadLine());
            while (num == 1)
            {
                switch (num)
                {

                    case 1:
                        {
                            MainGame Y = new MainGame();
                            Player1 playerX = new Player1();
                            Player2 playerO = new Player2();
                            Y.NovoJogo(playerX, playerO, Velha);
                            Console.WriteLine("\n 1- NOVA PARTIDA , 2 - SAIR");
                            break;
                        }
                    case 2:
                        {
                            Console.Clear();
                            break;
                        }
                }
            }
        }
    }
}










