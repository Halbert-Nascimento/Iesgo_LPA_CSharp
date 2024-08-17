using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.Arm;

public class SecretariaEscolar
{
    static void calcularMediaDeNotas(List<decimal> notasPortugues, List<decimal> notasMatematica)
    {
        decimal somaNotaPorgues = 0;
        decimal somaMatematica = 0;
        foreach (int notaP in notasPortugues)
        {
            somaNotaPorgues += notaP;
        }
        foreach (int notaM in notasMatematica)
        {
            somaMatematica += notaM;
        }
        decimal mediaMatemtica = somaMatematica / notasMatematica.Count;
        decimal mediaPortugues = somaNotaPorgues / notasPortugues.Count;

        Console.Write($"A media das notas de PORTUGUES de todos os alunos e: {mediaPortugues}");
        Console.WriteLine();
        Console.Write($"A media das notas de MATEMATICA de todos os alunos e: {mediaMatemtica}");
        Console.WriteLine();

    }
    static string RepeatCaracterFim(string caracter, int vezes)
    {
        string repeticaoString = caracter;
        for (int i = 0; i < vezes; i++)
        {
            repeticaoString += caracter;

        }


        return repeticaoString += "\n\n";
    }

    static void FormatCorTitulo()
    {
        Console.ResetColor();
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;

    }
    static void ExibirDiferentesRepresentacoes(string texto)
    {
        FormatCorTitulo();
        Console.Write("Exibindo o nome do aluno em diferentes representações:");
        Console.ResetColor();
        Console.WriteLine(); // salta 1 linha

        //converte a string texto para um array de caracter
        char[] arr_char = texto.ToCharArray();

        //exibe os caracter de forma literal com tabulação
        Console.Write("{0,-20}", "Literal: ");
        for (int caracter = 0; caracter < arr_char.Length; caracter++)
        {
            Console.Write("{0,-10}", arr_char[caracter]);
        }
        Console.WriteLine(); // pular linha

        //exibir caracteres unicode com tabulação
        Console.Write("{0,-20}", "Unicode: ");
        for (int caracter = 0; caracter < arr_char.Length; caracter++)
        {
            string unicodeRepresentacao = $"\\u{(int)arr_char[caracter]:X4}";
            Console.Write("{0,-10}", unicodeRepresentacao);
        }
        Console.WriteLine(); // pular linha


        //exibe os caracter hexadecima com tabulação
        Console.Write("{0,-20}", "HexaDecimal: ");
        for (int caracter = 0; caracter < arr_char.Length; caracter++)
        {
            string hexadecimaRepresentacao = $"\\x{(int)arr_char[caracter]:X4}";
            Console.Write("{0,-10}", hexadecimaRepresentacao);
        }
        Console.WriteLine(); // pular linha

        // exibir caracter inteiro com tabulação
        Console.Write("{0,-20}", "Decimal: ");
        for (int caracter = 0; caracter < arr_char.Length; caracter++)
        {
            int inteiroRepresentacao = (int)arr_char[caracter];
            Console.Write("{0,-10}", inteiroRepresentacao);
        }
        Console.WriteLine(); // pular linha

    }

    static void ExibirSeFoiAprovado(decimal notaPortugues, decimal notaMatematica)
    {

        Console.BackgroundColor = notaPortugues >= 60 ? ConsoleColor.Green : ConsoleColor.Red;
        Console.Write(notaPortugues >= 60 ? "APROVADO EM PORTUGUES!" : "REPROVADO EM PORTUGUES!");
        Console.ResetColor();

        Console.WriteLine(); // salta 1 linha

        Console.BackgroundColor = notaMatematica >= 60 ? ConsoleColor.Green : ConsoleColor.Red;
        Console.Write(notaMatematica >= 60 ? "APROVADO EM MATEMATICA!" : "REPROVADO EM MATEMATICA!");
        Console.ResetColor();
        Console.WriteLine(); // salta 1 linha


    }
    static void ValidarBolsaEstudor(decimal notaPortugues, decimal notaMatematica)
    {
        Console.BackgroundColor = notaPortugues < 80 || notaMatematica < 80 ? ConsoleColor.Red : ConsoleColor.Green;
        Console.Write(notaPortugues < 80 || notaMatematica < 80 ? "Devido nota inferior a 80. O aluno perdeu a bolsa de estudos!" : "Aluno mantem a bolsa de estudos!");
        Console.ResetColor();
        Console.WriteLine(); // salta 1 linha


    }

    static void ExibirAlunos(List<string> nomes, List<int> idades, List<decimal> notasPortugues, List<decimal> notasMatematica, List<Boolean> bolsaEstudos)
    {

        Console.WriteLine(); //quebrar linha
        //formatar a cor do console
        Console.BackgroundColor = ConsoleColor.DarkYellow;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("\t\t\t ****** Alunos ******");
        Console.ResetColor(); // reseta a cor do console para original
        Console.WriteLine(); //quebrar linha

        for (int aluno = 0; aluno < nomes.Count; aluno++)
        {
            Console.WriteLine($"Aluno: {nomes[aluno]}, idade {idades[aluno]}, possui a nota {notasPortugues[aluno]} em portugues e {notasMatematica[aluno]} em matematica, ");

            ExibirSeFoiAprovado(notasPortugues[aluno], notasMatematica[aluno]);

            if (bolsaEstudos[aluno])
            {
                ValidarBolsaEstudor(notasPortugues[aluno], notasMatematica[aluno]);
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine("Não possui bolsa de estudos!");

            }

            ExibirDiferentesRepresentacoes(nomes[aluno]);


            Console.Write(RepeatCaracterFim("#", 50));
        }

        calcularMediaDeNotas(notasPortugues, notasMatematica);

        Console.Write(RepeatCaracterFim("_", 100));

    }

    public void Turma()
    {

        List<string> nomes = new List<string>();
        List<int> idades = new List<int>();
        List<decimal> notasPortugues = new List<decimal>();
        List<decimal> notasMatematica = new List<decimal>();
        List<Boolean> bolsaEstudos = new List<Boolean>();

        string sair = "";
        int cont = 0;
        while (sair != "f")
        {
            Console.Clear();
            Console.WriteLine($"Chamada numero: {cont}");

            Console.Write($"Digite o nome do aluno: ");

            string nome = Console.ReadLine();


            Console.Write($"Digite a idade de {nome}: ");
            int idade = Convert.ToInt32(Console.ReadLine());

            Console.Write($"Digite a nota de PORTUGUES do aluno {nome}: ");
            decimal notaPortugues = Convert.ToDecimal(Console.ReadLine());

            Console.Write($"Digite a nota de MATEMATICA do aluno {nome}: ");
            decimal notaMatematica = Convert.ToDecimal(Console.ReadLine());

            Console.Write($"{nome} possui bolsa de estudos? sim/nao ");
            string bolsaEstudo = Console.ReadLine().ToLower();
            Boolean bolsa_estudo_bool = (bolsaEstudo == "sim") ? true : false;

            nomes.Add(nome);
            idades.Add(idade);
            notasPortugues.Add(notaPortugues);
            notasMatematica.Add(notaMatematica);
            bolsaEstudos.Add(bolsa_estudo_bool);

            Console.WriteLine("Cadastrar novo aluno? ");
            FormatCorTitulo();
            Console.Write("   Pressione qualquer tecla p continuar ou 'F' para finalizar: ");
            Console.ResetColor();
            cont++;
            sair = Console.ReadLine().ToLower();

        }
        Console.Clear();
        ExibirAlunos(
            nomes, idades, notasPortugues, notasMatematica, bolsaEstudos
            );

    }
}