using ClubeLeitura.Junta;


namespace ClubeLeitura
{
    public class Caixa : Entidade
    {
        public string cor;
        public string ediqueta;
        public List<Revista> revistas = new List<Revista>();


        public Caixa()
        {

        }
        public Caixa(string cor, int id, string ediqueta)
        {
            this.cor = cor;
            this.ediqueta = ediqueta;
            this.id = id;
        }

        

        
    }
}
