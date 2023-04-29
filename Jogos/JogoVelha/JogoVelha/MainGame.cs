
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoVelha
{
    internal class MainGame
    {
        int PontosX = 0;
        int PontosO = 0;
        public void MostrarJogo(string[,] velha)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            for (int i = 0; i < 3; i++)
            {

                for (int j = 0; j < 3; j++)
                {
                    Console.Write("                " + velha[i, j]);
                }
                Console.WriteLine();
            }

            Console.ResetColor();

        }


        public void NovoJogo(Player1 player1, Player2 player2, string[,] velha)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    velha[i, j] = "-";
                }
            }
            while (player1.Vencedor == false)
            {



                if (player1.Vencedor == false)
                {
                    Console.Beep();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Player X, Faça sua jogada! Escolha:");
                    Console.Write("Linha: ");
                    int posicaoLinha = int.Parse(Console.ReadLine());
                    Console.Write("Coluna: ");
                    int posicaoColuna = int.Parse(Console.ReadLine());
                    player1.Jogada(velha, posicaoLinha, posicaoColuna);
                    MostrarJogo(velha);
                    player1.VerificarVencedor(velha);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    //------------------------------------------------------------------------
                    if (player1.Vencedor == true)
                    {
                        Console.WriteLine("\t\t\tFIM DE JOGO.\n");
                        player1.VencedorPlayer(1);
                        PontosX++;
                        Console.WriteLine("Jogador O: " + PontosO + " pontos");
                        Console.WriteLine("Jogador X: " + PontosX + " pontos");
                    }

                    else
                    {
                        Console.Beep();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Player O, Faça sua jogada! Escolha:");
                        Console.Write("Linha: ");
                        int posicaoLinha2 = int.Parse(Console.ReadLine());
                        Console.Write("Coluna: ");
                        int posicaoColuna2 = int.Parse(Console.ReadLine());
                        Console.ResetColor();
                        player2.Jogada2(velha, posicaoLinha2, posicaoColuna2);
                        MostrarJogo(velha);
                        player2.VerificarVencedor2(velha);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        if (player2.Vencedor == true)
                        {
                            Console.WriteLine("\t\t\tFIM DE JOGO.\n");
                            player1.VencedorPlayer(2);
                            PontosO++;
                            Console.WriteLine("Jogador O: " + PontosO + " pontos");
                            Console.WriteLine("Jogador X: " + PontosX + " pontos");

                        }
                        Console.ResetColor();
                    }


                }

            }
        }
    }
}
