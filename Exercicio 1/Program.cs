using System;
using Exercicio_1.classes;

namespace Exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ElevadorSocial elevador1 = new ElevadorSocial();
            ElevadorServico elevador2 = new ElevadorServico();

            int opcao = 1;
            while (opcao != 0)
            {
                bool isInt = true;

                do
                {
                    Console.WriteLine("\nO que você deseja fazer?\n");
                    Console.Write("Inicializar [1]\nFechar [0]\n-> ");
                    string opcaoStr = Console.ReadLine();
                    isInt = int.TryParse(opcaoStr, out opcao);
                    if (isInt)
                    {
                        opcao = int.Parse(opcaoStr);
                    }
                    else
                    {
                        Console.WriteLine("Digite apenas números\n");
                        isInt = false;
                    }
                } while (!isInt);

                if (opcao == 1)
                {
                    bool opcaoValida = true;
                    do
                    {
                        Console.Write("\nElevador Social [1]\nElevador de serviço [2]\n-> ");
                        string opcaoElevador = Console.ReadLine();
                        if (opcaoElevador == "1")
                        {
                            elevador1.Inicializar();
                            string acaoElevador = "";
                            while (acaoElevador != "0")
                            {
                                Console.WriteLine("\nO que você deseja fazer?");
                                Console.WriteLine("Subir [1]\nDescer [2]\nEntrar no elevador [3]\nSair do elevador [4]");
                                Console.WriteLine("Fechar [0]");
                                acaoElevador = Console.ReadLine();
                                switch (acaoElevador)
                                {
                                    case "1":
                                        elevador1.Subir();
                                        break;
                                    case "2":
                                        elevador1.Descer();
                                        break;
                                    case "3":
                                        elevador1.Entrar();
                                        break;
                                    case "4":
                                        elevador1.Sair();
                                        break;
                                    case "0":
                                        Console.WriteLine("Você saiu fechou o sistema desse elevador");
                                        opcaoValida = true;
                                        break;
                                    default:
                                        Console.WriteLine("\nOpção invalida.");
                                        break;
                                }

                            }
                        }
                        else if (opcaoElevador == "2")
                        {
                            elevador2.Inicializar();
                            string acaoElevador2 = "";
                            while (acaoElevador2 != "0")
                            {
                                Console.WriteLine("O que você deseja fazer?");
                                Console.WriteLine("Subir [1]\nDescer [2]\nEntrar no elevador [3]\nSair do elevador [4]\nAlterar número de caixas [5]");
                                Console.WriteLine("Fechar [0]");
                                acaoElevador2 = Console.ReadLine();
                                switch (acaoElevador2)
                                {
                                    case "1":
                                        elevador2.Subir();
                                        break;
                                    case "2":
                                        elevador2.Descer();
                                        break;
                                    case "3":
                                        elevador2.Entrar();
                                        break;
                                    case "4":
                                        elevador2.Sair();
                                        break;
                                    case "5":
                                        elevador2.AlteraCaixas();
                                        break;
                                    case "0":
                                        Console.WriteLine("Você saiu fechou o sistema desse elevador");
                                        opcaoValida = true;
                                        break;
                                    default:
                                        Console.WriteLine("\nOpção invalida.");
                                        break;
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Opção invalida");
                            opcaoValida = false;
                        }
                    } while (!opcaoValida);
                }
            }
            Console.WriteLine("Obrigado por usar nosso sistema");
        }
    }
}
