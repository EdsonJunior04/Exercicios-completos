using System;
using Exercicio_2.Classes;

namespace Exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            JogadorAtaque jogador1= new JogadorAtaque();

            bool isDouble = false;
            int anoAtual = DateTime.Now.Year;
            do 
            {
                Console.Write("Qual o nome do jogador? ");
                string nome = Console.ReadLine();
                double check;
                isDouble = double.TryParse(nome, out check);
                if (!isDouble && nome != "") {
                    jogador1.Nome = nome.ToUpper().Trim();
                } else
                {
                    Console.WriteLine("\nNome invalido\nInsira pelo menos 1 letra\n");
                    isDouble = true; 
                }
            } while (isDouble);


            bool isInt = true;
            do 
            {
                Console.Write("\nQual o ano de nascimento do jogador? ");
                string anoStr = Console.ReadLine();
                isInt = int.TryParse(anoStr, out jogador1.AnoNascimento);
                if (isInt) {
                    jogador1.AnoNascimento = int.Parse(anoStr);
                    if (jogador1.AnoNascimento < 1930 || jogador1.AnoNascimento > anoAtual)
                    {
                        Console.WriteLine("\nAno de nascimento invalido");
                        isInt = false; 
                    }
                } else {
                    Console.WriteLine("\nAno de nascimento invalido");
                    Console.WriteLine("Digite apenas números");
                }
            } while (!isInt);


            do 
            {
                Console.Write("\nQual a altura do jogador? ");
                string alturaStr = Console.ReadLine();
                isDouble = double.TryParse(alturaStr, out jogador1.Altura);
                if (isDouble && alturaStr != "") {
                    jogador1.Altura = double.Parse(alturaStr);
                    if (jogador1.Altura > 2.5)
                    {
                        Console.WriteLine("\nAltura Invalida");
                        isDouble = false;
                    }
                } else {
                    Console.WriteLine("\nAltura invalida\nDigite apenas números");
                }
            } while (!isDouble);


            do 
            {
                Console.Write("\nQual a naturalidade do jogador? ");
                string naturalidade = Console.ReadLine();
                double check;
                isDouble = double.TryParse(naturalidade, out check);
                if (isDouble || naturalidade == "") {
                    Console.WriteLine("\nNaturalidade invalida");
                    isDouble = true; 
                } else {
                    jogador1.Naturalidade = naturalidade.ToUpper().Trim();
                }
            } while (isDouble);

            isDouble = true; 
            do 
            {
                Console.Write("\nQual o peso do jogador? ");
                string pesoStr = Console.ReadLine();
                isDouble = double.TryParse(pesoStr, out jogador1.Peso);
                if (isDouble && pesoStr != "") {
                    jogador1.Peso = double.Parse(pesoStr);
                } else {
                    Console.WriteLine("\nPeso invalido");
                }
            } while (!isDouble);


            jogador1.Dados();
            Console.WriteLine(jogador1.Aposentar());
        }
    }
}
