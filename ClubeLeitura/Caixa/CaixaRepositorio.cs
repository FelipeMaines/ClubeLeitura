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

        public static void MostrarCaixas(ArrayList ListaCaixas)
        {

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkBlue;

            Console.WriteLine("|{0,-15} |{1,-25} |{2,-25}", "Id", "Cor", "Ediqueta");

            foreach (Caixa item in ListaCaixas)
            {
                Console.WriteLine("|{0,-15} |{1,-25} |{2,-25}", item.id, item.cor, item.ediqueta);
            }

            Console.ResetColor();
        }

        public static void RegistarCaixa()
        {

            //Console.Write("Qual o id da caixa: ");

            int id = ListaCaixas.Count;

            Console.WriteLine("Qual a cor da caixa: ");
            string cor = Console.ReadLine();

            Console.WriteLine("Qual a ediqueta da caixa: ");
            string ediqueta = Console.ReadLine();

            var caixa = new Caixa(cor, id, ediqueta);
            ListaCaixas.Add(caixa);

            Program.MensagemVerde("Caixa Adicionada com sucesso");
            Console.ReadLine();

        }
    }
}
