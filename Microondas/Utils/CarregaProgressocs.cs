using System.Text;

namespace Microondas.Util
{
    public class CarregaProgresso
    {
        private int potencia;
        private string simbolo;

        // Construtor da classe
        public CarregaProgresso(int potencia, string simbolo)
        {
            this.potencia = potencia;
            this.simbolo = simbolo;
        }

        // Método para gerar o progresso
        public string GerarProgresso(string textoAtual)
        {
            StringBuilder progresso = new StringBuilder(textoAtual);

            for (int j = 0; j < potencia; j++)
            {
                progresso.Append(simbolo);
            }

            progresso.Append(" ");
            return progresso.ToString();
        }
    }
}
