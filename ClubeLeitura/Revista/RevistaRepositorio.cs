
using System.Collections;


namespace ClubeLeitura
{
    internal class RevistaRepositorio
    {

    public static ArrayList revistasCadastradas = new ArrayList();
        public static void CadastrarRevista()
        {
            var revista = new Revista();

            Console.Write("Qual o nome da revista: ");
            revista.colecao = Console.ReadLine();

            Console.Write("Qual o numero de edicao da revista: ");
            revista.numeroEdicao = int.Parse(Console.ReadLine());

            Console.Write("Qual o ano de lancamento da revista: ");
            revista.anoRevista = int.Parse(Console.ReadLine());

            CaixaRepositorio.MostrarCaixas(CaixaRepositorio.ListaCaixas);

            Console.WriteLine("Qual o id da caixa que deseja inserir");
            int id = int.Parse(Console.ReadLine());

            RevistaRepositorio.ColocarRevistaCaixa(revista, id);

            Program.MensagemVerde("Revista Cadastrada com sucesso!");
            Console.ReadLine();
        }

        public static void ColocarRevistaCaixa(Revista revista, int id)
        {
            id = CaixaRepositorio.ListaCaixas.IndexOf(id);
            id += 1;

            revista.caixa = (Caixa)CaixaRepositorio.ListaCaixas[id];
            revistasCadastradas.Add(revista);
        }

        public static void MostrarRevistasCadastradas(ArrayList array)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkBlue;

            Console.WriteLine("|{0,-15} |{1,-15} |{2,-20} |{3,-20}", "nome", "Ano Revista", "Num Edicao", "Ediqueta Caixa");

            foreach (Revista item in array)
            {
                Console.WriteLine("|{0,-15} |{1,-15} |{2,-20} |{3,-20}", item.colecao, item.anoRevista, item.numeroEdicao, item.caixa.ediqueta);
            }


            Console.ResetColor();
        }

        public static int ProcurarListaNomeRevista(string nome, ArrayList array)
        {
            foreach (Revista item in array)
            {
                var revista = item;

                if (revista.colecao == nome)
                {
                    int id = array.IndexOf(nome);
                    return id + 1;
                }
            }

            Console.WriteLine("Essa revista nao foi cadastrada!");

            return 404;
        }
    }
}
