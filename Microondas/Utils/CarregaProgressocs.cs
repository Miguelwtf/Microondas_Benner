using System.Text;

namespace Microondas.Utils
{
    public class CarregaProgresso
    {
        private int potencia;
        private string simbolo;

        public CarregaProgresso(int potencia, string simbolo)
        {
            this.potencia = potencia;
            this.simbolo = simbolo;
        }

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
