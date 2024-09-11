//Aluno: Halbert Nascimento

//Prof: Romes


using System;
using System.Drawing;
using System.Runtime.CompilerServices;

using Aula28_08_2024; // usado pois as classes stao dentro desse namespace

namespace Aula_14_08
{

    


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

    class Program
    {
        static void Main()
        {

            Par objTeste = new Par();
            //objTeste.MetodoPar();

            Tabuada objTabuada = new Tabuada();
            //objTabuada.MetodoTab();

            Contador objContador = new Contador();
            //objContador.metodoContador();

            MediaNotas objMediaNotas = new MediaNotas();
            //objMediaNotas.Metodo_mediaNotas();


            CalcularSalario atividade = new CalcularSalario();
            atividade.atv();

            RepresentacaoDeCaracteres atividade2 = new RepresentacaoDeCaracteres();
            //atividade2.MetodoAtv2();

            // Classe SecretariaEscolar esta em outro arquivo de classe SecretariaEscolar.cs
            SecretariaEscolar secretariaEscolar = new SecretariaEscolar();
            //secretariaEscolar.Turma();

            Aula28_08_24 aula28_08_24 = new Aula28_08_24();
            //aula28_08_24.Menu();


            //Fim foi ate o 10 do main
        }
    }


    //fim nameSpace aula
}