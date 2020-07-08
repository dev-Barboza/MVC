using System;
using System.Collections.Generic;
using System.IO;
namespace Aula34.Models
{
    public class produto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }

        private const string PATH = "Database/produto.csv";

        public List<produto> Ler()
        {
            

            List<produto> produtos = new List<produto>();
            
           
            string[] linhas = File.ReadAllLines(PATH);

          
            foreach(string linha in linhas)
            {
            string[] dado = linha.Split(";");

            //criar instancia para add na lista

           produto x = new produto();
            
            x.Codigo = Int32.Parse(separar(dado[0]));
            x.Nome = separar(dado[1]);
            x.Preco = float.Parse(separar(dado[2]));
            
            produtos.Add(x);
            }

            
            
            return produtos;
        }
         
          private string separar(string _coluna)
        {
            return _coluna.Split("=")[1];
        }
    }
}