// using System;

// using Repository;


// namespace Models
// {
    
//     public class Estoque
//     {
//         private int Id {get; set;}

//         private string Nome {get; set;}


//         public Estoque() {

//         }

//         public Estoque(string nome)
//         {

//             Nome = nome;
//         }

//         public void EditarEstoque(string nome)
//         {
//             Nome = nome;
//         }

//         // public void ExcluirEstoque(int id)
//         // {
//         //      Produto produto = BuscarProduto(id);
//         //      produto.Remove(produto);
//         // }


//         public Estoque BuscarEstoque(int id)
//         {
//             Estoque? estoque = Database.Estoques.Find(e => e.Id == id);
//             return estoque;
//         }
//     }

// }