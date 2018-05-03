﻿using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Magicnote.Domain
{
    public class DbManager
    {
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
                //if (!reader.HasRows)
                //{
                //    return mainLegalAreas;
                //}
                while (reader.Read())
                {
                    MainLegalArea = new MainLegalArea
                    {
                        Title = (string)reader["MA_Title"]
                    };
                    MainLegalArea.MainLegalAreas.Add(MainLegalArea);
                }
                return mainLegalAreas;
            }
        }

        public List<SubLegalArea> GetSubAreas(int number)
        {
            MainLegalArea mainLegalArea = new MainLegalArea();
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("SP_GetSubLegalAreas", conn)
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