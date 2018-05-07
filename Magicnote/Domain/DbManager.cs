using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;

namespace Magicnote.Domain
{
    public class DbManager
    {
        internal MainLegalArea MainLegalArea = new MainLegalArea();
        internal Note note = new Note();
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
                        Id = (int)reader["PK_SA_ID"],
                        Title = (string)reader["SA_Title"]
                    };

                    subLegalAreas.Add(subLegalArea);
                }
            }
            return subLegalAreas;
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
                cmd.Parameters.Add(new SqlParameter("@FK_SA_ID", number));
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

        public List<Note> GetNote(int number)
        {
            List<Note> Note = new List<Note>();
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("dbo.SP_GetNote", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("@PK_N_ID", number));
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Note note = new Note()
                    {
                        NoteText = (string) reader["NoteText"],
                        NoteDate = (DateTime) reader["NoteDate"]
                    };
                    Note.Add(note);
                }

                return Note;
            }
        }

        public void AddNote(string noteText, DateTime dateTime)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("SP_AddNote", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("@NoteText", noteText));
                cmd.Parameters.Add(new SqlParameter("@NoteDate", dateTime));

                cmd.ExecuteNonQuery();
            }
        }
    }
}