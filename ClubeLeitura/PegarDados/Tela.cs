using System.Collections;

namespace ClubeLeitura.PegarDados
{
    internal class Tela
    {
        public static void Mensagem(string mensagem, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(mensagem);
            Console.ResetColor();
        }

        internal static Revista PegarDadosRevista(Revista revista )
        {
            Console.Write("Qual o nome da revista: ");
            revista.colecao = Console.ReadLine();

            Console.Write("Qual o numero de edicao da revista: ");
            revista.numeroEdicao = int.Parse(Console.ReadLine());

            Console.Write("Qual o ano de lancamento da revista: ");
            revista.anoRevista = int.Parse(Console.ReadLine());

            Tela.MostrarCaixas(CaixaRepositorio.ListaCaixas);

            ColocarRevistaCaixa(revista);

            Tela.Mensagem("Revista Cadastrada com sucesso!", ConsoleColor.Green);
            Console.ReadLine();

            return revista;
        }

        public static void ColocarRevistaCaixa(Revista revista )
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
                Tela.Mensagem("Caixa nao encontrada!", ConsoleColor.DarkRed);
                Console.ReadLine();
                Program.MenuPrincipal(0);
            }
            

            revista.caixa = (Caixa)CaixaRepositorio.ListaCaixas[id];
            RevistaRepositorio.revistasCadastradas.Add(revista);



        }

        internal static void PegarDadosAmigo(Amigo amigo)
        {

            Console.Write("Qual o nome do amigo:");
            amigo.nome = Console.ReadLine();

            Console.Write("Qual o nome do responsavel do amigo: ");
            amigo.nomeRespostavel = Console.ReadLine();

            Console.Write("Qual o telefone do amigo: ");
            amigo.telefone = Console.ReadLine();

            Console.Write("Qual o edereco do amigo: ");
            amigo.endereco = Console.ReadLine();
        }

        public static void MostrarArrayAmigos(ArrayList array)
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

        public static void MostrarCaixas(ArrayList ListaCaixas)
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

        internal static void PegarDadosCaixa(Caixa caixa)
        {
            Console.WriteLine("Qual a cor da caixa: ");
            caixa.cor = Console.ReadLine();

            Console.WriteLine("Qual a ediqueta da caixa: ");
            caixa.ediqueta = Console.ReadLine();

            caixa.id = CaixaRepositorio.ListaCaixas.Count;
        }
        public static void MostrarEmprestimosAbertos()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkBlue;

            Console.WriteLine("|{0,-15} |{1,-25} |{2,-25} |{3, -25}", "Amigo", "Revista", "Data do Emprestimo", "Data Devolucao");

            foreach (Emprestimo item in EmprestimoRepositorio.emprestimosAberto)
            {
                Console.WriteLine("|{0,-15} |{1,-25} |{2,-25} |{3,-25}", item.amigo.nome, item.revista.colecao, item.dataDesaida, item.dataDevolucao);
            }
            Console.ReadLine();
            Console.ResetColor();
        }

        internal static string PegarInformacaoEmprestimo(string mensagem)
        {

            Console.WriteLine(mensagem);
            string amigoNome = Console.ReadLine();

            return amigoNome;
        }
    }
}
