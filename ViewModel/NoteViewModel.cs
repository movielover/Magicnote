using System;
using Magicnote.Domain;

namespace ViewModel
{
    public class NoteViewModel
    {
        public static DbManager DbManager;
        public SubLegalArea SubLegalArea;
        public Paragraph Paragraph;
        public string HeadLine { get; set; }
        public string LawText { get; set; }
        public int ParagraphNumber { get; set; }
        public static string NoteText{ get; set; }

        public static void SaveNoteToDb(string textRangeText, int paragraphNumber)
        {
            DbManager.SaveNote(NoteText, paragraphNumber);
        }
        public void GetNote(int paragraphNumber)
        {
            NoteText = DbManager.GetNote(paragraphNumber);
        }
        public void SaveNote(string noteText, int paragraphId)
        {
            DbManager.SaveNote(noteText, paragraphId);
        }

    }
}
