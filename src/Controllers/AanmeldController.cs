using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using src.Models;
using database;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

namespace src.Controllers
{
    [Authorize]
    public class AanmeldController : Controller
    {
         private readonly Context _context;
          private readonly UserManager<UserModel> _userManager;
         public AanmeldController(Context context, UserManager<UserModel> userManager){
          _context = context;
          _userManager = userManager;
         }
         // GET: Aanmeld
         public async Task<IActionResult> Index()
         {
             return View(await _context.Aanmelding.ToListAsync());
         }

         // GET: Aanmeld/Details/5
         public async Task<IActionResult> Details(int? id)
         {
             if (id == null)
             {
                 return NotFound();
             }

             var aanmeldModel = await _context.Aanmelding
                 .FirstOrDefaultAsync(m => m.Id == id);
             if (aanmeldModel == null)
             {
                 return NotFound();
             }

             return View(aanmeldModel);
         }

         // GET: Aanmeld/Create
         public IActionResult Create()
         {
             return View();
         }

         // POST: Aanmeld/Create
         // To protect from overposting attacks, enable the specific properties you want to bind to.
         // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
         [HttpPost]
         [ValidateAntiForgeryToken]
         public async Task<IActionResult> Create([Bind("Id,CareGiverId,UserId")] AanmeldModel aanmeldModel)
         {
             if (ModelState.IsValid)
             {
                 var user = await _userManager.GetUserAsync(HttpContext.User);
                 aanmeldModel.User = user;
                 _context.Add(aanmeldModel);
                 await _context.SaveChangesAsync();
                 return RedirectToAction(nameof(Index));
             }
             return View(aanmeldModel);
         }

         // GET: Aanmeld/Edit/5
         public async Task<IActionResult> Edit(int? id)
         {
             if (id == null)
             {
                 return NotFound();
             }

             var aanmeldModel = await _context.Aanmelding.FindAsync(id);
             if (aanmeldModel == null)
             {
                 return NotFound();
             }
             return View(aanmeldModel);
         }

         // POST: Aanmeld/Edit/5
         // To protect from overposting attacks, enable the specific properties you want to bind to.
         // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
         [HttpPost]
         [ValidateAntiForgeryToken]
         public async Task<IActionResult> Edit(int id, [Bind("Id,CareGiverId,UserId")] AanmeldModel aanmeldModel)
         {
             if (id != aanmeldModel.Id)
             {
                 return NotFound();
             }

             if (ModelState.IsValid)
             {
                 try
                 {
                     _context.Update(aanmeldModel);
                     await _context.SaveChangesAsync();
                 }
                 catch (DbUpdateConcurrencyException)
                 {
                     if (!AanmeldModelExists(aanmeldModel.Id))
                     {
                         return NotFound();
                     }
                     else
                     {
                         throw;
                     }
                 }
                 return RedirectToAction(nameof(Index));
             }
             return View(aanmeldModel);
         }

         // GET: Aanmeld/Delete/5
         public async Task<IActionResult> Delete(int? id)
         {
             if (id == null)
             {
                 return NotFound();
             }

             var aanmeldModel = await _context.Aanmelding
                 .FirstOrDefaultAsync(m => m.Id == id);
             if (aanmeldModel == null)
             {
                 return NotFound();
             }

             return View(aanmeldModel);
         }

         // POST: Aanmeld/Delete/5
         [HttpPost, ActionName("Delete")]
         [ValidateAntiForgeryToken]
         public async Task<IActionResult> DeleteConfirmed(int id)
         {
             var aanmeldModel = await _context.Aanmelding.FindAsync(id);
             _context.Aanmelding.Remove(aanmeldModel);
             await _context.SaveChangesAsync();
             return RedirectToAction(nameof(Index));
         }

         private bool AanmeldModelExists(int id)
         {
             return _context.Aanmelding.Any(e => e.Id == id);
         }
    }
}
