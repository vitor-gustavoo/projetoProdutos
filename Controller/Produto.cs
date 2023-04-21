using System;

using Models;

namespace Controller
{

    public class Produto
    {

        public Models.Produto CadastrarProduto(string nome, string preco)
        {
            return new Models.Produto
            (
                nome,
                Double.Parse(preco)
            );
        }


        // public Models.Produto EditarProduto(string nome, string preco)
        // {
        //     return new Models.Produto
        //     (
        //         nome,
        //         Double.Parse(preco)
        //     );
        // }



    }
}