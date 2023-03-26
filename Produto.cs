using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque
{
    internal class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public void AdicionarNovoProduto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;

        }
        public double ValorTotalEmEstoque()
        {

            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
        public override string ToString()
        {
            return "Produto: " + Nome 
                   +" |Preço R$|"+ Preco.ToString("F2",CultureInfo.InvariantCulture)
                   +" |Quantidade:| "+ Quantidade
                   +" |Valor Total em estoque:| "+ValorTotalEmEstoque().ToString("F2",CultureInfo.InvariantCulture);
        }
       public void MostrarOpcoes()
        {
           Console.WriteLine("1-MOSTRAR PRODUTOS, 2-ADICIONAR , 3-REMOVER , 4-ADICIONAR PRODUTO, 5 -SAIR");
        }
    }
}
