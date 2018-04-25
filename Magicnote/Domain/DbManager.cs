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

        public List<Paragraph> GetMainAreas(int number)
        {
            List<Paragraph> paragraphs = new List<Paragraph>();
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
                    return paragraphs;
                }
                while (reader.Read())
                {
                    Paragraph paragraph = new Paragraph
                    {
                        ParagraphNumber = (int) reader["ParagraphNumber"],
                        Headline = reader["Headline"] as string,
                        Lawtext = (string) reader["Lawtext"]
                    };

                    paragraphs.Add(paragraph);
                }
            }
            return paragraphs;
        }

        public List<SubLegalArea> GetSubAreas(int number)
        {
            MainLegalArea mainLegalArea = new MainLegalArea();
            using (SqlConnection connection = new SqlConnection(Conn("Database")))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("SP_GetSubArea", connection)
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
                        Paragraph = (Paragraph) reader["ParagraphNumber"],
                    };

                    mainLegalArea.SubLegalAreas.Add(subLegalArea);
                }
            }
            return mainLegalArea.SubLegalAreas;
        }
    }
}