
using ClubeLeitura.Junta;
using ClubeLeitura.PegarDados;
using System.Collections;


namespace ClubeLeitura
{
    internal class RevistaRepositorio : Repositorio
    {
        Exibicao exibicao = new Exibicao();

        Tela tela = new Tela();

        public static ArrayList revistasCadastradas = new ArrayList();
        public static ArrayList revistasEmprestadas = new ArrayList();
        public static int id;
        public void CadastrarRevista()
        {
            if (CaixaRepositorio.ListaCaixas.Count == 0)
            {
                exibicao.Mensagem("Nao eh possivel cadastrar uma revista sem uma caixa!", ConsoleColor.DarkRed);
                Console.ReadLine();
                return;
            }
            var revista = new Revista();

            tela.PegarDadosRevista(revista);
        }
        
        
    }
}
