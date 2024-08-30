using Dapper;
using System.Collections.Generic;
using System.Linq;

namespace Microondas
{
    // Classe que representa a estrutura da tabela Receitas
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

    // Classe para acessar o banco de dados
    public class DBProgramas
    {
        // Método para adicionar um novo programa
        public bool Add(ProgramaAquecimento programaAquecimento)
        {
            using (var dbConnection = new Properties.DBConnection())
            {
                string query = @"INSERT INTO receitas (nome, alimento, tempo, potencia, instrucoes, simbolo, padrao)
                                 VALUES (@Nome, @Alimento, @Tempo, @Potencia, @Instrucoes, @Simbolo, @Padrao)";

                var result = dbConnection.Connection.Execute(query, programaAquecimento);

                return result == 1;
            }
        }

        // Método para listar todos os programas
        public IEnumerable<ProgramaAquecimento> GetAll()
        {
            using (var dbConnection = new Properties.DBConnection())
            {
                string query = @"SELECT id, nome, alimento, tempo, potencia, instrucoes, simbolo, padrao FROM receitas";
                return dbConnection.Connection.Query<ProgramaAquecimento>(query);
            }
        }
    }
}
