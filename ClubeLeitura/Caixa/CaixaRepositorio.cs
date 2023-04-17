using ClubeLeitura.Junta;
using ClubeLeitura.PegarDados;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeLeitura
{
    internal class CaixaRepositorio : Repositorio
    {
        Tela tela = new Tela();
        Exibicao exibicao = new Exibicao();

        public static ArrayList ListaCaixas = new ArrayList();
        public  void RegistarCaixa()
        {
           
            Caixa caixa = new Caixa();

            tela.PegarDadosCaixa(caixa);

            Adicionar(caixa, ListaCaixas);

            exibicao.Mensagem("Caixa Adicionada com sucesso", ConsoleColor.Green);
            Console.ReadLine();

        }

        
    }
}
