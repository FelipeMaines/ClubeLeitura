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

        public int PegarPorId(int id,Entidade varivel)
        {
            Caixa caixa = null;

            foreach (Entidade item in CaixaRepositorio.ListaCaixas)
            {
                if (item.id == id)
                {
                    return id;
                }
            }
            return 404;
        }

        public void VerificarId404(int id, string mensagem)
        {
            if (id == 404)
            {
                Console.WriteLine(mensagem);
                return;
            }
        }

        public void ColocarRevistaCaixa(Revista revista)
        {
            Console.WriteLine("Qual o id da caixa que deseja inserir");
            int id = int.Parse(Console.ReadLine());

            Caixa caixa = null;

            int idItem = PegarPorId(id, caixa);

            VerificarId404(idItem, "Caixa inexistente");

            revista.caixa = (Caixa)CaixaRepositorio.ListaCaixas[id];
        }

    }
}
