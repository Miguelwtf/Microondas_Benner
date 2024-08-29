using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Microondas.Properties
{
    internal class DBProgramas
    {
        public bool Add(DBProgramas dbprogramas)
        { 
            var conn = new DBConnection();

            string query = @"INSERT INTO dbprogramas(id, nome, alimento, tempo, potencia, instrucoes) VALUES (?,?,?,?,?,?);";
            
            var result = conn.Connection.Execute(sql: query, param: dbprogramas);

            return result == 1;
        }

        public List<DBProgramas> Get()
        {
            var conn = new DBConnection();
            string query = @"SELECT * FROM dbprogramas";

            var result = conn.Connection.Query<DBProgramas>(sql: query);
            return result.Tolist();
        }


        public bool Update(DBProgramas dbprogramas)
        {
            //if (programaAquecimento == null || programaAquecimento.Id == 0)
            //{
                throw new ArgumentException("Objeto ProgramaAquecimento ou Id inválido.", "Error");
            //}

            var conn = new Properties.DBProgramas();

            string query = @"UPDATE public.programaaquecimento
	                        SET nomeprograma=@NomePrograma, alimento=@Alimento, tempo=@Tempo, potencia=@Potencia, 
                                simbolo=@Simbolo, instrucoes=@Instrucoes, padrao=false
	                        WHERE programaaquecimento.id = @Id";

            var result = conn.Connection.Execute(sql: query, param: dbprogramas);


            return result == 1;
        }


    }
}
/*
 Cadastro de programas
Id:
Nome:
Alimento:
Tempo:
Potência:
Instruções:


"INSERT INTO public.microondas(id, nome, alimento, tempo, potencia, instrucoes)
    VALUES (?,?,?,?,?,?);";

 */