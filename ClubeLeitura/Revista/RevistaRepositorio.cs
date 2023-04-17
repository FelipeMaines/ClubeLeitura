
using ClubeLeitura.Junta;
using ClubeLeitura.PegarDados;
using System.Collections;
using System.Diagnostics.CodeAnalysis;

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

            if (!VerificarCount(CaixaRepositorio.ListaCaixas, "Eh preciso ter um emprestimo em aberto para uma devolucao"))
                return;

            var revista = new Revista();

            Revista revistaFinal = tela.PegarDadosRevista(revista);

            ColocarRevistaCaixa(revistaFinal);

            exibicao.Mensagem("Inserido com sucesso", ConsoleColor.Red);

            Adicionar(revistaFinal, revistasCadastradas);

            

            
        }
        
        
    }
}
