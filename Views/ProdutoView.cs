using System.Collections.Generic;
using Aula34.Models;
using System;

namespace Aula34.Views
{
    public class ProdutoView
    {
        public void MostrarNoConsole(List<produto> lista)
        {
                foreach(produto item in lista)
                {
                    System.Console.WriteLine($" {item.Codigo}R$ {item.Preco} - {item.Nome}"); 
                }
        }
    }
}