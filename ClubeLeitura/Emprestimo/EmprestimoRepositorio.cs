using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeLeitura
{
    internal class EmprestimoRepositorio
    {
        public static ArrayList emprestimpoFeitos = new ArrayList();
        public static ArrayList emprestimosAberto = new ArrayList();

        public static void AdicionarEmprestimoLista()
        {
            var emprestimo = new Emprestimo();
            Console.Clear();

            AmigoRepositorio.MostrarArrayAmigos(AmigoRepositorio.amigosCadastrados);

            Console.WriteLine("Qual o nome do amigo que sera emprestado a revista");
            string amigoNome = Console.ReadLine();

            //Descobre o inndex do objeto no array pelo nome
            int id = AmigoRepositorio.ProcurarListaNomeAmigo(amigoNome, AmigoRepositorio.amigosCadastrados);

            if (id == 404)
            {
                Console.WriteLine("Erro!");
                return;
            }


            emprestimo.amigo = (Amigo)AmigoRepositorio.amigosCadastrados[id];

            Amigo amigo = (Amigo)AmigoRepositorio.amigosCadastrados[id];

            //Verifica se o amigo ja pegou um livro emprestado
            if (amigo.emprestado == true)
            {
               // MostrarListaEmprestimos(emprestimpoFeitos);
                Console.WriteLine("\nEsse amigo ja tem uma revista emprestada!");
                Console.ReadLine();
                return;
            }


            Console.Clear();

            RevistaRepositorio.MostrarRevistasCadastradas(RevistaRepositorio.revistasCadastradas);

            Console.WriteLine("Qual o nome da revista? ");
            string nomeRevista = Console.ReadLine();

            //Descobre o index do objeto no array
            int idRevista = RevistaRepositorio.ProcurarListaNomeRevista(nomeRevista, RevistaRepositorio.revistasCadastradas);

            if (idRevista == 404)
            {
                Console.WriteLine("Revista nao cadastrada!");
                return;
            }

            emprestimo.revista = (Revista)RevistaRepositorio.revistasCadastradas[idRevista];
            emprestimo.dataDesaida = DateTime.Today.Date;
            emprestimo.dataDevolucao = DateTime.Today.AddDays(30);

            emprestimosAberto.Add(emprestimo);
            amigo.emprestado = true;

            Program.MensagemVerde("Emprestimo Cadastrado com sucesso!");
            Console.ReadLine();
        }

        public static void MostrarEmprestimosAbertos()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkBlue;

            Console.WriteLine("|{0,-15} |{1,-25} |{2,-25} |{3, -25}", "Amigo", "Revista", "Data do Emprestimo", "Data Devolucao");

            foreach (Emprestimo item in emprestimosAberto)
            {
                Console.WriteLine("|{0,-15} |{1,-25} |{2,-25} |{3,-25}", item.amigo.nome, item.revista.colecao, item.dataDesaida, item.dataDevolucao);
            }
            Console.ReadLine();
            Console.ResetColor();
        }
    }
}
