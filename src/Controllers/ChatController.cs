using System.Runtime.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using database;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using src.Models;
using Microsoft.EntityFrameworkCore;

namespace src.Controllers
{
    public class ChatController : Controller
    {
        private readonly Context _context;
        private readonly ILogger<ChatController> _logger;
        private readonly UserManager<UserModel> userManager;

        public ChatController(Context context, ILogger<ChatController> logger, UserManager<UserModel> userMgr)
        {
            _context = context;
            _logger = logger;
            userManager = userMgr;
        }
        
        public IActionResult Index()
        {
            var rooms = _context.Rooms.Include(r => r.Users).ToList();

            // RoomViewModel rmodel = new RoomViewModel();

            // foreach (var item in rooms)
            // {
            //     ChatRoomModel cr = new ChatRoomModel();
            //     cr.RoomName = item.RoomName;
            //     cr.Id = item.Id;
            //     rmodel.RoomNames.Append(cr);
            // }

            ViewBag.rooms = rooms;
            foreach (var item in rooms)
            {
                _logger.LogInformation("a");
                foreach (var x in item.Users)
                {
                    // _logger.LogInformation(x.UserId);
                    _logger.LogInformation("b");
                }
                
            }
            return View(Input);
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel
        {
            [Display(Name = "Room name")]
            [Required]
            public string RoomName { get; set; }

            [Display(Name = "Room subject")]
            [Required]
            public string RoomSubject { get; set; }
        }

        [HttpPost]
        public async Task<IActionResult> CreateRoom()
        {
            if (ModelState.IsValid)
            {
                var room = new ChatRoom
                {
                    RoomName = Input.RoomName,
                    RoomSubject = Input.RoomSubject
                };

                await _context.Rooms.AddAsync(room);
                await _context.SaveChangesAsync();

                UserModel self = await userManager.GetUserAsync(HttpContext.User);
                await AddUserToChatAsync(room.Id, self);
            }

            var errors = ModelState.Values.SelectMany(v => v.Errors);
            foreach (var error in errors)
            {
                ModelState.AddModelError(string.Empty, error.ToString());
            }

            return RedirectToAction(nameof(Index));
        }

        private async Task AddUserToChatAsync(int roomId, UserModel self)
        {
            _logger.LogInformation(self.Id);
            _logger.LogInformation(roomId.ToString());
            ChatUser chatuser = new ChatUser
            {
                UserId = self.Id,
                ChatRoomId = roomId
            };
            await _context.ChatUser.AddAsync(chatuser);
            await _context.SaveChangesAsync();
        }

        public IActionResult ChatPage()
        {
            return View();
        }

        public IActionResult Rooms()
        {
            
            var rooms = _context.Rooms.Select(r => r.RoomName);
            
            RoomViewModel rmodel = new RoomViewModel();
            foreach (var item in rooms)
            {
                ChatRoom cr = new ChatRoom();
                cr.RoomName = item;
                rmodel.RoomNames.Append(cr);
            }
            
            return View(rmodel);
        }
    }
}
