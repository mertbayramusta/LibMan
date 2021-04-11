using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibMan.Models.DB;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace LibMan
{
    public class LibraryModel : PageModel
    {
        private readonly LibMan.Models.DB.LibManContext _context;

        public LibraryModel(LibMan.Models.DB.LibManContext context)
        {
            _context = context;
        }
        public string Username { get; set; }
        public string UserId { get; set; }
        public IList<TblLibrary> TblLibrary { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public SelectList Books { get; set; }
        public string Name { get; set; }
        public IList<TblUser> TblUser { get; set; }
        public async Task OnGetAsync()
        {
            TblUser = await _context.TblUser.ToListAsync();
            Username = HttpContext.Session.GetString("username");
            Name = HttpContext.Session.GetString("Title");
            TblLibrary = await _context.TblLibrary
                .Include(t => t.User).ToListAsync();


            // Use LINQ to get list of genres.
            IQueryable<string> genreQuery = from m in _context.TblLibrary
                                            orderby m.Title
                                            select m.Title;

            var names = from m in _context.TblLibrary
                         select m;

            if (!string.IsNullOrEmpty(SearchString))
            {
                names = names.Where(s => s.Title.Contains(SearchString));
            }
            Books = new SelectList(await genreQuery.Distinct().ToListAsync());
            TblLibrary = await names.ToListAsync();
        }
        
        public IActionResult OnGetLogout()
        {
            HttpContext.Session.Remove("username");
            return RedirectToPage("Index");
        }
    }
}