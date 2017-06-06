using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bestway2Learn
{
    class Conexao
    {
        SqlConnection conn = null;

        public SqlConnection ConnectToDatabase()
        {
            try
            {
                //Criar uma nova instancia
                conn = new SqlConnection();
                var path = AppDomain.CurrentDomain.BaseDirectory?.Replace("bin\\Debug\\", "").Replace("bin\\Release\\", "");

                conn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + path + "Database.mdf;Integrated Security=True;Connect Timeout=30";
                conn.Open();
                return conn;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
