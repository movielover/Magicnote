using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Magicnote.Domain
{
    public class DbManager
    {
        public static string Conn(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }

        public List<Paragraph> GetParagraphs(int number)
        {
            using (SqlConnection connection = new SqlConnection(Conn("Database")))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("SP_GetParagraphs", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.ExecuteNonQuery();
                
            }
        }
    }
}
