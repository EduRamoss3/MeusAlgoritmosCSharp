using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoVelha
{
    internal class Player2 : Player1
    {
        public void VerificarVencedor2(string[,] velha)
        {
            //Diagonal
            if (velha[0, 0] == "O" && velha[1, 1] == "O" && velha[2, 2] == "O" && Vencedor == false)
            {
                Vencedor = true;


            }
            if (velha[0, 0] == "O" && velha[0, 1] == "O" && velha[0, 2] == "O" && Vencedor == false)
            {
                Vencedor = true;
            }

            if (velha[1, 0] == "O" && velha[1, 1] == "O" && velha[1, 2] == "O" && Vencedor == false)
            {
                Vencedor = true;
            }
            if (velha[2, 0] == "O" && velha[2, 1] == "O" && velha[2, 2] == "O" && Vencedor == false)
            {
                Vencedor = true;
            }
            //CIMA PRA BAIXO
            if (velha[0, 0] == "O" && velha[1, 0] == "O" && velha[2, 0] == "O" && Vencedor == false)
            {
                Vencedor = true;
            }
            if (velha[0, 1] == "O" && velha[1, 1] == "O" && velha[2, 1] == "O" && Vencedor == false)
            {
                Vencedor = true;
            }
            if (velha[0, 2] == "O" && velha[1, 2] == "O" && velha[2, 2] == "O" && Vencedor == false)
            {
                Vencedor = true;
            }

        }
        public void Jogada2(string[,] velha, int posicaolinha, int posicaocoluna)

        {

            int linha, coluna;
            linha = posicaolinha - 1;
            coluna = posicaocoluna - 1;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {

                    if (velha[linha, coluna] == "-")
                    {

                        velha[linha, coluna] = "O";

                    }

                }
                Console.WriteLine();
            }

        }
    }
}
