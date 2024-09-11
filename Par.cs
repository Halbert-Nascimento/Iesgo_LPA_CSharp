using System;

public class Par
{
    public void MetodoPar()
    {
        Console.Write("Digite um numero: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite + um numero: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        int soma = num1 + num2;

        Console.WriteLine("A soma dos numero é: " + soma);

        //usando if e else
        if (soma % 2 == 0)
        {
            Console.WriteLine("A soma dos numeros e par");
        }
        else
        {
            Console.WriteLine("A soma dos numeros e Impar");
        }
    }
}