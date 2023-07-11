using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarrinhoCompras.Models
{
    public class Carrinho
    {
        public List<Produto> Produtos { get; set; }

        public Cliente Cliente { get; set; }


        public void AdicionarProduto(Produto produto)
        {
            Produtos.Add(produto);
        }

        public void removerProduto(Produto produto)
        {
            Produtos.Remove(produto);
        }

        public void imprimirProdutos(){
            foreach (var item in Produtos)
            {
                Console.WriteLine(item);
            }
        }
    }
}



