

using System.Collections;

namespace ClubeLeitura.Junta
{
    public class Exibicao
    {
        public void Mensagem(string mensagem, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(mensagem);
            Console.ResetColor();
        }

        public string PegarInformacaoEmprestimo(string mensagem)
        {

            Console.WriteLine(mensagem);
            string amigoNome = Console.ReadLine();

            return amigoNome;
        }

        
    }
}
