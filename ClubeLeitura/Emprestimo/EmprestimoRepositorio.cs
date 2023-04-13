using ClubeLeitura.PegarDados;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
            if(AmigoRepositorio.amigosCadastrados.Count == 0)
            {
                Tela.Mensagem("Nenhum amigo cadastrado para fazer um emprestimo!", ConsoleColor.DarkRed);
                Console.ReadLine();
                return;
            }

            else if (RevistaRepositorio.revistasCadastradas.Count == 0)
            {
                Tela.Mensagem("Nenhuma revista cadastrada para fazer um emprestimo!", ConsoleColor.DarkRed);
                Console.ReadLine();
                return;
            }

            var emprestimo = new Emprestimo();
            Console.Clear();

            Tela.MostrarArrayAmigos(AmigoRepositorio.amigosCadastrados);

            string amigoNome = Tela.PegarInformacaoEmprestimo("Qual o nome do amigo que pegara a revista");

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

            string nomeRevista = Tela.PegarInformacaoEmprestimo("Qual o nome da revista? ");

            //Descobre o index do objeto no array
            int idRevista = RevistaRepositorio.ProcurarListaNomeRevista(nomeRevista, RevistaRepositorio.revistasCadastradas);

            if (idRevista == 404)
            {
                Console.WriteLine("Revista nao cadastrada!");
                return;
            }

            Revista revista = (Revista)RevistaRepositorio.revistasCadastradas[idRevista];

            if (revista.emprestado == true)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Tela.Mensagem("Revista ja empresatada", ConsoleColor.DarkRed);
                Console.ReadLine();
                Console.ResetColor();
                return;
            }

            emprestimo.revista = revista;
            revista.emprestado = true;
            emprestimo.dataDesaida = DateTime.Today.Date;
            emprestimo.dataDevolucao = DateTime.Today.AddDays(30);

            emprestimosAberto.Add(emprestimo);
            amigo.emprestado = true;

            Tela.Mensagem("Emprestimo Cadastrado com sucesso!", ConsoleColor.Green);
            Console.ReadLine();
        }

       
    }
}
