﻿using Magicnote.Domain;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace ViewModel
{
    public class CreateParagraphViewModel : INotifyPropertyChanged
    {
        public DbManager DbManager;

        public event PropertyChangedEventHandler PropertyChanged;

        public List<MainLegalArea> MainLegalAreas { get; }

        private List<SubLegalArea> _subLegalAreas;

        public List<SubLegalArea> SubLegalAreas
        {
            get => _subLegalAreas;

            set
            {
                _subLegalAreas = value;
                OnPropertyChanged(nameof(SubLegalAreas));
            }
        }

        public CreateParagraphViewModel()
        {
            DbManager = new DbManager();
            SubLegalAreas = new List<SubLegalArea>();
            MainLegalAreas = DbManager.GetMainLegalAreas();
            _subLegalAreas = new List<SubLegalArea>();
        }

        public void GetSubLegalArea(int subAreaId)
        {
            SubLegalAreas = DbManager.GetSubAreas(subAreaId).ToList();
        }

        public void CreateParagraphAndNote(int paragraphNumber, string headline, string lawText, int id)
        {
            DbManager.CreateParagraph(paragraphNumber, headline, lawText, id);
            int pkpid = DbManager.GetRecentParagraph();
            DbManager.CreateNote(pkpid);
        }

        protected virtual void OnPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}