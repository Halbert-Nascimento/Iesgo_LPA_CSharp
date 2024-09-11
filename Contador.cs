using System;

class Contador
{
    public void metodoContador()
    {
        Console.WriteLine("Contador: ");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{i}");
        }

    }
}