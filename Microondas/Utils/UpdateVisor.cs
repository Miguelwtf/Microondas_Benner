using System;

namespace Microondas.Util
{
    public class UpdateVisor
    {
        public string Atualiza(string input)
        {
            if (input == null)
                throw new ArgumentNullException(nameof(input));

            string paddedInput = input.PadLeft(4, '0');
            int minutos = 0;
            int segundos = 0;


            if (input.Length < 5)
            {
                minutos = int.Parse(paddedInput.Substring(0, 2));
                segundos = int.Parse(paddedInput.Substring(2, 2));
            }
            if (input.Length < 6)
            {
                minutos = int.Parse(paddedInput.Substring(0, 2));
                segundos = int.Parse(paddedInput.Substring(3, 2));
            }

            return $"{minutos:D2}:{segundos:D2}";
        }
    }
}
