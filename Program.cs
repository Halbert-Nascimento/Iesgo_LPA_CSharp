//Aula 14/08/2024

//Aluno: Halbert Nascimento

//Prof: Romes


using System;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace Aula_14_08
{

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

    public class Atv_in_Aula
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


            Atv_in_Aula atividade = new Atv_in_Aula();
            //atividade.atv();

            RepresentacaoDeCaracteres atividade2 = new RepresentacaoDeCaracteres();
            //atividade2.MetodoAtv2();

            // Classe SecretariaEscolar esta em outro arquivo de classe SecretariaEscolar.cs
            SecretariaEscolar secretariaEscolar = new SecretariaEscolar();
            secretariaEscolar.Turma();


            //Fim foi ate o 10 do main
        }
    }


    //fim nameSpace aula
}