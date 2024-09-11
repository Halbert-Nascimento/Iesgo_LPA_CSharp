using System;

public class CalcularSalario
{
    public void atv()
    {
        //Você vai criar um programa que calcula o salário de um 
        //funcionário com base nas horas trabalhadas, na taxa de 
        //pagamento por hora e no valor das comissões.O programa 
        //deve usar diferentes tipos de dados para armazenar as 
        //informações e realizar as operações necessárias.
        //1.Solicite ao usuário para inserir o nome do funcionário(string).
        //2.Solicite ao usuário para inserir as horas trabalhadas na semana(int).
        //3.Solicite ao usuário para inserir a taxa de pagamento por hora(double).
        //4.Solicite ao usuário para inserir o valor das comissões recebidas na semana(decimal).
        //5.Calcule o salário bruto(horas trabalhadas multiplicadas pela taxa de pagamento) e adicione as comissões.
        //6.Exiba o nome do funcionário e o salário total(decimal) no final.

        //1 - 1.Solicite ao usuário para inserir o nome do funcionário(string).
        Console.Write("Digite o nome do funcionario: ");
        String nomeFuncionario = Console.ReadLine();

        //2 - 2.Solicite ao usuário para inserir as horas trabalhadas na semana(int).
        Console.Write("Informe as horas trabalhadas: ");
        int horasTrabalhadas = Convert.ToInt32(Console.ReadLine());

        // 3 - Solicite ao usuário para inserir a taxa de pagamento por hora(double)
        Console.Write("Informe a taxa de pagamento hora: ");
        double taxaPagamento = Convert.ToDouble(Console.ReadLine());

        // 4 - Solicite ao usuário para inserir o valor das comissões recebidas na semana(decimal).
        Console.Write("Informe o valor das comisssoes recebina na semana: ");
        decimal comissao = Convert.ToDecimal(Console.ReadLine());

        //5 - Calcule o salário bruto(horas trabalhadas multiplicadas pela taxa de pagamento) e adicione as comissões.
        decimal salarioBruto = (decimal)(horasTrabalhadas * taxaPagamento) + comissao;

        //6 - Exiba o nome do funcionário e o salário total(decimal) no final.
        Console.WriteLine($"{nomeFuncionario} seu salario e: {salarioBruto}");


    }
}