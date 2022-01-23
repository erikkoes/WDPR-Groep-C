using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using src.Models;

namespace src.Controllers
{
    [Authorize(Roles = "Admin")]
    public class UtilsController : Controller
    {
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly UserManager<UserModel> userManager;

        public UtilsController(RoleManager<IdentityRole> roleMgr, UserManager<UserModel> userMgr)
        {
            roleManager = roleMgr;
            userManager =  userMgr;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var roles = roleManager.Roles.ToArray();
            var user = await userManager.GetUserAsync(HttpContext.User);
            var userRoles = await userManager.GetRolesAsync(user);
            var users = userManager.Users;

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
                IdentityRole identityRole = new IdentityRole
                {
                    Name = model.RoleName
                };

                IdentityResult result =  await roleManager.CreateAsync(identityRole);

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
            var users = userManager.Users;
            return View(users);
        }

        [HttpGet]
        public async Task<IActionResult> EditUser(string id)
        {
            var user = await userManager.FindByIdAsync(id);

            if (user == null)
            {
                return View("NotFound");
            }
            
            return View(user);
        }
    }
}