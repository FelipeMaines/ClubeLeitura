using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeLeitura
{
    internal class Caixa
    {
        public string cor;
        public int id;
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
