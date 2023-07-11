using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarrinhoCompras.Validate
{
    public class CompraException : Exception
    {
        public CompraException()
        {

        }
        public CompraException(string mensagem) : base(mensagem)
        {

        }

    }
}