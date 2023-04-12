using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeLeitura
{
    internal class Revista
    {
        public string colecao;
        public int numeroEdicao;
        public int anoRevista;
        public Caixa caixa;

        public Revista()
        {

        }
        public Revista(string colecao, int numeroEdicao, int anoRevita)
        {
            this.colecao = colecao;
            this.numeroEdicao = numeroEdicao;
            this.anoRevista = anoRevita;
        }




       

       
    }
}
