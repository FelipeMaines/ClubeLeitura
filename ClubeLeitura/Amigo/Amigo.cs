using ClubeLeitura.Junta;


namespace ClubeLeitura
{
    public class Amigo : Entidade
    {
        public string nome;
        public string nomeRespostavel;
        public string telefone;
        public string endereco;
        public bool emprestado;
        

        public Amigo()
        {

        }


        public Amigo(string nome, string nomeResposavel, string telefone, string edereco)
        {
            this.nome = nome;
            this.nomeRespostavel = nomeResposavel;
            this.telefone = telefone;
            this.endereco = edereco;
        }

        

        

       
    }
}
