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
                SqlCommand cmd = new SqlCommand("SP_GetMainLegalAreas", conn)
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

        public List<SubLegalArea> GetSubAreas(int number)
        {
            List<SubLegalArea> subLegalAreas = new List<SubLegalArea>();
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SP_GetSubLegalAreas", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("@FK_MA_ID", number));
                SqlDataReader reader = cmd.ExecuteReader();
                if (!reader.HasRows)
                {
                    return subLegalAreas;
                }
                while (reader.Read())
                {
                    SubLegalArea subLegalArea = new SubLegalArea
                    {
                        Id = (int) reader["PK_SA_ID"],
                        Title = (string) reader["SA_Title"]
                    };
                    subLegalAreas.Add(subLegalArea);
                }
            }
            return subLegalAreas;
        }

        public List<Paragraph> GetParagraphs(int pkSaId)
        {
            List<Paragraph> paragraphs = new List<Paragraph>();
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SP_GetParagraphs", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("@FK_SA_ID", pkSaId));
                SqlDataReader reader = cmd.ExecuteReader();
                if (!reader.HasRows)
                {
                    return paragraphs;
                }
                while (reader.Read())
                {
                    Paragraph paragraph = new Paragraph
                    {
                        Id = (int) reader["PK_P_ID"],
                        ParagraphNumber = (int) reader["ParagraphNumber"],
                        Headline = (string) reader["Headline"],
                        Lawtext = (string) reader["Lawtext"]
                    };
                    paragraphs.Add(paragraph);
                }
            }
            return paragraphs;
        }

        public string GetNote(int number)
        {
            string noteText = "";
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("dbo.SP_GetNote", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("@FK_P_ID", number));
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    noteText = (string)reader["NoteText"];
                }
                return noteText;
            }
        }

        public void CreateParagraph(int paragraphNumber, string headLine, string lawText, int fkSaId)
        {
            //int pkPId = GetRecentParagraph();
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SP_CreateParagraph", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("@ParagraphNumber", paragraphNumber));
                cmd.Parameters.Add(new SqlParameter("@HeadLine", headLine));
                cmd.Parameters.Add(new SqlParameter("@Lawtext", lawText));
                cmd.Parameters.Add(new SqlParameter("@FK_SA_ID", fkSaId));
                cmd.ExecuteNonQuery();
            }
        }

        public void CreateNote(int fkPId)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SP_CreateNote", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("@FK_P_ID", fkPId));
                cmd.ExecuteNonQuery();
            }
        }

        public void SaveNote(string noteText, int paragraphNumber)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SP_SaveNote", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("@NoteText", noteText));
                cmd.Parameters.Add(new SqlParameter("@FK_P_ID", paragraphNumber));
                cmd.ExecuteNonQuery();
            }
        }

        public int GetRecentParagraph()
        {
            int pkPId = 0;

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("SP_GetRecentParagraph", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    pkPId = (int)reader["PK_P_ID"];
                }

                return pkPId;
            }
        }
        public void GetNoteData(int id)
        {
            List<Paragraph> paragraphs = new List<Paragraph>();
            List<Note> Notes = new List<Note>();
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SP_GetNoteData", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("@PK_P_ID",id));

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Paragraph paragraph = new Paragraph();
                    Note note = new Note();
                    {
                        note.NoteText = (string) reader["NoteText"];
                        paragraph.Headline = (string) reader["Headline"];
                        paragraph.Lawtext = (string)reader["Lawtext"];
                        paragraph.ParagraphNumber = (int)reader["ParagraphNumber"];
                    }
                    paragraphs.Add(paragraph);
                    Notes.Add(note);
                }
               
            }

        }



            //}
            //public void InsertSubLegalAreaParagraph(int PK_P_ID, int PK_SA_ID)
            //{
            //    using (SqlConnection conn = new SqlConnection(ConnectionString))
            //    {
            //        conn.Open();

            //        SqlCommand cmd = new SqlCommand("SP_Insert_SubLegalArea_Paragraph", conn)
            //        {
            //            CommandType = CommandType.StoredProcedure
            //        };

            //        cmd.Parameters.Add(new SqlParameter("@FK_P_ID", PK_P_ID));
            //        cmd.Parameters.Add(new SqlParameter("@ FK_SA_ID", PK_SA_ID));

            //        cmd.ExecuteNonQuery();
        
    }
}



