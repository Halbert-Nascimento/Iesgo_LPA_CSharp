using System;
using System.Reflection;
namespace Aula28_08_2024
{
    public class Aula28_08_24
    {

        public void Menu()
        {
            

            bool runnig = true;
            while (runnig)
            {
                Console.WriteLine("Digite a opção desejada: ");
                Console.WriteLine($"1 para exibir um dog: \n2 para exibir um Cat: \n3 para exibir um Coelho!");
                Console.WriteLine($"4. para peixe nadando!");
                Console.WriteLine($"0. para SAIR!");
                string opc = Console.ReadLine();


                switch (opc)    
                {
                    case "0":
                        runnig = false;
                        break;

                    case "1":
                        Dog dog = new Dog();
                        Console.WriteLine(dog.GetDog());
                        break;

                    case "2":
                        Cat cat = new Cat();
                        Console.WriteLine(cat.GetCat());
                        break;

                    case "3":
                        Coelho coelho = new Coelho();
                        Console.WriteLine(coelho.GetCoelho());
                        break;

                    case "4":
                        Animacao animal = new Animacao();
                        animal.RunAnimacao();
                        break;


                    default:
                        Console.WriteLine("opção invalida!");
                        break;
                }

                if (runnig)
                {
                    Console.WriteLine("Cliqueem qualquer tecla pra volta ao menu...");
                    Console.ReadKey();
                    Console.Clear();   
                }


            }

          

        }

        public void DogAscii()
        {
            string dog = "  / \\__\r\n (    @\\___\r\n /         O\r\n/   (_____/\r\n/_____/ U\r\n";

            // usar o @ antes da string ela vira uma literal a aceita quebra de linhas e caracter especiais

            string dog2 = @"

  / \__
 (    @\___
 /         O
/   (_____/
/_____/ U

            

";

            Console.WriteLine(dog2);

        }

       
 
        


    }


}


