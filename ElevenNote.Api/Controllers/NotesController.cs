using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Microsoft.AspNet.Identity;

namespace ElevenNote.Api.Controllers
{
    [Authorize]
    public class NotesController : ApiController
    {
        ///<summary
        /// Gets all the notes for the current user.
        /// </summary>
        /// <returns></returns>
        
       
        public IHttpActionResult GetNotes()
        {
            var service = new Services.NoteService();
            var userId = User.Identity.GetUserId();
            var notes = service.GetAllForUser(Guid.Parse(userId));

            return Ok(notes);
        }
    }
}
