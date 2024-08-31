using System;

namespace Microondas.Utils
{
    public class TimeConverter
    {
        public int ConverteTempo(int tempoRestante)
        {
            string tempoInput = tempoRestante.ToString();
            int totalSegundos;

            string paddedInput = tempoInput.PadLeft(4, '0');

            int minutos = int.Parse(paddedInput.Substring(0, 2));
            int segundos = int.Parse(paddedInput.Substring(2, 2));

            totalSegundos = (minutos * 60) + segundos;

            return totalSegundos;
        }
    }
}
