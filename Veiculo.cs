//using System;

//public class Veiculo
//{
//    //dentro da classe pode colocar os atributos
//    private string Cor { get; set; }
//    private string Marca { get; set; }
//    private string Modelo { get; set; }
//    public int Ano { get; private set; }

//    //construtor
//    public Veiculo(string cor, string marca, string modelo, int ano)
//    {
//        Cor = cor;
//        Marca = marca;
//        Modelo = modelo;
//        Ano = ano;
//    }

//    //metodos da classe
//    //metodos para acelerar o veiculo
//    public virtual void Acelerar()
//    {
//        Console.WriteLine("Acelerando o veiculo...");
//    }

//    //metodos para frear o veiculo
//    public virtual void Frear()
//    {
//        Console.WriteLine("Freando o veiculo...");
//    }

//    //metodos para exibir informacoes do veiculo
//    public virtual void MostrarInfor()
//    {
//        Console.WriteLine($"Cor: {Cor}");
//        Console.WriteLine($"Marca: {Marca}");
//        Console.WriteLine($"Modelo: {Modelo}");
//        Console.WriteLine($"Ano: {Ano}");

//    }

//}

//public class Carro : Veiculo
//{
//    //numeros de portas
//    public int NumPortas { get; private set; }

//    //comstrutor da classe
//    public Carro(string cor, string marca, string modelo, int ano, int numPortas) : base(cor, marca, modelo, ano)
//    {
//        NumPortas = numPortas;

//    }

//    //metodo abrir portas
//    public void AbrirPortas()
//    {
//        Console.WriteLine($"Abrindo as {NumPortas} portas do carro...");
//    }

//    //mostrar informacoes do carro
//    public override void MostrarInfor()
//    {
//        base.MostrarInfor();
//        Console.WriteLine($"Numero de portas: {NumPortas}");
//    }

//}

////criar classe moto
//public class Moto : Veiculo
//{
//    //cilindradas
//    public int Cilindradas { get; private set; }

//    //construtor da classe
//    public Moto(string cor, string marca, string modelo, int ano, int cilindradas) : base(cor, marca, modelo, ano)
//    {
//        Cilindradas = cilindradas;
//    }

//    //metodo ligar a moto
//    public void DarGrau()
//    {
//        Console.WriteLine("Dando grau com a moto...");
//    }

//    //mostrar informacoes da moto
//    public override void MostrarInfor()
//    {
//        base.MostrarInfor();
//        Console.WriteLine($"Cilindradas: {Cilindradas}");
//    }

//}

