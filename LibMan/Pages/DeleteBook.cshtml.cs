using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibMan.Models.DB;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace LibMan
{
    public class DeleteBookModel : PageModel
    {
        private readonly LibMan.Models.DB.LibManContext _context;

        public DeleteBookModel(LibMan.Models.DB.LibManContext context)
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
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            TblLibrary = await _context.TblLibrary.FindAsync(id);

            if (TblLibrary != null)
            {
                _context.TblLibrary.Remove(TblLibrary);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Library");
        }
    }
}