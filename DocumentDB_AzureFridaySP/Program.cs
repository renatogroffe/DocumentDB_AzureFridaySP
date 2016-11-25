using System;

namespace DocumentDB_AzureFridaySP
{
    class Program
    {
        static void Main(string[] args)
        {
            Estruturas.CriarBanco().Wait();
            Console.WriteLine("Criação do banco finalizada...");
            Console.ReadKey();

            Estruturas.CriarColecao().Wait();
            Console.WriteLine("Criação da coleção finalizada...");
            Console.ReadKey();

            CRUD.InserirDadosProdutos().Wait();
            CRUD.InserirDadosServicos().Wait();
            Console.WriteLine("Dados inseridos...");
            Console.ReadKey();

            CRUD.AtualizarServico().Wait();
            Console.ReadKey();

            CRUD.ExcluirServico().Wait();
            Console.WriteLine("Exclusão finalizada...");
            Console.ReadKey();

            CRUD.ConsultarSQL();
            Console.ReadKey();

            CRUD.ConsultarLINQ();
            Console.ReadKey();
        }
    }
}