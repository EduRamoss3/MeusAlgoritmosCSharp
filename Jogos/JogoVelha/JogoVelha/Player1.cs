using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoVelha
{
    internal class Player1
    {
        public bool  Vencedor { get; set; }   

        public void VencedorPlayer(int player)
        {
            if(player == 1)
            {
                Console.WriteLine("Vencedor: Player X");
            }
            else if(player == 2)
            {
                Console.WriteLine("Vencedor: Player O");
            }
        }
        public void VerificarVencedor(string[,] velha)
        {

            if (velha[0, 0] == "X" && velha[1, 1] == "X" && velha[2, 2] == "X" && Vencedor == false)
            {
                Vencedor = true;
                

            }
            if (velha[0,0] == "X" && velha[0,1] == "X" && velha[0,2] == "X" && Vencedor == false)
            {
                Vencedor = true;
            }
            
            if (velha[1, 0] == "X" && velha[1, 1] == "X" && velha[1, 2] == "X" && Vencedor == false)
            {
                Vencedor = true;
            }
            if (velha[2, 0] == "X" && velha[2, 1] == "X" && velha[2, 2] == "X" && Vencedor == false)
            {
                Vencedor = true;
            }
            //CIMA PRA BAIXO
            if (velha[0, 0] == "X" && velha[1, 0] == "X" && velha[2, 0] == "X" && Vencedor == false)
            {
                Vencedor = true;
            }
            if (velha[0, 1] == "X" && velha[1, 1] == "X" && velha[2, 1] == "X" && Vencedor == false)
            {
                Vencedor = true;
            }
            if (velha[0, 2] == "X" && velha[1, 2] == "X" && velha[2, 2] == "X" && Vencedor == false)
            {
                Vencedor = true;
            }







        }
        public void Jogada(string[,] velha, int posicaolinha, int posicaocoluna)

        {
            int linha, coluna;
            linha = posicaolinha - 1;
            coluna = posicaocoluna - 1;
            
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {

           // Preenchendo jogada
                    if (velha[linha,coluna] == "-")
                    {
                        
                        velha[linha, coluna] = "X";
                        
                    }

                }
                
            }
        }
    }
}
