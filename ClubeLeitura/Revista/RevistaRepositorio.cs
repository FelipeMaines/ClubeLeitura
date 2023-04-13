
using ClubeLeitura.PegarDados;
using System.Collections;


namespace ClubeLeitura
{
    internal class RevistaRepositorio
    {

        public static ArrayList revistasCadastradas = new ArrayList();
        public static int id;
        public static void CadastrarRevista()
        {
            if (CaixaRepositorio.ListaCaixas.Count == 0)
            {
                Tela.Mensagem("Nao eh possivel cadastrar uma revista sem uma caixa!", ConsoleColor.DarkRed);
                Console.ReadLine();
                return;
            }
            var revista = new Revista();

            Tela.PegarDadosRevista(revista);
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
                    int id = array.IndexOf(item);
                    return id;
                }
            }

            Console.WriteLine("Essa revista nao foi cadastrada!");

            return 404;
        }
    }
}
