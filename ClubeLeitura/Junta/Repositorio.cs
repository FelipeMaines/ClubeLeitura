using ClubeLeitura.PegarDados;
using System.Collections;

namespace ClubeLeitura.Junta
{
    public class Repositorio
    {

        Exibicao exibicao = new Exibicao();

        public int ProcurarListaNomeAmigo(string nome, ArrayList array, string mensagem)
        {
            foreach (Entidade item in array)
            {
                if (item.nome == nome)
                {
                    int id = array.IndexOf(item);
                    return id;
                }
            }

            exibicao.Mensagem(mensagem, ConsoleColor.DarkRed);

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

        public void Adicionar(Entidade item, ArrayList array)
        {
            array.Add(item);
        }

        public bool VerificarCount(ArrayList array, string mensagem)
        {
            if (array.Count == 0)
            {
                exibicao.Mensagem(mensagem, ConsoleColor.Red);
                Console.ReadLine();
                return false;
            }
            return true;
        }



    }
}
