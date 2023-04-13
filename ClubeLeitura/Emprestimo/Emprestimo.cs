
using ClubeLeitura.Junta;

namespace ClubeLeitura
{
    public class Emprestimo : Entidade
    {
        public Amigo amigo;
        public Revista revista;
        public DateTime dataDesaida;
        public DateTime dataDevolucao;

    }
}
