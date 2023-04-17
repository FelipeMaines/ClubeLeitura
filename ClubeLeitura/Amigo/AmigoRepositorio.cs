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
    public class AmigoRepositorio : Repositorio
    {
        public Tela tela = new Tela();
        Exibicao exibicao = new Exibicao();
        public static ArrayList amigosCadastrados = new ArrayList();
        public void CadastrarAmigo()
        {

            var amigo = new Amigo();

            tela.PegarDadosAmigo(amigo);

            Adicionar(amigo, amigosCadastrados);

            exibicao.Mensagem("Amigo Cadastrado com sucesso", ConsoleColor.Green);
            Console.ReadLine();

        }
        
    }
}
