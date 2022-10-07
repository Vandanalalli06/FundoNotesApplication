using Business_Layer.Interface;
using Common_Layer.Model;
using Repository_Layer.Entity;
using Repository_Layer.Interafce;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business_Layer.Service
{
    public class NotesBL : INotesBL
    {
        private readonly INotesRL notesRL;
        public NotesBL(INotesRL notesRL)
        {
            this.notesRL = notesRL;
        }

        public NotesEntity Create(NotesModel notes, long UserId)
        {
            try
            {
                return notesRL.Create(notes, UserId);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}