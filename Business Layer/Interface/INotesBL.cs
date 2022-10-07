using Common_Layer.Model;
using Repository_Layer.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business_Layer.Interface
{
    public interface INotesBL
    {
        public NotesEntity Create(NotesModel notes, long UserId);
    }
}
