using ClubeLeitura.PegarDados;
using System.Collections;

namespace ClubeLeitura
{
    internal class Program
    {
        Program program = null;

        static void Main(string[] args)
        {
            int valorSwitch = 0;
            MenuPrincipal(valorSwitch);

           

        }

         public static void MenuPrincipal(int valorSwitch)
        {
            AmigoRepositorio amigoRepositorio = new AmigoRepositorio();
            CaixaRepositorio caixaRepositorio = new CaixaRepositorio();
            RevistaRepositorio revistaRepositorio = new RevistaRepositorio();
            EmprestimoRepositorio emprestimoRepositorio = new EmprestimoRepositorio();
            Tela tela = new Tela();

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
                Console.WriteLine("(6) Todos os emprestimos feitos ate agora");
                Console.WriteLine("(7) Devolver Livro");
                valorSwitch = int.Parse(Console.ReadLine());

                switch (valorSwitch)
                {
                    case 1:
                        Console.WriteLine("Cadastrando Amigo\n");
                        //AdicionarAmigoAutomatico(AmigoRepositorio.amigosCadastrados);
                        amigoRepositorio.CadastrarAmigo();

                        break;

                    case 2:
                        Console.WriteLine("Caixa\n");
                        //AdicionarCaixasAutomatico(CaixaRepositorio.ListaCaixas);
                        caixaRepositorio.RegistarCaixa();
                        break;

                    case 3:
                        Console.WriteLine("Revistas");
                        revistaRepositorio.CadastrarRevista();
                        break;

                    case 4:
                        Console.WriteLine("Emprestimo");
                        emprestimoRepositorio.AdicionarEmprestimoLista();
                        break;

                    case 5:
                        Console.WriteLine("Emprestimos em aberto: \n");
                        tela.MostrarEmprestimosAbertos();
                        break;

                    case 6:
                        Console.WriteLine("Todos os emprestimos Feitos: \n");
                        tela.MostrarTodosOsEmprestimosFeitos();
                        break;


                    case 7:
                        Console.WriteLine("Devolucao \n");
                        emprestimoRepositorio.DevolverLivro();
                        break;


                }
            }
        }
        /*  private static int ProcurarListaId(int id, ArrayList array)
          {
              id = int.Parse(Console.ReadLine());
              id = array.IndexOf(id);
              return id + 1;
          
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

        
         Arrumar 
        5 - Arrumar requisitos {

                - Caso foi pego uma revista deve sair das revistas disponiveis -
                Implementar Mostrar Emprestimos abertos todos os dias
                Implemtar Mostrar todos os Emprestimos ate o momento!
               }
         */
    }
}