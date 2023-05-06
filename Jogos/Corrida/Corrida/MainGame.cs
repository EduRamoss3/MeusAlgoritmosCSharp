using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corrida
{
    internal class MainGame
    {
        public bool mapaFinalizado;
        public void IniciarJogo(string[,] mapa)
        {
            for(int i = 0; i < 2; i ++) {
               
                for(int j = 0; j < 10; j ++)
                {
                    mapa[i, j] = "-  _  - ";

                }

            }  
        }
        public void AdicionarCarros(string[,] mapa)

        {
            Console.ForegroundColor = ConsoleColor.Red;
          mapa[0, 0] = "o-^õ";
            Console.ResetColor();

            Console.ForegroundColor= ConsoleColor.Blue;
            mapa[1, 0] = "o-^õ";
            Console.ResetColor();
      
            Console.Beep(37, 2007);
         

        }
        public void Jogada(string[,] mapa , string tecla)
        {
            int number = 1;
            for(int i = 0; i < 10; i++)
            {
                if (tecla == "d" && mapa[0, 0] == "o-^õ")
                {
                    mapa[0, 0] = "-  _  - ";
                    mapa[0, 1] = "o-^õ";
                    number++;
                    MostrarJogo(mapa);
                    
                }
                if(tecla == "a" && mapa[0,number] == "-  _  - ")
                {
                    mapa[0, number] = "o-^õ";
                    number--;
                }
            }
            mapaFinalizado = true;
            

        }
        public void MostrarJogo(string[,] mapa)
        {
            
            for (int i = 0; i < 2; i++)
            {


                for (int j = 0; j < 10; j++)
                {
                   
                    Console.Write(mapa[i, j]);
                  
                }

                Console.WriteLine("\n");
            }
           
            
        }
    }
}
