using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using database;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using src.Models;

namespace src.Controllers
{
    public class ChatController : Controller
    {
        private readonly Context _context;

        public ChatController(Context context)
        {
            _context = context;
        }
        
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult ChatPage()
        {
            return View();
        }
        public IActionResult Rooms(){
          //  var kamers = _context.Rooms.All();
            return View();
        }
    }
}
