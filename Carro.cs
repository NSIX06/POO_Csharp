using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace 
{
    public class Carro
    {
        #region Atributos
        public string Cor {get; set;}

        public string Modelo {get; set;}

        public int Ano {get; set;}

    #endregion

    #region Construtores

        //* Criação com Parâmnetros 
        public Carro(string cor, string modelo, int ano)
        {
            //* this deixa explícito 
            Cor = cor;
            Modelo = modelo;
            Ano = ano;

        }

        public Carro()
        {
        }

    #endregion


    #region Métodos  

    //*Void método sem retorno
    public void LigarCarro()
    {

        System.Console.WriteLine("Liagndo o carro...");
        System.Console.WriteLine("Carro ligado!");

    }

    //*Void método sem retorno
    public void LigarBuzina()
    {
        System.Console.WriteLine("Buzinando!!!");
    }


    #endregion
    }
}