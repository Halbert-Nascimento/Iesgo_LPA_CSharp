using System;

class MediaNotas
{
    public void Metodo_mediaNotas()
    {
        double[] notas = new double[3];
        double somaM = 0;

        for (int i = 0; i < notas.Length; i++)
        {
            Console.Write($"Digite a nota {1}: ");
            notas[i] = Convert.ToInt32(Console.ReadLine());
            somaM += notas[i];
        }
        Console.WriteLine($"A media das notas e: {somaM / notas.Length} ");

    }
}