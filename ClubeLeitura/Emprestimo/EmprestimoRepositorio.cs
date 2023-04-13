using ClubeLeitura.Junta;
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
    internal class EmprestimoRepositorio : Repositorio
    {
        public static ArrayList emprestimpoFeitos = new ArrayList();
        public static List<Emprestimo> emprestimosAberto = new List<Emprestimo>();
        Tela tela = new Tela();
        Exibicao exibicao = new Exibicao();

        public void AdicionarEmprestimoLista()
        {


            if(AmigoRepositorio.amigosCadastrados.Count == 0)
            {
                exibicao.Mensagem("Nenhum amigo cadastrado para fazer um emprestimo!", ConsoleColor.DarkRed);
                Console.ReadLine();
                return;
            }

            else if (RevistaRepositorio.revistasCadastradas.Count == 0)
            {
                exibicao.Mensagem("Nenhuma revista cadastrada para fazer um emprestimo!", ConsoleColor.DarkRed);
                Console.ReadLine();
                return;
            }

            var emprestimo = new Emprestimo();
            Console.Clear();

            tela.MostrarArrayAmigos(AmigoRepositorio.amigosCadastrados);

            // Pega os dados no classe Tela
            string amigoNome = exibicao.PegarInformacaoEmprestimo("Qual o nome do amigo que pegara a revista");

            //Descobre o inndex do objeto no array pelo nome
            int id = ProcurarListaNomeAmigo(amigoNome, AmigoRepositorio.amigosCadastrados);

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

            MostrarRevistasCadastradas(RevistaRepositorio.revistasCadastradas);

            string nomeRevista = tela.PegarInformacaoEmprestimo("Qual o nome da revista? ");

            //Descobre o index do objeto no array
            int idRevista = ProcurarListaNomeRevista(nomeRevista, RevistaRepositorio.revistasCadastradas);

            if (idRevista == 404)
            {
                Console.WriteLine("Revista nao cadastrada!");
                return;
            }

            Revista revista = (Revista)RevistaRepositorio.revistasCadastradas[idRevista];

            if (revista.emprestado == true)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                exibicao.Mensagem("Revista ja empresatada", ConsoleColor.DarkRed);
                Console.ReadLine();
                Console.ResetColor();
                return;
            }

            emprestimo.id = emprestimpoFeitos.Count; 
            emprestimo.revista = revista;
            revista.emprestado = true;
            emprestimo.dataDesaida = DateTime.Today.Date;
            emprestimo.dataDevolucao = DateTime.Today.AddDays(30);

            emprestimpoFeitos.Add(emprestimo);
            emprestimosAberto.Add(emprestimo);
            amigo.emprestado = true;

            exibicao.Mensagem("Emprestimo Cadastrado com sucesso!", ConsoleColor.Green);
            Console.ReadLine();
        }

        public void DevolverLivro()
        {
            Console.Clear();
            tela.MostrarEmprestimosAbertos();
            int id = tela.PegarIdEmprestimo(emprestimosAberto);

            var amigoEmprestimo = emprestimosAberto[id].amigo.emprestado = false;
            var amigoRevista = emprestimosAberto[id].revista.emprestado = false;

            emprestimosAberto.RemoveAt(id);





        }

       
    }
}
