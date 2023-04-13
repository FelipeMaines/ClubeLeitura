using ClubeLeitura.PegarDados;
using System.Collections;

namespace ClubeLeitura.Junta
{
    public class Repositorio
    {

        Exibicao exibicao = new Exibicao();

        public int ProcurarListaNomeAmigo(string nome, ArrayList array)
        {
            foreach (Amigo item in array)
            {
                if (item.nome == nome)
                {
                    int id = array.IndexOf(item);
                    return id;
                }
            }

            exibicao.Mensagem("Esse amigo nao foi cadastrado!", ConsoleColor.DarkRed);

            return 404;
        }

        public  int ProcurarListaNomeRevista(string nome, ArrayList array)
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

        public void MostrarRevistasCadastradas(ArrayList array)
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
    }
}
