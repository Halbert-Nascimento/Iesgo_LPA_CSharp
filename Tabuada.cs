using System;

public class Tabuada
{
    public void MetodoTab()
    {

        Console.Write("Digite um numero para tabuada: ");
        int tab = Convert.ToInt32(Console.ReadLine());

        //usando for loop
        for (int i = 0; i <= 10; i++)
        {
            Console.WriteLine($"Tabuada de  {tab} X {i} = {tab * i}");
        }

    }
}
