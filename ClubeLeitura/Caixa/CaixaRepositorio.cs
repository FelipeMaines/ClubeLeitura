using ClubeLeitura.PegarDados;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeLeitura
{
    internal class CaixaRepositorio
    {
        public static ArrayList ListaCaixas = new ArrayList();
        public static void RegistarCaixa()
        {
           
            var caixa = new Caixa();

            Tela.PegarDadosCaixa(caixa);

            ListaCaixas.Add(caixa);

            Tela.Mensagem("Caixa Adicionada com sucesso", ConsoleColor.Green);
            Console.ReadLine();

        }
    }
}
