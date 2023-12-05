using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace 
{
    public class Motorista
    {
        public class Motorista : Pessoa //*O motorista está herdando a classe Pessoa
    {
        public Motorista(int idade) : base(idade)
        {



        }

        public void AdicionarNome(string nome) //*Adioconar o nome pro motorista
        {
            Nome = nome;
        }
    }
    }
}