﻿using ClubeLeitura.Junta;
using System.Collections;

namespace ClubeLeitura.PegarDados
{
    public  class Tela : Exibicao
    {
       
        public Revista PegarDadosRevista(Revista revista )
        {
            Console.Write("Qual o nome da revista: ");
            revista.colecao = Console.ReadLine();

            Console.Write("Qual o numero de edicao da revista: ");
            revista.numeroEdicao = int.Parse(Console.ReadLine());

            Console.Write("Qual o ano de lancamento da revista: ");
            revista.anoRevista = int.Parse(Console.ReadLine());

            MostrarCaixas(CaixaRepositorio.ListaCaixas);

            ColocarRevistaCaixa(revista);

            Mensagem("Revista Cadastrada com sucesso!", ConsoleColor.Green);
            Console.ReadLine();

            return revista;
        }

        public void ColocarRevistaCaixa(Revista revista )
        {
            Console.WriteLine("Qual o id da caixa que deseja inserir");
            int id = int.Parse(Console.ReadLine());

            Caixa caixa = null;

            foreach (Caixa item in CaixaRepositorio.ListaCaixas)
            {
                if (item.id == id)
                {
                    caixa = item;
                    break;
                }
            }



            if (id == -1)
            {
                Mensagem("Caixa nao encontrada!", ConsoleColor.DarkRed);
                Console.ReadLine();
                Program.MenuPrincipal(0);
            }
            

            revista.caixa = (Caixa)CaixaRepositorio.ListaCaixas[id];
            RevistaRepositorio.revistasCadastradas.Add(revista);



        }

        public int PegarIdEmprestimo(List<Emprestimo> listaEmprestimo)
        {
            Console.WriteLine("Qual o id do emprestimo que deseja cancelar");
            int id = int.Parse(Console.ReadLine());

            foreach (Emprestimo item in listaEmprestimo)
            {
                if (item.id == id)
                {
                    return listaEmprestimo.IndexOf(item);
                }
                
            }
            return 404;
        }

        internal void PegarDadosAmigo(Amigo amigo)
        {

            Console.Write("Qual o nome do amigo:");
            amigo.nome = Console.ReadLine();

            Console.Write("Qual o nome do responsavel do amigo: ");
            amigo.nomeRespostavel = Console.ReadLine();

            Console.Write("Qual o telefone do amigo: ");
            amigo.telefone = Console.ReadLine();

            Console.Write("Qual o edereco do amigo: ");
            amigo.endereco = Console.ReadLine();

            amigo.id = AmigoRepositorio.amigosCadastrados.Count;
        }

        public void MostrarArrayAmigos(ArrayList array)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkBlue;

            Console.WriteLine("|{0,-15} |{1,-15} |{2,-15} |{3,-15}", "nome", "Nome Resp", "Telefone", "endereco");

            foreach (Amigo item in array)
            {
                Console.WriteLine("|{0,-15} |{1,-15} |{2,-20} |{3,-20}", item.nome, item.nomeRespostavel, item.telefone, item.endereco);
            }


            Console.ResetColor();
        }

        public void MostrarCaixas(ArrayList ListaCaixas)
        {

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkBlue;

            Console.WriteLine("|{0,-15} |{1,-25} |{2,-25}", "Id", "Cor", "Ediqueta");

            foreach (Caixa item in ListaCaixas)
            {
                Console.WriteLine("|{0,-15} |{1,-25} |{2,-25}", item.id, item.cor, item.ediqueta);
            }

            Console.ResetColor();
        }

        internal void PegarDadosCaixa(Caixa caixa)
        {
            Console.WriteLine("Qual a cor da caixa: ");
            caixa.cor = Console.ReadLine();

            Console.WriteLine("Qual a ediqueta da caixa: ");
            caixa.ediqueta = Console.ReadLine();

            caixa.id = CaixaRepositorio.ListaCaixas.Count;
        }
        public void MostrarEmprestimosAbertos()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkBlue;

            Console.WriteLine("|{0,-15} |{1,-25} |{2,-25} |{3, -25} |{4, -25}", "Amigo", "Revista", "Data do Emprestimo", "Data Devolucao", "Id");

            foreach (Emprestimo item in EmprestimoRepositorio.emprestimosAberto)
            {
                Console.WriteLine("|{0,-15} |{1,-25} |{2,-25} |{3,-25} |{4, -25}", item.amigo.nome, item.revista.colecao, item.dataDesaida, item.dataDevolucao, item.id);
            }
            Console.ReadLine();
            Console.ResetColor();
        }

       
    }
}