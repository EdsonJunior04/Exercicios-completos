using System;

namespace Exercicio_1.classes
{
    public abstract class Elevador
    {
        protected int AndarAtual;

        protected int TotalAndares;

        protected int Capacidade;

        protected int PessoasPresentes;

        public void Inicializar()
        {
            AndarAtual = 0;
            PessoasPresentes = 0;

            bool isInt;
            do
            {
                Console.Write("Quantas pessoas cabem no elevador? ");
                string capacidade = Console.ReadLine();
                isInt = int.TryParse(capacidade, out Capacidade);
                if (isInt)
                {
                    Capacidade = int.Parse(capacidade);
                }
                else
                {
                    Console.WriteLine("Digite apenas números");
                }
            } while (!isInt);

            do
            {
                Console.Write("\nO prédio possui quantos andares? ");
                string AndaresStr = Console.ReadLine();
                isInt = int.TryParse(AndaresStr, out TotalAndares);
                if (isInt)
                {
                    TotalAndares = int.Parse(AndaresStr);
                }
                else
                {
                    Console.WriteLine("Digite apenas números");
                }
            } while (!isInt);

            Console.WriteLine($"\nO elevador está no {AndarAtual}º andar e com {PessoasPresentes} pessoas\n");
        }

        public void Entrar()
        {
            if (PessoasPresentes < Capacidade)
            {
                PessoasPresentes++;
                int sobra = Capacidade - PessoasPresentes;
                if (sobra > 0)
                {
                    switch (AndarAtual)
                    {
                        case 0:
                            Console.WriteLine($"\nUma pessoa entrou no elevador no terreo, ainda cabem {sobra} pessoas\n");
                            break;
                        default:
                            Console.WriteLine($"\nUma pessoa entrou no elevador no {AndarAtual}º andar, ainda cabem {sobra} pessoas\n");
                            break;
                    }
                }
                else { Console.WriteLine("\nO elevador atingiu a capacidade máxima"); }
            }
            else
            {
                Console.WriteLine("\nO elevador já atingiu a capacidade máxima.");
            }
        }

        public void Sair()
        {
            if (PessoasPresentes > 0)
            {
                PessoasPresentes--;

                switch (PessoasPresentes)
                {
                    case 0:
                        Console.WriteLine("\nA ultima pessoa saiu do elevador que agora está vazio");
                        break;
                    default:
                        switch (AndarAtual)
                        {
                            case 0:
                                Console.WriteLine($"\nUma pessoa saiu do elevador no terreo, ainda restam {PessoasPresentes} pessoas no elevador\n");
                                break;
                            default:
                                Console.WriteLine($"\nUma pessoa saiu do elevador no {AndarAtual}º andar, ainda restam {PessoasPresentes} pessoas no elevador\n");
                                break;
                        }
                        break;
                }

            }
            else { Console.WriteLine("\nO elevador já está vazio"); }
        }

        public void Subir()
        {
            if (AndarAtual < TotalAndares)
            {
                AndarAtual++;
                Console.WriteLine($"\nO elevador subiu para o {AndarAtual}º andar");
            }
            else
            {
                Console.WriteLine("\nO elevador já está no ultimo andar, só é possivel descer");
            }
        }

        public void Descer()
        {
            if (AndarAtual > 0)
            {
                AndarAtual--;
                switch (AndarAtual)
                {
                    case 0:
                        Console.WriteLine($"\nO elevador desceu para o terreo");
                        break;
                    default:
                        Console.WriteLine($"\nO elevador desceu para o {AndarAtual}º andar");
                        break;
                }
            }
            else
            {
                Console.WriteLine("\nO elevador já está no térreo");
            }
        }
    }
}