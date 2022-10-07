using Common_Layer.Model;
using Repository_Layer.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository_Layer.Interafce
{
    public interface INotesRL
    {
        public NotesEntity Create(NotesModel notes, long UserId);
    }
}
