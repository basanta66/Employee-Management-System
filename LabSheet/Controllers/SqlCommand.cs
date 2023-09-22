using DocumentFormat.OpenXml.Drawing.Diagrams;
using Microsoft.Data.SqlClient;

namespace LabSheet.Controllers
{
    internal class SqlCommand
    {
        private string command;
        private Connection conn;
        private SqlConnection connection;

        public SqlCommand(string command, Connection conn)
        {
            this.command = command;
            this.conn = conn;
        }

        public SqlCommand(string command, SqlConnection connection)
        {
            this.command = command;
            this.connection = connection;
        }

        internal void ExecuteNonQuery()
        {
            throw new NotImplementedException();
        }

        internal SqlDataReader ExecuteReader()
        {
            throw new NotImplementedException();
        }
    }
}