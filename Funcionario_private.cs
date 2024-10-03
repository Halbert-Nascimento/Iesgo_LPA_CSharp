//// Herança, Encapsulamento e Polimorfismo em C#
//// Criar um Sistema de Gerenciamento de Funcionários

///*

//Desenvolva um sistema que permita gerenciar diferentes tipos de funcionários em uma empresa. 
//A empresa tem funcionários que podem ser Funcionários Comuns, Gerentes ou Diretores; 
//cada um com características e comportamentos específicos

//*/

//// protegendo os dados com encapsulamento

//using System;

//public class Funcionario
//{
//    private string nome { get; set; }
//    private double salario { get; set; }

//    //criando propriedades públicas para acessar os atributos privados
//    public string Nome
//    {
//        get { return nome; }
//        set { nome = value; }
//    }

//    public double Salario
//    {
//        get { return salario; }
//        set {
//            //criando uma regra para o salário
//            if ( value > 0)
//            {
//            salario = value; 
                
//            }
//        }
//    }

//    public virtual double CalcularSalario()
//    {
//        return Salario;
//    }

//    public virtual void ExibirInformacoes()
//    {
//        Console.WriteLine($"Nome: {Nome}, Salário: {CalcularSalario():C}"); // :C formata para moeda

//    }
//}


//public class Gerente : Funcionario
//{
//    public override double CalcularSalario()
//    {
//        return Salario + 2000;
//    }
//    public override void ExibirInformacoes()
//    {
//        Console.WriteLine($"Gerente - Nome : {Nome}, Salário: {CalcularSalario():C}"); // :C formata para moeda

//    }
//}

//public class Diretor : Funcionario
//{
//    public override double CalcularSalario()
//    {
//        return Salario + 5000;
//    }
//    public override void ExibirInformacoes()
//    {
//        Console.WriteLine($"Diretor - Nome : {Nome}, Salário: {CalcularSalario():C}"); // :C e um especificador de formato que formata um valor como uma moeda
//                                                                                       // :F (fixo-point) é um especificador de formato que formata um valor como um número de ponto fixo. ex: valor:F3 (3 casas decimais) - 1.456
//                                                                                       // :N (separa de milhar) é um especificador de formato que formata um valor com separadores de milhar. ex: valor:N2 - 1,456.00
//                                                                                       // :E (exponencial) é um especificador de formato que formata um valor em notação científica. ex: valor:E2 - 1.46E+3
//                                                                                       // :P (porcentagem) é um especificador de formato que formata um valor como uma porcentagem. ex: valor:P2 - 145.60%
//                                                                                       // :D (decimal) é um especificador de formato que formata um valor como um número inteiro. ex: valor:D2 - 145

//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Funcionario f1 = new Funcionario();
//        f1.Nome = "João";
//        f1.Salario = 2000;
//        //f1.ExibirInformacoes();

//        Funcionario f2 = new Funcionario { Nome = "Maria", Salario = 3000 }; // outra forma de instanciar um objeto

//        Gerente g1 = new Gerente();
//        g1.Nome = "Maria";
//        g1.Salario = 5000;
//        // g1.ExibirInformacoes();

//        Diretor d1 = new Diretor();
//        d1.Nome = "José";
//        d1.Salario = 10000;
//        //d1.ExibirInformacoes();

//        // exibir info dos funcionários
//        Console.WriteLine("Informações dos Colaboradores ");
//        Console.WriteLine("-------------------------------");
//        f1.ExibirInformacoes();
//        f2.ExibirInformacoes();
//        g1.ExibirInformacoes();
//        d1.ExibirInformacoes();


//        Console.WriteLine("\n Pressione qualquer tecla para sair...");
//        Console.ReadKey();
//    }
//}