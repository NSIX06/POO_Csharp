using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace 
{
    public class Pessoa
    {
    #region Atributos
        protected string Nome {get; set;}

        public string SobreNome {get; set;}

        public int Idade {get; set;}

    #endregion

    //*Public = qualquer um pode acessar;
    //?Private = somente o mesmo da classe pode acessar;
    //!Protected = somente o mesmo da classe pode acessar e seus filhos;


    public string NomeCompleto => Nome + SobreNome;


        public Pessoa(int idade)
        {

            Idade = idade;

        }
    }
}