using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Jokes_APP_ASP.NET_CORE_WE_APP__mvc_.Data;
using Jokes_APP_ASP.NET_CORE_WE_APP__mvc_.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

namespace Jokes_APP_ASP.NET_CORE_WE_APP__mvc_.Controllers
{
    
    public class JokesController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ApplicationDbContext _context;

        public JokesController(
    ApplicationDbContext context,
    UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        // GET: Jokes
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Jokes.Include(j => j.CreatedByUser);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Jokes/Details/5
        [AllowAnonymous]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var joke = await _context.Jokes
                .Include(j => j.CreatedByUser)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (joke == null)
            {
                return NotFound();
            }

            return View(joke);
        }

        // GET: Jokes/Create
        [Authorize]
        public IActionResult Create()
        {
            return View();
        }
        // POST: Jokes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Joke joke)
        {
            if (ModelState.IsValid)
            {
                joke.Id = 0;
                joke.DateCreated = DateTime.UtcNow;
                joke.CreatedByUserId = _userManager.GetUserId(User);

                _context.Jokes.Add(joke);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }

            return View(joke);
        }

        // GET: Jokes/Edit/5
        [Authorize]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var joke = await _context.Jokes.FindAsync(id);

            if (joke == null)
            {
                return NotFound();
            }

            var userId = _userManager.GetUserId(User);

            if (joke.CreatedByUserId != userId)
            {
                return Forbid();
            }

            return View(joke);
        }

        // POST: Jokes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(
     int id,
     [Bind("Id,JokeQuestion,JokeAnswer")] Joke joke)
        {
            if (id != joke.Id)
            {
                return NotFound();
            }

            var existingJoke = await _context.Jokes.FindAsync(id);

            if (existingJoke == null)
            {
                return NotFound();
            }

            var userId = _userManager.GetUserId(User);

            if (existingJoke.CreatedByUserId != userId)
            {
                return Forbid();
            }

            if (ModelState.IsValid)
            {
                existingJoke.JokeQuestion = joke.JokeQuestion;
                existingJoke.JokeAnswer = joke.JokeAnswer;

                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }

            return View(joke);
        }

        // GET: Jokes/Delete/5
        [Authorize]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var joke = await _context.Jokes
                .FirstOrDefaultAsync(j => j.Id == id);

            if (joke == null)
            {
                return NotFound();
            }

            var userId = _userManager.GetUserId(User);

            if (joke.CreatedByUserId != userId)
            {
                return Forbid();
            }

            return View(joke);
        }

        // POST: Jokes/Delete/5
        [Authorize]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var joke = await _context.Jokes.FindAsync(id);

            if (joke == null)
            {
                return NotFound();
            }

            var userId = _userManager.GetUserId(User);

            if (joke.CreatedByUserId != userId)
            {
                return Forbid();
            }

            _context.Jokes.Remove(joke);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
    }
}
