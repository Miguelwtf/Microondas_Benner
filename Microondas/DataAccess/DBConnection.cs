using Npgsql;
using System;

namespace Microondas.DataAccess
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
