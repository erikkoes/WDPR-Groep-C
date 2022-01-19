using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using src.Models;

namespace src.Controllers
{
    public class ChatController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult ChatPage()
        {
            return View();
        }
        public IActionResult ReportMessage(string user, string message){
            //bericht opslaan in database
            return Index();
        }
    }
}
