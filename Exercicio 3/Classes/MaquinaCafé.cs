using System;

namespace Exercicio_3.Classes
{
    public class MaquinaCafe
    {
        public double AcucarDisponivel;

        public void FazerCafe(double acucar) {
            if(AcucarDisponivel >= acucar) {
                Console.WriteLine($"Seu café será feito com {acucar} gramas de açucar");
                AcucarDisponivel -= acucar;
                Console.WriteLine("Seu café está pronto");
            }
            else {
                Console.WriteLine($"Ops... temos apenas {AcucarDisponivel} gramas de açucar disponível");
                
            }
        }

        public void FazerCafe() {
            if (AcucarDisponivel >= 10) {
                Console.WriteLine("\nSeu cafézinho ficará pronto em instantes. Será feito com 10 gramas de açucar.");
                AcucarDisponivel -= 10;
                Console.WriteLine("Seu café está pronto\n");
            } else if (AcucarDisponivel > 0 && AcucarDisponivel < 10){
                bool opcaoValida = true;
                do
                {
                    Console.WriteLine($"Tem apenas {AcucarDisponivel} gramas de açucar disponivel. Deseja fazer seu café com\n{AcucarDisponivel} gramas de açucar [1]\nSem Açucar [2]");
                    string opcao = Console.ReadLine();
                    switch (opcao)
                    {
                        case "1":
                            Console.WriteLine($"Seu café está pronto com {AcucarDisponivel} gramas de açucar");
                            AcucarDisponivel = 0;
                            break;
                        case "2":
                            Console.WriteLine("Seu café sem açucar está pronto");
                            break;
                        default:
                            Console.WriteLine("Opção inválida");
                            opcaoValida = false;
                            break;
                    } 
                } while (!opcaoValida);
            } else {
                bool opcaoValida = true;
                do
                {
                    Console.Write("Não há açucar disponivel, deseja um café sem açucar? (S/N) ");
                    string opcao = Console.ReadLine().ToLower().Substring(0,1);
                    switch (opcao)
                    {
                        case "s":
                            Console.WriteLine("O seu café sem açucar está pronto");
                            break;
                        case "n":
                            Console.WriteLine("Obrigado pela compreenção");
                            break;    
                        default:
                            Console.WriteLine("Opção invalida");
                            opcaoValida = false;
                            break;
                }
                } while (!opcaoValida);
                
            }
        }
    }
}