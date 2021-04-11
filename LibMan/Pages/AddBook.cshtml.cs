using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibMan.Models.DB;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LibMan
{
    public class AddBookModel : PageModel
    {
        private readonly LibMan.Models.DB.LibManContext _context;
        public string Username { get; set; }
        public AddBookModel(LibMan.Models.DB.LibManContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            Username = HttpContext.Session.GetString("username");
            ViewData["UserId"] = new SelectList(_context.TblUser, "Id", "Id");
            return Page();
        }

        [BindProperty]
        public TblLibrary TblLibrary { get; set; }
        public void Save(TblLibrary cust) { _context.TblLibrary.Update(cust); _context.SaveChanges(); }
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {

            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.TblLibrary.Add(TblLibrary);
            await _context.SaveChangesAsync();

            return RedirectToPage("./BookImage");
        }
    }
}