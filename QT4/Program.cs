/*-------------------------------------------------------------------
Questão 4: Sistema de Resgate em Labirinto
•
Contextualização: Em um jogo de exploração, o jogador precisa resgatar aliados perdidos em um labirinto. O sucesso do resgate depende da quantidade de energia, da distância até o aliado e do nível de ameaça no caminho.
•
Comando: Crie um programa que receba a energia do jogador, a distância até o aliado (em metros) e o nível de ameaça (baixo, médio, alto). Crie uma função que determine se o resgate é possível com base nas seguintes condições:
•
Energia maior que 50: Resgate bem-sucedido.
•
Distância menor que 20 metros: +10 de energia.
•
Nível de ameaça:
o
Baixo: Sem penalidade.
o
Médio: -10 de energia.
o
Alto: -20 de energia.
•
Exiba se o resgate foi bem-sucedido ou falhou.
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
        string? ameaca;
        double energia, aliado;

        Console.WriteLine("Qual a sua energia inicial? ");
        double.TryParse(Console.ReadLine(), out energia);

        Console.WriteLine("Qual sua distância até o aliado?");
        double.TryParse(Console.ReadLine(), out aliado);

        Console.WriteLine("Qual o nível de ameaça ");
        ameaca = Console.ReadLine();


        double total = Some( aliado, energia,ameaca);
        Console.ReadLine();

        Console.WriteLine("o seu ataque foi de: " + total);
    }
    static double Some(double aliado, double energia, string? ameaca)
    {

        double total = 0;
        if (ameaca == "baixo")
        {
            if(aliado<20)
            {
                total=energia+10;
                if(total>50)
                {
                Console.WriteLine("Resgate bem sucedido");
                }
                else
                {
                    Console.WriteLine("Resgate falhou");
                }
            }
             else 
            {
                   if(energia>50)
                {
                Console.WriteLine("Resgate bem sucedido");
                }
                else 
                {
                    Console.WriteLine("Resgate falhou");
                }
            }
           
        }

        else if (ameaca == "medio")
        {energia-=10;
             if(aliado<20)
            {
                total=energia+10;
                if(total>50)
                {
                Console.WriteLine("Resgate bem sucedido");
                }
                else
                {
                    Console.WriteLine("Resgate falhou");
                }
            }
             else 
            {
                   if(energia>50)
                {
                Console.WriteLine("Resgate bem sucedido");
                }
                else 
                {
                    Console.WriteLine("Resgate falhou");
                }
            }
        }

        else if (ameaca == "alto")
        {energia-=20;
             if(aliado<20)
            {
                total=energia+10;
                if(total>50)
                {
                Console.WriteLine("Resgate bem sucedido");
                }
                else 
                {
                    Console.WriteLine("Resgate falhou");
                }
            }
            else 
            {
                   if(energia>50)
                {
                Console.WriteLine("Resgate bem sucedido");
                }
                else 
                {
                    Console.WriteLine("Resgate falhou");
                }
            }
        }
        return total;
    }
}