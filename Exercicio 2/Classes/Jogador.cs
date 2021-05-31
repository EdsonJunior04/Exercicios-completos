using System;

namespace Exercicio_2.Classes
{
    public abstract class Jogador
    {
        public string Nome;
        public int AnoNascimento;
        public string Naturalidade;
        public double Altura;
        public double Peso;

        public void Dados() {
            Console.Write($"\n\n{Nome}, {AnoNascimento}, {Naturalidade}, {Altura}m, {Peso}kg\n\n");
        }   

        public int CalculaIdade() {
            int idade = DateTime.Now.Year - AnoNascimento;
            return idade;
        }

        public virtual string Aposentar() {
            return "";
        }
    }
}