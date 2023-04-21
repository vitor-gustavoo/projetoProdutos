// using System;

// using Repository;




// namespace Models

// {
//     public class Saldo
//     {
        
//         private int Id {get; set;}

//         private int ProdutoId {get; set;}

//         private int EstoqueId {get; set;}

//         private int Quantidade {get; set;}
        
//         public Saldo(

//         ){
//             // para localizar a classe na migrations
//         }

//         public Saldo(int nome, int produtoId, int estoqueId, int quantidade)
//         {
//            Id = Id;
//            ProdutoId = produtoId;
//            EstoqueId = estoqueId;
//            Quantidade = quantidade;

//             // adicionar o context para salvar no banco
//         }



//         // public void CadastrarProduto(string nome, double preco)
//         // {
//         //     Nome = nome;
//         //     Preco = preco;
//         // }

//         public void EditarSaldo(int id, int quantidade)
//         {
//            Id = id;
//            Quantidade = quantidade;
//         }


//         public void ExcluirSaldo(int id)
//         {
//             // Produto produto = BuscarProduto(id);
//             // produto.Remove(produto);
//         }


//         public Estoque BuscarSaldo(int id)
//         {
//             Saldo? saldo = Database.Saldos.Find(s => s.Id == id);
//             return saldo;
//         }
//     }
// }