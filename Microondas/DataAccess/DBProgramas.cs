using Dapper;
using System.Collections.Generic;
using System.Linq;
using Microondas;
using Microondas.DataAccess;
using Microondas.Models;

namespace Microondas.DataAccess
{
    /*
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
    */
    public class DBProgramas
    {
        public bool Add(ProgramaAquecimento programaAquecimento)
        {
            using (var dbConnection = new DataAccess.DBConnection())
            {
                string query = @"INSERT INTO receitas (nome, alimento, tempo, potencia, instrucoes, simbolo, padrao)
                                 VALUES (@Nome, @Alimento, @Tempo, @Potencia, @Instrucoes, @Simbolo, @Padrao)";

                var result = dbConnection.Connection.Execute(query, programaAquecimento);

                return result == 1;
            }
        }

        public bool Update(ProgramaAquecimento programaAquecimento)
        {
            using (var dbConnection = new DataAccess.DBConnection())
            {
                string query = @"UPDATE receitas
                                 SET nome = @Nome,
                                     alimento = @Alimento,
                                     tempo = @Tempo,
                                     potencia = @Potencia,
                                     instrucoes = @Instrucoes,
                                     simbolo = @Simbolo,
                                     padrao = @Padrao
                                 WHERE id = @Id";

                var result = dbConnection.Connection.Execute(query, programaAquecimento);

                return result == 1;
            }
        }

        public ProgramaAquecimento GetById(int id)
        {
            using (var dbConnection = new DataAccess.DBConnection())
            {
                string query = @"SELECT id, nome, alimento, tempo, potencia, instrucoes, simbolo, padrao 
                         FROM receitas 
                         WHERE id = @Id";

                return dbConnection.Connection.QueryFirstOrDefault<ProgramaAquecimento>(query, new { Id = id });
            }
        }


        public IEnumerable<ProgramaAquecimento> GetAll()
        {
            using (var dbConnection = new DataAccess.DBConnection())
            {
                string query = @"SELECT id, nome, alimento, tempo, potencia, instrucoes, simbolo, padrao FROM receitas";
                return dbConnection.Connection.Query<ProgramaAquecimento>(query);
            }
        }

        public bool Delete(int id)
        {
            using (var dbConnection = new DataAccess.DBConnection())
            {
                string query = "DELETE FROM public.receitas WHERE id = @Id";
                var result = dbConnection.Connection.Execute(query, new { Id = id });
                return result == 1;
            }
        }
    }
}
