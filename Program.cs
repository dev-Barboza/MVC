using System;
using Aula34.Controllers;

namespace Aula34
{
    class Program
    {
        static void Main(string[] args)
        {
            ProdutoController produtos = new ProdutoController();
            produtos.Filtar("5600");
        }
    }
}
