using System;
class RepresentacaoDeCaracteres
{
    public void MetodoAtv2()
    {
        //crien um programa em C# que peça ao usuario inserir um caracter e exiba em 
        //seguida esse caractere de quatro encoding diferentes.

        //1. literal de caractere
        //2. unicode
        //3. Hexadecimal
        //4. Inteiro para char

        //Solicitar que o suario insira um caracter
        Console.Write("Digite um caractere: ");
        char caractere = Console.ReadKey().KeyChar;
        Console.WriteLine();

        //Converter o caracter conforme o enunciado
        string unicodeRepresentacao = $"\\u{(int)caractere:X4}";

        string hexadecimaRepresentacao = $"\\x{(int)caractere:X4}";

        int inteiroRepresentacao = (int)caractere;

        // exibir as representações
        Console.WriteLine($"Caractere litera:' {caractere}'");
        Console.WriteLine($"Caractere Unicode: '{unicodeRepresentacao}'");
        Console.WriteLine($"Caractere HexaDecimal: '{hexadecimaRepresentacao}'");
        Console.WriteLine($"Caractere Inteiro: '{inteiroRepresentacao}'");



    }
}