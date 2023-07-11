using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace CarrinhoCompras.Models
{
    public class Produto
    {
        public int CodProduto { get; set; }
        
        public string Nome { get; set; }

        public double Preco { get; set; }

        public int Quantidade { get; set; }

    }
}