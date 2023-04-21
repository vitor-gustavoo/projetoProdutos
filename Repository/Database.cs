// using System;
// using System.Collections.Generic;
// using System.Linq;
// using Microsoft.EntityFrameworkCore;
// using Models;



// // PARA RODAR O COMANDO DOTNET BUILD É NECESSÁRIO TER A CRIAÇÃO DO BANCO

// // COMANDO PARA CRIAR AS MIGRATIONS: dotnet ef migrations add "nome da minha migrations"
// namespace Repository
// {
//     public class Database : DbContext

//     {
//         // public static DbSet<Models.Produto> Produtos = new DbSet<Models.Produto>();


//         public static DbSet<Models.Produto> Produtos { get; set;}
//         public static DbSet<Models.Estoque> Estoques { get; set; }
//         public static DbSet<Models.Saldo> Saldos { get; set; }

        
//         string connection = "Server=localhost;Uid=root;Database=;";

//         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//             => optionsBuilder.UseMySql(connection, ServerVersion.AutoDetect(connection));


//     }
// }