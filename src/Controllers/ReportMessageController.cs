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
    public class ReportMessageController : Controller
    {
        private readonly Context _context;

        public ReportMessageController(Context context)
        {
            _context = context;
        }
        public IActionResult index(){
            return View();
        }
        public IActionResult ReportMessage(string user, string message){
            ReportMessageModel a = new ReportMessageModel();
            a.UserId = user;
            a.Message = message;
            _context.Reports.Add(a);
            return View();
        }
    }    
}