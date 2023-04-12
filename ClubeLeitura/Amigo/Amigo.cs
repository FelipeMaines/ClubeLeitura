using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeLeitura
{
    internal class Amigo
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
