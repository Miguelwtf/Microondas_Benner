using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microondas.Properties; 

namespace Microondas.Models
{
    public class ProgramaAquecimento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Alimento { get; set; }
        public int Tempo { get; set; }
        public int Potencia { get; set; }
        public string Instrucoes { get; set; }
        public string Simbolo { get; set; }
        public bool Padrao { get; set; }
    }
}
