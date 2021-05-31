using System;

namespace Exercicio_1.classes
{
    public class ElevadorServico : Elevador
    {
        private int CaixasDentro;

        public void  AlteraCaixas() {
            bool isInt;
            int caixas;
            do
            {
                Console.WriteLine("Há quantas caixas no elevador? ");
                string caixasStr = Console.ReadLine();
                isInt = int.TryParse(caixasStr, out caixas);
                
                if (isInt) 
                {
                    caixas = int.Parse(caixasStr);
                    CaixasDentro = caixas;
                }
                else Console.WriteLine("Digite apenas números positivos");
            } while (!isInt && caixas >= 0); 
            Console.WriteLine($"\nHá {CaixasDentro} caixas dentro do elevador\n");  
        }
    }
}