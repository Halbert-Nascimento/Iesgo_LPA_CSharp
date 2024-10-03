///*
//A IESGO tem diferentes veículos (Carros, Motos e Caminhões)
//cada um tem suas características/comportamentos
//Todos têm: Marca, Modelo, Velocidade Máxima.
//Cada um tem um comportamento para consumo de combustível

//Classe Base Veiculo:
//	•	Atributos:
//    	•   Marca (string)
//    	•	Modelo (string)
//    	•	VelocidadeMaxima (double)
//	•	Métodos:
//    	•	CalcularConsumo(): Deve ser um método virtual que será sobrescrito nas classes derivadas.
//    	•	ExibirInformacoes(): Método que exibe as informações do veículo e o consumo de combustível 
//            (esse método será sobrescrito nas classes derivadas).
    	
//    •	Classe Carro:
//    	•	Sobrescrever o método CalcularConsumo(), onde o consumo é calculado como: 12 km/l de combustível.
//    	•	Sobrescrever o método ExibirInformacoes().
//	•	Classe Moto:
//    	•	Sobrescrever o método CalcularConsumo(), onde o consumo é calculado como: 40 km/l.
//    	•	Sobrescrever o método ExibirInformacoes().
//	•	Classe Caminhao:
//    	•	Sobrescrever o método CalcularConsumo(), onde o consumo é calculado como: 8 km/l.
//    	•	Sobrescrever o método ExibirInformacoes().
    	
// Encapsulamento: Os atributos da classe base devem ser privados e acessados via propriedades públicas.
// Polimorfismo: o método Main(), crie uma lista de veículos (Carros, Motos e Caminhões) e exiba as informações de cada um, utilizando o 
//polimorfismo para chamar o método ExibirInformacoes() da maneira apropriada.
//*/

//using System;
//using System.Collections.Generic;

//public class Veiculo
//{
//    private string marca { get; set; }
//    private string modelo { get; set; }
//    private double velocidadeMaxima { get; set; }

//    //criando propriedades públicas para acessar os atributos privados
//    public string Marca
//    {
//        get { return marca; }
//        set { marca = value; }

//    }
//    public string Modelo
//    {
//        get { return modelo; }
//        set { modelo = value; }

//    }
//    public double VelocidadeMaxima
//    {
//        get { return velocidadeMaxima; }
//        set { velocidadeMaxima = value; }

//    }

//    //metodo para calcular o consumo de combustivel
//    public virtual double CalcularConsumo()
//    {
//        return 0; // base genérica
//    }

//    //metodo para exibir informacoes do veiculo
//    public virtual void ExibirInformacoes()
//    {
//        Console.WriteLine($"Marca: {Marca}");
//        Console.WriteLine($"Modelo: {Modelo}");
//        Console.WriteLine($"Velocidade Máxima: {VelocidadeMaxima} km/h");
//        //Console.WriteLine($"Consumo de Combustível: {CalcularConsumo()} km/l");
//    }
//}

//public class Carro : Veiculo
//{
//    public override double CalcularConsumo()
//    {
//        return 12;
//    }

//    public override void ExibirInformacoes()
//    {
//        Console.WriteLine("Carro:");
//        base.ExibirInformacoes();
//        Console.WriteLine($"Consumo de Combustível do carro: {CalcularConsumo()} km/l");

//    }

    
//}

//public class Moto : Veiculo
//{
//    public override double CalcularConsumo()
//    {
//        return 40;
//    }

//    public override void ExibirInformacoes()
//    {
//        Console.WriteLine("Moto:");
//        base.ExibirInformacoes();
//        Console.WriteLine($"Consumo de Combustível da moto: {CalcularConsumo()} km/l");
//    }
//}

//public class Caminhao : Veiculo
//{
//    public override double CalcularConsumo()
//    {
//        return 8;
//    }

//    public override void ExibirInformacoes()
//    {
//        Console.WriteLine("Caminhão:");
//        base.ExibirInformacoes();
//        Console.WriteLine($"Consumo de Combustível do caminhão: {CalcularConsumo()} km/l");
//    }
//}

////Polimorfismo: o método Main(), crie uma lista de veículos (Carros, Motos e Caminhões) e
////exiba as informações de cada um, utilizando o 
////polimorfismo para chamar o método ExibirInformacoes() da maneira apropriada.
//public class Program
//{
//    static void Main(string[] args)
//    {
//        //criando uma lista de veiculos
//        Veiculo[] veiculos = new Veiculo[3];

//        //instanciando os veiculos
//        veiculos[0] = new Carro();
//        veiculos[0].Marca = "Chevrolet";
//        veiculos[0].Modelo = "Onix";
//        veiculos[0].VelocidadeMaxima = 180;

//        veiculos[1] = new Moto();
//        veiculos[1].Marca = "Honda";
//        veiculos[1].Modelo = "CG 160";
//        veiculos[1].VelocidadeMaxima = 120;

//        veiculos[2] = new Caminhao();
//        veiculos[2].Marca = "Volvo";
//        veiculos[2].Modelo = "FH 540";
//        veiculos[2].VelocidadeMaxima = 100;

//        //exibindo as informacoes dos veiculos
//        foreach (Veiculo veiculo in veiculos)
//        {
//            veiculo.ExibirInformacoes();
//            Console.WriteLine();
//        }

//        //outra forma usando lista generica
//        //lista de veiculos list<T>
//        List<Veiculo> veiculos_List = new List<Veiculo>();

//        //adicionando os veiculos na lista
//        veiculos_List.Add(new Carro { Marca = "Chevrolet", Modelo = "Onix", VelocidadeMaxima = 180 });
//        veiculos_List.Add(new Moto { Marca = "Honda", Modelo = "CG 160", VelocidadeMaxima = 120 });
//        veiculos_List.Add(new Caminhao { Marca = "Volvo", Modelo = "FH 540", VelocidadeMaxima = 100 });

//        //exibindo as informacoes dos veiculos
//        Console.WriteLine("Exibindo as informações dos veículos da lista:");
//        foreach (Veiculo veiculo in veiculos_List)
//        {
//            veiculo.ExibirInformacoes();
//            Console.WriteLine();
//        }



//    }
//}
