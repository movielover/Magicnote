using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Magicnote.Domain
{
    public class DbManager
    {
        public List<SubLegalArea> SubLegal = new List<SubLegalArea>();
        internal MainLegalArea MainLegalArea = new MainLegalArea();
        private const string ConnectionString =
            "Server=EALSQL1.eal.local; Database=DB2017_B13; User Id=USER_B13; Password=SesamLukOp_13;";

        public List<MainLegalArea> GetMainLegalAreas()
        {
            List<MainLegalArea> mainLegalAreas = new List<MainLegalArea>();
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("dbo.SP_GetMainLegalAreas", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    MainLegalArea = new MainLegalArea
                    {
                        Id = (int)reader["PK_MA_ID"],
                        Title = (string)reader["MA_Title"]
                    };
                    mainLegalAreas.Add(MainLegalArea);
                }
                return mainLegalAreas;
            }
        }

        public void GetSubAreas(int number)
        {
            //List<SubLegalArea> subLegalAreas = new List<SubLegalArea>();
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("SP_GetSubLegalAreas", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("@FK_MA_ID", number));
                SqlDataReader reader = cmd.ExecuteReader();
                //if (!reader.HasRows)
                //{
                //    return subLegalAreas;
                //}
                while (reader.Read())
                {
                    SubLegalArea subLegalArea = new SubLegalArea
                    {
                        Id = (int)reader["PK_SA_ID"],
                        Title = (string)reader["SA_Title"]
                    };

                    //subLegalAreas.Add(subLegalArea);
                    SubLegal.Add(subLegalArea);
                }
            }
            //return subLegalAreas;
        }
        public List<Paragraph> GetParagraphs(int number)
        {
            List<Paragraph> paragraphs = new List<Paragraph>();
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("SP_GetParagraphs", conn)
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
    }
}