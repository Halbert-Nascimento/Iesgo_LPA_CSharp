//using System;

//namespace prova
//{


//    public class fatorioal
//    {
//        public static void Main(string[] args)
//        {
//            Console.Write("Digite seu primeiro nome: ");
//            string nome = Console.ReadLine();
//            int numeroDeLetrasDoNome = nome.Length;
//            bool entradaValida = false;

//            while (!entradaValida) // permitir que o usuário tente novamente.
//            {
//                Console.WriteLine("Digite um número inteiro positivo:");
//                string entrada = Console.ReadLine();
//                int numero;


//                //-> Verifique se o número inserido é um número inteiro positivo.
//                if (int.TryParse(entrada, out numero) && numero >= 0)//verifica se a entrada é um número inteiro positivo caso sim manda o numero convertido na saida
//                {
//                    entradaValida = true; // Se a entrada for válida, sair do loop

//                    if (numero == numeroDeLetrasDoNome)
//                    {
//                        // Caso o usuário insira um número que seja igual ao
//                        // número de letras do seu primeiro nome, exiba no lugar
//                        // do resultado o seu nome no terminal. 
//                        Console.WriteLine($"{nome} O Numero digitado e igual a quantidade de letras do seu nome");
//                    }
//                    else
//                    {
//                        //-> Calcule o fatorial do número inserido.Exiba o resultado do cálculo do fatorial.
//                        long fatorial = CalcularFatorial(numero);
//                        Console.WriteLine($"O fatorial de {numero} é {fatorial}");
//                    }
//                }
//                else
//                {
//                    //Caso o usuário insira um valor inválido
//                    //(como um número negativo ou uma entrada que não seja um número),
//                    //o programa deve exibir uma mensagem de erro apropriada e permitir
//                    //que o usuário tente novamente.
//                    Console.WriteLine("Entrada inválida. Por favor, insira um número inteiro positivo.");
//                }
//            }
//        }
//        //-> Calcule o fatorial do número inserido.Exiba o resultado do cálculo do fatorial.
//        public static long CalcularFatorial(int numero)
//        {
//            if (numero == 0 || numero == 1)
//            {
//                return 1;
//            }

//            long resultado = 1;
//            for (int i = 2; i <= numero; i++)
//            {
//                resultado *= i;
//            }

//            return resultado;
//        }
//    }
//}