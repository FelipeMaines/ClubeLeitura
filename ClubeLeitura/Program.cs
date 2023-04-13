using ClubeLeitura.PegarDados;
using System.Collections;

namespace ClubeLeitura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valorSwitch = 0;
            MenuPrincipal(valorSwitch);
        }

        static public void MenuPrincipal(int valorSwitch)
        {
            while (true)
            {

                //Corrigir erro disponibilidade da revista mesmo n tendo sido pega

                Console.Clear();
                Console.WriteLine("Qual opcao deseja afetuar:");
                Console.WriteLine("(1) Cadastrar Amigo");
                Console.WriteLine("(2) Cadastrar Caixa");
                Console.WriteLine("(3) Cadastrar Revista");
                Console.WriteLine("(4) Cadastrar Emprestimo");
                Console.WriteLine("(5) Emprestimos em Aberto");
                valorSwitch = int.Parse(Console.ReadLine());

                switch (valorSwitch)
                {
                    case 1:
                        Console.WriteLine("Cadastrando Amigo\n");
                        AdicionarAmigoAutomatico(AmigoRepositorio.amigosCadastrados);
                        AmigoRepositorio.CadastrarAmigo();

                        break;

                    case 2:
                        Console.WriteLine("Caixa\n");
                        AdicionarCaixasAutomatico(CaixaRepositorio.ListaCaixas);
                        CaixaRepositorio.RegistarCaixa();
                        break;

                    case 3:
                        Console.WriteLine("Revistas");
                        RevistaRepositorio.CadastrarRevista();
                        break;

                    case 4:
                        Console.WriteLine("Emprestimo");
                        EmprestimoRepositorio.AdicionarEmprestimoLista();
                        break;

                    case 5:
                        Console.WriteLine("Emprestimos em aberto: \n");
                        Tela.MostrarEmprestimosAbertos();
                        break;


                }
            }
        }
        /*  private static int ProcurarListaId(int id, ArrayList array)
          {
              id = int.Parse(Console.ReadLine());
              id = array.IndexOf(id);
              return id + 1;
          }*/
        public static void AdicionarAmigoAutomatico(ArrayList listaAmigos)
        {
            var amigo = new Amigo();

            amigo.nome = "Pedro";
            amigo.endereco = "R Fausto";
            amigo.telefone = "99181293124";
            amigo.nomeRespostavel = "Joao";

            AmigoRepositorio.amigosCadastrados.Add(amigo);

            var amigo2 = new Amigo();

            amigo2.nome = "Felipe";
            amigo2.endereco = "R Teste";
            amigo2.telefone = "99181293124";
            amigo2.nomeRespostavel = "Mario";

            AmigoRepositorio.amigosCadastrados.Add(amigo2);

            var amigo3 = new Amigo();

            amigo3.nome = "Alizu";
            amigo3.endereco = "R Gremio";
            amigo3.telefone = "99181293124";
            amigo3.nomeRespostavel = "Ednilson";

            AmigoRepositorio.amigosCadastrados.Add(amigo3);
        }
        public static void AdicionarCaixasAutomatico(ArrayList listaCaixas)
        {
            var caixa = new Caixa();

            caixa.id = 0;
            caixa.ediqueta = "Anime";
            caixa.cor = "Vermelho";

            listaCaixas.Add(caixa);

            var caixa2 = new Caixa();

            caixa2.id = 1;
            caixa2.ediqueta = "Filme";
            caixa2.cor = "Azul";

            listaCaixas.Add(caixa2);
        }

        /*
         Arrumar 
        5 - Arrumar requisitos {

                - Caso foi pego uma revista deve sair das revistas disponiveis -
                Implementar Mostrar Emprestimos abertos todos os dias
                Implemtar Mostrar todos os Emprestimos ate o momento!
               }
         */
    }
}