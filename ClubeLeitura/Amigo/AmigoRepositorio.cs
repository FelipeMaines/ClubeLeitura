using ClubeLeitura.PegarDados;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeLeitura
{
    internal class AmigoRepositorio
    {
        public static ArrayList amigosCadastrados = new ArrayList();
        public static void CadastrarAmigo()
        {
            var amigo = new Amigo();

            Tela.PegarDadosAmigo(amigo);

            amigosCadastrados.Add(amigo);

            Tela.Mensagem("Amigo Cadastrado com sucesso", ConsoleColor.Green);
            Console.ReadLine();

        }
        public static int ProcurarListaNomeAmigo(string nome, ArrayList array)
        {
            foreach (Amigo item in array)
            {
               if (item.nome == nome)
                {
                    int id = array.IndexOf(item);
                    return id;
                }
            }

            Tela.Mensagem("Esse amigo nao foi cadastrado!", ConsoleColor.DarkRed);

            return 404;
        }
    }
}
