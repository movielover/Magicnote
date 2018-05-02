using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Magicnote.Domain
{
    public class DbManager
    {
        public MainLegalArea MainLegalArea = new MainLegalArea();
        public static string Conn(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }

        public void SetMainAreas()
        {
            using (SqlConnection connection = new SqlConnection(Conn("Database")))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("SP_GetMainLegalAreas", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    MainLegalArea = new MainLegalArea
                    {
                        Title = (string)reader["MA_Title"]
                    };

                    MainLegalArea.MainLegalAreas.Add(MainLegalArea);
                }
            }
        }

        public List<SubLegalArea> GetSubAreas(int number)
        {
            MainLegalArea mainLegalArea = new MainLegalArea();
            using (SqlConnection connection = new SqlConnection(Conn("Database")))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("SP_GetSubLegalAreas", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                SqlDataReader reader = cmd.ExecuteReader();
                if (!reader.HasRows)
                {
                    return mainLegalArea.SubLegalAreas;
                }
                while (reader.Read())
                {
                    SubLegalArea subLegalArea = new SubLegalArea
                    {
                        Title = (string)reader["SA_Title"]
                    };

                    mainLegalArea.SubLegalAreas.Add(subLegalArea);
                }
            }
            return mainLegalArea.SubLegalAreas;
        }
        public List<Paragraph> GetParagraphs(int number)
        {
            SubLegalArea subLegalArea = new SubLegalArea();
            using (SqlConnection connection = new SqlConnection(Conn("Database")))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("SP_GetParagraphs", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                SqlDataReader reader = cmd.ExecuteReader();
                if (!reader.HasRows)
                {
                    return subLegalArea.Paragraphs;
                }
                while (reader.Read())
                {
                    Paragraph paragraph = new Paragraph
                    {
                        ParagraphNumber = (int) reader["ParagraphNumber"],
                        Headline = reader["Headline"] as string,
                        Lawtext = (string) reader["Lawtext"]
                    };

                    subLegalArea.Paragraphs.Add(paragraph);
                }
            }
            return subLegalArea.Paragraphs;
        }
    }
}