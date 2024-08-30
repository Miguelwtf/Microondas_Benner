using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microondas.Properties; // Isso deve ser o namespace que contém o DBProgramas

/*
namespace Microondas.model
{
    public class ListaProgramas
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Alimento { get; set; }
        public int Tempo { get; set; }
        public int Potencia { get; set; }
        public string Instrucoes { get; set; }
        public string Simbolo { get; set; }

        public ListaProgramas() { }

        public ListaProgramas(int id, string nome, string alimento, int tempo, int potencia, string simbolo, string instrucoes)
        {
            try
            {
                if (string.IsNullOrEmpty(nome))
                    throw new ArgumentNullException(nameof(nome), "Nome é obrigatório!");

                if (string.IsNullOrEmpty(alimento))
                    throw new ArgumentNullException(nameof(alimento), "Alimento é obrigatório!");

                if (tempo <= 0)
                    throw new ArgumentOutOfRangeException(nameof(tempo), "Tempo deve ser maior que zero!");

                if (potencia <= 0)
                    throw new ArgumentOutOfRangeException(nameof(potencia), "Potência deve ser maior que zero!");

                if (string.IsNullOrEmpty(simbolo))
                    throw new ArgumentNullException(nameof(simbolo), "Símbolo é obrigatório!");

                //var repository = new ReceitaRepository();
                //var receitas = repository.Get();

                foreach (var item in receitas.OrderBy(r => r.Id))
                {
                    if (item.Simbolo == simbolo)
                    {
                        throw new ArgumentException("Símbolo informado já utilizado em outro programa. Por favor, informe outro símbolo!");
                    }
                }

                Id = id;
                Nome = nome;
                Alimento = alimento;
                Tempo = tempo;
                Potencia = potencia;
                Instrucoes = instrucoes;
                Simbolo = simbolo;
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message, "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
*/