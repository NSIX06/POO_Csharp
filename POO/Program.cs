// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//?Classe Carro
 //* Criação sem Parâmnetros 

var carro= new Carro();
carro.Ano = 2023;
carro.Cor = "Vermelho";
carro.Modelo = "Esporte";

System.Console.WriteLine();


 //* Criação com Parâmnetros 
var carro1 = new Carro("Azul", "Eco", 2023);

System.Console.WriteLine();


//*Criando com inicialização e parâmetros
var carro2 = new Carro{

    Cor = "Verde",
    Modelo = "4x4",
    Ano = 2023
};

System.Console.WriteLine();

//*Chamando o método
carro1.LigarCarro();

carro2.LigarBuzina();

//?

//?Classe Pessoa 

//var pessoa = new Pessoa();
//pessoa.Nome = "Felipe";
//pessoa.SobreNome = "Bugalho";

//System.Console.WriteLine(pessoa.NomeCompleto);


//?Classe Motorista com a herença da classe Pessoa

var motorista = new Motorista(32);
motorista.SobreNome = "Pablo";
motorista.AdicionarNome("Escobar");



    
}
