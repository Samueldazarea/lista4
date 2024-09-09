/*-------------------------------------------------------------------
Questão 1: Sistema de Cura de Personagem
• Contextualização: Em um jogo de RPG, o jogador pode usar poções de cura para
recuperar a vida do seu personagem durante a batalha. A quantidade de vida
recuperada depende do tipo de poção, do nível do personagem e da quantidade de
poções usadas.
• Comando: Crie um programa que receba o tipo de poção (Pequena, Média, Grande), o
nível do personagem e a quantidade de poções usadas. Crie uma função que calcule a
quantidade de vida recuperada com base nos seguintes critérios:
• Poção Pequena: 10 pontos de vida por poção.
• Poção Média: 20 pontos de vida por poção.
• Poção Grande: 30 pontos de vida por poção.
• Adicione 5 pontos adicionais para cada nível do personagem acima de 5.
• Exiba o total de vida recuperada.
@Lista: 04 - Condicionais
@Autor: Eduardo Gomes de Sena
@Data: 03/09/2024
---------------------------------------------------------------------*/
/*-------------------------------------------------------------------
@Lista: 04 - Funções
Questão 1: Sistema de Cura de Personagem
* Contextualização: Em um jogo de RPG, o jogador pode usar poções de cura para
recuperar a vida do seu personagem durante a batalha. A quantidade de vida
recuperada depende do tipo de poção, do nível do personagem e da quantidade de
poções usadas.
* Comando: Crie um programa que receba o tipo de poção (Pequena, Média, Grande), o
nível do personagem e a quantidade de poções usadas. Crie uma função que calcule a
quantidade de vida recuperada com base nos seguintes critérios:
* Poção Pequena: 10 pontos de vida por poção.
* Poção Média: 20 pontos de vida por poção.
* Poção Grande: 30 pontos de vida por poção.
* Adicione 5 pontos adicionais para cada nível do personagem acima de 5.
* Exiba o total de vida recuperada.
@Autor: Samuel Barbosa Chaves Brandão
@Data: 05/09/2024
---------------------------------------------------------------------*/
using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        string? tipo;
        int nivel , quant ;
        Console.ReadLine();
        Console.WriteLine("Qual o tipo da poção?");
        tipo = Console.ReadLine();
        Console.WriteLine("Qual o nível do seu personagem?");
        int.TryParse(Console.ReadLine(), out nivel);
        Console.WriteLine("Quantidade de poções usadas?");
        int.TryParse(Console.ReadLine(), out quant);
        int total = Some(nivel, quant, tipo);
        Console.WriteLine($"Você curou {total} pontos");
        Console.ReadLine();

    }
    static int Some(int nivel, int quant, string? tipo)
    {
        int total1=0, total2=0;
        if (nivel > 5)
        {

            total1 = (nivel - 5) * 5;

            if (tipo == "pequeno")
            {
                total2 = (quant * 10) + total1;
                Console.WriteLine($"Você curou {total2} pontos");

            }
            else if (tipo == "medio")
            {
                total2 = (quant * 20) + total1;
                Console.WriteLine($"Você curou {total2} pontos");

            }
            else if (tipo == "grande")
            {
                total2 = (quant * 30) + total1;
                Console.WriteLine($"Você curou {total2} pontos");

            }
        }
            return total2;  
    }
}