using ClubeLeitura.Junta;
using ClubeLeitura.PegarDados;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ClubeLeitura
{
    public class EmprestimoRepositorio : Repositorio
    {
        public static ArrayList emprestimpoFeitos = new ArrayList();
        public static List<Emprestimo> emprestimosAberto = new List<Emprestimo>();
        Tela tela = new Tela();
        Exibicao exibicao = new Exibicao();

        public void AdicionarEmprestimoLista()
        {

            if (!VerificarCount(AmigoRepositorio.amigosCadastrados, "Nenhum amigo cadastrado para fazer um emprestimo!"))
                return;

            if(!VerificarCount(RevistaRepositorio.revistasCadastradas, "Nenhuma revista cadastrada para fazer um emprestimo!"))
                return;

            var emprestimo = new Emprestimo();

            Console.Clear();
            tela.MostrarArrayAmigos(AmigoRepositorio.amigosCadastrados);

            // Pega os dados no classe Tela
            string amigoNome = exibicao.PegarInformacaoEmprestimo("Qual o nome do amigo que pegara a revista");

            //Descobre o inndex do objeto no array pelo nome
            int id = ProcurarListaNomeAmigo(amigoNome, AmigoRepositorio.amigosCadastrados, "Amigo nao cadastrado");

            VerificarId404(id, "Id nao encontrado");
            emprestimo.amigo = (Amigo)AmigoRepositorio.amigosCadastrados[id];
            Amigo amigo = (Amigo)AmigoRepositorio.amigosCadastrados[id];

            //Verifica se o amigo ja pegou um livro emprestado

            VerificarAmigoPossuiEmprestimo(amigo);

            Console.Clear();

            MostrarRevistasCadastradas(RevistaRepositorio.revistasCadastradas);

            string nomeRevista = tela.PegarInformacaoEmprestimo("Qual o nome da revista? ");

            //Descobre o index do objeto no array
            int idRevista = ProcurarListaNomeAmigo(nomeRevista, RevistaRepositorio.revistasCadastradas, "Revista nao cadastrada");

            VerificarId404(idRevista, "Revista nao cadastrada");

            Revista revista = (Revista)RevistaRepositorio.revistasCadastradas[idRevista];

            VerificarRevistaEmprestada(revista);

            emprestimo.id = emprestimpoFeitos.Count; 
            emprestimo.revista = revista;
            revista.emprestado = true;
            emprestimo.dataDesaida = DateTime.Today.Date;
            emprestimo.dataDevolucao = DateTime.Today.AddDays(30);

            Adicionar(emprestimo, emprestimpoFeitos);

            emprestimosAberto.Add(emprestimo);
            amigo.emprestado = true;

            exibicao.Mensagem("Emprestimo Cadastrado com sucesso!", ConsoleColor.Green);
            Console.ReadLine();
        }

        public void DevolverLivro()
        {
            if (emprestimosAberto.Count == 0)
            {
                exibicao.Mensagem("Eh preciso ter um emprestimo em aberto para uma devolucao", ConsoleColor.Red); 
                Console.ReadLine();
                return;
            }

            Console.Clear();
            tela.MostrarEmprestimosAbertos();
            int id = tela.PegarIdEmprestimo(emprestimosAberto);

            emprestimosAberto[id].amigo.emprestado = false;
            emprestimosAberto[id].revista.emprestado = false;

            emprestimosAberto.RemoveAt(id);
        }

        public void VerificarRevistaEmprestada(Revista revista)
        {
            if (revista.emprestado == true)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                exibicao.Mensagem("Revista ja empresatada", ConsoleColor.DarkRed);
                Console.ReadLine();
                Console.ResetColor();
                return;
            }
        }

        public void VerificarAmigoPossuiEmprestimo(Amigo amigo)
        {
            if (amigo.emprestado == true)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                exibicao.Mensagem("Amigo ja possui uma revista emprestada", ConsoleColor.DarkRed);
                Console.ReadLine();
                Console.ResetColor();
                return;
            }
        }

       
    }
}
