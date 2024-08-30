using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microondas.Properties
{
    internal class DBConnection : IDisposable
    {
        public NpgsqlConnection Connection { get; set; }

        public DBConnection()
        {
            Connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=Microondas;User Id=postgres;Password=123;");
            Connection.Open();
        }

        public void Dispose()
        {
            Connection.Close();
        }
    }
}
