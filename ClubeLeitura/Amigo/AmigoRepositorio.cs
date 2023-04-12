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

            Console.Write("Qual o nome do amigo:");
            string nome = Console.ReadLine();

            Console.Write("Qual o nome do responsavel do amigo: ");
            string nomeResponsavel = Console.ReadLine();

            Console.Write("Qual o telefone do amigo: ");
            string telefone = Console.ReadLine();

            Console.Write("Qual o edereco do amigo: ");
            string endereco = Console.ReadLine();

            var amigo = new Amigo(nome, nomeResponsavel, telefone, endereco);

            amigosCadastrados.Add(amigo);

            Program.MensagemVerde("Amigo Cadastrado com sucesso");
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

            Console.WriteLine("Esse amigo nao foi cadastrado!");

            return 404;
        }

        public static void MostrarArrayAmigos(ArrayList array)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkBlue;

            Console.WriteLine("|{0,-15} |{1,-15} |{2,-15} |{3,-15}", "nome", "Nome Resp", "Telefone", "endereco");

            foreach (Amigo item in array)
            {
                Console.WriteLine("|{0,-15} |{1,-15} |{2,-20} |{3,-20}", item.nome, item.nomeRespostavel, item.telefone, item.endereco);
            }


            Console.ResetColor();
        }
    }
}
