using System;

namespace Models
{
    public class Produto
    {
        
        private int Id {get; set;}

        private string Nome {get; set;}

        private double Preco {get; set;}
        
        public Produto(){
            // para localizar a classe na migrations
        }

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;

            // adicionar o context para salvar no banco
        }



        // public void CadastrarProduto(string nome, double preco)
        // {
        //     Nome = nome;
        //     Preco = preco;
        // }

        // public void EditarProduto(int id, string nome, double preco)
        // {
        //     Nome = nome;
        //     Preco = preco;
        // }


        // public void ExcluirProduto(int id)
        // {
        //     // Produto produto = BuscarProduto(id);
        //     // produto.Remove(produto);
        // }


        // public Produto BuscarProduto(int id)
        // {
        //     Produto? produto = Repository.Database.Produtos.Find(prd => prd.Id == id);
        //     return produto;
        // }
    }
}