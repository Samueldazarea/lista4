/*-------------------------------------------------------------------
@Lista: 04 - Funções
Questão 3: Cálculo de Dano Crítico
* Contextualização: Em combates, o jogador pode realizar ataques críticos que causam
danos adicionais. O dano causado depende do ataque base, do multiplicador crítico e
da arma utilizada.
* Comando: Crie um programa que receba o valor do ataque base, o multiplicador crítico
(1.5x, 2x, 3x) e o tipo de arma (Espada, Arco, Cajado). Crie uma função que calcule o
dano crítico da seguinte forma:
* Espada: +10 pontos ao dano total.
* Arco: +5 pontos ao dano total.
* Cajado: +15 pontos ao dano total.
* Exiba o dano total causado pelo ataque crítico.
@Autor: Samuel Barbosa Chaves Brandão
@Data: 06/09/2024
---------------------------------------------------------------------*/
using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        Console.Clear();
        string? tipo;
        double ataque, critico;

        Console.WriteLine("Quanto foi o ataque base? ");
        double.TryParse(Console.ReadLine(), out ataque);

        Console.WriteLine("Qual o multiplicador crítico?");
        double.TryParse(Console.ReadLine(), out critico);

        Console.WriteLine("Qual o tipo de arma (espada, arco ou cajado)? ");
        tipo = Console.ReadLine();


        double total = Some( ataque, critico, tipo);
        Console.ReadLine();

        Console.WriteLine("o seu ataque foi de: " + total);
    }
    static double Some(double ataque, double critico, string? tipo)
    {

        double total = 0;
        if (tipo == "espada")
        {
            total = (critico * ataque) + 10;
            Console.WriteLine($"O dano critico foi de {total}");
        }

        else if (tipo == "arco")
        {
            total = (critico * ataque) + 5;
            Console.WriteLine($"O dano critico foi de {total}");
        }

        else if (tipo == "cajado")
        {
            total = (critico * ataque) + 15;
            Console.WriteLine($"O dano critico foi de {total}");
        }
        return total;
    }
} 