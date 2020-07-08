using System.Collections.Generic;
using Aula34.Models;
using Aula34.Views;

namespace Aula34.Controllers
{
    public class ProdutoController
    {
        produto produtoModel = new produto();
        ProdutoView produtoView = new ProdutoView();
        public void Listar()
        {
            produtoView.MostrarNoConsole(produtoModel.Ler( ));
        }

        public void Filtar(string _preco)
        {
            List<produto> lista = produtoModel.Ler();
            lista = lista.FindAll(x=> x.Preco== float.Parse(_preco));
            produtoView.MostrarNoConsole(lista);
        }

    }
}