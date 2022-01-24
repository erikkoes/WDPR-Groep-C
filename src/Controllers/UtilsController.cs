using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using src.Models;

namespace src.Controllers
{
    //[Authorize(Roles = "Admin")]
    public class UtilsController : Controller
    {
        private readonly RoleManager<RoleModel> _roleManager;
        private readonly UserManager<UserModel> _userManager;
        private readonly ILogger<UtilsController> _logger;

        public UtilsController(RoleManager<RoleModel> roleMgr, UserManager<UserModel> userMgr, ILogger<UtilsController> logger)
        {
            _roleManager = roleMgr;
            _userManager =  userMgr;
            _logger =  logger;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var roles = await _roleManager.Roles.ToListAsync();
            var user = await _userManager.GetUserAsync(HttpContext.User);
            var userRoles = await _userManager.GetRolesAsync(user);
            var users = await _userManager.Users
                .Include(x => x.UserRoles)
                .ThenInclude(x => x.Role)
                .AsNoTracking()
                .ToListAsync();

            UtilsViewModel utils = new UtilsViewModel();
            utils.User = user;
            utils.CurrentRoles = userRoles;

            utils.Roles = roles;
            utils.AllUsers = users;
            return View(utils);
        }

        [HttpGet]
        public IActionResult CreateRole()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateRole(CreateRoleViewModel model)
        {
            if (ModelState.IsValid)
            {
                RoleModel roleModel = new RoleModel
                {
                    Name = model.RoleName
                };

                IdentityResult result =  await _roleManager.CreateAsync(roleModel);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }

                foreach (IdentityError error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Users()
        {
            var users = _userManager.Users
                .Include(x => x.UserRoles)
                .ThenInclude(x => x.Role)
                .AsNoTracking()
                .ToList();
            return View(users);
        }

        [HttpGet]
        public async Task<IActionResult> EditUser(string id)
        {
            var user = await _userManager.Users
                    .Include(x => x.UserRoles)
                    .ThenInclude(x => x.Role)
                    .AsNoTracking()
                    .Where(x => x.Id == id)
                    .SingleOrDefaultAsync();

            if (user == null)
            {
                return View("NotFound");
            }

            var roles = await _roleManager.Roles.ToListAsync();
            ViewBag.Roles = roles;
            
            return View(user);
        }

        [HttpPost]
        public async Task<IActionResult> AddRoleToUser(string RoleId, string UserId)
        {
            _logger.LogInformation(UserId);
            _logger.LogInformation("a");
            var user = await _userManager.FindByIdAsync(UserId);
            var role = await _roleManager.FindByIdAsync(RoleId);
            await _userManager.AddToRoleAsync(user, role.Name);
            return Redirect(HttpContext.Request.Headers["Referer"]);
        }
    }
}