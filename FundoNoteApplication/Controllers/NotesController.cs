using Business_Layer.Interface;
using Common_Layer.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository_Layer.Context;
using System;
using System.Linq;

namespace FundoNoteApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotesController : ControllerBase
    {
        private readonly INotesBL notesBL;
        private readonly FundoContext fundocontext;
        
        public NotesController(INotesBL notesBL, FundoContext fundocontext)
        {
            this.notesBL = notesBL;
            this.fundocontext = fundocontext;
        }
        [Authorize]
        [HttpPost]
        [Route("Create")]
        public ActionResult Create(NotesModel notes)
        {
            try
            {
                long UserID = Convert.ToInt32(User.Claims.FirstOrDefault(e => e.Type == "UserID").Value);
                var result = notesBL.Create(notes, UserID);
                if (result != null)
                {
                    return Ok(new { success = true, message = "Notes Created Successfully", data = result });
                }
                else
                {
                    return NotFound(new { success = false, message = "Notes is not created " });
                }
            }
            catch (System.Exception)
            {

                throw;
            }
        }
    }
}
