using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibMan.Models.DB;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace LibMan
{
    public class EditBookModel : PageModel
    {
        private readonly LibMan.Models.DB.LibManContext _context;

        public EditBookModel(LibMan.Models.DB.LibManContext context)
        {
            _context = context;
        }

        [BindProperty]
        public TblLibrary TblLibrary { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            TblLibrary = await _context.TblLibrary
                .Include(t => t.User).FirstOrDefaultAsync(m => m.BookId == id);

            if (TblLibrary == null)
            {
                return NotFound();
            }
            ViewData["UserId"] = new SelectList(_context.TblUser, "Id", "Id");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(TblLibrary).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TblLibraryExists(TblLibrary.BookId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Library");
        }

        private bool TblLibraryExists(int id)
        {
            return _context.TblLibrary.Any(e => e.BookId == id);
        }
    }
}