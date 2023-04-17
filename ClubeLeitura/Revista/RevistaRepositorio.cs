
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
           
            VerificarCount(CaixaRepositorio.ListaCaixas, "Eh preciso ter um emprestimo em aberto para uma devolucao");

            var revista = new Revista();

            Revista revistaFinal = tela.PegarDadosRevista(revista);

            Adicionar(revistaFinal, revistasCadastradas);
        }
        
        
    }
}
