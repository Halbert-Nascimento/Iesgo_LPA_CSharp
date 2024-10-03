////Aluno: Halbert Nascimento

////Prof: Romes



//using System;



//namespace Prova
//{
//    public class Operacoes
//    {
//        public int Somar(int a, int b)
//        {
//            return a + b;
//        }

//        public int Subtrair(int a, int b)
//        {
//            return a - b;
//        }

//        public int Multiplicar(int a, int b)
//        {
//            return a * b;
//        }

//        public double Dividir(int a, int b)
//        {
//            if (b == 0)
//                throw new DivideByZeroException("Não é possível dividir por zero.");

//            return (double)a / b;
//        }
//    }






//    public class Calculadora
//    {
//        public static void Main(string[] args)
//        {
//            Operacoes operacoes = new Operacoes();
//            bool continuar = true;

//            while (continuar)
//            {
//                Console.Clear();
//                Console.WriteLine("Escolha uma operação:");
//                Console.WriteLine("1. Soma");
//                Console.WriteLine("2. Subtração");
//                Console.WriteLine("3. Multiplicação");
//                Console.WriteLine("4. Divisão");
//                Console.WriteLine("5. Sair");

//                int escolha = Convert.ToInt32(Console.ReadLine());

//                if (escolha == 5)
//                {
//                    continuar = false;
//                    break;
//                }

//                Console.WriteLine("Informe o primeiro número:");
//                int num1 = Convert.ToInt32(Console.ReadLine());

//                Console.WriteLine("Informe o segundo número:");
//                int num2 = Convert.ToInt32(Console.ReadLine());

               
                
//                    switch (escolha)
//                    {
//                        case 1:
//                            Console.WriteLine($"Resultado: {operacoes.Somar(num1, num2)}");
//                            //pausar ate o usuario teclar uma tecla
//                            Console.ReadKey();
//                            break;
//                        case 2:
//                            Console.WriteLine($"Resultado: {operacoes.Subtrair(num1, num2)}");
//                            Console.ReadKey();
//                            break;
//                        case 3:
//                            Console.WriteLine($"Resultado: {operacoes.Multiplicar(num1, num2)}");
//                            Console.ReadKey();
//                            break;
//                        case 4:
//                            Console.WriteLine($"Resultado: {operacoes.Dividir(num1, num2)}");
//                            Console.ReadKey();
//                            break;
//                        default:
//                            Console.WriteLine("Opção inválida!");
//                            Console.ReadKey();
//                            break;
//                    }
                
                

//                Console.WriteLine();
//            }
//        }
//    }
//}//fim namespace Prova