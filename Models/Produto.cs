using System;



namespace Models

{
    public class Produto
    {
        
        private int Id {get; set;}

        private string Nome {get; set;}

        private double Preco {get; set;}
        
        public static List<Produto> Produtos = new List<Produto>();

        public Produto(int id, string nome, string preco)
        {
            Id = id;
            Nome = nome;
            Preco = double.Parse(preco);

            Produtos.Add(this);
        }


        public void EditarProduto(int id, string nome, string preco)
        {
            Nome = nome;
            Preco = double.Parse(preco);
        }


        public void ExcluirProduto(int id)
        {
            Produto produto = BuscarProduto(id);
            Produtos.Remove(produto);
        }


        public static Produto BuscarProduto(int id)
        {
            Produto? produto = Produtos.Find(prd => prd.Id == id);
            if(produto == null){
                throw new Exception("Produto não encontrado!");
            }
            return produto;
        }
    }
}