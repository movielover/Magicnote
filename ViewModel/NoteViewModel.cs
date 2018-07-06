using Magicnote.Domain;
using System.ComponentModel;

namespace ViewModel
{
    public class NoteViewModel 
    {
        public DbManager DbManager;
        private Paragraph _paragraph;
        public string LawText { get; set; }
        public string Headline { get; set; }
        public int ParagraphNumber { get; set; }
        

        public NoteViewModel()
        {
            DbManager = new DbManager();
        }

  

        public void GetParagraphsToNote(int pkPId)
        {
            _paragraph =DbManager.GetParagraphsToNote(pkPId);
            Headline = _paragraph.Headline;
            LawText = _paragraph.LawText;
            ParagraphNumber = _paragraph.ParagraphNumber;
             
        }

        public void SaveNoteToDb(string noteText, int paragraphNumber)
        {
            DbManager.SaveNote(noteText, paragraphNumber);
        }

        
    }

}

