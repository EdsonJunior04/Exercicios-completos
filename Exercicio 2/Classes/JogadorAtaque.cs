namespace Exercicio_2.Classes
{
    public class JogadorAtaque : Jogador
    {
        int Aposentadoria = 35;

        public override string Aposentar()
        {
            int aposentar = Aposentadoria - this.CalculaIdade();
            if (aposentar > 0) {
                return $"{this.Nome} tem {this.CalculaIdade()} anos. Faltam {aposentar} anos para {this.Nome} se aposentar";
            } else {
                return $"{this.Nome} já aposentou";
            }
        }
    }
}