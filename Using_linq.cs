//LINQ : LANGUAGE INTEGRATED QUERY


using System;
using System.Linq;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        //criando uma lista de objetos genéricos de numeros inteiros
        //list<T> nome = new list<T>{};
        List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9};

        //filtrar numros impares, ordernar em ordem decrescente e multiplicar por 3
        var resultado = numeros
            .Where(n => n % 2 != 0) // e um numero impar
            .OrderByDescending(n => n) // ordena em ordem decrescente
            .Select(n => n * 3); // multiplica cada elemento por 3

        //exibindo o resultado
        Console.WriteLine("Resultado:");
        foreach ( var numero in resultado)
        {
            Console.WriteLine(numero);
        }
        //pular uma linha
        Console.WriteLine();

        //usando o LINQ para filtrar os números pares
        var numerosPares = numeros.Where(n => n % 2 == 0);

        //exibindo os números pares
        Console.WriteLine("Números pares:");
        foreach (var numero in numerosPares)
        {
            Console.WriteLine(numero);
        }



    } // fim do método Main
} // fim da classe Program


//Operadores LINQ
//Where: filtra os elementos de uma coleção com base em um predicado
//Select: projeta cada elemento de uma coleção em um novo formulário
//OrderBy: classifica os elementos de uma coleção em ordem crescente
//OrderByDescending: classifica os elementos de uma coleção em ordem decrescente
//GroupBy: agrupa os elementos de uma coleção com base em uma chave
//Join: combina duas coleções com base em uma chave
//Any: verifica se há elementos em uma coleção que correspondem a um predicado
//All: verifica se todos os elementos de uma coleção correspondem a um predicado
//Contains: verifica se uma coleção contém um determinado elemento
//Count: conta o número de elementos em uma coleção
//Sum: calcula a soma dos valores em uma coleção
//Average: calcula a média dos valores em uma coleção
//Max: retorna o valor máximo em uma coleção
//Min: retorna o valor mínimo em uma coleção
//First: retorna o primeiro elemento de uma coleção
//FirstOrDefault: retorna o primeiro elemento de uma coleção ou um valor padrão se a coleção estiver vazia
//Last: retorna o último elemento de uma coleção
//LastOrDefault: retorna o último elemento de uma coleção ou um valor padrão se a coleção estiver vazia
//Single: retorna o único elemento de uma coleção
//SingleOrDefault: retorna o único elemento de uma coleção ou um valor padrão se a coleção não contiver exatamente um elemento
//Skip: ignora os primeiros n elementos de uma coleção
//Take: retorna os primeiros n elementos de uma coleção
//SkipWhile: ignora os elementos de uma coleção até que um predicado retorne falso
//TakeWhile: retorna os elementos de uma coleção até que um predicado retorne falso
//Distinct: remove elementos duplicados de uma coleção
//Concat: combina duas coleções em uma única coleção
//Union: combina duas coleções em uma única coleção, removendo elementos duplicados
//Intersect: retorna os elementos que estão presentes em ambas as coleções
//Except: retorna os elementos que estão presentes em uma coleção, mas não em outra coleção
//Reverse: inverte a ordem dos elementos em uma coleção
//ElementAt: retorna o elemento em um índice específico em uma coleção
//ElementAtOrDefault: retorna o elemento em um índice específico em uma coleção ou um valor padrão se o índice estiver fora dos limites
//Range: gera uma sequência de números inteiros em um intervalo especificado
//Repeat: gera uma sequência de elementos repetidos um número especificado de vezes
//Empty: retorna uma coleção vazia de um tipo específico
//DefaultIfEmpty: retorna uma coleção padrão se a coleção estiver vazia
//Cast: converte os elementos de uma coleção para um tipo específico
//OfType: filtra os elementos de uma coleção com base em um tipo específico
//ToDictionary: cria um dicionário a partir de uma coleção
//ToLookup: cria um lookup a partir de uma coleção
//ToHashSet: cria um HashSet a partir de uma coleção
