using ElevenNote.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;

namespace ElevenNote.Web.Controllers
{
    [Authorize]
    public class NotesController : Controller
    {
        // GET: Notes
        public ActionResult Index()
        {
            var noteService = new Services.NoteService();
            var notes = noteService.GetAllForUser(Guid.Parse(User.Identity.GetUserId()));

            return View(notes);
        }
    }
}